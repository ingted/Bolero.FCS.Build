// This is a generated file; the original input is 'M:\git\Bolero.FCS.Build\src\Compiler\Facilities\UtilsStrings.txt'
namespace UtilsStrings

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
    /// Microsoft (R) F# Compiler version %s
    /// (Originally from M:\git\Bolero.FCS.Build\src\Compiler\Facilities\UtilsStrings.txt:1)
    static member buildProductName: a0: System.String -> string
    /// %s for F# %s
    /// (Originally from M:\git\Bolero.FCS.Build\src\Compiler\Facilities\UtilsStrings.txt:2)
    static member fSharpBannerVersion: a0: System.String * a1: System.String -> string
    static member RunStartupValidation: unit -> unit
