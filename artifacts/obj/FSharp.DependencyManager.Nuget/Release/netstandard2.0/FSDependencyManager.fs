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

type internal SR private() =

    // BEGIN BOILERPLATE
    static let getCurrentAssembly () = System.Reflection.Assembly.GetExecutingAssembly()

    static let getTypeInfo (t: System.Type) = t

    static let resources = lazy (new System.Resources.ResourceManager("FSDependencyManager", getCurrentAssembly()))

    static let GetString(name:string) =
        let s = resources.Value.GetString(name, System.Globalization.CultureInfo.CurrentUICulture)
    #if DEBUG
        if isNull s then
            System.Diagnostics.Debug.Assert(false, sprintf "**RESOURCE ERROR**: Resource token %s does not exist!" name)
    #endif
    #if NULLABLE
        Unchecked.nonNull s
    #else
        s
    #endif


    static let mkFunctionValue (tys: System.Type[]) (impl:objnull->objnull) =
        FSharpValue.MakeFunction(FSharpType.MakeFunctionType(tys.[0],tys.[1]), impl)

    static let funTyC = typeof<(obj -> obj)>.GetGenericTypeDefinition()

    static let isNamedType(ty:System.Type) = not (ty.IsArray ||  ty.IsByRef ||  ty.IsPointer)
    static let isFunctionType (ty1:System.Type)  =
        isNamedType(ty1) && getTypeInfo(ty1).IsGenericType && System.Type.op_Equality(ty1.GetGenericTypeDefinition(), funTyC)

    static let rec destFunTy (ty:System.Type) =
        if isFunctionType ty then
            ty, ty.GetGenericArguments()
        else
            match getTypeInfo(ty).BaseType with
            | null -> failwith "destFunTy: not a function type"
            | b -> destFunTy b

    static let buildFunctionForOneArgPat (ty: System.Type) impl =
        let _,tys = destFunTy ty
        let rty = tys.[1]
        // PERF: this technique is a bit slow (e.g. in simple cases, like 'sprintf "%x"')
        mkFunctionValue tys (fun inp -> impl rty inp)

    #if !NULLABLE
    static let capture1 (fmt:string) i args ty (go: obj list -> System.Type -> int -> obj) : obj =
    #else
    static let capture1 (fmt:string) i args ty (go: objnull list -> System.Type -> int -> obj) : obj =
    #endif
        match fmt.[i] with
        | '%' -> go args ty (i+1)
        | 'd'
        | 'f'
        | 's' -> buildFunctionForOneArgPat ty (fun rty n -> go (n :: args) rty (i+1))
        | _ -> failwith "bad format specifier"

    // newlines and tabs get converted to strings when read from a resource file
    // this will preserve their original intention
    static let postProcessString (s: string) =
        s.Replace("\\n","\n").Replace("\\t","\t").Replace("\\r","\r").Replace("\\\"", "\"")

    static let createMessageString (messageString: string) (fmt: Printf.StringFormat<'T>) : 'T =
        let fmt = fmt.Value // here, we use the actual error string, as opposed to the one stored as fmt
        let len = fmt.Length

        /// Function to capture the arguments and then run.
        let rec capture args ty i =
            if i >= len ||  (fmt.[i] = '%' && i+1 >= len) then
                let b = new System.Text.StringBuilder()
                b.AppendFormat(messageString, [| for x in List.rev args -> x |]) |> ignore
    #if !NULLABLE
                box(b.ToString())
    #else
                box(b.ToString()) |> Unchecked.nonNull
    #endif
            // REVIEW: For these purposes, this should be a nop, but I'm leaving it
            // in incase we ever decide to support labels for the error format string
            // E.g., "<name>%s<foo>%d"
            elif System.Char.IsSurrogatePair(fmt,i) then
                capture args ty (i+2)
            else
                match fmt.[i] with
                | '%' ->
                    let i = i+1
                    capture1 fmt i args ty capture
                | _ ->
                    capture args ty (i+1)

        (unbox (capture [] (typeof<'T>) 0) : 'T)

    static let mutable swallowResourceText = false

    static let GetStringFunc((messageID: string),(fmt: Printf.StringFormat<'T>)) : 'T =
        if swallowResourceText then
            sprintf fmt
        else
            let mutable messageString = GetString(messageID)
            messageString <- postProcessString messageString
            createMessageString messageString fmt

    static member GetTextOpt(key:string) : string option = GetString(key) |> Option.ofObj

    /// If set to true, then all error messages will just return the filled 'holes' delimited by ',,,'s - this is for language-neutral testing (e.g. localization-invariant baselines).
    static member SwallowResourceText with get () = swallowResourceText
                                        and set (b) = swallowResourceText <- b
    // END BOILERPLATE

    /// PackageManager cannot reference the System Package '%s'
    /// (Originally from FSDependencyManager.txt:2)
    static member cantReferenceSystemPackage(a0 : System.String) = (GetStringFunc("cantReferenceSystemPackage",",,,%s,,,") a0)
    /// %s requires a value
    /// (Originally from FSDependencyManager.txt:3)
    static member requiresAValue(a0 : System.String) = (GetStringFunc("requiresAValue",",,,%s,,,") a0)
    /// Unable to apply implicit argument number %d
    /// (Originally from FSDependencyManager.txt:4)
    static member unableToApplyImplicitArgument(a0 : System.Int32) = (GetStringFunc("unableToApplyImplicitArgument",",,,%d,,,") a0)
    /// Not used
    /// (Originally from FSDependencyManager.txt:5)
    static member notUsed() = (GetStringFunc("notUsed",",,,") )
    /// Load Nuget Package
    /// (Originally from FSDependencyManager.txt:6)
    static member loadNugetPackage() = (GetStringFunc("loadNugetPackage",",,,") )
    /// version
    /// (Originally from FSDependencyManager.txt:7)
    static member version() = (GetStringFunc("version",",,,") )
    /// with the highest version
    /// (Originally from FSDependencyManager.txt:8)
    static member highestVersion() = (GetStringFunc("highestVersion",",,,") )
    /// The source directory '%s' not found
    /// (Originally from FSDependencyManager.txt:9)
    static member sourceDirectoryDoesntExist(a0 : System.String) = (GetStringFunc("sourceDirectoryDoesntExist",",,,%s,,,") a0)
    /// Timed out resolving packages, process: '%s' '%s'
    /// (Originally from FSDependencyManager.txt:10)
    static member timedoutResolvingPackages(a0 : System.String, a1 : System.String) = (GetStringFunc("timedoutResolvingPackages",",,,%s,,,%s,,,") a0 a1)
    /// Invalid value for timeout '%s', valid values: none, -1 and integer milliseconds to wait
    /// (Originally from FSDependencyManager.txt:11)
    static member invalidTimeoutValue(a0 : System.String) = (GetStringFunc("invalidTimeoutValue",",,,%s,,,") a0)
    /// Missing value for timeout
    /// (Originally from FSDependencyManager.txt:12)
    static member missingTimeoutValue() = (GetStringFunc("missingTimeoutValue",",,,") )
    /// Invalid value for boolean '%s', valid values: true or false
    /// (Originally from FSDependencyManager.txt:13)
    static member invalidBooleanValue(a0 : System.String) = (GetStringFunc("invalidBooleanValue",",,,%s,,,") a0)

    /// Call this method once to validate that all known resources are valid; throws if not
    static member RunStartupValidation() =
        ignore(GetString("cantReferenceSystemPackage"))
        ignore(GetString("requiresAValue"))
        ignore(GetString("unableToApplyImplicitArgument"))
        ignore(GetString("notUsed"))
        ignore(GetString("loadNugetPackage"))
        ignore(GetString("version"))
        ignore(GetString("highestVersion"))
        ignore(GetString("sourceDirectoryDoesntExist"))
        ignore(GetString("timedoutResolvingPackages"))
        ignore(GetString("invalidTimeoutValue"))
        ignore(GetString("missingTimeoutValue"))
        ignore(GetString("invalidBooleanValue"))
        ()
