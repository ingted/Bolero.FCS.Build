# FSharp.Compiler.Service Diff Report
**Comparison:** `f9530e172c535abc79fef41be59b60781e2d109e` (Base) vs `HEAD` (Current)
**Context:** Investigation of Bolero/Blazor WASM hangs and increased download size in .NET 10.

## 1. Summary
The current `HEAD` contains significant modifications specifically targeted at **Blazor WebAssembly compatibility**. These changes are controlled by a `BLAZOR` preprocessor directive.

*   **Files Changed:** 16
*   **Insertions:** 72
*   **Deletions:** 18

## 2. Key Findings

### A. Dependency Reduction (The "Lots of Files" Cause)
**File:** `src/fsharp/DotNetFrameworkDependencies.fs`

The `HEAD` version wraps many "desktop" or "heavy" assembly references in `#if !BLAZOR` blocks.

**Changes:**
When `BLAZOR` is defined, the following assemblies are **EXCLUDED** from the default references:
*   `System.Xml`
*   `System.Runtime.Remoting`
*   `System.Runtime.Serialization.Formatters.Soap`
*   `System.Data`
*   `System.Drawing`
*   `System.Linq.Expressions`
*   `System.Net.Requests`
*   `System.Web`
*   `System.Web.Services`
*   `System.Windows.Forms`
*   `FSharp.Compiler.Interactive.Settings` (fsi library)

**Impact Analysis:**
If your .NET 10 build **does not** have these changes (or does not define the `BLAZOR` symbol during compilation), the compiler service will attempt to reference and load all these assemblies.
*   **Result:** The Blazor AOT/Trimmer will see these as required dependencies and include them in the deployment. This directly explains the **"transfer a bunch of wasm files"** observation.

### B. Logging and Threading (The "Hang" Cause)
**File:** `src/fsharp/Logger.fs`

**Changes:**
*   `HEAD` disables **Event Tracing for Windows (ETW)** when `BLAZOR` is defined.
*   It replaces `FSharpCompilerEventSource` (which inherits `EventSource`) with a no-op stub class.

**Impact Analysis:**
*   `EventSource` and ETW logic can be problematic in the Browser WASM sandbox. If the .NET 10 build attempts to initialize real ETW providers, it may deadlock or throw exceptions that aren't surfaced in the console, looking like a "hang".

### C. Diagnostics Stubs
**File:** `fcs/FSharp.Compiler.Service/BlazorOverrides.fs` (New File)

**Changes:**
*   Stubs out `System.Diagnostics.Debug.Assert` and `System.Diagnostics.Trace.TraceInformation`.

**Impact Analysis:**
*   If the compiler hits an assertion or trace in the unmodified version, it might try to write to a listener that doesn't exist or is blocking in WASM.

## 3. Conclusion & Recommendations

The `HEAD` of this repository seems to contain **critical patches** for running FCS in Blazor.

**Hypothesis:**
The .NET 10 version of `Bolero.FCS.Build` you are testing is likely **missing these patches** or **not defining the `BLAZOR` symbol**.

1.  **Hanging:** Caused by `Logger.fs` trying to use ETW or `DotNetFrameworkDependencies.fs` trying to resolve `System.Web`/`System.Windows.Forms`.
2.  **File Size:** Caused by `DotNetFrameworkDependencies.fs` including the full Desktop .NET reference set.

**Next Steps:**
Please compare the source code of your .NET 10 `Bolero.FCS.Build` against the `src/fsharp/DotNetFrameworkDependencies.fs` and `src/fsharp/Logger.fs` files in this repo to confirm if the `#if BLAZOR` logic is present.

## 4. External Context: Threading Issues
**Issue:** [dotnet/runtime#61381](https://github.com/dotnet/runtime/issues/61381) - *Threading support in Blazor WASM*

*   **Relevance:** Blazor WASM is historically single-threaded. While .NET 7/8+ introduced experimental multithreading, it remains complex.
*   **FCS Connection:** The F# Compiler Service relies heavily on `Async` workflows. If code executes `Async.RunSynchronously` or accesses `.Result` on a Task within the single-threaded synchronization context of the browser, **it will deadlock (hang)**.
*   **Observation:** The "hang without error" you observed is a classic symptom of this deadlock.
*   **Mitigation:** The changes in `Logger.fs` (removing ETW) and `BlazorOverrides.fs` likely remove paths that might inadvertently trigger blocking calls or unsupported threading primitives.
