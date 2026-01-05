// This is a generated file; the original input is 'FSDependencyManager.txt'
namespace FSDependencyManager

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
    /// PackageManager cannot reference the System Package '%s'
    /// (Originally from FSDependencyManager.txt:2)
    static member cantReferenceSystemPackage: a0: System.String -> string
    /// %s requires a value
    /// (Originally from FSDependencyManager.txt:3)
    static member requiresAValue: a0: System.String -> string
    /// Unable to apply implicit argument number %d
    /// (Originally from FSDependencyManager.txt:4)
    static member unableToApplyImplicitArgument: a0: System.Int32 -> string
    /// Not used
    /// (Originally from FSDependencyManager.txt:5)
    static member notUsed: unit -> string
    /// Load Nuget Package
    /// (Originally from FSDependencyManager.txt:6)
    static member loadNugetPackage: unit -> string
    /// version
    /// (Originally from FSDependencyManager.txt:7)
    static member version: unit -> string
    /// with the highest version
    /// (Originally from FSDependencyManager.txt:8)
    static member highestVersion: unit -> string
    /// The source directory '%s' not found
    /// (Originally from FSDependencyManager.txt:9)
    static member sourceDirectoryDoesntExist: a0: System.String -> string
    /// Timed out resolving packages, process: '%s' '%s'
    /// (Originally from FSDependencyManager.txt:10)
    static member timedoutResolvingPackages: a0: System.String * a1: System.String -> string
    /// Invalid value for timeout '%s', valid values: none, -1 and integer milliseconds to wait
    /// (Originally from FSDependencyManager.txt:11)
    static member invalidTimeoutValue: a0: System.String -> string
    /// Missing value for timeout
    /// (Originally from FSDependencyManager.txt:12)
    static member missingTimeoutValue: unit -> string
    /// Invalid value for boolean '%s', valid values: true or false
    /// (Originally from FSDependencyManager.txt:13)
    static member invalidBooleanValue: a0: System.String -> string
    static member RunStartupValidation: unit -> unit
