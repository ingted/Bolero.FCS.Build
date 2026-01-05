// This is a generated file; the original input is 'Interactive\FSIstrings.txt'
namespace FSIstrings

open Microsoft.FSharp.Core.LanguagePrimitives.IntrinsicOperators
open Microsoft.FSharp.Reflection
open System.Reflection
// (namespaces below for specific case of using the tool to compile FSharp.Core itself)
open Microsoft.FSharp.Core
open Microsoft.FSharp.Core.Operators
open Microsoft.FSharp.Text
open Microsoft.FSharp.Collections
open Printf

#nowarn "3262" // The call to Option.ofObj below is applied in multiple compilation modes for GetString, sometimes the value is typed as a non-nullable string
#if BUILDING_WITH_LKG
#nowarn "3261" // Nullness warnings can happen due to LKG not having latest fixes
#endif

type internal SR =
    private new: unit -> SR
    // BEGIN BOILERPLATE

    static member GetTextOpt: key:string -> string option

    /// If set to true, then all error messages will just return the filled 'holes' delimited by ',,,'s - this is for language-neutral testing (e.g. localization-invariant baselines).
    static member SwallowResourceText: bool with get, set
    // END BOILERPLATE
    /// Stopped due to error\n
    /// (Originally from Interactive\FSIstrings.txt:2)
    static member stoppedDueToError: unit -> string
    /// Usage: %s <options> [script.fsx [<arguments>]]
    /// (Originally from Interactive\FSIstrings.txt:3)
    static member fsiUsage: a0: System.String -> string
    /// - INPUT FILES -
    /// (Originally from Interactive\FSIstrings.txt:4)
    static member fsiInputFiles: unit -> string
    /// - CODE GENERATION -
    /// (Originally from Interactive\FSIstrings.txt:5)
    static member fsiCodeGeneration: unit -> string
    /// - ERRORS AND WARNINGS -
    /// (Originally from Interactive\FSIstrings.txt:6)
    static member fsiErrorsAndWarnings: unit -> string
    /// - LANGUAGE -
    /// (Originally from Interactive\FSIstrings.txt:7)
    static member fsiLanguage: unit -> string
    /// - MISCELLANEOUS -
    /// (Originally from Interactive\FSIstrings.txt:8)
    static member fsiMiscellaneous: unit -> string
    /// - ADVANCED -
    /// (Originally from Interactive\FSIstrings.txt:9)
    static member fsiAdvanced: unit -> string
    /// Exception raised when starting remoting server.\n%s
    /// (Originally from Interactive\FSIstrings.txt:10)
    static member fsiExceptionRaisedStartingServer: a0: System.String -> string
    /// Use the given file on startup as initial input
    /// (Originally from Interactive\FSIstrings.txt:11)
    static member fsiUse: unit -> string
    /// #load the given file on startup
    /// (Originally from Interactive\FSIstrings.txt:12)
    static member fsiLoad: unit -> string
    /// Treat remaining arguments as command line arguments, accessed using fsi.CommandLineArgs
    /// (Originally from Interactive\FSIstrings.txt:13)
    static member fsiRemaining: unit -> string
    /// Display this usage message (Short form: -?)
    /// (Originally from Interactive\FSIstrings.txt:14)
    static member fsiHelp: unit -> string
    /// Exit fsi after loading the files or running the .fsx script given on the command line
    /// (Originally from Interactive\FSIstrings.txt:15)
    static member fsiExec: unit -> string
    /// Execute interactions on a Windows Forms event loop (%s by default)
    /// (Originally from Interactive\FSIstrings.txt:16)
    static member fsiGui: a0: System.String -> string
    /// Suppress fsi writing to stdout
    /// (Originally from Interactive\FSIstrings.txt:17)
    static member fsiQuiet: unit -> string
    /// Support TAB completion in console (%s by default)
    /// (Originally from Interactive\FSIstrings.txt:18)
    static member fsiReadline: a0: System.String -> string
    /// Emit debug information in quotations (%s by default)
    /// (Originally from Interactive\FSIstrings.txt:19)
    static member fsiEmitDebugInfoInQuotations: a0: System.String -> string
    /// For help type #help;;
    /// (Originally from Interactive\FSIstrings.txt:20)
    static member fsiBanner3: unit -> string
    /// A problem occurred starting the F# Interactive process. This may be due to a known problem with background process console support for Unicode-enabled applications on some Windows systems. Try selecting Tools->Options->F# Interactive for Visual Studio and enter '--fsi-server-no-unicode'.
    /// (Originally from Interactive\FSIstrings.txt:21)
    static member fsiConsoleProblem: unit -> string
    /// '%s' is not a valid assembly name
    /// (Originally from Interactive\FSIstrings.txt:22)
    static member fsiInvalidAssembly: a0: System.String -> int * string
    /// Directory '%s' doesn't exist
    /// (Originally from Interactive\FSIstrings.txt:23)
    static member fsiDirectoryDoesNotExist: a0: System.String -> int * string
    /// Warning: line too long, ignoring some characters\n
    /// (Originally from Interactive\FSIstrings.txt:24)
    static member fsiLineTooLong: unit -> string
    /// Real: %s, CPU: %s, GC %s
    /// (Originally from Interactive\FSIstrings.txt:25)
    static member fsiTimeInfoMainString: a0: System.String * a1: System.String * a2: System.String -> string
    /// gen
    /// (Originally from Interactive\FSIstrings.txt:26)
    static member fsiTimeInfoGCGenerationLabelSomeShorthandForTheWordGeneration: unit -> string
    /// \n\nException raised during pretty printing.\nPlease report this so it can be fixed.\nTrace: %s\n
    /// (Originally from Interactive\FSIstrings.txt:27)
    static member fsiExceptionDuringPrettyPrinting: a0: System.String -> string
    ///   F# Interactive directives:
    /// (Originally from Interactive\FSIstrings.txt:28)
    static member fsiIntroTextHeader1directives: unit -> string
    /// Reference (dynamically load) the given DLL
    /// (Originally from Interactive\FSIstrings.txt:29)
    static member fsiIntroTextHashrInfo: unit -> string
    /// Add the given search path for referenced DLLs
    /// (Originally from Interactive\FSIstrings.txt:30)
    static member fsiIntroTextHashIInfo: unit -> string
    /// Include package source uri when searching for packages
    /// (Originally from Interactive\FSIstrings.txt:31)
    static member fsiIntroPackageSourceUriInfo: unit -> string
    /// Load the given file(s) as if compiled and referenced
    /// (Originally from Interactive\FSIstrings.txt:32)
    static member fsiIntroTextHashloadInfo: unit -> string
    /// Toggle timing on/off
    /// (Originally from Interactive\FSIstrings.txt:33)
    static member fsiIntroTextHashtimeInfo: unit -> string
    /// Display help
    /// (Originally from Interactive\FSIstrings.txt:34)
    static member fsiIntroTextHashhelpInfo: unit -> string
    /// Display documentation for an identifier, e.g. #help \"List.map\";;
    /// (Originally from Interactive\FSIstrings.txt:35)
    static member fsiIntroTextHashhelpdocInfo: unit -> string
    /// Exit
    /// (Originally from Interactive\FSIstrings.txt:36)
    static member fsiIntroTextHashquitInfo: unit -> string
    /// Clear screen
    /// (Originally from Interactive\FSIstrings.txt:37)
    static member fsiIntroTextHashclearInfo: unit -> string
    ///   F# Interactive command line options:
    /// (Originally from Interactive\FSIstrings.txt:38)
    static member fsiIntroTextHeader2commandLine: unit -> string
    ///       See '%s' for options
    /// (Originally from Interactive\FSIstrings.txt:39)
    static member fsiIntroTextHeader3: a0: System.String -> string
    /// Loading
    /// (Originally from Interactive\FSIstrings.txt:40)
    static member fsiLoadingFilesPrefixText: unit -> string
    /// \n- Interrupt\n
    /// (Originally from Interactive\FSIstrings.txt:41)
    static member fsiInterrupt: unit -> string
    /// \n- Exit...\n
    /// (Originally from Interactive\FSIstrings.txt:42)
    static member fsiExit: unit -> string
    /// - Aborting main thread...
    /// (Originally from Interactive\FSIstrings.txt:43)
    static member fsiAbortingMainThread: unit -> string
    /// Failed to install ctrl-c handler - Ctrl-C handling will not be available. Error was:\n\t%s
    /// (Originally from Interactive\FSIstrings.txt:44)
    static member fsiCouldNotInstallCtrlCHandler: a0: System.String -> string
    /// --> Referenced '%s'
    /// (Originally from Interactive\FSIstrings.txt:45)
    static member fsiDidAHashr: a0: System.String -> string
    /// --> Referenced '%s' (file may be locked by F# Interactive process)
    /// (Originally from Interactive\FSIstrings.txt:46)
    static member fsiDidAHashrWithLockWarning: a0: System.String -> string
    /// --> Referenced '%s' (an assembly with a different timestamp has already been referenced from this location, reset fsi to load the updated assembly)
    /// (Originally from Interactive\FSIstrings.txt:47)
    static member fsiDidAHashrWithStaleWarning: a0: System.String -> string
    /// --> Added '%s' to library include path
    /// (Originally from Interactive\FSIstrings.txt:48)
    static member fsiDidAHashI: a0: System.String -> string
    /// --> Timing now on
    /// (Originally from Interactive\FSIstrings.txt:49)
    static member fsiTurnedTimingOn: unit -> string
    /// --> Timing now off
    /// (Originally from Interactive\FSIstrings.txt:50)
    static member fsiTurnedTimingOff: unit -> string
    /// - Unexpected ThreadAbortException (Ctrl-C) during event handling: Trying to restart...
    /// (Originally from Interactive\FSIstrings.txt:51)
    static member fsiUnexpectedThreadAbortException: unit -> string
    /// Failed to resolve assembly '%s'
    /// (Originally from Interactive\FSIstrings.txt:52)
    static member fsiFailedToResolveAssembly: a0: System.String -> string
    /// Binding session to '%s'...
    /// (Originally from Interactive\FSIstrings.txt:53)
    static member fsiBindingSessionTo: a0: System.String -> string
    /// Microsoft (R) F# Interactive version %s
    /// (Originally from Interactive\FSIstrings.txt:54)
    static member fsiProductName: a0: System.String -> string
    /// F# Interactive for F# %s
    /// (Originally from Interactive\FSIstrings.txt:55)
    static member fsiProductNameCommunity: a0: System.String -> string
    /// Prevents references from being locked by the F# Interactive process (%s by default)
    /// (Originally from Interactive\FSIstrings.txt:56)
    static member shadowCopyReferences: a0: System.String -> string
    /// Operation could not be completed due to earlier error
    /// (Originally from Interactive\FSIstrings.txt:57)
    static member fsiOperationCouldNotBeCompleted: unit -> string
    /// Operation failed. The error text has been printed in the error stream. To return the corresponding FSharpDiagnostic use the EvalInteractionNonThrowing, EvalScriptNonThrowing or EvalExpressionNonThrowing
    /// (Originally from Interactive\FSIstrings.txt:58)
    static member fsiOperationFailed: unit -> string
    /// Emit multiple assemblies (%s by default)
    /// (Originally from Interactive\FSIstrings.txt:59)
    static member fsiMultiAssemblyEmitOption: a0: System.String -> string
    /// Functions with [<EntryPoint>] are not invoked in FSI. '%s' was not invoked. Execute '%s <args>' in order to invoke '%s' with the appropriate string array of command line arguments.
    /// (Originally from Interactive\FSIstrings.txt:60)
    static member fsiEntryPointWontBeInvoked: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// See https://learn.microsoft.com/dotnet/fsharp/language-reference/fsharp-interactive-options for more details.
    /// (Originally from Interactive\FSIstrings.txt:61)
    static member fsiDetailedHelpLink: unit -> string
    static member RunStartupValidation: unit -> unit
