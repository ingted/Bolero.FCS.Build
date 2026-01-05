// This is a generated file; the original input is 'FSComp.txt'
namespace FSComp

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
    /// The namespace '%s' is not defined.
    /// (Originally from FSComp.txt:5)
    static member undefinedNameNamespace: a0: System.String -> string
    /// The namespace or module '%s' is not defined.
    /// (Originally from FSComp.txt:6)
    static member undefinedNameNamespaceOrModule: a0: System.String -> string
    /// The field, constructor or member '%s' is not defined.
    /// (Originally from FSComp.txt:7)
    static member undefinedNameFieldConstructorOrMember: a0: System.String -> string
    /// The type '%s' does not define the field, constructor or member '%s'.
    /// (Originally from FSComp.txt:8)
    static member undefinedNameFieldConstructorOrMemberWhenTypeIsKnown: a0: System.String * a1: System.String -> string
    /// The value, constructor, namespace or type '%s' is not defined.
    /// (Originally from FSComp.txt:9)
    static member undefinedNameValueConstructorNamespaceOrType: a0: System.String -> string
    /// The value or constructor '%s' is not defined.
    /// (Originally from FSComp.txt:10)
    static member undefinedNameValueOfConstructor: a0: System.String -> string
    /// The value, namespace, type or module '%s' is not defined.
    /// (Originally from FSComp.txt:11)
    static member undefinedNameValueNamespaceTypeOrModule: a0: System.String -> string
    /// The constructor, module or namespace '%s' is not defined.
    /// (Originally from FSComp.txt:12)
    static member undefinedNameConstructorModuleOrNamespace: a0: System.String -> string
    /// The type '%s' is not defined.
    /// (Originally from FSComp.txt:13)
    static member undefinedNameType: a0: System.String -> string
    /// The type '%s' is not defined in '%s'.
    /// (Originally from FSComp.txt:14)
    static member undefinedNameTypeIn: a0: System.String * a1: System.String -> string
    /// The record label or namespace '%s' is not defined.
    /// (Originally from FSComp.txt:15)
    static member undefinedNameRecordLabelOrNamespace: a0: System.String -> string
    /// The record label '%s' is not defined.
    /// (Originally from FSComp.txt:16)
    static member undefinedNameRecordLabel: a0: System.String -> string
    /// Maybe you want one of the following:
    /// (Originally from FSComp.txt:17)
    static member undefinedNameSuggestionsIntro: unit -> string
    /// The type parameter %s is not defined.
    /// (Originally from FSComp.txt:18)
    static member undefinedNameTypeParameter: a0: System.String -> string
    /// The pattern discriminator '%s' is not defined.
    /// (Originally from FSComp.txt:19)
    static member undefinedNamePatternDiscriminator: a0: System.String -> string
    /// Replace with '%s'
    /// (Originally from FSComp.txt:20)
    static member replaceWithSuggestion: a0: System.String -> string
    /// Add . for indexer access.
    /// (Originally from FSComp.txt:21)
    static member addIndexerDot: unit -> string
    /// All elements of a list must be implicitly convertible to the type of the first element, which here is '%s'. This element has type '%s'.
    /// (Originally from FSComp.txt:22)
    static member listElementHasWrongType: a0: System.String * a1: System.String -> string
    /// All elements of a list must be implicitly convertible to the type of the first element, which here is a tuple of length %d of type\n    %s    \nThis element is a tuple of length %d of type\n    %s    \n
    /// (Originally from FSComp.txt:23)
    static member listElementHasWrongTypeTuple: a0: System.Int32 * a1: System.String * a2: System.Int32 * a3: System.String -> string
    /// All elements of an array must be implicitly convertible to the type of the first element, which here is '%s'. This element has type '%s'.
    /// (Originally from FSComp.txt:24)
    static member arrayElementHasWrongType: a0: System.String * a1: System.String -> string
    /// All elements of an array must be implicitly convertible to the type of the first element, which here is a tuple of length %d of type\n    %s    \nThis element is a tuple of length %d of type\n    %s    \n
    /// (Originally from FSComp.txt:25)
    static member arrayElementHasWrongTypeTuple: a0: System.Int32 * a1: System.String * a2: System.Int32 * a3: System.String -> string
    /// This 'if' expression is missing an 'else' branch. Because 'if' is an expression, and not a statement, add an 'else' branch which also returns a value of type '%s'.
    /// (Originally from FSComp.txt:26)
    static member missingElseBranch: a0: System.String -> string
    /// The 'if' expression needs to have type '%s' to satisfy context type requirements. It currently has type '%s'.
    /// (Originally from FSComp.txt:27)
    static member ifExpression: a0: System.String * a1: System.String -> string
    /// The 'if' expression needs to return a tuple of length %d of type\n    %s    \nto satisfy context type requirements. It currently returns a tuple of length %d of type\n    %s    \n
    /// (Originally from FSComp.txt:28)
    static member ifExpressionTuple: a0: System.Int32 * a1: System.String * a2: System.Int32 * a3: System.String -> string
    /// All branches of an 'if' expression must return values implicitly convertible to the type of the first branch, which here is '%s'. This branch returns a value of type '%s'.
    /// (Originally from FSComp.txt:29)
    static member elseBranchHasWrongType: a0: System.String * a1: System.String -> string
    /// All branches of an 'if' expression must return values implicitly convertible to the type of the first branch, which here is a tuple of length %d of type\n    %s    \nThis branch returns a tuple of length %d of type\n    %s    \n
    /// (Originally from FSComp.txt:30)
    static member elseBranchHasWrongTypeTuple: a0: System.Int32 * a1: System.String * a2: System.Int32 * a3: System.String -> string
    /// All branches of a pattern match expression must return values implicitly convertible to the type of the first branch, which here is '%s'. This branch returns a value of type '%s'.
    /// (Originally from FSComp.txt:31)
    static member followingPatternMatchClauseHasWrongType: a0: System.String * a1: System.String -> string
    /// All branches of a pattern match expression must return values implicitly convertible to the type of the first branch, which here is a tuple of length %d of type\n    %s    \nThis branch returns a tuple of length %d of type\n    %s    \n
    /// (Originally from FSComp.txt:32)
    static member followingPatternMatchClauseHasWrongTypeTuple: a0: System.Int32 * a1: System.String * a2: System.Int32 * a3: System.String -> string
    /// A pattern match guard must be of type 'bool', but this 'when' expression is of type '%s'.
    /// (Originally from FSComp.txt:33)
    static member patternMatchGuardIsNotBool: a0: System.String -> string
    /// A ';' is used to separate field values in records. Consider replacing ',' with ';'.
    /// (Originally from FSComp.txt:34)
    static member commaInsteadOfSemicolonInRecord: unit -> string
    /// The '!' operator is used to dereference a ref cell. Consider using 'not expr' here.
    /// (Originally from FSComp.txt:35)
    static member derefInsteadOfNot: unit -> string
    /// The non-generic type '%s' does not expect any type arguments, but here is given %d type argument(s)
    /// (Originally from FSComp.txt:36)
    static member buildUnexpectedTypeArgs: a0: System.String * a1: System.Int32 -> string
    /// Consider using 'return!' instead of 'return'.
    /// (Originally from FSComp.txt:37)
    static member returnUsedInsteadOfReturnBang: unit -> string
    /// Consider using 'yield!' instead of 'yield'.
    /// (Originally from FSComp.txt:38)
    static member yieldUsedInsteadOfYieldBang: unit -> string
    /// \nA tuple type is required for one or more arguments. Consider wrapping the given arguments in additional parentheses or review the definition of the interface.
    /// (Originally from FSComp.txt:39)
    static member tupleRequiredInAbstractMethod: unit -> string
    /// Unexpected symbol '.' in member definition. Expected 'with', '=' or other token.
    /// (Originally from FSComp.txt:40)
    static member parsUnexpectedSymbolDot: unit -> int * string
    /// Namespaces cannot contain values. Consider using a module to hold your value declarations.
    /// (Originally from FSComp.txt:41)
    static member tcNamespaceCannotContainValues: unit -> int * string
    /// This attribute is currently unsupported by the F# compiler. Applying it will not achieve its intended effect.
    /// (Originally from FSComp.txt:42)
    static member unsupportedAttribute: unit -> int * string
    /// Invalid warning number '%s'
    /// (Originally from FSComp.txt:43)
    static member buildInvalidWarningNumber: a0: System.String -> int * string
    /// Invalid version string '%s'
    /// (Originally from FSComp.txt:44)
    static member buildInvalidVersionString: a0: System.String -> int * string
    /// Invalid version file '%s'
    /// (Originally from FSComp.txt:45)
    static member buildInvalidVersionFile: a0: System.String -> int * string
    /// Problem with filename '%s': %s
    /// (Originally from FSComp.txt:46)
    static member buildProblemWithFilename: a0: System.String * a1: System.String -> int * string
    /// No inputs specified
    /// (Originally from FSComp.txt:47)
    static member buildNoInputsSpecified: unit -> int * string
    /// The '--pdb' option requires the '--debug' option to be used
    /// (Originally from FSComp.txt:48)
    static member buildPdbRequiresDebug: unit -> int * string
    /// The search directory '%s' is invalid
    /// (Originally from FSComp.txt:49)
    static member buildInvalidSearchDirectory: a0: System.String -> int * string
    /// The search directory '%s' could not be found
    /// (Originally from FSComp.txt:50)
    static member buildSearchDirectoryNotFound: a0: System.String -> int * string
    /// '%s' is not a valid filename
    /// (Originally from FSComp.txt:51)
    static member buildInvalidFilename: a0: System.String -> int * string
    /// '%s' is not a valid assembly name
    /// (Originally from FSComp.txt:52)
    static member buildInvalidAssemblyName: a0: System.String -> int * string
    /// Unrecognized privacy setting '%s' for managed resource, valid options are 'public' and 'private'
    /// (Originally from FSComp.txt:53)
    static member buildInvalidPrivacy: a0: System.String -> int * string
    /// Unable to read assembly '%s'
    /// (Originally from FSComp.txt:54)
    static member buildCannotReadAssembly: a0: System.String -> int * string
    /// Assembly resolution failure at or near this location
    /// (Originally from FSComp.txt:55)
    static member buildAssemblyResolutionFailed: unit -> int * string
    /// The declarations in this file will be placed in an implicit module '%s' based on the file name '%s'. However this is not a valid F# identifier, so the contents will not be accessible from other files. Consider renaming the file or adding a 'module' or 'namespace' declaration at the top of the file.
    /// (Originally from FSComp.txt:56)
    static member buildImplicitModuleIsNotLegalIdentifier: a0: System.String * a1: System.String -> int * string
    /// Files in libraries or multiple-file applications must begin with a namespace or module declaration, e.g. 'namespace SomeNamespace.SubNamespace' or 'module SomeNamespace.SomeModule'. Only the last source file of an application may omit such a declaration.
    /// (Originally from FSComp.txt:57)
    static member buildMultiFileRequiresNamespaceOrModule: unit -> int * string
    /// Files in libraries or multiple-file applications must begin with a namespace or module declaration. When using a module declaration at the start of a file the '=' sign is not allowed. If this is a top-level module, consider removing the = to resolve this error.
    /// (Originally from FSComp.txt:58)
    static member noEqualSignAfterModule: unit -> int * string
    /// This file contains multiple declarations of the form 'module SomeNamespace.SomeModule'. Only one declaration of this form is permitted in a file. Change your file to use an initial namespace declaration and/or use 'module ModuleName = ...' to define your modules.
    /// (Originally from FSComp.txt:59)
    static member buildMultipleToplevelModules: unit -> int * string
    /// Option requires parameter: %s
    /// (Originally from FSComp.txt:60)
    static member buildOptionRequiresParameter: a0: System.String -> int * string
    /// Source file '%s' could not be found
    /// (Originally from FSComp.txt:61)
    static member buildCouldNotFindSourceFile: a0: System.String -> int * string
    /// The file extension of '%s' is not recognized. Source files must have extension .fs, .fsi, .fsx, .fsscript, .ml or .mli.
    /// (Originally from FSComp.txt:62)
    static member buildInvalidSourceFileExtension: a0: System.String -> int * string
    /// The file extension of '%s' is not recognized. Source files must have extension .fs, .fsi, .fsx or .fsscript
    /// (Originally from FSComp.txt:63)
    static member buildInvalidSourceFileExtensionUpdated: a0: System.String -> int * string
    /// The file extension of '%s' is not recognized. Source files must have extension .fs, .fsi, .fsx or .fsscript. To enable the deprecated use of .ml or .mli extensions, use '--langversion:5.0' and '--mlcompatibility'.
    /// (Originally from FSComp.txt:64)
    static member buildInvalidSourceFileExtensionML: a0: System.String -> int * string
    /// Could not resolve assembly '%s'
    /// (Originally from FSComp.txt:65)
    static member buildCouldNotResolveAssembly: a0: System.String -> int * string
    /// Error opening binary file '%s': %s
    /// (Originally from FSComp.txt:66)
    static member buildErrorOpeningBinaryFile: a0: System.String * a1: System.String -> int * string
    /// The F#-compiled DLL '%s' needs to be recompiled to be used with this version of F#
    /// (Originally from FSComp.txt:67)
    static member buildDifferentVersionMustRecompile: a0: System.String -> int * string
    /// Invalid directive. Expected '#I \"<path>\"'.
    /// (Originally from FSComp.txt:68)
    static member buildInvalidHashIDirective: unit -> int * string
    /// Invalid directive. Expected '#r \"<file-or-assembly>\"'.
    /// (Originally from FSComp.txt:69)
    static member buildInvalidHashrDirective: unit -> int * string
    /// Invalid directive. Expected '#load \"<file>\" ... \"<file>\"'.
    /// (Originally from FSComp.txt:70)
    static member buildInvalidHashloadDirective: unit -> int * string
    /// Invalid directive. Expected '#time', '#time \"on\"' or '#time \"off\"'.
    /// (Originally from FSComp.txt:71)
    static member buildInvalidHashtimeDirective: unit -> int * string
    /// Directives inside modules are ignored
    /// (Originally from FSComp.txt:72)
    static member buildDirectivesInModulesAreIgnored: unit -> int * string
    /// A signature for the file or module '%s' has already been specified
    /// (Originally from FSComp.txt:73)
    static member buildSignatureAlreadySpecified: a0: System.String -> int * string
    /// An implementation of file or module '%s' has already been given. Compilation order is significant in F# because of type inference. You may need to adjust the order of your files to place the signature file before the implementation. In Visual Studio files are type-checked in the order they appear in the project file, which can be edited manually or adjusted using the solution explorer.
    /// (Originally from FSComp.txt:74)
    static member buildImplementationAlreadyGivenDetail: a0: System.String -> int * string
    /// An implementation of the file or module '%s' has already been given
    /// (Originally from FSComp.txt:75)
    static member buildImplementationAlreadyGiven: a0: System.String -> int * string
    /// The signature file '%s' does not have a corresponding implementation file. If an implementation file exists then check the 'module' and 'namespace' declarations in the signature and implementation files match.
    /// (Originally from FSComp.txt:76)
    static member buildSignatureWithoutImplementation: a0: System.String -> int * string
    /// '%s' is not a valid integer argument
    /// (Originally from FSComp.txt:77)
    static member buildArgInvalidInt: a0: System.String -> int * string
    /// '%s' is not a valid floating point argument
    /// (Originally from FSComp.txt:78)
    static member buildArgInvalidFloat: a0: System.String -> int * string
    /// Unrecognized option: '%s'. Use '--help' to learn about recognized command line options.
    /// (Originally from FSComp.txt:79)
    static member buildUnrecognizedOption: a0: System.String -> int * string
    /// Invalid module or namespace name
    /// (Originally from FSComp.txt:80)
    static member buildInvalidModuleOrNamespaceName: unit -> int * string
    /// Error reading/writing metadata for the F# compiled DLL '%s'. Was the DLL compiled with an earlier version of the F# compiler? (error: '%s').
    /// (Originally from FSComp.txt:81)
    static member pickleErrorReadingWritingMetadata: a0: System.String * a1: System.String -> string
    /// The type/module '%s' is not a concrete module or type
    /// (Originally from FSComp.txt:82)
    static member tastTypeOrModuleNotConcrete: a0: System.String -> int * string
    /// The type '%s' has an inline assembly code representation
    /// (Originally from FSComp.txt:83)
    static member tastTypeHasAssemblyCodeRepresentation: a0: System.String -> string
    /// Unrecognized value '%s' for --langversion use --langversion:? for complete list
    /// (Originally from FSComp.txt:84)
    static member optsUnrecognizedLanguageVersion: a0: System.String -> int * string
    /// A namespace and a module named '%s' both occur in two parts of this assembly
    /// (Originally from FSComp.txt:85)
    static member tastNamespaceAndModuleWithSameNameInAssembly: a0: System.String -> int * string
    /// Two modules named '%s' occur in two parts of this assembly
    /// (Originally from FSComp.txt:86)
    static member tastTwoModulesWithSameNameInAssembly: a0: System.String -> int * string
    /// Two type definitions named '%s' occur in namespace '%s' in two parts of this assembly
    /// (Originally from FSComp.txt:87)
    static member tastDuplicateTypeDefinitionInAssembly: a0: System.String * a1: System.String -> int * string
    /// A module and a type definition named '%s' occur in namespace '%s' in two parts of this assembly
    /// (Originally from FSComp.txt:88)
    static member tastConflictingModuleAndTypeDefinitionInAssembly: a0: System.String * a1: System.String -> int * string
    /// Invalid member signature encountered because of an earlier error
    /// (Originally from FSComp.txt:89)
    static member tastInvalidMemberSignature: unit -> int * string
    /// This value does not have a valid property setter type
    /// (Originally from FSComp.txt:90)
    static member tastValueDoesNotHaveSetterType: unit -> int * string
    /// Invalid form for a property getter. At least one '()' argument is required when using the explicit syntax.
    /// (Originally from FSComp.txt:91)
    static member tastInvalidFormForPropertyGetter: unit -> int * string
    /// Invalid form for a property setter. At least one argument is required.
    /// (Originally from FSComp.txt:92)
    static member tastInvalidFormForPropertySetter: unit -> int * string
    /// Unexpected use of a byref-typed variable
    /// (Originally from FSComp.txt:93)
    static member tastUnexpectedByRef: unit -> int * string
    /// A value must be mutable in order to mutate the contents or take the address of a value type, e.g. 'let mutable x = ...'
    /// (Originally from FSComp.txt:94)
    static member tastValueMustBeMutable: unit -> int * string
    /// Invalid mutation of a constant expression. Consider copying the expression to a mutable local, e.g. 'let mutable x = ...'.
    /// (Originally from FSComp.txt:95)
    static member tastInvalidMutationOfConstant: unit -> int * string
    /// The value has been copied to ensure the original is not mutated by this operation or because the copy is implicit when returning a struct from a member and another member is then accessed
    /// (Originally from FSComp.txt:96)
    static member tastValueHasBeenCopied: unit -> string
    /// Recursively defined values cannot appear directly as part of the construction of a tuple value within a recursive binding
    /// (Originally from FSComp.txt:97)
    static member tastRecursiveValuesMayNotBeInConstructionOfTuple: unit -> int * string
    /// Recursive values cannot appear directly as a construction of the type '%s' within a recursive binding. This feature has been removed from the F# language. Consider using a record instead.
    /// (Originally from FSComp.txt:98)
    static member tastRecursiveValuesMayNotAppearInConstructionOfType: a0: System.String -> int * string
    /// Recursive values cannot be directly assigned to the non-mutable field '%s' of the type '%s' within a recursive binding. Consider using a mutable field instead.
    /// (Originally from FSComp.txt:99)
    static member tastRecursiveValuesMayNotBeAssignedToNonMutableField: a0: System.String * a1: System.String -> int * string
    /// Unexpected decode of AutoOpenAttribute
    /// (Originally from FSComp.txt:100)
    static member tastUnexpectedDecodeOfAutoOpenAttribute: unit -> string
    /// Unexpected decode of InternalsVisibleToAttribute
    /// (Originally from FSComp.txt:101)
    static member tastUnexpectedDecodeOfInternalsVisibleToAttribute: unit -> string
    /// Unexpected decode of InterfaceDataVersionAttribute
    /// (Originally from FSComp.txt:102)
    static member tastUnexpectedDecodeOfInterfaceDataVersionAttribute: unit -> string
    /// Active patterns cannot return more than 7 possibilities
    /// (Originally from FSComp.txt:103)
    static member tastActivePatternsLimitedToSeven: unit -> int * string
    /// This is not a valid constant expression or custom attribute value
    /// (Originally from FSComp.txt:104)
    static member tastNotAConstantExpression: unit -> int * string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe mutability attributes differ
    /// (Originally from FSComp.txt:105)
    static member ValueNotContainedMutabilityAttributesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe names differ
    /// (Originally from FSComp.txt:106)
    static member ValueNotContainedMutabilityNamesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe compiled names differ
    /// (Originally from FSComp.txt:107)
    static member ValueNotContainedMutabilityCompiledNamesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe display names differ
    /// (Originally from FSComp.txt:108)
    static member ValueNotContainedMutabilityDisplayNamesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe accessibility specified in the signature is more than that specified in the implementation
    /// (Originally from FSComp.txt:109)
    static member ValueNotContainedMutabilityAccessibilityMore: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe inline flags differ
    /// (Originally from FSComp.txt:110)
    static member ValueNotContainedMutabilityInlineFlagsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe literal constant values and/or attributes differ
    /// (Originally from FSComp.txt:111)
    static member ValueNotContainedMutabilityLiteralConstantValuesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is a type function and the other is not. The signature requires explicit type parameters if they are present in the implementation.
    /// (Originally from FSComp.txt:112)
    static member ValueNotContainedMutabilityOneIsTypeFunction: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe respective type parameter counts differ
    /// (Originally from FSComp.txt:113)
    static member ValueNotContainedMutabilityParameterCountsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe types differ
    /// (Originally from FSComp.txt:114)
    static member ValueNotContainedMutabilityTypesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Nullness warning: Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe types differ in their nullness annotations
    /// (Originally from FSComp.txt:115)
    static member ValueNotContainedMutabilityTypesDifferNullness: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is an extension member and the other is not
    /// (Originally from FSComp.txt:116)
    static member ValueNotContainedMutabilityExtensionsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nAn arity was not inferred for this value
    /// (Originally from FSComp.txt:117)
    static member ValueNotContainedMutabilityArityNotInferred: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe number of generic parameters in the signature and implementation differ (the signature declares %s but the implementation declares %s
    /// (Originally from FSComp.txt:118)
    static member ValueNotContainedMutabilityGenericParametersDiffer: a0: System.String * a1: System.String * a2: System.String * a3: System.String * a4: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe generic parameters in the signature and implementation have different kinds. Perhaps there is a missing [<Measure>] attribute.
    /// (Originally from FSComp.txt:119)
    static member ValueNotContainedMutabilityGenericParametersAreDifferentKinds: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe arities in the signature and implementation differ. The signature specifies that '%s' is function definition or lambda expression accepting at least %s argument(s), but the implementation is a computed function value. To declare that a computed function value is a permitted implementation simply parenthesize its type in the signature, e.g.\n\tval %s: int -> (int -> int)\ninstead of\n\tval %s: int -> int -> int.
    /// (Originally from FSComp.txt:120)
    static member ValueNotContainedMutabilityAritiesDiffer: a0: System.String * a1: System.String * a2: System.String * a3: System.String * a4: System.String * a5: System.String * a6: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe CLI member names differ
    /// (Originally from FSComp.txt:121)
    static member ValueNotContainedMutabilityDotNetNamesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is static and the other isn't
    /// (Originally from FSComp.txt:122)
    static member ValueNotContainedMutabilityStaticsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is virtual and the other isn't
    /// (Originally from FSComp.txt:123)
    static member ValueNotContainedMutabilityVirtualsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is abstract and the other isn't
    /// (Originally from FSComp.txt:124)
    static member ValueNotContainedMutabilityAbstractsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is final and the other isn't
    /// (Originally from FSComp.txt:125)
    static member ValueNotContainedMutabilityFinalsDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is marked as an override and the other isn't
    /// (Originally from FSComp.txt:126)
    static member ValueNotContainedMutabilityOverridesDiffer: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nOne is a constructor/property and the other is not
    /// (Originally from FSComp.txt:127)
    static member ValueNotContainedMutabilityOneIsConstructor: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe compiled representation of this method is as a static member but the signature indicates its compiled representation is as an instance member
    /// (Originally from FSComp.txt:128)
    static member ValueNotContainedMutabilityStaticButInstance: a0: System.String * a1: System.String * a2: System.String -> string
    /// Module '%s' contains\n    %s    \nbut its signature specifies\n    %s    \nThe compiled representation of this method is as an instance member, but the signature indicates its compiled representation is as a static member
    /// (Originally from FSComp.txt:129)
    static member ValueNotContainedMutabilityInstanceButStatic: a0: System.String * a1: System.String * a2: System.String -> string
    /// The %s definitions in the signature and implementation are not compatible because the names differ. The type is called '%s' in the signature file but '%s' in implementation.
    /// (Originally from FSComp.txt:130)
    static member DefinitionsInSigAndImplNotCompatibleNamesDiffer: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the respective type parameter counts differ
    /// (Originally from FSComp.txt:131)
    static member DefinitionsInSigAndImplNotCompatibleParameterCountsDiffer: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the accessibility specified in the signature is more than that specified in the implementation
    /// (Originally from FSComp.txt:132)
    static member DefinitionsInSigAndImplNotCompatibleAccessibilityDiffer: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature requires that the type supports the interface %s but the interface has not been implemented
    /// (Originally from FSComp.txt:133)
    static member DefinitionsInSigAndImplNotCompatibleMissingInterface: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation says this type may use nulls as a representation but the signature does not
    /// (Originally from FSComp.txt:134)
    static member DefinitionsInSigAndImplNotCompatibleImplementationSaysNull: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation says this type may use nulls as an extra value but the signature does not
    /// (Originally from FSComp.txt:135)
    static member DefinitionsInSigAndImplNotCompatibleImplementationSaysNull2: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature says this type may use nulls as a representation but the implementation does not
    /// (Originally from FSComp.txt:136)
    static member DefinitionsInSigAndImplNotCompatibleSignatureSaysNull: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature says this type may use nulls as an extra value but the implementation does not
    /// (Originally from FSComp.txt:137)
    static member DefinitionsInSigAndImplNotCompatibleSignatureSaysNull2: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation type is sealed but the signature implies it is not. Consider adding the [<Sealed>] attribute to the signature.
    /// (Originally from FSComp.txt:138)
    static member DefinitionsInSigAndImplNotCompatibleImplementationSealed: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation type is not sealed but signature implies it is. Consider adding the [<Sealed>] attribute to the implementation.
    /// (Originally from FSComp.txt:139)
    static member DefinitionsInSigAndImplNotCompatibleImplementationIsNotSealed: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation is an abstract class but the signature is not. Consider adding the [<AbstractClass>] attribute to the signature.
    /// (Originally from FSComp.txt:140)
    static member DefinitionsInSigAndImplNotCompatibleImplementationIsAbstract: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature is an abstract class but the implementation is not. Consider adding the [<AbstractClass>] attribute to the implementation.
    /// (Originally from FSComp.txt:141)
    static member DefinitionsInSigAndImplNotCompatibleSignatureIsAbstract: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the types have different base types
    /// (Originally from FSComp.txt:142)
    static member DefinitionsInSigAndImplNotCompatibleTypesHaveDifferentBaseTypes: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the number of %ss differ
    /// (Originally from FSComp.txt:143)
    static member DefinitionsInSigAndImplNotCompatibleNumbersDiffer: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature defines the %s '%s' but the implementation does not (or does, but not in the same order)
    /// (Originally from FSComp.txt:144)
    static member DefinitionsInSigAndImplNotCompatibleSignatureDefinesButImplDoesNot: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation defines the %s '%s' but the signature does not (or does, but not in the same order)
    /// (Originally from FSComp.txt:145)
    static member DefinitionsInSigAndImplNotCompatibleImplDefinesButSignatureDoesNot: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the implementation defines a struct but the signature defines a type with a hidden representation
    /// (Originally from FSComp.txt:146)
    static member DefinitionsInSigAndImplNotCompatibleImplDefinesStruct: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because a CLI type representation is being hidden by a signature
    /// (Originally from FSComp.txt:147)
    static member DefinitionsInSigAndImplNotCompatibleDotNetTypeRepresentationIsHidden: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because a type representation is being hidden by a signature
    /// (Originally from FSComp.txt:148)
    static member DefinitionsInSigAndImplNotCompatibleTypeIsHidden: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the types are of different kinds
    /// (Originally from FSComp.txt:149)
    static member DefinitionsInSigAndImplNotCompatibleTypeIsDifferentKind: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the IL representations differ
    /// (Originally from FSComp.txt:150)
    static member DefinitionsInSigAndImplNotCompatibleILDiffer: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the representations differ
    /// (Originally from FSComp.txt:151)
    static member DefinitionsInSigAndImplNotCompatibleRepresentationsDiffer: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the field %s was present in the implementation but not in the signature
    /// (Originally from FSComp.txt:152)
    static member DefinitionsInSigAndImplNotCompatibleFieldWasPresent: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the order of the fields is different in the signature and implementation
    /// (Originally from FSComp.txt:153)
    static member DefinitionsInSigAndImplNotCompatibleFieldOrderDiffer: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the field %s was required by the signature but was not specified by the implementation
    /// (Originally from FSComp.txt:154)
    static member DefinitionsInSigAndImplNotCompatibleFieldRequiredButNotSpecified: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the field '%s' was present in the implementation but not in the signature. Struct types must now reveal their fields in the signature for the type, though the fields may still be labelled 'private' or 'internal'.
    /// (Originally from FSComp.txt:155)
    static member DefinitionsInSigAndImplNotCompatibleFieldIsInImplButNotSig: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the abstract member '%s' was required by the signature but was not specified by the implementation
    /// (Originally from FSComp.txt:156)
    static member DefinitionsInSigAndImplNotCompatibleAbstractMemberMissingInImpl: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the abstract member '%s' was present in the implementation but not in the signature
    /// (Originally from FSComp.txt:157)
    static member DefinitionsInSigAndImplNotCompatibleAbstractMemberMissingInSig: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature declares a %s while the implementation declares a %s
    /// (Originally from FSComp.txt:158)
    static member DefinitionsInSigAndImplNotCompatibleSignatureDeclaresDiffer: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because an abbreviation is being hidden by a signature. The abbreviation must be visible to other CLI languages. Consider making the abbreviation visible in the signature.
    /// (Originally from FSComp.txt:159)
    static member DefinitionsInSigAndImplNotCompatibleAbbreviationHiddenBySig: a0: System.String * a1: System.String -> int * string
    /// The %s definitions for type '%s' in the signature and implementation are not compatible because the signature has an abbreviation while the implementation does not
    /// (Originally from FSComp.txt:160)
    static member DefinitionsInSigAndImplNotCompatibleSigHasAbbreviation: a0: System.String * a1: System.String -> int * string
    /// The module contains the constructor\n    %s    \nbut its signature specifies\n    %s    \nThe names differ
    /// (Originally from FSComp.txt:161)
    static member ModuleContainsConstructorButNamesDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the constructor\n    %s    \nbut its signature specifies\n    %s    \nThe respective number of data fields differ
    /// (Originally from FSComp.txt:162)
    static member ModuleContainsConstructorButDataFieldsDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the constructor\n    %s    \nbut its signature specifies\n    %s    \nThe types of the fields differ
    /// (Originally from FSComp.txt:163)
    static member ModuleContainsConstructorButTypesOfFieldsDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the constructor\n    %s    \nbut its signature specifies\n    %s    \nthe accessibility specified in the signature is more than that specified in the implementation
    /// (Originally from FSComp.txt:164)
    static member ModuleContainsConstructorButAccessibilityDiffers: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe names differ
    /// (Originally from FSComp.txt:165)
    static member FieldNotContainedNamesDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nthe accessibility specified in the signature is more than that specified in the implementation
    /// (Originally from FSComp.txt:166)
    static member FieldNotContainedAccessibilitiesDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe 'static' modifiers differ
    /// (Originally from FSComp.txt:167)
    static member FieldNotContainedStaticsDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe 'mutable' modifiers differ
    /// (Originally from FSComp.txt:168)
    static member FieldNotContainedMutablesDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe 'literal' modifiers differ
    /// (Originally from FSComp.txt:169)
    static member FieldNotContainedLiteralsDiffer: a0: System.String * a1: System.String -> string
    /// The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe types differ
    /// (Originally from FSComp.txt:170)
    static member FieldNotContainedTypesDiffer: a0: System.String * a1: System.String -> string
    /// Nullness warning: The module contains the field\n    %s    \nbut its signature specifies\n    %s    \nThe types differ in their nullness annotations
    /// (Originally from FSComp.txt:171)
    static member FieldNotContainedTypesDifferNullness: a0: System.String * a1: System.String -> string
    /// The implicit instantiation of a generic construct at or near this point could not be resolved because it could resolve to multiple unrelated types, e.g. '%s' and '%s'. Consider using type annotations to resolve the ambiguity
    /// (Originally from FSComp.txt:172)
    static member typrelCannotResolveImplicitGenericInstantiation: a0: System.String * a1: System.String -> int * string
    /// Could not resolve the ambiguity inherent in the use of a 'printf'-style format string
    /// (Originally from FSComp.txt:173)
    static member typrelCannotResolveAmbiguityInPrintf: unit -> int * string
    /// Could not resolve the ambiguity in the use of a generic construct with an 'enum' constraint at or near this position
    /// (Originally from FSComp.txt:174)
    static member typrelCannotResolveAmbiguityInEnum: unit -> int * string
    /// Could not resolve the ambiguity in the use of a generic construct with a 'delegate' constraint at or near this position
    /// (Originally from FSComp.txt:175)
    static member typrelCannotResolveAmbiguityInDelegate: unit -> int * string
    /// Invalid value
    /// (Originally from FSComp.txt:176)
    static member typrelInvalidValue: unit -> int * string
    /// The signature and implementation are not compatible because the respective type parameter counts differ
    /// (Originally from FSComp.txt:177)
    static member typrelSigImplNotCompatibleParamCountsDiffer: unit -> int * string
    /// The signature and implementation are not compatible because the type parameter in the class/signature has a different compile-time requirement to the one in the member/implementation
    /// (Originally from FSComp.txt:178)
    static member typrelSigImplNotCompatibleCompileTimeRequirementsDiffer: unit -> int * string
    /// The signature and implementation are not compatible because the declaration of the type parameter '%s' requires a constraint of the form %s
    /// (Originally from FSComp.txt:179)
    static member typrelSigImplNotCompatibleConstraintsDiffer: a0: System.String * a1: System.String -> int * string
    /// The signature and implementation are not compatible because the type parameter '%s' has a constraint of the form %s but the implementation does not. Either remove this constraint from the signature or add it to the implementation.
    /// (Originally from FSComp.txt:180)
    static member typrelSigImplNotCompatibleConstraintsDifferRemove: a0: System.String * a1: System.String -> int * string
    /// The type '%s' implements 'System.IComparable'. Consider also adding an explicit override for 'Object.Equals'
    /// (Originally from FSComp.txt:181)
    static member typrelTypeImplementsIComparableShouldOverrideObjectEquals: a0: System.String -> int * string
    /// The type '%s' implements 'System.IComparable' explicitly but provides no corresponding override for 'Object.Equals'. An implementation of 'Object.Equals' has been automatically provided, implemented via 'System.IComparable'. Consider implementing the override 'Object.Equals' explicitly
    /// (Originally from FSComp.txt:182)
    static member typrelTypeImplementsIComparableDefaultObjectEqualsProvided: a0: System.String -> int * string
    /// The struct, record or union type '%s' has an explicit implementation of 'Object.GetHashCode' or 'Object.Equals'. You must apply the 'CustomEquality' attribute to the type
    /// (Originally from FSComp.txt:183)
    static member typrelExplicitImplementationOfGetHashCodeOrEquals: a0: System.String -> int * string
    /// The struct, record or union type '%s' has an explicit implementation of 'Object.GetHashCode'. Consider implementing a matching override for 'Object.Equals(obj)'
    /// (Originally from FSComp.txt:184)
    static member typrelExplicitImplementationOfGetHashCode: a0: System.String -> int * string
    /// The struct, record or union type '%s' has an explicit implementation of 'Object.Equals'. Consider implementing a matching override for 'Object.GetHashCode()'
    /// (Originally from FSComp.txt:185)
    static member typrelExplicitImplementationOfEquals: a0: System.String -> int * string
    /// The exception definitions are not compatible because a CLI exception mapping is being hidden by a signature. The exception mapping must be visible to other modules. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s
    /// (Originally from FSComp.txt:186)
    static member ExceptionDefsNotCompatibleHiddenBySignature: a0: System.String * a1: System.String -> string
    /// The exception definitions are not compatible because the CLI representations differ. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s
    /// (Originally from FSComp.txt:187)
    static member ExceptionDefsNotCompatibleDotNetRepresentationsDiffer: a0: System.String * a1: System.String -> string
    /// The exception definitions are not compatible because the exception abbreviation is being hidden by the signature. The abbreviation must be visible to other CLI languages. Consider making the abbreviation visible in the signature. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:188)
    static member ExceptionDefsNotCompatibleAbbreviationHiddenBySignature: a0: System.String * a1: System.String -> string
    /// The exception definitions are not compatible because the exception abbreviations in the signature and implementation differ. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:189)
    static member ExceptionDefsNotCompatibleSignaturesDiffer: a0: System.String * a1: System.String -> string
    /// The exception definitions are not compatible because the exception declarations differ. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:190)
    static member ExceptionDefsNotCompatibleExceptionDeclarationsDiffer: a0: System.String * a1: System.String -> string
    /// The exception definitions are not compatible because the field '%s' was required by the signature but was not specified by the implementation. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:191)
    static member ExceptionDefsNotCompatibleFieldInSigButNotImpl: a0: System.String * a1: System.String * a2: System.String -> string
    /// The exception definitions are not compatible because the field '%s' was present in the implementation but not in the signature. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:192)
    static member ExceptionDefsNotCompatibleFieldInImplButNotSig: a0: System.String * a1: System.String * a2: System.String -> string
    /// The exception definitions are not compatible because the order of the fields is different in the signature and implementation. The module contains the exception definition\n    %s    \nbut its signature specifies\n\t%s.
    /// (Originally from FSComp.txt:193)
    static member ExceptionDefsNotCompatibleFieldOrderDiffers: a0: System.String * a1: System.String -> string
    /// The namespace or module attributes differ between signature and implementation
    /// (Originally from FSComp.txt:194)
    static member typrelModuleNamespaceAttributesDifferInSigAndImpl: unit -> int * string
    /// This method is over-constrained in its type parameters
    /// (Originally from FSComp.txt:195)
    static member typrelMethodIsOverconstrained: unit -> int * string
    /// No implementations of '%s' had the correct number of arguments and type parameters. The required signature is '%s'.
    /// (Originally from FSComp.txt:196)
    static member typrelOverloadNotFound: a0: System.String * a1: System.String -> int * string
    /// The override for '%s' was ambiguous
    /// (Originally from FSComp.txt:197)
    static member typrelOverrideWasAmbiguous: a0: System.String -> int * string
    /// More than one override implements '%s'
    /// (Originally from FSComp.txt:198)
    static member typrelMoreThenOneOverride: a0: System.String -> int * string
    /// The method '%s' is sealed and cannot be overridden
    /// (Originally from FSComp.txt:199)
    static member typrelMethodIsSealed: a0: System.String -> int * string
    /// The override '%s' implements more than one abstract slot, e.g. '%s' and '%s'
    /// (Originally from FSComp.txt:200)
    static member typrelOverrideImplementsMoreThenOneSlot: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Duplicate or redundant interface
    /// (Originally from FSComp.txt:201)
    static member typrelDuplicateInterface: unit -> int * string
    /// The interface '%s' is included in multiple explicitly implemented interface types. Add an explicit implementation of this interface.
    /// (Originally from FSComp.txt:202)
    static member typrelNeedExplicitImplementation: a0: System.String -> int * string
    /// The named argument '%s' has been assigned more than one value
    /// (Originally from FSComp.txt:203)
    static member typrelNamedArgumentHasBeenAssignedMoreThenOnce: a0: System.String -> int * string
    /// No implementation was given for '%s'
    /// (Originally from FSComp.txt:204)
    static member typrelNoImplementationGiven: a0: System.String -> int * string
    /// No implementation was given for those members: %s
    /// (Originally from FSComp.txt:205)
    static member typrelNoImplementationGivenSeveral: a0: System.String -> int * string
    /// No implementation was given for those members (some results omitted): %s
    /// (Originally from FSComp.txt:206)
    static member typrelNoImplementationGivenSeveralTruncated: a0: System.String -> int * string
    /// No implementation was given for '%s'. Note that all interface members must be implemented and listed under an appropriate 'interface' declaration, e.g. 'interface ... with member ...'.
    /// (Originally from FSComp.txt:207)
    static member typrelNoImplementationGivenWithSuggestion: a0: System.String -> int * string
    /// No implementation was given for those members: %sNote that all interface members must be implemented and listed under an appropriate 'interface' declaration, e.g. 'interface ... with member ...'.
    /// (Originally from FSComp.txt:208)
    static member typrelNoImplementationGivenSeveralWithSuggestion: a0: System.String -> int * string
    /// No implementation was given for those members (some results omitted): %sNote that all interface members must be implemented and listed under an appropriate 'interface' declaration, e.g. 'interface ... with member ...'.
    /// (Originally from FSComp.txt:209)
    static member typrelNoImplementationGivenSeveralTruncatedWithSuggestion: a0: System.String -> int * string
    /// The member '%s' does not have the correct number of arguments. The required signature is '%s'.
    /// (Originally from FSComp.txt:210)
    static member typrelMemberDoesNotHaveCorrectNumberOfArguments: a0: System.String * a1: System.String -> int * string
    /// The member '%s' does not have the correct number of method type parameters. The required signature is '%s'.
    /// (Originally from FSComp.txt:211)
    static member typrelMemberDoesNotHaveCorrectNumberOfTypeParameters: a0: System.String * a1: System.String -> int * string
    /// The member '%s' does not have the correct kinds of generic parameters. The required signature is '%s'.
    /// (Originally from FSComp.txt:212)
    static member typrelMemberDoesNotHaveCorrectKindsOfGenericParameters: a0: System.String * a1: System.String -> int * string
    /// The member '%s' cannot be used to implement '%s'. The required signature is '%s'.
    /// (Originally from FSComp.txt:213)
    static member typrelMemberCannotImplement: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Error while parsing embedded IL
    /// (Originally from FSComp.txt:214)
    static member astParseEmbeddedILError: unit -> int * string
    /// Error while parsing embedded IL type
    /// (Originally from FSComp.txt:215)
    static member astParseEmbeddedILTypeError: unit -> int * string
    /// This indexer notation has been removed from the F# language
    /// (Originally from FSComp.txt:216)
    static member astDeprecatedIndexerNotation: unit -> string
    /// Invalid expression on left of assignment
    /// (Originally from FSComp.txt:217)
    static member astInvalidExprLeftHandOfAssignment: unit -> int * string
    /// The 'ReferenceEquality' attribute cannot be used on structs. Consider using the 'StructuralEquality' attribute instead, or implement an override for 'System.Object.Equals(obj)'.
    /// (Originally from FSComp.txt:218)
    static member augNoRefEqualsOnStruct: unit -> int * string
    /// This type uses an invalid mix of the attributes 'NoEquality', 'ReferenceEquality', 'StructuralEquality', 'NoComparison' and 'StructuralComparison'
    /// (Originally from FSComp.txt:219)
    static member augInvalidAttrs: unit -> int * string
    /// The 'NoEquality' attribute must be used in conjunction with the 'NoComparison' attribute
    /// (Originally from FSComp.txt:220)
    static member augNoEqualityNeedsNoComparison: unit -> int * string
    /// The 'StructuralComparison' attribute must be used in conjunction with the 'StructuralEquality' attribute
    /// (Originally from FSComp.txt:221)
    static member augStructCompNeedsStructEquality: unit -> int * string
    /// The 'StructuralEquality' attribute must be used in conjunction with the 'NoComparison' or 'StructuralComparison' attributes
    /// (Originally from FSComp.txt:222)
    static member augStructEqNeedsNoCompOrStructComp: unit -> int * string
    /// A type cannot have both the 'ReferenceEquality' and 'StructuralEquality' or 'StructuralComparison' attributes
    /// (Originally from FSComp.txt:223)
    static member augTypeCantHaveRefEqAndStructAttrs: unit -> int * string
    /// Only record, union, exception and struct types may be augmented with the 'ReferenceEquality', 'StructuralEquality' and 'StructuralComparison' attributes
    /// (Originally from FSComp.txt:224)
    static member augOnlyCertainTypesCanHaveAttrs: unit -> int * string
    /// A type with attribute 'ReferenceEquality' cannot have an explicit implementation of 'Object.Equals(obj)', 'System.IEquatable<_>' or 'System.Collections.IStructuralEquatable'
    /// (Originally from FSComp.txt:225)
    static member augRefEqCantHaveObjEquals: unit -> int * string
    /// A type with attribute 'CustomEquality' must have an explicit implementation of at least one of 'Object.Equals(obj)', 'System.IEquatable<_>' or 'System.Collections.IStructuralEquatable'
    /// (Originally from FSComp.txt:226)
    static member augCustomEqNeedsObjEquals: unit -> int * string
    /// A type with attribute 'CustomComparison' must have an explicit implementation of at least one of 'System.IComparable' or 'System.Collections.IStructuralComparable'
    /// (Originally from FSComp.txt:227)
    static member augCustomCompareNeedsIComp: unit -> int * string
    /// A type with attribute 'NoEquality' should not usually have an explicit implementation of 'Object.Equals(obj)'. Disable this warning if this is intentional for interoperability purposes
    /// (Originally from FSComp.txt:228)
    static member augNoEqNeedsNoObjEquals: unit -> int * string
    /// A type with attribute 'NoComparison' should not usually have an explicit implementation of 'System.IComparable', 'System.IComparable<_>' or 'System.Collections.IStructuralComparable'. Disable this warning if this is intentional for interoperability purposes
    /// (Originally from FSComp.txt:229)
    static member augNoCompCantImpIComp: unit -> int * string
    /// The 'CustomEquality' attribute must be used in conjunction with the 'NoComparison' or 'CustomComparison' attributes
    /// (Originally from FSComp.txt:230)
    static member augCustomEqNeedsNoCompOrCustomComp: unit -> int * string
    /// Positional specifiers are not permitted in format strings
    /// (Originally from FSComp.txt:231)
    static member forPositionalSpecifiersNotPermitted: unit -> string
    /// Missing format specifier
    /// (Originally from FSComp.txt:232)
    static member forMissingFormatSpecifier: unit -> string
    /// '%s' flag set twice
    /// (Originally from FSComp.txt:233)
    static member forFlagSetTwice: a0: System.String -> string
    /// Prefix flag (' ' or '+') set twice
    /// (Originally from FSComp.txt:234)
    static member forPrefixFlagSpacePlusSetTwice: unit -> string
    /// The # formatting modifier is invalid in F#
    /// (Originally from FSComp.txt:235)
    static member forHashSpecifierIsInvalid: unit -> string
    /// Bad precision in format specifier
    /// (Originally from FSComp.txt:236)
    static member forBadPrecision: unit -> string
    /// Bad width in format specifier
    /// (Originally from FSComp.txt:237)
    static member forBadWidth: unit -> string
    /// '%s' format does not support '0' flag
    /// (Originally from FSComp.txt:238)
    static member forDoesNotSupportZeroFlag: a0: System.String -> string
    /// Precision missing after the '.'
    /// (Originally from FSComp.txt:239)
    static member forPrecisionMissingAfterDot: unit -> string
    /// '%s' format does not support precision
    /// (Originally from FSComp.txt:240)
    static member forFormatDoesntSupportPrecision: a0: System.String -> string
    /// Bad format specifier (after l or L): Expected ld,li,lo,lu,lx or lX. In F# code you can use %%d, %%x, %%o or %%u instead, which are overloaded to work with all basic integer types.
    /// (Originally from FSComp.txt:241)
    static member forBadFormatSpecifier: unit -> string
    /// The 'l' or 'L' in this format specifier is unnecessary. In F# code you can use %%d, %%x, %%o or %%u instead, which are overloaded to work with all basic integer types.
    /// (Originally from FSComp.txt:242)
    static member forLIsUnnecessary: unit -> string
    /// The 'h' or 'H' in this format specifier is unnecessary. You can use %%d, %%x, %%o or %%u instead, which are overloaded to work with all basic integer types.
    /// (Originally from FSComp.txt:243)
    static member forHIsUnnecessary: unit -> string
    /// '%s' does not support prefix '%s' flag
    /// (Originally from FSComp.txt:244)
    static member forDoesNotSupportPrefixFlag: a0: System.String * a1: System.String -> string
    /// Bad format specifier: '%s'
    /// (Originally from FSComp.txt:245)
    static member forBadFormatSpecifierGeneral: a0: System.String -> string
    /// The '%%A' format specifier may not be used in an assembly being compiled with option '--reflectionfree'. This construct implicitly uses reflection.
    /// (Originally from FSComp.txt:246)
    static member forPercentAInReflectionFreeCode: unit -> string
    /// System.Environment.Exit did not exit
    /// (Originally from FSComp.txt:247)
    static member elSysEnvExitDidntExit: unit -> string
    /// The treatment of this operator is now handled directly by the F# compiler and its meaning cannot be redefined
    /// (Originally from FSComp.txt:248)
    static member elDeprecatedOperator: unit -> string
    /// A protected member is called or 'base' is being used. This is only allowed in the direct implementation of members since they could escape their object scope.
    /// (Originally from FSComp.txt:249)
    static member chkProtectedOrBaseCalled: unit -> int * string
    /// The byref-typed variable '%s' is used in an invalid way. Byrefs cannot be captured by closures or passed to inner functions.
    /// (Originally from FSComp.txt:250)
    static member chkByrefUsedInInvalidWay: a0: System.String -> int * string
    /// The 'base' keyword is used in an invalid way. Base calls cannot be used in closures. Consider using a private member to make base calls.
    /// (Originally from FSComp.txt:251)
    static member chkBaseUsedInInvalidWay: unit -> int * string
    /// The variable '%s' is used in an invalid way
    /// (Originally from FSComp.txt:252)
    static member chkVariableUsedInInvalidWay: a0: System.String -> string
    /// The type '%s' is less accessible than the value, member or type '%s' it is used in.
    /// (Originally from FSComp.txt:253)
    static member chkTypeLessAccessibleThanType: a0: System.String * a1: System.String -> int * string
    /// 'System.Void' can only be used as 'typeof<System.Void>' in F#
    /// (Originally from FSComp.txt:254)
    static member chkSystemVoidOnlyInTypeof: unit -> int * string
    /// A type instantiation involves a byref type. This is not permitted by the rules of Common IL.
    /// (Originally from FSComp.txt:255)
    static member chkErrorUseOfByref: unit -> int * string
    /// Calls to 'reraise' may only occur directly in a handler of a try-with
    /// (Originally from FSComp.txt:256)
    static member chkErrorContainsCallToRethrow: unit -> int * string
    /// Expression-splicing operators may only be used within quotations
    /// (Originally from FSComp.txt:257)
    static member chkSplicingOnlyInQuotations: unit -> int * string
    /// First-class uses of the expression-splicing operator are not permitted
    /// (Originally from FSComp.txt:258)
    static member chkNoFirstClassSplicing: unit -> int * string
    /// First-class uses of the address-of operators are not permitted
    /// (Originally from FSComp.txt:259)
    static member chkNoFirstClassAddressOf: unit -> int * string
    /// First-class uses of the 'reraise' function is not permitted
    /// (Originally from FSComp.txt:260)
    static member chkNoFirstClassRethrow: unit -> int * string
    /// The byref typed value '%s' cannot be used at this point
    /// (Originally from FSComp.txt:261)
    static member chkNoByrefAtThisPoint: a0: System.String -> int * string
    /// 'base' values may only be used to make direct calls to the base implementations of overridden members
    /// (Originally from FSComp.txt:262)
    static member chkLimitationsOfBaseKeyword: unit -> int * string
    /// The address of the variable '%s' cannot be used at this point
    /// (Originally from FSComp.txt:264)
    static member chkNoAddressOfAtThisPoint: a0: System.String -> int * string
    /// The address of the static field '%s' cannot be used at this point
    /// (Originally from FSComp.txt:265)
    static member chkNoAddressStaticFieldAtThisPoint: a0: System.String -> int * string
    /// The address of the field '%s' cannot be used at this point
    /// (Originally from FSComp.txt:266)
    static member chkNoAddressFieldAtThisPoint: a0: System.String -> int * string
    /// The address of an array element cannot be used at this point
    /// (Originally from FSComp.txt:267)
    static member chkNoAddressOfArrayElementAtThisPoint: unit -> int * string
    /// The type of a first-class function cannot contain byrefs
    /// (Originally from FSComp.txt:268)
    static member chkFirstClassFuncNoByref: unit -> int * string
    /// A method return type would contain byrefs which is not permitted
    /// (Originally from FSComp.txt:269)
    static member chkReturnTypeNoByref: unit -> int * string
    /// Invalid custom attribute value (not a constant or literal)
    /// (Originally from FSComp.txt:270)
    static member chkInvalidCustAttrVal: unit -> int * string
    /// The attribute type '%s' has 'AllowMultiple=false'. Multiple instances of this attribute cannot be attached to a single language element.
    /// (Originally from FSComp.txt:271)
    static member chkAttrHasAllowMultiFalse: a0: System.String -> int * string
    /// The member '%s' is used in an invalid way. A use of '%s' has been inferred prior to its definition at or near '%s'. This is an invalid forward reference.
    /// (Originally from FSComp.txt:272)
    static member chkMemberUsedInInvalidWay: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// A byref typed value would be stored here. Top-level let-bound byref values are not permitted.
    /// (Originally from FSComp.txt:273)
    static member chkNoByrefAsTopValue: unit -> int * string
    /// [<ReflectedDefinition>] terms cannot contain uses of the prefix splice operator '%%'
    /// (Originally from FSComp.txt:274)
    static member chkReflectedDefCantSplice: unit -> int * string
    /// A function labeled with the 'EntryPointAttribute' attribute must be the last declaration in the last file in the compilation sequence.
    /// (Originally from FSComp.txt:275)
    static member chkEntryPointUsage: unit -> int * string
    /// compiled form of the union case
    /// (Originally from FSComp.txt:276)
    static member chkUnionCaseCompiledForm: unit -> string
    /// default augmentation of the union case
    /// (Originally from FSComp.txt:277)
    static member chkUnionCaseDefaultAugmentation: unit -> string
    /// The property '%s' has the same name as a method in type '%s'.
    /// (Originally from FSComp.txt:278)
    static member chkPropertySameNameMethod: a0: System.String * a1: System.String -> int * string
    /// The property '%s' of type '%s' has a getter and a setter that do not match. If one is abstract then the other must be as well.
    /// (Originally from FSComp.txt:279)
    static member chkGetterSetterDoNotMatchAbstract: a0: System.String * a1: System.String -> int * string
    /// The property '%s' has the same name as another property in type '%s', but one takes indexer arguments and the other does not. You may be missing an indexer argument to one of your properties.
    /// (Originally from FSComp.txt:280)
    static member chkPropertySameNameIndexer: a0: System.String * a1: System.String -> int * string
    /// A type would store a byref typed value. This is not permitted by Common IL.
    /// (Originally from FSComp.txt:281)
    static member chkCantStoreByrefValue: unit -> int * string
    /// Duplicate method. The method '%s' has the same name and signature as another method in type '%s'.
    /// (Originally from FSComp.txt:282)
    static member chkDuplicateMethod: a0: System.String * a1: System.String -> int * string
    /// Duplicate method. The method '%s' has the same name and signature as another method in type '%s' once tuples, functions, units of measure and/or provided types are erased.
    /// (Originally from FSComp.txt:283)
    static member chkDuplicateMethodWithSuffix: a0: System.String * a1: System.String -> int * string
    /// The method '%s' has curried arguments but has the same name as another method in type '%s'. Methods with curried arguments cannot be overloaded. Consider using a method taking tupled arguments.
    /// (Originally from FSComp.txt:284)
    static member chkDuplicateMethodCurried: a0: System.String * a1: System.String -> int * string
    /// Methods with curried arguments cannot declare 'out', 'ParamArray', 'optional', 'ReflectedDefinition', 'byref', 'CallerLineNumber', 'CallerMemberName', or 'CallerFilePath' arguments
    /// (Originally from FSComp.txt:285)
    static member chkCurriedMethodsCantHaveOutParams: unit -> int * string
    /// Duplicate property. The property '%s' has the same name and signature as another property in type '%s'.
    /// (Originally from FSComp.txt:286)
    static member chkDuplicateProperty: a0: System.String * a1: System.String -> int * string
    /// Duplicate property. The property '%s' has the same name and signature as another property in type '%s' once tuples, functions, units of measure and/or provided types are erased.
    /// (Originally from FSComp.txt:287)
    static member chkDuplicatePropertyWithSuffix: a0: System.String * a1: System.String -> int * string
    /// Duplicate method. The abstract method '%s' has the same name and signature as an abstract method in an inherited type.
    /// (Originally from FSComp.txt:288)
    static member chkDuplicateMethodInheritedType: a0: System.String -> int * string
    /// Duplicate method. The abstract method '%s' has the same name and signature as an abstract method in an inherited type once tuples, functions, units of measure and/or provided types are erased.
    /// (Originally from FSComp.txt:289)
    static member chkDuplicateMethodInheritedTypeWithSuffix: a0: System.String -> int * string
    /// This type implements the same interface at different generic instantiations '%s' and '%s'. This is not permitted in this version of F#.
    /// (Originally from FSComp.txt:290)
    static member chkMultipleGenericInterfaceInstantiations: a0: System.String * a1: System.String -> int * string
    /// The type of a field using the 'DefaultValue' attribute must admit default initialization, i.e. have 'null' as a proper value or be a struct type whose fields all admit default initialization. You can use 'DefaultValue(false)' to disable this check
    /// (Originally from FSComp.txt:291)
    static member chkValueWithDefaultValueMustHaveDefaultValue: unit -> int * string
    /// The type abbreviation contains byrefs. This is not permitted by F#.
    /// (Originally from FSComp.txt:292)
    static member chkNoByrefInTypeAbbrev: unit -> int * string
    /// The variable '%s' is bound in a quotation but is used as part of a spliced expression. This is not permitted since it may escape its scope.
    /// (Originally from FSComp.txt:293)
    static member crefBoundVarUsedInSplice: a0: System.String -> int * string
    /// Quotations cannot contain uses of generic expressions
    /// (Originally from FSComp.txt:294)
    static member crefQuotationsCantContainGenericExprs: unit -> int * string
    /// Quotations cannot contain function definitions that are inferred or declared to be generic. Consider adding some type constraints to make this a valid quoted expression.
    /// (Originally from FSComp.txt:295)
    static member crefQuotationsCantContainGenericFunctions: unit -> int * string
    /// Quotations cannot contain object expressions
    /// (Originally from FSComp.txt:296)
    static member crefQuotationsCantContainObjExprs: unit -> int * string
    /// Quotations cannot contain expressions that take the address of a field
    /// (Originally from FSComp.txt:297)
    static member crefQuotationsCantContainAddressOf: unit -> int * string
    /// Quotations cannot contain expressions that fetch static fields
    /// (Originally from FSComp.txt:298)
    static member crefQuotationsCantContainStaticFieldRef: unit -> int * string
    /// Quotations cannot contain inline assembly code or pattern matching on arrays
    /// (Originally from FSComp.txt:299)
    static member crefQuotationsCantContainInlineIL: unit -> int * string
    /// Quotations cannot contain descending for loops
    /// (Originally from FSComp.txt:300)
    static member crefQuotationsCantContainDescendingForLoops: unit -> int * string
    /// Quotations cannot contain expressions that fetch union case indexes
    /// (Originally from FSComp.txt:301)
    static member crefQuotationsCantFetchUnionIndexes: unit -> int * string
    /// Quotations cannot contain expressions that set union case fields
    /// (Originally from FSComp.txt:302)
    static member crefQuotationsCantSetUnionFields: unit -> int * string
    /// Quotations cannot contain expressions that set fields in exception values
    /// (Originally from FSComp.txt:303)
    static member crefQuotationsCantSetExceptionFields: unit -> int * string
    /// Quotations cannot contain expressions that require byref pointers
    /// (Originally from FSComp.txt:304)
    static member crefQuotationsCantRequireByref: unit -> int * string
    /// Quotations cannot contain expressions that make member constraint calls, or uses of operators that implicitly resolve to a member constraint call
    /// (Originally from FSComp.txt:305)
    static member crefQuotationsCantCallTraitMembers: unit -> int * string
    /// Quotations cannot contain this kind of constant
    /// (Originally from FSComp.txt:306)
    static member crefQuotationsCantContainThisConstant: unit -> int * string
    /// Quotations cannot contain this kind of pattern match
    /// (Originally from FSComp.txt:307)
    static member crefQuotationsCantContainThisPatternMatch: unit -> int * string
    /// Quotations cannot contain array pattern matching
    /// (Originally from FSComp.txt:308)
    static member crefQuotationsCantContainArrayPatternMatching: unit -> int * string
    /// Quotations cannot contain this kind of type
    /// (Originally from FSComp.txt:309)
    static member crefQuotationsCantContainThisType: unit -> int * string
    /// The declared type parameter '%s' cannot be used here since the type parameter cannot be resolved at compile time
    /// (Originally from FSComp.txt:310)
    static member csTypeCannotBeResolvedAtCompileTime: a0: System.String -> string
    /// This code is less generic than indicated by its annotations. A unit-of-measure specified using '_' has been determined to be '1', i.e. dimensionless. Consider making the code generic, or removing the use of '_'.
    /// (Originally from FSComp.txt:311)
    static member csCodeLessGeneric: unit -> int * string
    /// Type inference problem too complicated (maximum iteration depth reached). Consider adding further type annotations.
    /// (Originally from FSComp.txt:312)
    static member csTypeInferenceMaxDepth: unit -> int * string
    /// Expected arguments to an instance member
    /// (Originally from FSComp.txt:313)
    static member csExpectedArguments: unit -> string
    /// This indexer expects %d arguments but is here given %d
    /// (Originally from FSComp.txt:314)
    static member csIndexArgumentMismatch: a0: System.Int32 * a1: System.Int32 -> string
    /// Expecting a type supporting the operator '%s' but given a function type. You may be missing an argument to a function.
    /// (Originally from FSComp.txt:315)
    static member csExpectTypeWithOperatorButGivenFunction: a0: System.String -> string
    /// Expecting a type supporting the operator '%s' but given a tuple type
    /// (Originally from FSComp.txt:316)
    static member csExpectTypeWithOperatorButGivenTuple: a0: System.String -> string
    /// None of the types '%s' support the operator '%s'
    /// (Originally from FSComp.txt:317)
    static member csTypesDoNotSupportOperator: a0: System.String * a1: System.String -> string
    /// The type '%s' does not support the operator '%s'
    /// (Originally from FSComp.txt:318)
    static member csTypeDoesNotSupportOperator: a0: System.String * a1: System.String -> string
    /// '%s' does not support the type '%s', because the latter lacks the required (real or built-in) member '%s'
    /// (Originally from FSComp.txt:319)
    static member csFunctionDoesNotSupportType: a0: System.String * a1: System.String * a2: System.String -> string
    /// None of the types '%s' support the operator '%s'. Consider opening the module 'Microsoft.FSharp.Linq.NullableOperators'.
    /// (Originally from FSComp.txt:320)
    static member csTypesDoNotSupportOperatorNullable: a0: System.String * a1: System.String -> string
    /// The type '%s' does not support the operator '%s'. Consider opening the module 'Microsoft.FSharp.Linq.NullableOperators'.
    /// (Originally from FSComp.txt:321)
    static member csTypeDoesNotSupportOperatorNullable: a0: System.String * a1: System.String -> string
    /// The type '%s' does not support a conversion to the type '%s'
    /// (Originally from FSComp.txt:322)
    static member csTypeDoesNotSupportConversion: a0: System.String * a1: System.String -> string
    /// The type '%s' has a method '%s' (full name '%s'), but the method is static
    /// (Originally from FSComp.txt:323)
    static member csMethodFoundButIsStatic: a0: System.String * a1: System.String * a2: System.String -> string
    /// The type '%s' has a method '%s' (full name '%s'), but the method is not static
    /// (Originally from FSComp.txt:324)
    static member csMethodFoundButIsNotStatic: a0: System.String * a1: System.String * a2: System.String -> string
    /// The constraints 'struct' and 'not struct' are inconsistent
    /// (Originally from FSComp.txt:325)
    static member csStructConstraintInconsistent: unit -> int * string
    /// The constraints 'unmanaged' and 'not struct' are inconsistent
    /// (Originally from FSComp.txt:326)
    static member csUnmanagedConstraintInconsistent: unit -> int * string
    /// The constraints 'comparison' and 'delegate' are inconsistent
    /// (Originally from FSComp.txt:327)
    static member csComparisonDelegateConstraintInconsistent: unit -> int * string
    /// The constraints 'struct' and 'null' are inconsistent
    /// (Originally from FSComp.txt:328)
    static member csNullStructConstraintInconsistent: unit -> int * string
    /// The type '%s' does not have 'null' as a proper value
    /// (Originally from FSComp.txt:329)
    static member csTypeDoesNotHaveNull: a0: System.String -> string
    /// The type '%s' does not have 'null' as a proper value. To create a null value for a Nullable type use 'System.Nullable()'.
    /// (Originally from FSComp.txt:330)
    static member csNullableTypeDoesNotHaveNull: a0: System.String -> string
    /// The type '%s' does not support the 'comparison' constraint because it has the 'NoComparison' attribute
    /// (Originally from FSComp.txt:331)
    static member csTypeDoesNotSupportComparison1: a0: System.String -> string
    /// The type '%s' does not support the 'comparison' constraint. For example, it does not support the 'System.IComparable' interface
    /// (Originally from FSComp.txt:332)
    static member csTypeDoesNotSupportComparison2: a0: System.String -> string
    /// The type '%s' does not support the 'comparison' constraint because it is a record, union or struct with one or more structural element types which do not support the 'comparison' constraint. Either avoid the use of comparison with this type, or add the 'StructuralComparison' attribute to the type to determine which field type does not support comparison
    /// (Originally from FSComp.txt:333)
    static member csTypeDoesNotSupportComparison3: a0: System.String -> string
    /// The type '%s' does not support the 'equality' constraint because it has the 'NoEquality' attribute
    /// (Originally from FSComp.txt:334)
    static member csTypeDoesNotSupportEquality1: a0: System.String -> string
    /// The type '%s' does not support the 'equality' constraint because it is a function type
    /// (Originally from FSComp.txt:335)
    static member csTypeDoesNotSupportEquality2: a0: System.String -> string
    /// The type '%s' does not support the 'equality' constraint because it is a record, union or struct with one or more structural element types which do not support the 'equality' constraint. Either avoid the use of equality with this type, or add the 'StructuralEquality' attribute to the type to determine which field type does not support equality
    /// (Originally from FSComp.txt:336)
    static member csTypeDoesNotSupportEquality3: a0: System.String -> string
    /// The type '%s' is not a CLI enum type
    /// (Originally from FSComp.txt:337)
    static member csTypeIsNotEnumType: a0: System.String -> string
    /// The type '%s' has a non-standard delegate type
    /// (Originally from FSComp.txt:338)
    static member csTypeHasNonStandardDelegateType: a0: System.String -> string
    /// The type '%s' is not a CLI delegate type
    /// (Originally from FSComp.txt:339)
    static member csTypeIsNotDelegateType: a0: System.String -> string
    /// This type parameter cannot be instantiated to 'Nullable'. This is a restriction imposed in order to ensure the meaning of 'null' in some CLI languages is not confusing when used in conjunction with 'Nullable' values.
    /// (Originally from FSComp.txt:340)
    static member csTypeParameterCannotBeNullable: unit -> string
    /// A generic construct requires that the type '%s' is a CLI or F# struct type
    /// (Originally from FSComp.txt:341)
    static member csGenericConstructRequiresStructType: a0: System.String -> string
    /// A generic construct requires that the type '%s' is an unmanaged type
    /// (Originally from FSComp.txt:342)
    static member csGenericConstructRequiresUnmanagedType: a0: System.String -> string
    /// The type '%s' is not compatible with any of the types %s, arising from the use of a printf-style format string
    /// (Originally from FSComp.txt:343)
    static member csTypeNotCompatibleBecauseOfPrintf: a0: System.String * a1: System.String -> string
    /// A generic construct requires that the type '%s' have reference semantics, but it does not, i.e. it is a struct
    /// (Originally from FSComp.txt:344)
    static member csGenericConstructRequiresReferenceSemantics: a0: System.String -> string
    /// A generic construct requires that the type '%s' be non-abstract
    /// (Originally from FSComp.txt:345)
    static member csGenericConstructRequiresNonAbstract: a0: System.String -> string
    /// A generic construct requires that the type '%s' have a public default constructor
    /// (Originally from FSComp.txt:346)
    static member csGenericConstructRequiresPublicDefaultConstructor: a0: System.String -> string
    /// A generic construct requires that a generic type parameter be known as a struct or reference type. Consider adding a type annotation.
    /// (Originally from FSComp.txt:347)
    static member csGenericConstructRequiresStructOrReferenceConstraint: unit -> string
    /// Type instantiation length mismatch
    /// (Originally from FSComp.txt:348)
    static member csTypeInstantiationLengthMismatch: unit -> int * string
    /// Optional arguments not permitted here
    /// (Originally from FSComp.txt:349)
    static member csOptionalArgumentNotPermittedHere: unit -> int * string
    /// %s is not a static member
    /// (Originally from FSComp.txt:350)
    static member csMemberIsNotStatic: a0: System.String -> int * string
    /// %s is not an instance member
    /// (Originally from FSComp.txt:351)
    static member csMemberIsNotInstance: a0: System.String -> int * string
    /// Argument length mismatch
    /// (Originally from FSComp.txt:352)
    static member csArgumentLengthMismatch: unit -> int * string
    /// The argument types don't match
    /// (Originally from FSComp.txt:353)
    static member csArgumentTypesDoNotMatch: unit -> int * string
    /// This method expects a CLI 'params' parameter in this position. 'params' is a way of passing a variable number of arguments to a method in languages such as C#. Consider passing an array for this argument
    /// (Originally from FSComp.txt:354)
    static member csMethodExpectsParams: unit -> int * string
    /// The member or object constructor '%s' is not %s
    /// (Originally from FSComp.txt:355)
    static member csMemberIsNotAccessible: a0: System.String * a1: System.String -> int * string
    /// The member or object constructor '%s' is not %s. Private members may only be accessed from within the declaring type. Protected members may only be accessed from an extending type and cannot be accessed from inner lambda expressions.
    /// (Originally from FSComp.txt:356)
    static member csMemberIsNotAccessible2: a0: System.String * a1: System.String -> int * string
    /// %s is not a static method
    /// (Originally from FSComp.txt:357)
    static member csMethodIsNotAStaticMethod: a0: System.String -> int * string
    /// %s is not an instance method
    /// (Originally from FSComp.txt:358)
    static member csMethodIsNotAnInstanceMethod: a0: System.String -> int * string
    /// The member or object constructor '%s' has no argument or settable return property '%s'. %s.
    /// (Originally from FSComp.txt:359)
    static member csMemberHasNoArgumentOrReturnProperty: a0: System.String * a1: System.String * a2: System.String -> string
    /// The object constructor '%s' has no argument or settable return property '%s'. %s.
    /// (Originally from FSComp.txt:360)
    static member csCtorHasNoArgumentOrReturnProperty: a0: System.String * a1: System.String * a2: System.String -> string
    /// The required signature is %s
    /// (Originally from FSComp.txt:361)
    static member csRequiredSignatureIs: a0: System.String -> int * string
    /// The member or object constructor '%s' requires %d argument(s). The required signature is '%s'.
    /// (Originally from FSComp.txt:362)
    static member csMemberSignatureMismatch: a0: System.String * a1: System.Int32 * a2: System.String -> int * string
    /// The member or object constructor '%s' requires %d additional argument(s). The required signature is '%s'.
    /// (Originally from FSComp.txt:363)
    static member csMemberSignatureMismatch2: a0: System.String * a1: System.Int32 * a2: System.String -> int * string
    /// The member or object constructor '%s' requires %d argument(s). The required signature is '%s'. Some names for missing arguments are %s.
    /// (Originally from FSComp.txt:364)
    static member csMemberSignatureMismatch3: a0: System.String * a1: System.Int32 * a2: System.String * a3: System.String -> int * string
    /// The member or object constructor '%s' requires %d additional argument(s). The required signature is '%s'. Some names for missing arguments are %s.
    /// (Originally from FSComp.txt:365)
    static member csMemberSignatureMismatch4: a0: System.String * a1: System.Int32 * a2: System.String * a3: System.String -> int * string
    /// The member or object constructor '%s' requires %d argument(s) but is here given %d unnamed and %d named argument(s). The required signature is '%s'.
    /// (Originally from FSComp.txt:366)
    static member csMemberSignatureMismatchArityNamed: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.Int32 * a4: System.String -> int * string
    /// The member or object constructor '%s' takes %d argument(s) but is here given %d. The required signature is '%s'.
    /// (Originally from FSComp.txt:367)
    static member csMemberSignatureMismatchArity: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String -> int * string
    /// The object constructor '%s' takes %d argument(s) but is here given %d. The required signature is '%s'.
    /// (Originally from FSComp.txt:368)
    static member csCtorSignatureMismatchArity: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String -> int * string
    /// The object constructor '%s' takes %d argument(s) but is here given %d. The required signature is '%s'. If some of the arguments are meant to assign values to properties, consider separating those arguments with a comma (',').
    /// (Originally from FSComp.txt:369)
    static member csCtorSignatureMismatchArityProp: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String -> int * string
    /// The member or object constructor '%s' takes %d type argument(s) but is here given %d. The required signature is '%s'.
    /// (Originally from FSComp.txt:370)
    static member csMemberSignatureMismatchArityType: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String -> int * string
    /// A member or object constructor '%s' taking %d arguments is not accessible from this code location. All accessible versions of method '%s' take %d arguments.
    /// (Originally from FSComp.txt:371)
    static member csMemberNotAccessible: a0: System.String * a1: System.Int32 * a2: System.String * a3: System.Int32 -> int * string
    /// Incorrect generic instantiation. No %s member named '%s' takes %d generic arguments.
    /// (Originally from FSComp.txt:372)
    static member csIncorrectGenericInstantiation: a0: System.String * a1: System.String * a2: System.Int32 -> int * string
    /// The member or object constructor '%s' does not take %d argument(s). An overload was found taking %d arguments.
    /// (Originally from FSComp.txt:373)
    static member csMemberOverloadArityMismatch: a0: System.String * a1: System.Int32 * a2: System.Int32 -> int * string
    /// No %s member or object constructor named '%s' takes %d arguments
    /// (Originally from FSComp.txt:374)
    static member csNoMemberTakesTheseArguments: a0: System.String * a1: System.String * a2: System.Int32 -> int * string
    /// No %s member or object constructor named '%s' takes %d arguments. Note the call to this member also provides %d named arguments.
    /// (Originally from FSComp.txt:375)
    static member csNoMemberTakesTheseArguments2: a0: System.String * a1: System.String * a2: System.Int32 * a3: System.Int32 -> int * string
    /// No %s member or object constructor named '%s' takes %d arguments. The named argument '%s' doesn't correspond to any argument or settable return property for any overload.
    /// (Originally from FSComp.txt:376)
    static member csNoMemberTakesTheseArguments3: a0: System.String * a1: System.String * a2: System.Int32 * a3: System.String -> int * string
    /// Method or object constructor '%s' not found
    /// (Originally from FSComp.txt:377)
    static member csMethodNotFound: a0: System.String -> int * string
    /// No overloads match for method '%s'.
    /// (Originally from FSComp.txt:378)
    static member csNoOverloadsFound: a0: System.String -> string
    /// Known type of argument: %s
    /// (Originally from FSComp.txt:379)
    static member csNoOverloadsFoundArgumentsPrefixSingular: a0: System.String -> string
    /// Known types of arguments: %s
    /// (Originally from FSComp.txt:380)
    static member csNoOverloadsFoundArgumentsPrefixPlural: a0: System.String -> string
    /// Known type parameter: %s
    /// (Originally from FSComp.txt:381)
    static member csNoOverloadsFoundTypeParametersPrefixSingular: a0: System.String -> string
    /// Known type parameters: %s
    /// (Originally from FSComp.txt:382)
    static member csNoOverloadsFoundTypeParametersPrefixPlural: a0: System.String -> string
    /// Known return type: %s
    /// (Originally from FSComp.txt:383)
    static member csNoOverloadsFoundReturnType: a0: System.String -> string
    /// A unique overload for method '%s' could not be determined based on type information prior to this program point. A type annotation may be needed.
    /// (Originally from FSComp.txt:384)
    static member csMethodIsOverloaded: a0: System.String -> string
    /// Candidates:\n%s
    /// (Originally from FSComp.txt:385)
    static member csCandidates: a0: System.String -> string
    /// Available overloads:\n%s
    /// (Originally from FSComp.txt:386)
    static member csAvailableOverloads: a0: System.String -> string
    /// Argument '%s' doesn't match
    /// (Originally from FSComp.txt:387)
    static member csOverloadCandidateNamedArgumentTypeMismatch: a0: System.String -> string
    /// Argument at index %d doesn't match
    /// (Originally from FSComp.txt:388)
    static member csOverloadCandidateIndexedArgumentTypeMismatch: a0: System.Int32 -> string
    /// Accessibility modifiers are not permitted on 'do' bindings, but '%s' was given.
    /// (Originally from FSComp.txt:389)
    static member parsDoCannotHaveVisibilityDeclarations: a0: System.String -> int * string
    /// End of file in #if section begun at or after here
    /// (Originally from FSComp.txt:390)
    static member parsEofInHashIf: unit -> int * string
    /// End of file in string begun at or before here
    /// (Originally from FSComp.txt:391)
    static member parsEofInString: unit -> int * string
    /// End of file in verbatim string begun at or before here
    /// (Originally from FSComp.txt:392)
    static member parsEofInVerbatimString: unit -> int * string
    /// End of file in comment begun at or before here
    /// (Originally from FSComp.txt:393)
    static member parsEofInComment: unit -> int * string
    /// End of file in string embedded in comment begun at or before here
    /// (Originally from FSComp.txt:394)
    static member parsEofInStringInComment: unit -> int * string
    /// End of file in verbatim string embedded in comment begun at or before here
    /// (Originally from FSComp.txt:395)
    static member parsEofInVerbatimStringInComment: unit -> int * string
    /// End of file in IF-OCAML section begun at or before here
    /// (Originally from FSComp.txt:396)
    static member parsEofInIfOcaml: unit -> int * string
    /// End of file in directive begun at or before here
    /// (Originally from FSComp.txt:397)
    static member parsEofInDirective: unit -> int * string
    /// No #endif found for #if or #else
    /// (Originally from FSComp.txt:398)
    static member parsNoHashEndIfFound: unit -> int * string
    /// Attributes have been ignored in this construct
    /// (Originally from FSComp.txt:399)
    static member parsAttributesIgnored: unit -> int * string
    /// 'use' bindings are not permitted in primary constructors
    /// (Originally from FSComp.txt:400)
    static member parsUseBindingsIllegalInImplicitClassConstructors: unit -> int * string
    /// 'use' bindings are not permitted in modules and are treated as 'let' bindings
    /// (Originally from FSComp.txt:401)
    static member parsUseBindingsIllegalInModules: unit -> int * string
    /// An integer for loop must use a simple identifier
    /// (Originally from FSComp.txt:402)
    static member parsIntegerForLoopRequiresSimpleIdentifier: unit -> int * string
    /// At most one 'with' augmentation is permitted
    /// (Originally from FSComp.txt:403)
    static member parsOnlyOneWithAugmentationAllowed: unit -> int * string
    /// A semicolon is not expected at this point
    /// (Originally from FSComp.txt:404)
    static member parsUnexpectedSemicolon: unit -> int * string
    /// Unexpected end of input
    /// (Originally from FSComp.txt:405)
    static member parsUnexpectedEndOfFile: unit -> int * string
    /// Accessibility modifiers are not permitted here, but '%s' was given.
    /// (Originally from FSComp.txt:406)
    static member parsUnexpectedVisibilityDeclaration: a0: System.String -> int * string
    /// Only '#' compiler directives may occur prior to the first 'namespace' declaration
    /// (Originally from FSComp.txt:407)
    static member parsOnlyHashDirectivesAllowed: unit -> int * string
    /// Accessibility modifiers should come immediately prior to the identifier naming a construct
    /// (Originally from FSComp.txt:408)
    static member parsVisibilityDeclarationsShouldComePriorToIdentifier: unit -> int * string
    /// Files should begin with either a namespace or module declaration, e.g. 'namespace SomeNamespace.SubNamespace' or 'module SomeNamespace.SomeModule', but not both. To define a module within a namespace use 'module SomeModule = ...'
    /// (Originally from FSComp.txt:409)
    static member parsNamespaceOrModuleNotBoth: unit -> int * string
    /// A module abbreviation must be a simple name, not a path
    /// (Originally from FSComp.txt:410)
    static member parsModuleAbbreviationMustBeSimpleName: unit -> int * string
    /// Ignoring attributes on module abbreviation
    /// (Originally from FSComp.txt:411)
    static member parsIgnoreAttributesOnModuleAbbreviation: unit -> int * string
    /// The '%s' accessibility attribute is not allowed on module abbreviation. Module abbreviations are always private.
    /// (Originally from FSComp.txt:412)
    static member parsIgnoreAttributesOnModuleAbbreviationAlwaysPrivate: a0: System.String -> int * string
    /// The '%s' visibility attribute is not allowed on module abbreviation. Module abbreviations are always private.
    /// (Originally from FSComp.txt:413)
    static member parsIgnoreVisibilityOnModuleAbbreviationAlwaysPrivate: a0: System.String -> int * string
    /// Unclosed block
    /// (Originally from FSComp.txt:414)
    static member parsUnClosedBlockInHashLight: unit -> int * string
    /// Unmatched 'begin' or 'struct'
    /// (Originally from FSComp.txt:415)
    static member parsUnmatchedBeginOrStruct: unit -> int * string
    /// A module name must be a simple name, not a path
    /// (Originally from FSComp.txt:416)
    static member parsModuleDefnMustBeSimpleName: unit -> int * string
    /// Unexpected empty type moduleDefn list
    /// (Originally from FSComp.txt:417)
    static member parsUnexpectedEmptyModuleDefn: unit -> int * string
    /// Attributes should be placed before 'val'
    /// (Originally from FSComp.txt:418)
    static member parsAttributesMustComeBeforeVal: unit -> string
    /// Attributes are not permitted on interface implementations
    /// (Originally from FSComp.txt:419)
    static member parsAttributesAreNotPermittedOnInterfaceImplementations: unit -> int * string
    /// Syntax error
    /// (Originally from FSComp.txt:420)
    static member parsSyntaxError: unit -> int * string
    /// Augmentations are not permitted on delegate type moduleDefns
    /// (Originally from FSComp.txt:421)
    static member parsAugmentationsIllegalOnDelegateType: unit -> int * string
    /// Unmatched 'class', 'interface' or 'struct'
    /// (Originally from FSComp.txt:422)
    static member parsUnmatchedClassInterfaceOrStruct: unit -> int * string
    /// A type definition requires one or more members or other declarations. If you intend to define an empty class, struct or interface, then use 'type ... = class end', 'interface end' or 'struct end'.
    /// (Originally from FSComp.txt:423)
    static member parsEmptyTypeDefinition: unit -> int * string
    /// Unmatched 'with' or badly formatted 'with' block
    /// (Originally from FSComp.txt:424)
    static member parsUnmatchedWith: unit -> int * string
    /// 'get', 'set' or 'get,set' required
    /// (Originally from FSComp.txt:425)
    static member parsGetOrSetRequired: unit -> int * string
    /// Only class types may take value arguments
    /// (Originally from FSComp.txt:426)
    static member parsOnlyClassCanTakeValueArguments: unit -> int * string
    /// Unmatched 'begin'
    /// (Originally from FSComp.txt:427)
    static member parsUnmatchedBegin: unit -> int * string
    /// Invalid declaration syntax
    /// (Originally from FSComp.txt:428)
    static member parsInvalidDeclarationSyntax: unit -> int * string
    /// 'get' and/or 'set' required
    /// (Originally from FSComp.txt:429)
    static member parsGetAndOrSetRequired: unit -> int * string
    /// Type annotations on property getters and setters must be given after the 'get()' or 'set(v)', e.g. 'with get() : string = ...'
    /// (Originally from FSComp.txt:430)
    static member parsTypeAnnotationsOnGetSet: unit -> int * string
    /// A getter property is expected to be a function, e.g. 'get() = ...' or 'get(index) = ...'
    /// (Originally from FSComp.txt:431)
    static member parsGetterMustHaveAtLeastOneArgument: unit -> int * string
    /// When the visibility for a property is specified, setting the visibility of the set or get method is not allowed.
    /// (Originally from FSComp.txt:432)
    static member parsMultipleAccessibilitiesForGetSet: unit -> int * string
    /// Property setters must be defined using 'set value = ', 'set idx value = ' or 'set (idx1,...,idxN) value = ... '
    /// (Originally from FSComp.txt:433)
    static member parsSetSyntax: unit -> int * string
    /// Interfaces always have the same visibility as the enclosing type
    /// (Originally from FSComp.txt:434)
    static member parsInterfacesHaveSameVisibilityAsEnclosingType: unit -> int * string
    /// Accessibility modifiers are not allowed on this member. Abstract slots always have the same visibility as the enclosing type.
    /// (Originally from FSComp.txt:435)
    static member parsAccessibilityModsIllegalForAbstract: unit -> int * string
    /// Attributes are not permitted on 'inherit' declarations
    /// (Originally from FSComp.txt:436)
    static member parsAttributesIllegalOnInherit: unit -> int * string
    /// Accessibility modifiers are not permitted on an 'inherits' declaration
    /// (Originally from FSComp.txt:437)
    static member parsVisibilityIllegalOnInherit: unit -> int * string
    /// 'inherit' declarations cannot have 'as' bindings. To access members of the base class when overriding a method, the syntax 'base.SomeMember' may be used; 'base' is a keyword. Remove this 'as' binding.
    /// (Originally from FSComp.txt:438)
    static member parsInheritDeclarationsCannotHaveAsBindings: unit -> int * string
    /// Attributes are not allowed here
    /// (Originally from FSComp.txt:439)
    static member parsAttributesIllegalHere: unit -> int * string
    /// Accessibility modifiers are not permitted in this position for type abbreviations
    /// (Originally from FSComp.txt:440)
    static member parsTypeAbbreviationsCannotHaveVisibilityDeclarations: unit -> int * string
    /// Accessibility modifiers are not permitted in this position for enum types
    /// (Originally from FSComp.txt:441)
    static member parsEnumTypesCannotHaveVisibilityDeclarations: unit -> int * string
    /// All enum fields must be given values
    /// (Originally from FSComp.txt:442)
    static member parsAllEnumFieldsRequireValues: unit -> int * string
    /// Accessibility modifiers are not permitted on inline assembly code types
    /// (Originally from FSComp.txt:443)
    static member parsInlineAssemblyCannotHaveVisibilityDeclarations: unit -> int * string
    /// Unexpected identifier: '%s'
    /// (Originally from FSComp.txt:444)
    static member parsUnexpectedIdentifier: a0: System.String -> int * string
    /// Accessibility modifiers are not permitted on union cases. Use 'type U = internal ...' or 'type U = private ...' to give an accessibility to the whole representation.
    /// (Originally from FSComp.txt:445)
    static member parsUnionCasesCannotHaveVisibilityDeclarations: unit -> int * string
    /// Accessibility modifiers are not permitted on enumeration fields
    /// (Originally from FSComp.txt:446)
    static member parsEnumFieldsCannotHaveVisibilityDeclarations: unit -> int * string
    /// Consider using a separate record type instead
    /// (Originally from FSComp.txt:447)
    static member parsConsiderUsingSeparateRecordType: unit -> string
    /// Accessibility modifiers are not permitted on record fields. Use 'type R = internal ...' or 'type R = private ...' to give an accessibility to the whole representation.
    /// (Originally from FSComp.txt:448)
    static member parsRecordFieldsCannotHaveVisibilityDeclarations: unit -> int * string
    /// The declaration form 'let ... and ...' for non-recursive bindings is not used in F# code. Consider using a sequence of 'let' bindings
    /// (Originally from FSComp.txt:449)
    static member parsLetAndForNonRecBindings: unit -> int * string
    /// Unmatched '('
    /// (Originally from FSComp.txt:450)
    static member parsUnmatchedParen: unit -> int * string
    /// Successive patterns should be separated by spaces or tupled
    /// (Originally from FSComp.txt:451)
    static member parsSuccessivePatternsShouldBeSpacedOrTupled: unit -> int * string
    /// No matching 'in' found for this 'let'
    /// (Originally from FSComp.txt:452)
    static member parsNoMatchingInForLet: unit -> int * string
    /// Error in the return expression for this 'let'. Possible incorrect indentation.
    /// (Originally from FSComp.txt:453)
    static member parsErrorInReturnForLetIncorrectIndentation: unit -> int * string
    /// The block following this '%s' is unfinished. Every code block is an expression and must have a result. '%s' cannot be the final code element in a block. Consider giving this block an explicit result.
    /// (Originally from FSComp.txt:454)
    static member parsExpectedExpressionAfterLet: a0: System.String * a1: System.String -> int * string
    /// Incomplete conditional. Expected 'if <expr> then <expr>' or 'if <expr> then <expr> else <expr>'.
    /// (Originally from FSComp.txt:455)
    static member parsIncompleteIf: unit -> int * string
    /// 'assert' may not be used as a first class value. Use 'assert <expr>' instead.
    /// (Originally from FSComp.txt:456)
    static member parsAssertIsNotFirstClassValue: unit -> int * string
    /// Identifier expected
    /// (Originally from FSComp.txt:457)
    static member parsIdentifierExpected: unit -> int * string
    /// 'in' or '=' expected
    /// (Originally from FSComp.txt:458)
    static member parsInOrEqualExpected: unit -> int * string
    /// The use of '->' in sequence and computation expressions is limited to the form 'for pat in expr -> expr'. Use the syntax 'for ... in ... do ... yield...' to generate elements in more complex sequence expressions.
    /// (Originally from FSComp.txt:459)
    static member parsArrowUseIsLimited: unit -> int * string
    /// Successive arguments should be separated by spaces or tupled, and arguments involving function or method applications should be parenthesized
    /// (Originally from FSComp.txt:460)
    static member parsSuccessiveArgsShouldBeSpacedOrTupled: unit -> int * string
    /// Unmatched '['
    /// (Originally from FSComp.txt:461)
    static member parsUnmatchedBracket: unit -> int * string
    /// Missing qualification after '.'
    /// (Originally from FSComp.txt:462)
    static member parsMissingQualificationAfterDot: unit -> int * string
    /// In F# code you may use 'expr.[expr]'. A type annotation may be required to indicate the first expression is an array
    /// (Originally from FSComp.txt:463)
    static member parsParenFormIsForML: unit -> string
    /// Mismatched quotation, beginning with '%s'
    /// (Originally from FSComp.txt:464)
    static member parsMismatchedQuote: a0: System.String -> int * string
    /// Unmatched '%s'
    /// (Originally from FSComp.txt:465)
    static member parsUnmatched: a0: System.String -> int * string
    /// Unmatched '[|'
    /// (Originally from FSComp.txt:466)
    static member parsUnmatchedBracketBar: unit -> int * string
    /// Unmatched '{'
    /// (Originally from FSComp.txt:467)
    static member parsUnmatchedBrace: unit -> int * string
    /// Unmatched '{|'
    /// (Originally from FSComp.txt:468)
    static member parsUnmatchedBraceBar: unit -> int * string
    /// Field bindings must have the form 'id = expr;'
    /// (Originally from FSComp.txt:469)
    static member parsFieldBinding: unit -> int * string
    /// This member is not permitted in an object implementation
    /// (Originally from FSComp.txt:470)
    static member parsMemberIllegalInObjectImplementation: unit -> int * string
    /// Missing function body
    /// (Originally from FSComp.txt:471)
    static member parsMissingFunctionBody: unit -> int * string
    /// Syntax error in labelled type argument
    /// (Originally from FSComp.txt:472)
    static member parsSyntaxErrorInLabeledType: unit -> int * string
    /// Unexpected infix operator in type expression
    /// (Originally from FSComp.txt:473)
    static member parsUnexpectedInfixOperator: unit -> int * string
    /// The syntax '(typ,...,typ) ident' is not used in F# code. Consider using 'ident<typ,...,typ>' instead
    /// (Originally from FSComp.txt:474)
    static member parsMultiArgumentGenericTypeFormDeprecated: unit -> string
    /// Invalid literal in type
    /// (Originally from FSComp.txt:475)
    static member parsInvalidLiteralInType: unit -> int * string
    /// Unexpected infix operator in unit-of-measure expression. Legal operators are '*', '/' and '^'.
    /// (Originally from FSComp.txt:476)
    static member parsUnexpectedOperatorForUnitOfMeasure: unit -> int * string
    /// Unexpected integer literal in unit-of-measure expression
    /// (Originally from FSComp.txt:477)
    static member parsUnexpectedIntegerLiteralForUnitOfMeasure: unit -> int * string
    /// Mismatched quotation operator name, beginning with '%s'
    /// (Originally from FSComp.txt:479)
    static member parsMismatchedQuotationName: a0: System.String -> int * string
    /// Active pattern case identifiers must begin with an uppercase letter
    /// (Originally from FSComp.txt:480)
    static member parsActivePatternCaseMustBeginWithUpperCase: unit -> int * string
    /// The '|' character is not permitted in active pattern case identifiers
    /// (Originally from FSComp.txt:481)
    static member parsActivePatternCaseContainsPipe: unit -> int * string
    /// Denominator must not be 0 in unit-of-measure exponent
    /// (Originally from FSComp.txt:482)
    static member parsIllegalDenominatorForMeasureExponent: unit -> int * string
    /// Incomplete character literal (example: 'Q') or qualified type invocation (example: 'T.Name)
    /// (Originally from FSComp.txt:483)
    static member parsIncompleteTyparExpr1: unit -> int * string
    /// Incomplete operator expression (example a^b) or qualified type invocation (example: ^T.Name)
    /// (Originally from FSComp.txt:484)
    static member parsIncompleteTyparExpr2: unit -> int * string
    /// No '=' symbol should follow a 'namespace' declaration
    /// (Originally from FSComp.txt:485)
    static member parsNoEqualShouldFollowNamespace: unit -> string
    /// The syntax 'module ... = struct .. end' is not used in F# code. Consider using 'module ... = begin .. end'
    /// (Originally from FSComp.txt:486)
    static member parsSyntaxModuleStructEndDeprecated: unit -> string
    /// The syntax 'module ... : sig .. end' is not used in F# code. Consider using 'module ... = begin .. end'
    /// (Originally from FSComp.txt:487)
    static member parsSyntaxModuleSigEndDeprecated: unit -> string
    /// A static field was used where an instance field is expected
    /// (Originally from FSComp.txt:488)
    static member tcStaticFieldUsedWhenInstanceFieldExpected: unit -> int * string
    /// Method '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:489)
    static member tcMethodNotAccessible: a0: System.String -> int * string
    /// Implicit product of measures following /
    /// (Originally from FSComp.txt:490)
    static member tcImplicitMeasureFollowingSlash: unit -> int * string
    /// Unexpected SynMeasure.Anon
    /// (Originally from FSComp.txt:491)
    static member tcUnexpectedMeasureAnon: unit -> int * string
    /// Non-zero constants cannot have generic units. For generic zero, write 0.0<_>.
    /// (Originally from FSComp.txt:492)
    static member tcNonZeroConstantCannotHaveGenericUnit: unit -> int * string
    /// In sequence expressions, results are generated using 'yield'
    /// (Originally from FSComp.txt:493)
    static member tcSeqResultsUseYield: unit -> int * string
    /// Unexpected big rational constant
    /// (Originally from FSComp.txt:494)
    static member tcUnexpectedBigRationalConstant: unit -> string
    /// Units-of-measure are only supported on float, float32, decimal, and integer types.
    /// (Originally from FSComp.txt:495)
    static member tcInvalidTypeForUnitsOfMeasure: unit -> int * string
    /// Unexpected Const_uint16array
    /// (Originally from FSComp.txt:496)
    static member tcUnexpectedConstUint16Array: unit -> string
    /// Unexpected Const_bytearray
    /// (Originally from FSComp.txt:497)
    static member tcUnexpectedConstByteArray: unit -> string
    /// A parameter with attributes must also be given a name, e.g. '[<Attribute>] Name : Type'
    /// (Originally from FSComp.txt:498)
    static member tcParameterRequiresName: unit -> int * string
    /// Return values cannot have names
    /// (Originally from FSComp.txt:499)
    static member tcReturnValuesCannotHaveNames: unit -> int * string
    /// SynMemberKind.PropertyGetSet only expected in parse trees
    /// (Originally from FSComp.txt:500)
    static member tcMemberKindPropertyGetSetNotExpected: unit -> string
    /// Namespaces cannot contain extension members except in the same file and namespace declaration group where the type is defined. Consider using a module to hold declarations of extension members.
    /// (Originally from FSComp.txt:501)
    static member tcNamespaceCannotContainExtensionMembers: unit -> int * string
    /// Multiple visibility attributes have been specified for this identifier
    /// (Originally from FSComp.txt:502)
    static member tcMultipleVisibilityAttributes: unit -> int * string
    /// Multiple visibility attributes have been specified for this identifier. 'let' bindings in classes are always private, as are any 'let' bindings inside expressions.
    /// (Originally from FSComp.txt:503)
    static member tcMultipleVisibilityAttributesWithLet: unit -> int * string
    /// The name '(%s)' should not be used as a member name. To define comparison semantics for a type, implement the 'System.IComparable' interface. If defining a static member for use from other CLI languages then use the name '%s' instead.
    /// (Originally from FSComp.txt:504)
    static member tcInvalidMethodNameForRelationalOperator: a0: System.String * a1: System.String -> string
    /// The name '(%s)' should not be used as a member name. To define equality semantics for a type, override the 'Object.Equals' member. If defining a static member for use from other CLI languages then use the name '%s' instead.
    /// (Originally from FSComp.txt:505)
    static member tcInvalidMethodNameForEquality: a0: System.String * a1: System.String -> string
    /// The name '(%s)' should not be used as a member name. If defining a static member for use from other CLI languages then use the name '%s' instead.
    /// (Originally from FSComp.txt:506)
    static member tcInvalidMemberName: a0: System.String * a1: System.String -> string
    /// The name '(%s)' should not be used as a member name because it is given a standard definition in the F# library over fixed types
    /// (Originally from FSComp.txt:507)
    static member tcInvalidMemberNameFixedTypes: a0: System.String -> string
    /// The '%s' operator should not normally be redefined. To define overloaded comparison semantics for a particular type, implement the 'System.IComparable' interface in the definition of that type.
    /// (Originally from FSComp.txt:508)
    static member tcInvalidOperatorDefinitionRelational: a0: System.String -> string
    /// The '%s' operator should not normally be redefined. To define equality semantics for a type, override the 'Object.Equals' member in the definition of that type.
    /// (Originally from FSComp.txt:509)
    static member tcInvalidOperatorDefinitionEquality: a0: System.String -> string
    /// The '%s' operator should not normally be redefined. Consider using a different operator name
    /// (Originally from FSComp.txt:510)
    static member tcInvalidOperatorDefinition: a0: System.String -> string
    /// The '%s' operator cannot be redefined. Consider using a different operator name
    /// (Originally from FSComp.txt:511)
    static member tcInvalidIndexOperatorDefinition: a0: System.String -> string
    /// Expected module or namespace parent %s
    /// (Originally from FSComp.txt:512)
    static member tcExpectModuleOrNamespaceParent: a0: System.String -> string
    /// The struct, record or union type '%s' implements the interface 'System.IComparable' explicitly. You must apply the 'CustomComparison' attribute to the type.
    /// (Originally from FSComp.txt:513)
    static member tcImplementsIComparableExplicitly: a0: System.String -> int * string
    /// The struct, record or union type '%s' implements the interface 'System.IComparable<_>' explicitly. You must apply the 'CustomComparison' attribute to the type, and should also provide a consistent implementation of the non-generic interface System.IComparable.
    /// (Originally from FSComp.txt:514)
    static member tcImplementsGenericIComparableExplicitly: a0: System.String -> int * string
    /// The struct, record or union type '%s' implements the interface 'System.IStructuralComparable' explicitly. Apply the 'CustomComparison' attribute to the type.
    /// (Originally from FSComp.txt:515)
    static member tcImplementsIStructuralComparableExplicitly: a0: System.String -> int * string
    /// This record contains fields from inconsistent types
    /// (Originally from FSComp.txt:516)
    static member tcRecordFieldInconsistentTypes: unit -> int * string
    /// DLLImport stubs cannot be inlined
    /// (Originally from FSComp.txt:517)
    static member tcDllImportStubsCannotBeInlined: unit -> int * string
    /// Structs may only bind a 'this' parameter at member declarations
    /// (Originally from FSComp.txt:518)
    static member tcStructsCanOnlyBindThisAtMemberDeclaration: unit -> int * string
    /// Unexpected expression at recursive inference point
    /// (Originally from FSComp.txt:519)
    static member tcUnexpectedExprAtRecInfPoint: unit -> int * string
    /// This code is less generic than required by its annotations because the explicit type variable '%s' could not be generalized. It was constrained to be '%s'.
    /// (Originally from FSComp.txt:520)
    static member tcLessGenericBecauseOfAnnotation: a0: System.String * a1: System.String -> int * string
    /// One or more of the explicit class or function type variables for this binding could not be generalized, because they were constrained to other types
    /// (Originally from FSComp.txt:521)
    static member tcConstrainedTypeVariableCannotBeGeneralized: unit -> int * string
    /// A generic type parameter has been used in a way that constrains it to always be '%s'
    /// (Originally from FSComp.txt:522)
    static member tcGenericParameterHasBeenConstrained: a0: System.String -> int * string
    /// This type parameter has been used in a way that constrains it to always be '%s'
    /// (Originally from FSComp.txt:523)
    static member tcTypeParameterHasBeenConstrained: a0: System.String -> int * string
    /// The type parameters inferred for this value are not stable under the erasure of type abbreviations. This is due to the use of type abbreviations which drop or reorder type parameters, e.g. \n\ttype taggedInt<'a> = int or\n\ttype swap<'a,'b> = 'b * 'a.\nConsider declaring the type parameters for this value explicitly, e.g.\n\tlet f<'a,'b> ((x,y) : swap<'b,'a>) : swap<'a,'b> = (y,x).
    /// (Originally from FSComp.txt:524)
    static member tcTypeParametersInferredAreNotStable: unit -> int * string
    /// Explicit type parameters may only be used on module or member bindings
    /// (Originally from FSComp.txt:525)
    static member tcExplicitTypeParameterInvalid: unit -> int * string
    /// You must explicitly declare either all or no type parameters when overriding a generic abstract method
    /// (Originally from FSComp.txt:526)
    static member tcOverridingMethodRequiresAllOrNoTypeParameters: unit -> int * string
    /// The field labels and expected type of this record expression or pattern do not uniquely determine a corresponding record type
    /// (Originally from FSComp.txt:527)
    static member tcFieldsDoNotDetermineUniqueRecordType: unit -> int * string
    /// The field '%s' appears multiple times in this record expression or pattern
    /// (Originally from FSComp.txt:528)
    static member tcMultipleFieldsInRecord: a0: System.String -> int * string
    /// Unknown union case
    /// (Originally from FSComp.txt:529)
    static member tcUnknownUnion: unit -> int * string
    /// This code is not sufficiently generic. The type variable %s could not be generalized because it would escape its scope.
    /// (Originally from FSComp.txt:530)
    static member tcNotSufficientlyGenericBecauseOfScope: a0: System.String -> int * string
    /// A property cannot have explicit type parameters. Consider using a method instead.
    /// (Originally from FSComp.txt:531)
    static member tcPropertyRequiresExplicitTypeParameters: unit -> int * string
    /// A constructor cannot have explicit type parameters. Consider using a static construction method instead.
    /// (Originally from FSComp.txt:532)
    static member tcConstructorCannotHaveTypeParameters: unit -> int * string
    /// This instance member needs a parameter to represent the object being invoked. Make the member static or use the notation 'member x.Member(args) = ...'.
    /// (Originally from FSComp.txt:533)
    static member tcInstanceMemberRequiresTarget: unit -> int * string
    /// Unexpected source-level property specification in syntax tree
    /// (Originally from FSComp.txt:534)
    static member tcUnexpectedPropertyInSyntaxTree: unit -> int * string
    /// A static initializer requires an argument
    /// (Originally from FSComp.txt:535)
    static member tcStaticInitializerRequiresArgument: unit -> int * string
    /// An object constructor requires an argument
    /// (Originally from FSComp.txt:536)
    static member tcObjectConstructorRequiresArgument: unit -> int * string
    /// This static member should not have a 'this' parameter. Consider using the notation 'member Member(args) = ...'.
    /// (Originally from FSComp.txt:537)
    static member tcStaticMemberShouldNotHaveThis: unit -> int * string
    /// An explicit static initializer should use the syntax 'static new(args) = expr'
    /// (Originally from FSComp.txt:538)
    static member tcExplicitStaticInitializerSyntax: unit -> int * string
    /// An explicit object constructor should use the syntax 'new(args) = expr'
    /// (Originally from FSComp.txt:539)
    static member tcExplicitObjectConstructorSyntax: unit -> int * string
    /// Unexpected source-level property specification
    /// (Originally from FSComp.txt:540)
    static member tcUnexpectedPropertySpec: unit -> int * string
    /// This form of object expression is not used in F#. Use 'member this.MemberName ... = ...' to define member implementations in object expressions.
    /// (Originally from FSComp.txt:541)
    static member tcObjectExpressionFormDeprecated: unit -> string
    /// Invalid declaration
    /// (Originally from FSComp.txt:542)
    static member tcInvalidDeclaration: unit -> int * string
    /// Attributes are not allowed within patterns
    /// (Originally from FSComp.txt:543)
    static member tcAttributesInvalidInPatterns: unit -> int * string
    /// The generic function '%s' must be given explicit type argument(s)
    /// (Originally from FSComp.txt:544)
    static member tcFunctionRequiresExplicitTypeArguments: a0: System.String -> int * string
    /// The method or function '%s' should not be given explicit type argument(s) because it does not declare its type parameters explicitly
    /// (Originally from FSComp.txt:545)
    static member tcDoesNotAllowExplicitTypeArguments: a0: System.String -> int * string
    /// This value, type or method expects %d type parameter(s) but was given %d
    /// (Originally from FSComp.txt:546)
    static member tcTypeParameterArityMismatch: a0: System.Int32 * a1: System.Int32 -> int * string
    /// The default, zero-initializing constructor of a struct type may only be used if all the fields of the struct type admit default initialization
    /// (Originally from FSComp.txt:547)
    static member tcDefaultStructConstructorCall: unit -> int * string
    /// Couldn't find Dispose on IDisposable, or it was overloaded
    /// (Originally from FSComp.txt:548)
    static member tcCouldNotFindIDisposable: unit -> string
    /// This value is not a literal and cannot be used in a pattern
    /// (Originally from FSComp.txt:549)
    static member tcNonLiteralCannotBeUsedInPattern: unit -> int * string
    /// This field is readonly
    /// (Originally from FSComp.txt:550)
    static member tcFieldIsReadonly: unit -> int * string
    /// Named arguments must appear after all other arguments
    /// (Originally from FSComp.txt:551)
    static member tcNameArgumentsMustAppearLast: unit -> int * string
    /// This function value is being used to construct a delegate type whose signature includes a byref argument. You must use an explicit lambda expression taking %d arguments.
    /// (Originally from FSComp.txt:552)
    static member tcFunctionRequiresExplicitLambda: a0: System.Int32 -> int * string
    /// The type '%s' is not a type whose values can be enumerated with this syntax, i.e. is not compatible with either seq<_>, IEnumerable<_> or IEnumerable and does not have a GetEnumerator method
    /// (Originally from FSComp.txt:553)
    static member tcTypeCannotBeEnumerated: a0: System.String -> int * string
    /// This recursive binding uses an invalid mixture of recursive forms
    /// (Originally from FSComp.txt:554)
    static member tcInvalidMixtureOfRecursiveForms: unit -> int * string
    /// This is not a valid object construction expression. Explicit object constructors must either call an alternate constructor or initialize all fields of the object and specify a call to a super class constructor.
    /// (Originally from FSComp.txt:555)
    static member tcInvalidObjectConstructionExpression: unit -> int * string
    /// Invalid constraint
    /// (Originally from FSComp.txt:556)
    static member tcInvalidConstraint: unit -> int * string
    /// Invalid constraint: the type used for the constraint is sealed, which means the constraint could only be satisfied by at most one solution
    /// (Originally from FSComp.txt:557)
    static member tcInvalidConstraintTypeSealed: unit -> int * string
    /// An 'enum' constraint must be of the form 'enum<type>'
    /// (Originally from FSComp.txt:558)
    static member tcInvalidEnumConstraint: unit -> int * string
    /// 'new' constraints must take one argument of type 'unit' and return the constructed type
    /// (Originally from FSComp.txt:559)
    static member tcInvalidNewConstraint: unit -> int * string
    /// This property has an invalid type. Properties taking multiple indexer arguments should have types of the form 'ty1 * ty2 -> ty3'. Properties returning functions should have types of the form '(ty1 -> ty2)'.
    /// (Originally from FSComp.txt:560)
    static member tcInvalidPropertyType: unit -> int * string
    /// Expected unit-of-measure parameter, not type parameter. Explicit unit-of-measure parameters must be marked with the [<Measure>] attribute.
    /// (Originally from FSComp.txt:561)
    static member tcExpectedUnitOfMeasureMarkWithAttribute: unit -> int * string
    /// Expected type parameter, not unit-of-measure parameter
    /// (Originally from FSComp.txt:562)
    static member tcExpectedTypeParameter: unit -> int * string
    /// Expected type, not unit-of-measure
    /// (Originally from FSComp.txt:563)
    static member tcExpectedTypeNotUnitOfMeasure: unit -> int * string
    /// Expected unit-of-measure, not type
    /// (Originally from FSComp.txt:564)
    static member tcExpectedUnitOfMeasureNotType: unit -> int * string
    /// Units-of-measure cannot be used as prefix arguments to a type. Rewrite as postfix arguments in angle brackets.
    /// (Originally from FSComp.txt:565)
    static member tcInvalidUnitsOfMeasurePrefix: unit -> int * string
    /// Unit-of-measure cannot be used in type constructor application
    /// (Originally from FSComp.txt:566)
    static member tcUnitsOfMeasureInvalidInTypeConstructor: unit -> int * string
    /// This control construct may only be used if the computation expression builder defines a '%s' method
    /// (Originally from FSComp.txt:567)
    static member tcRequireBuilderMethod: a0: System.String -> int * string
    /// An empty body may only be used if the computation expression builder defines a 'Zero' method.
    /// (Originally from FSComp.txt:568)
    static member tcEmptyBodyRequiresBuilderZeroMethod: unit -> int * string
    /// This type has no nested types
    /// (Originally from FSComp.txt:569)
    static member tcTypeHasNoNestedTypes: unit -> int * string
    /// Unexpected %s in type expression
    /// (Originally from FSComp.txt:570)
    static member tcUnexpectedSymbolInTypeExpression: a0: System.String -> int * string
    /// Type parameter cannot be used as type constructor
    /// (Originally from FSComp.txt:571)
    static member tcTypeParameterInvalidAsTypeConstructor: unit -> int * string
    /// Illegal syntax in type expression
    /// (Originally from FSComp.txt:572)
    static member tcIllegalSyntaxInTypeExpression: unit -> int * string
    /// Anonymous unit-of-measure cannot be nested inside another unit-of-measure expression
    /// (Originally from FSComp.txt:573)
    static member tcAnonymousUnitsOfMeasureCannotBeNested: unit -> int * string
    /// Anonymous type variables are not permitted in this declaration
    /// (Originally from FSComp.txt:574)
    static member tcAnonymousTypeInvalidInDeclaration: unit -> int * string
    /// Unexpected / in type
    /// (Originally from FSComp.txt:575)
    static member tcUnexpectedSlashInType: unit -> int * string
    /// Unexpected type arguments
    /// (Originally from FSComp.txt:576)
    static member tcUnexpectedTypeArguments: unit -> int * string
    /// Optional arguments are only permitted on type members
    /// (Originally from FSComp.txt:577)
    static member tcOptionalArgsOnlyOnMembers: unit -> int * string
    /// Name '%s' not bound in pattern context
    /// (Originally from FSComp.txt:578)
    static member tcNameNotBoundInPattern: a0: System.String -> int * string
    /// Non-primitive numeric literal constants cannot be used in pattern matches because they can be mapped to multiple different types through the use of a NumericLiteral module. Consider using replacing with a variable, and use 'when <variable> = <constant>' at the end of the match clause.
    /// (Originally from FSComp.txt:579)
    static member tcInvalidNonPrimitiveLiteralInPatternMatch: unit -> int * string
    /// Type arguments cannot be specified here
    /// (Originally from FSComp.txt:580)
    static member tcInvalidTypeArgumentUsage: unit -> int * string
    /// Only active patterns returning exactly one result may accept arguments
    /// (Originally from FSComp.txt:581)
    static member tcRequireActivePatternWithOneResult: unit -> int * string
    /// Invalid argument to parameterized pattern label
    /// (Originally from FSComp.txt:582)
    static member tcInvalidArgForParameterizedPattern: unit -> int * string
    /// Internal error. Invalid index into active pattern array
    /// (Originally from FSComp.txt:583)
    static member tcInvalidIndexIntoActivePatternArray: unit -> int * string
    /// This union case does not take arguments
    /// (Originally from FSComp.txt:584)
    static member tcUnionCaseDoesNotTakeArguments: unit -> int * string
    /// This union case takes one argument
    /// (Originally from FSComp.txt:585)
    static member tcUnionCaseRequiresOneArgument: unit -> int * string
    /// This union case expects %d arguments in tupled form, but was given %d. The missing field arguments may be any of:%s
    /// (Originally from FSComp.txt:586)
    static member tcUnionCaseExpectsTupledArguments: a0: System.Int32 * a1: System.Int32 * a2: System.String -> int * string
    /// Field '%s' is not static
    /// (Originally from FSComp.txt:587)
    static member tcFieldIsNotStatic: a0: System.String -> int * string
    /// This field is not a literal and cannot be used in a pattern
    /// (Originally from FSComp.txt:588)
    static member tcFieldNotLiteralCannotBeUsedInPattern: unit -> int * string
    /// This is not a variable, constant, active recognizer or literal
    /// (Originally from FSComp.txt:589)
    static member tcRequireVarConstRecogOrLiteral: unit -> int * string
    /// This is not a valid pattern
    /// (Originally from FSComp.txt:590)
    static member tcInvalidPattern: unit -> int * string
    /// Illegal pattern
    /// (Originally from FSComp.txt:591)
    static member tcIllegalPattern: unit -> int * string
    /// Syntax error - unexpected '?' symbol
    /// (Originally from FSComp.txt:592)
    static member tcSyntaxErrorUnexpectedQMark: unit -> int * string
    /// Expected %d expressions, got %d
    /// (Originally from FSComp.txt:593)
    static member tcExpressionCountMisMatch: a0: System.Int32 * a1: System.Int32 -> int * string
    /// TcExprUndelayed: delayed
    /// (Originally from FSComp.txt:594)
    static member tcExprUndelayed: unit -> int * string
    /// This expression form may only be used in sequence and computation expressions
    /// (Originally from FSComp.txt:595)
    static member tcExpressionRequiresSequence: unit -> int * string
    /// Invalid object expression. Objects without overrides or interfaces should use the expression form 'new Type(args)' without braces.
    /// (Originally from FSComp.txt:596)
    static member tcInvalidObjectExpressionSyntaxForm: unit -> int * string
    /// Invalid object, sequence or record expression
    /// (Originally from FSComp.txt:597)
    static member tcInvalidObjectSequenceOrRecordExpression: unit -> int * string
    /// Invalid record, sequence or computation expression. Sequence expressions should be of the form 'seq { ... }'
    /// (Originally from FSComp.txt:598)
    static member tcInvalidSequenceExpressionSyntaxForm: unit -> int * string
    /// This list or array expression includes an element of the form 'if ... then ... else'. Parenthesize this expression to indicate it is an individual element of the list or array, to disambiguate this from a list generated using a sequence expression
    /// (Originally from FSComp.txt:599)
    static member tcExpressionWithIfRequiresParenthesis: unit -> string
    /// Unable to parse format string '%s'
    /// (Originally from FSComp.txt:600)
    static member tcUnableToParseFormatString: a0: System.String -> int * string
    /// This list expression exceeds the maximum size for list literals. Use an array for larger literals and call Array.ToList.
    /// (Originally from FSComp.txt:601)
    static member tcListLiteralMaxSize: unit -> int * string
    /// The expression form 'expr then expr' may only be used as part of an explicit object constructor
    /// (Originally from FSComp.txt:602)
    static member tcExpressionFormRequiresObjectConstructor: unit -> int * string
    /// Named arguments cannot be given to member trait calls
    /// (Originally from FSComp.txt:603)
    static member tcNamedArgumentsCannotBeUsedInMemberTraits: unit -> int * string
    /// This is not a valid name for an enumeration case
    /// (Originally from FSComp.txt:604)
    static member tcNotValidEnumCaseName: unit -> int * string
    /// This field is not mutable
    /// (Originally from FSComp.txt:605)
    static member tcFieldIsNotMutable: unit -> int * string
    /// This construct may only be used within list, array and sequence expressions, e.g. expressions of the form 'seq { ... }', '[ ... ]' or '[| ... |]'. These use the syntax 'for ... in ... do ... yield...' to generate elements
    /// (Originally from FSComp.txt:606)
    static member tcConstructRequiresListArrayOrSequence: unit -> int * string
    /// This construct may only be used within computation expressions. To return a value from an ordinary function simply write the expression without 'return'.
    /// (Originally from FSComp.txt:607)
    static member tcConstructRequiresComputationExpressions: unit -> int * string
    /// This construct may only be used within sequence or computation expressions
    /// (Originally from FSComp.txt:608)
    static member tcConstructRequiresSequenceOrComputations: unit -> int * string
    /// This construct may only be used within computation expressions
    /// (Originally from FSComp.txt:609)
    static member tcConstructRequiresComputationExpression: unit -> int * string
    /// Incomplete expression or invalid use of indexer syntax
    /// (Originally from FSComp.txt:610)
    static member tcInvalidIndexerExpression: unit -> int * string
    /// The operator 'expr.[idx]' has been used on an object of indeterminate type based on information prior to this program point. Consider adding further type constraints
    /// (Originally from FSComp.txt:611)
    static member tcObjectOfIndeterminateTypeUsedRequireTypeConstraint: unit -> int * string
    /// Cannot inherit from a variable type
    /// (Originally from FSComp.txt:612)
    static member tcCannotInheritFromVariableType: unit -> int * string
    /// Calls to object constructors on type parameters cannot be given arguments
    /// (Originally from FSComp.txt:613)
    static member tcObjectConstructorsOnTypeParametersCannotTakeArguments: unit -> int * string
    /// The 'CompiledName' attribute cannot be used with this language element
    /// (Originally from FSComp.txt:614)
    static member tcCompiledNameAttributeMisused: unit -> int * string
    /// '%s' may only be used with named types
    /// (Originally from FSComp.txt:615)
    static member tcNamedTypeRequired: a0: System.String -> int * string
    /// 'inherit' cannot be used on interface types. Consider implementing the interface by using 'interface ... with ... end' instead.
    /// (Originally from FSComp.txt:616)
    static member tcInheritCannotBeUsedOnInterfaceType: unit -> int * string
    /// 'new' cannot be used on interface types. Consider using an object expression '{ new ... with ... }' instead.
    /// (Originally from FSComp.txt:617)
    static member tcNewCannotBeUsedOnInterfaceType: unit -> int * string
    /// Instances of this type cannot be created since it has been marked abstract or not all methods have been given implementations. Consider using an object expression '{ new ... with ... }' instead.
    /// (Originally from FSComp.txt:618)
    static member tcAbstractTypeCannotBeInstantiated: unit -> int * string
    /// It is recommended that objects supporting the IDisposable interface are created using the syntax 'new Type(args)', rather than 'Type(args)' or 'Type' as a function value representing the constructor, to indicate that resources may be owned by the generated value
    /// (Originally from FSComp.txt:619)
    static member tcIDisposableTypeShouldUseNew: unit -> int * string
    /// '%s' may only be used to construct object types
    /// (Originally from FSComp.txt:620)
    static member tcSyntaxCanOnlyBeUsedToCreateObjectTypes: a0: System.String -> int * string
    /// Constructors for the type '%s' must directly or indirectly call its implicit object constructor. Use a call to the implicit object constructor instead of a record expression.
    /// (Originally from FSComp.txt:621)
    static member tcConstructorRequiresCall: a0: System.String -> int * string
    /// The field '%s' has been given a value, but is not present in the type '%s'
    /// (Originally from FSComp.txt:622)
    static member tcUndefinedField: a0: System.String * a1: System.String -> int * string
    /// No assignment given for field '%s' of type '%s'
    /// (Originally from FSComp.txt:623)
    static member tcFieldRequiresAssignment: a0: System.String * a1: System.String -> int * string
    /// Extraneous fields have been given values
    /// (Originally from FSComp.txt:624)
    static member tcExtraneousFieldsGivenValues: unit -> int * string
    /// Only overrides of abstract and virtual members may be specified in object expressions
    /// (Originally from FSComp.txt:625)
    static member tcObjectExpressionsCanOnlyOverrideAbstractOrVirtual: unit -> int * string
    /// The member '%s' does not correspond to any abstract or virtual method available to override or implement.
    /// (Originally from FSComp.txt:626)
    static member tcNoAbstractOrVirtualMemberFound: a0: System.String -> int * string
    /// The type %s contains the member '%s' but it is not a virtual or abstract method that is available to override or implement.
    /// (Originally from FSComp.txt:627)
    static member tcMemberFoundIsNotAbstractOrVirtual: a0: System.String * a1: System.String -> int * string
    /// The member '%s' does not accept the correct number of arguments. %d argument(s) are expected, but %d were given. The required signature is '%s'.%s
    /// (Originally from FSComp.txt:628)
    static member tcArgumentArityMismatch: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String * a4: System.String -> int * string
    /// The member '%s' does not accept the correct number of arguments. One overload accepts %d arguments, but %d were given. The required signature is '%s'.%s
    /// (Originally from FSComp.txt:629)
    static member tcArgumentArityMismatchOneOverload: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.String * a4: System.String -> int * string
    /// A simple method name is required here
    /// (Originally from FSComp.txt:630)
    static member tcSimpleMethodNameRequired: unit -> int * string
    /// The types System.ValueType, System.Enum, System.Delegate, System.MulticastDelegate and System.Array cannot be used as super types in an object expression or class
    /// (Originally from FSComp.txt:631)
    static member tcPredefinedTypeCannotBeUsedAsSuperType: unit -> int * string
    /// 'new' must be used with a named type
    /// (Originally from FSComp.txt:632)
    static member tcNewMustBeUsedWithNamedType: unit -> int * string
    /// Cannot create an extension of a sealed type
    /// (Originally from FSComp.txt:633)
    static member tcCannotCreateExtensionOfSealedType: unit -> int * string
    /// No arguments may be given when constructing a record value
    /// (Originally from FSComp.txt:634)
    static member tcNoArgumentsForRecordValue: unit -> int * string
    /// Interface implementations cannot be given on construction expressions
    /// (Originally from FSComp.txt:635)
    static member tcNoInterfaceImplementationForConstructionExpression: unit -> int * string
    /// Object construction expressions may only be used to implement constructors in class types
    /// (Originally from FSComp.txt:636)
    static member tcObjectConstructionCanOnlyBeUsedInClassTypes: unit -> int * string
    /// Only simple bindings of the form 'id = expr' can be used in construction expressions
    /// (Originally from FSComp.txt:637)
    static member tcOnlySimpleBindingsCanBeUsedInConstructionExpressions: unit -> int * string
    /// Objects must be initialized by an object construction expression that calls an inherited object constructor and assigns a value to each field
    /// (Originally from FSComp.txt:638)
    static member tcObjectsMustBeInitializedWithObjectExpression: unit -> int * string
    /// Expected an interface type
    /// (Originally from FSComp.txt:639)
    static member tcExpectedInterfaceType: unit -> int * string
    /// Constructor expressions for interfaces do not take arguments
    /// (Originally from FSComp.txt:640)
    static member tcConstructorForInterfacesDoNotTakeArguments: unit -> int * string
    /// This object constructor requires arguments
    /// (Originally from FSComp.txt:641)
    static member tcConstructorRequiresArguments: unit -> int * string
    /// 'new' may only be used with object constructors
    /// (Originally from FSComp.txt:642)
    static member tcNewRequiresObjectConstructor: unit -> int * string
    /// At least one override did not correctly implement its corresponding abstract member
    /// (Originally from FSComp.txt:643)
    static member tcAtLeastOneOverrideIsInvalid: unit -> int * string
    /// This numeric literal requires that a module '%s' defining functions FromZero, FromOne, FromInt32, FromInt64 and FromString be in scope
    /// (Originally from FSComp.txt:644)
    static member tcNumericLiteralRequiresModule: a0: System.String -> int * string
    /// Invalid record construction
    /// (Originally from FSComp.txt:645)
    static member tcInvalidRecordConstruction: unit -> int * string
    /// The expression form { expr with ... } may only be used with record types. To build object types use { new Type(...) with ... }
    /// (Originally from FSComp.txt:646)
    static member tcExpressionFormRequiresRecordTypes: unit -> int * string
    /// The inherited type is not an object model type
    /// (Originally from FSComp.txt:647)
    static member tcInheritedTypeIsNotObjectModelType: unit -> int * string
    /// Object construction expressions (i.e. record expressions with inheritance specifications) may only be used to implement constructors in object model types. Use 'new ObjectType(args)' to construct instances of object model types outside of constructors
    /// (Originally from FSComp.txt:648)
    static member tcObjectConstructionExpressionCanOnlyImplementConstructorsInObjectModelTypes: unit -> int * string
    /// '{ }' is not a valid expression. Records must include at least one field. Empty sequences are specified by using Seq.empty or an empty list '[]'.
    /// (Originally from FSComp.txt:649)
    static member tcEmptyRecordInvalid: unit -> int * string
    /// This type is not a record type. Values of class and struct types must be created using calls to object constructors.
    /// (Originally from FSComp.txt:650)
    static member tcTypeIsNotARecordTypeNeedConstructor: unit -> int * string
    /// This type is not a record type
    /// (Originally from FSComp.txt:651)
    static member tcTypeIsNotARecordType: unit -> int * string
    /// This construct is ambiguous as part of a computation expression. Nested expressions may be written using 'let _ = (...)' and nested computations using 'let! res = builder { ... }'.
    /// (Originally from FSComp.txt:652)
    static member tcConstructIsAmbiguousInComputationExpression: unit -> int * string
    /// This construct is ambiguous as part of a sequence expression. Nested expressions may be written using 'let _ = (...)' and nested sequences using 'yield! seq {... }'.
    /// (Originally from FSComp.txt:653)
    static member tcConstructIsAmbiguousInSequenceExpression: unit -> int * string
    /// 'do!' cannot be used within sequence expressions
    /// (Originally from FSComp.txt:654)
    static member tcDoBangIllegalInSequenceExpression: unit -> int * string
    /// The use of 'let! x = coll' in sequence expressions is not permitted. Use 'for x in coll' instead.
    /// (Originally from FSComp.txt:655)
    static member tcUseForInSequenceExpression: unit -> int * string
    /// 'try'/'with' cannot be used within sequence expressions
    /// (Originally from FSComp.txt:656)
    static member tcTryIllegalInSequenceExpression: unit -> int * string
    /// In sequence expressions, multiple results are generated using 'yield!'
    /// (Originally from FSComp.txt:657)
    static member tcUseYieldBangForMultipleResults: unit -> int * string
    /// Invalid assignment
    /// (Originally from FSComp.txt:658)
    static member tcInvalidAssignment: unit -> int * string
    /// Invalid use of a type name
    /// (Originally from FSComp.txt:659)
    static member tcInvalidUseOfTypeName: unit -> int * string
    /// This type has no accessible object constructors
    /// (Originally from FSComp.txt:660)
    static member tcTypeHasNoAccessibleConstructor: unit -> int * string
    /// Invalid use of an interface type
    /// (Originally from FSComp.txt:661)
    static member tcInvalidUseOfInterfaceType: unit -> int * string
    /// Invalid use of a delegate constructor. Use the syntax 'new Type(args)' or just 'Type(args)'.
    /// (Originally from FSComp.txt:662)
    static member tcInvalidUseOfDelegate: unit -> int * string
    /// Property '%s' is not static
    /// (Originally from FSComp.txt:663)
    static member tcPropertyIsNotStatic: a0: System.String -> int * string
    /// Property '%s' is not readable
    /// (Originally from FSComp.txt:664)
    static member tcPropertyIsNotReadable: a0: System.String -> int * string
    /// This lookup cannot be used here
    /// (Originally from FSComp.txt:665)
    static member tcLookupMayNotBeUsedHere: unit -> int * string
    /// Property '%s' is static
    /// (Originally from FSComp.txt:666)
    static member tcPropertyIsStatic: a0: System.String -> int * string
    /// Property '%s' cannot be set
    /// (Originally from FSComp.txt:667)
    static member tcPropertyCannotBeSet1: a0: System.String -> int * string
    /// Init-only property '%s' cannot be set outside the initialization code. See https://aka.ms/fsharp-assigning-values-to-properties-at-initialization
    /// (Originally from FSComp.txt:668)
    static member tcInitOnlyPropertyCannotBeSet1: a0: System.String -> int * string
    /// Cannot call '%s' - a setter for init-only property, please use object initialization instead. See https://aka.ms/fsharp-assigning-values-to-properties-at-initialization
    /// (Originally from FSComp.txt:669)
    static member tcSetterForInitOnlyPropertyCannotBeCalled1: a0: System.String -> int * string
    /// Constructors must be applied to arguments and cannot be used as first-class values. If necessary use an anonymous function '(fun arg1 ... argN -> new Type(arg1,...,argN))'.
    /// (Originally from FSComp.txt:670)
    static member tcConstructorsCannotBeFirstClassValues: unit -> int * string
    /// The syntax 'expr.id' may only be used with record labels, properties and fields
    /// (Originally from FSComp.txt:671)
    static member tcSyntaxFormUsedOnlyWithRecordLabelsPropertiesAndFields: unit -> int * string
    /// Event '%s' is static
    /// (Originally from FSComp.txt:672)
    static member tcEventIsStatic: a0: System.String -> int * string
    /// Event '%s' is not static
    /// (Originally from FSComp.txt:673)
    static member tcEventIsNotStatic: a0: System.String -> int * string
    /// The named argument '%s' did not match any argument or mutable property
    /// (Originally from FSComp.txt:674)
    static member tcNamedArgumentDidNotMatch: a0: System.String -> int * string
    /// One or more of the overloads of this method has curried arguments. Consider redesigning these members to take arguments in tupled form.
    /// (Originally from FSComp.txt:675)
    static member tcOverloadsCannotHaveCurriedArguments: unit -> int * string
    /// The unnamed arguments do not form a prefix of the arguments of the method called
    /// (Originally from FSComp.txt:676)
    static member tcUnnamedArgumentsDoNotFormPrefix: unit -> string
    /// Static optimization conditionals are only for use within the F# library
    /// (Originally from FSComp.txt:677)
    static member tcStaticOptimizationConditionalsOnlyForFSharpLibrary: unit -> int * string
    /// The corresponding formal argument is not optional
    /// (Originally from FSComp.txt:678)
    static member tcFormalArgumentIsNotOptional: unit -> int * string
    /// Invalid optional assignment to a property or field
    /// (Originally from FSComp.txt:679)
    static member tcInvalidOptionalAssignmentToPropertyOrField: unit -> int * string
    /// A delegate constructor must be passed a single function value
    /// (Originally from FSComp.txt:680)
    static member tcDelegateConstructorMustBePassed: unit -> int * string
    /// A binding cannot be marked both 'use' and 'rec'
    /// (Originally from FSComp.txt:681)
    static member tcBindingCannotBeUseAndRec: unit -> int * string
    /// The 'VolatileField' attribute may only be used on 'let' bindings in classes
    /// (Originally from FSComp.txt:682)
    static member tcVolatileOnlyOnClassLetBindings: unit -> int * string
    /// Attributes are not permitted on 'let' bindings in expressions
    /// (Originally from FSComp.txt:683)
    static member tcAttributesAreNotPermittedOnLetBindings: unit -> int * string
    /// The 'DefaultValue' attribute may only be used on 'val' declarations
    /// (Originally from FSComp.txt:684)
    static member tcDefaultValueAttributeRequiresVal: unit -> int * string
    /// The 'ConditionalAttribute' attribute may only be used on members
    /// (Originally from FSComp.txt:685)
    static member tcConditionalAttributeRequiresMembers: unit -> int * string
    /// '%s' is not a valid method name. Use a 'let' binding instead.
    /// (Originally from FSComp.txt:686)
    static member tcInvalidActivePatternName: a0: System.String -> int * string
    /// The 'EntryPointAttribute' attribute may only be used on function definitions in modules
    /// (Originally from FSComp.txt:687)
    static member tcEntryPointAttributeRequiresFunctionInModule: unit -> int * string
    /// Mutable values cannot be marked 'inline'
    /// (Originally from FSComp.txt:688)
    static member tcMutableValuesCannotBeInline: unit -> int * string
    /// Mutable values cannot have generic parameters
    /// (Originally from FSComp.txt:689)
    static member tcMutableValuesMayNotHaveGenericParameters: unit -> int * string
    /// Mutable function values should be written 'let mutable f = (fun args -> ...)'
    /// (Originally from FSComp.txt:690)
    static member tcMutableValuesSyntax: unit -> int * string
    /// Only functions may be marked 'inline'
    /// (Originally from FSComp.txt:691)
    static member tcOnlyFunctionsCanBeInline: unit -> int * string
    /// A literal value cannot be given the [<ThreadStatic>] or [<ContextStatic>] attributes
    /// (Originally from FSComp.txt:692)
    static member tcIllegalAttributesForLiteral: unit -> int * string
    /// A literal value cannot be marked 'mutable'
    /// (Originally from FSComp.txt:693)
    static member tcLiteralCannotBeMutable: unit -> int * string
    /// A literal value cannot be marked 'inline'
    /// (Originally from FSComp.txt:694)
    static member tcLiteralCannotBeInline: unit -> int * string
    /// Literal values cannot have generic parameters
    /// (Originally from FSComp.txt:695)
    static member tcLiteralCannotHaveGenericParameters: unit -> int * string
    /// This is not a valid constant expression
    /// (Originally from FSComp.txt:696)
    static member tcInvalidConstantExpression: unit -> int * string
    /// This type is not accessible from this code location
    /// (Originally from FSComp.txt:697)
    static member tcTypeIsInaccessible: unit -> int * string
    /// Unexpected condition in imported assembly: failed to decode AttributeUsage attribute
    /// (Originally from FSComp.txt:698)
    static member tcUnexpectedConditionInImportedAssembly: unit -> int * string
    /// Unrecognized attribute target. Valid attribute targets are 'assembly', 'module', 'type', 'method', 'property', 'return', 'param', 'field', 'event', 'constructor'.
    /// (Originally from FSComp.txt:699)
    static member tcUnrecognizedAttributeTarget: unit -> int * string
    /// This attribute is not valid for use on this language element. Assembly attributes should be attached to a 'do ()' declaration, if necessary within an F# module.
    /// (Originally from FSComp.txt:700)
    static member tcAttributeIsNotValidForLanguageElementUseDo: unit -> int * string
    /// Optional arguments cannot be used in custom attributes
    /// (Originally from FSComp.txt:701)
    static member tcOptionalArgumentsCannotBeUsedInCustomAttribute: unit -> int * string
    /// This property cannot be set
    /// (Originally from FSComp.txt:702)
    static member tcPropertyCannotBeSet0: unit -> int * string
    /// This property or field was not found on this custom attribute type
    /// (Originally from FSComp.txt:703)
    static member tcPropertyOrFieldNotFoundInAttribute: unit -> int * string
    /// A custom attribute must be a reference type
    /// (Originally from FSComp.txt:704)
    static member tcCustomAttributeMustBeReferenceType: unit -> int * string
    /// The number of args for a custom attribute does not match the expected number of args for the attribute constructor
    /// (Originally from FSComp.txt:705)
    static member tcCustomAttributeArgumentMismatch: unit -> int * string
    /// A custom attribute must invoke an object constructor
    /// (Originally from FSComp.txt:706)
    static member tcCustomAttributeMustInvokeConstructor: unit -> int * string
    /// Attribute expressions must be calls to object constructors
    /// (Originally from FSComp.txt:707)
    static member tcAttributeExpressionsMustBeConstructorCalls: unit -> int * string
    /// This attribute cannot be used in this version of F#
    /// (Originally from FSComp.txt:708)
    static member tcUnsupportedAttribute: unit -> int * string
    /// Invalid inline specification
    /// (Originally from FSComp.txt:709)
    static member tcInvalidInlineSpecification: unit -> int * string
    /// 'use' bindings must be of the form 'use <var> = <expr>'
    /// (Originally from FSComp.txt:710)
    static member tcInvalidUseBinding: unit -> int * string
    /// Abstract members are not permitted in an augmentation - they must be defined as part of the type itself
    /// (Originally from FSComp.txt:711)
    static member tcAbstractMembersIllegalInAugmentation: unit -> int * string
    /// Method overrides and interface implementations are not permitted here
    /// (Originally from FSComp.txt:712)
    static member tcMethodOverridesIllegalHere: unit -> int * string
    /// No abstract or interface member was found that corresponds to this override
    /// (Originally from FSComp.txt:713)
    static member tcNoMemberFoundForOverride: unit -> int * string
    /// This override takes a different number of arguments to the corresponding abstract member. The following abstract members were found:%s
    /// (Originally from FSComp.txt:714)
    static member tcOverrideArityMismatch: a0: System.String -> int * string
    /// This method already has a default implementation
    /// (Originally from FSComp.txt:715)
    static member tcDefaultImplementationAlreadyExists: unit -> int * string
    /// The method implemented by this default is ambiguous
    /// (Originally from FSComp.txt:716)
    static member tcDefaultAmbiguous: unit -> int * string
    /// No abstract property was found that corresponds to this override
    /// (Originally from FSComp.txt:717)
    static member tcNoPropertyFoundForOverride: unit -> int * string
    /// This property overrides or implements an abstract property but the abstract property doesn't have a corresponding %s
    /// (Originally from FSComp.txt:718)
    static member tcAbstractPropertyMissingGetOrSet: a0: System.String -> int * string
    /// Invalid signature for set member
    /// (Originally from FSComp.txt:719)
    static member tcInvalidSignatureForSet: unit -> int * string
    /// This new member hides the abstract member '%s'. Rename the member or use 'override' instead.
    /// (Originally from FSComp.txt:720)
    static member tcNewMemberHidesAbstractMember: a0: System.String -> int * string
    /// This new member hides the abstract member '%s' once tuples, functions, units of measure and/or provided types are erased. Rename the member or use 'override' instead.
    /// (Originally from FSComp.txt:721)
    static member tcNewMemberHidesAbstractMemberWithSuffix: a0: System.String -> int * string
    /// Interfaces cannot contain definitions of static initializers
    /// (Originally from FSComp.txt:722)
    static member tcStaticInitializersIllegalInInterface: unit -> int * string
    /// Interfaces cannot contain definitions of object constructors
    /// (Originally from FSComp.txt:723)
    static member tcObjectConstructorsIllegalInInterface: unit -> int * string
    /// Interfaces cannot contain definitions of member overrides
    /// (Originally from FSComp.txt:724)
    static member tcMemberOverridesIllegalInInterface: unit -> int * string
    /// Interfaces cannot contain definitions of concrete instance members. You may need to define a constructor on your type to indicate that the type is a class.
    /// (Originally from FSComp.txt:725)
    static member tcConcreteMembersIllegalInInterface: unit -> int * string
    /// Constructors cannot be specified in exception augmentations
    /// (Originally from FSComp.txt:726)
    static member tcConstructorsDisallowedInExceptionAugmentation: unit -> int * string
    /// Structs cannot have an object constructor with no arguments. This is a restriction imposed on all CLI languages as structs automatically support a default constructor.
    /// (Originally from FSComp.txt:727)
    static member tcStructsCannotHaveConstructorWithNoArguments: unit -> int * string
    /// Constructors cannot be defined for this type
    /// (Originally from FSComp.txt:728)
    static member tcConstructorsIllegalForThisType: unit -> int * string
    /// Recursive bindings that include member specifications can only occur as a direct augmentation of a type
    /// (Originally from FSComp.txt:729)
    static member tcRecursiveBindingsWithMembersMustBeDirectAugmentation: unit -> int * string
    /// Only simple variable patterns can be bound in 'let rec' constructs
    /// (Originally from FSComp.txt:730)
    static member tcOnlySimplePatternsInLetRec: unit -> int * string
    /// Mutable 'let' bindings can't be recursive or defined in recursive modules or namespaces
    /// (Originally from FSComp.txt:731)
    static member tcOnlyRecordFieldsAndSimpleLetCanBeMutable: unit -> int * string
    /// This member is not sufficiently generic
    /// (Originally from FSComp.txt:732)
    static member tcMemberIsNotSufficientlyGeneric: unit -> int * string
    /// A declaration may only be the [<Literal>] attribute if a constant value is also given, e.g. 'val x: int = 1'
    /// (Originally from FSComp.txt:733)
    static member tcLiteralAttributeRequiresConstantValue: unit -> int * string
    /// A declaration may only be given a value in a signature if the declaration has the [<Literal>] attribute
    /// (Originally from FSComp.txt:734)
    static member tcValueInSignatureRequiresLiteralAttribute: unit -> int * string
    /// Thread-static and context-static variables must be static and given the [<DefaultValue>] attribute to indicate that the value is initialized to the default value on each new thread
    /// (Originally from FSComp.txt:735)
    static member tcThreadStaticAndContextStaticMustBeStatic: unit -> int * string
    /// Volatile fields must be marked 'mutable' and cannot be thread-static
    /// (Originally from FSComp.txt:736)
    static member tcVolatileFieldsMustBeMutable: unit -> int * string
    /// Uninitialized 'val' fields must be mutable and marked with the '[<DefaultValue>]' attribute. Consider using a 'let' binding instead of a 'val' field.
    /// (Originally from FSComp.txt:737)
    static member tcUninitializedValFieldsMustBeMutable: unit -> int * string
    /// Static 'val' fields in types must be mutable, private and marked with the '[<DefaultValue>]' attribute. They are initialized to the 'null' or 'zero' value for their type. Consider also using a 'static let mutable' binding in a class type.
    /// (Originally from FSComp.txt:738)
    static member tcStaticValFieldsMustBeMutableAndPrivate: unit -> int * string
    /// This field requires a name
    /// (Originally from FSComp.txt:739)
    static member tcFieldRequiresName: unit -> int * string
    /// Invalid namespace, module, type or union case name
    /// (Originally from FSComp.txt:740)
    static member tcInvalidNamespaceModuleTypeUnionName: unit -> int * string
    /// Explicit type declarations for constructors must be of the form 'ty1 * ... * tyN -> resTy'. Parentheses may be required around 'resTy'
    /// (Originally from FSComp.txt:741)
    static member tcIllegalFormForExplicitTypeDeclaration: unit -> int * string
    /// Return types of union cases must be identical to the type being defined, up to abbreviations
    /// (Originally from FSComp.txt:742)
    static member tcReturnTypesForUnionMustBeSameAsType: unit -> int * string
    /// This is not a valid value for an enumeration literal
    /// (Originally from FSComp.txt:743)
    static member tcInvalidEnumerationLiteral: unit -> int * string
    /// The type '%s' is not an interface type
    /// (Originally from FSComp.txt:744)
    static member tcTypeIsNotInterfaceType1: a0: System.String -> int * string
    /// Duplicate specification of an interface
    /// (Originally from FSComp.txt:745)
    static member tcDuplicateSpecOfInterface: unit -> int * string
    /// A field/val declaration is not permitted here
    /// (Originally from FSComp.txt:746)
    static member tcFieldValIllegalHere: unit -> int * string
    /// A inheritance declaration is not permitted here
    /// (Originally from FSComp.txt:747)
    static member tcInheritIllegalHere: unit -> int * string
    /// This declaration opens the module '%s', which is marked as 'RequireQualifiedAccess'. Adjust your code to use qualified references to the elements of the module instead, e.g. 'List.map' instead of 'map'. This change will ensure that your code is robust as new constructs are added to libraries.
    /// (Originally from FSComp.txt:748)
    static member tcModuleRequiresQualifiedAccess: a0: System.String -> int * string
    /// This declaration opens the namespace or module '%s' through a partially qualified path. Adjust this code to use the full path of the namespace. This change will make your code more robust as new constructs are added to the F# and CLI libraries.
    /// (Originally from FSComp.txt:749)
    static member tcOpenUsedWithPartiallyQualifiedPath: a0: System.String -> int * string
    /// Local class bindings cannot be marked inline. Consider lifting the definition out of the class or else do not mark it as inline.
    /// (Originally from FSComp.txt:750)
    static member tcLocalClassBindingsCannotBeInline: unit -> int * string
    /// Type abbreviations cannot have members
    /// (Originally from FSComp.txt:751)
    static member tcTypeAbbreviationsMayNotHaveMembers: unit -> int * string
    /// As of F# 4.1, the accessibility of type abbreviations is checked at compile-time. Consider changing the accessibility of the type abbreviation. Ignoring this warning might lead to runtime errors.
    /// (Originally from FSComp.txt:752)
    static member tcTypeAbbreviationsCheckedAtCompileTime: unit -> string
    /// Enumerations cannot have members
    /// (Originally from FSComp.txt:753)
    static member tcEnumerationsMayNotHaveMembers: unit -> int * string
    /// Measure declarations may have only static members
    /// (Originally from FSComp.txt:754)
    static member tcMeasureDeclarationsRequireStaticMembers: unit -> int * string
    /// Structs cannot contain 'do' bindings because the default constructor for structs would not execute these bindings
    /// (Originally from FSComp.txt:755)
    static member tcStructsMayNotContainDoBindings: unit -> string
    /// Structs cannot contain value definitions because the default constructor for structs will not execute these bindings. Consider adding additional arguments to the primary constructor for the type.
    /// (Originally from FSComp.txt:756)
    static member tcStructsMayNotContainLetBindings: unit -> int * string
    /// For F#7 and lower, static 'let','do' and 'member val' definitions may only be used in types with a primary constructor ('type X(args) = ...'). To enable them in all other types, use language version '8' or higher.
    /// (Originally from FSComp.txt:757)
    static member tcStaticLetBindingsRequireClassesWithImplicitConstructors: unit -> int * string
    /// Measure declarations may have only static members: constructors are not available
    /// (Originally from FSComp.txt:758)
    static member tcMeasureDeclarationsRequireStaticMembersNotConstructors: unit -> int * string
    /// A member and a local class binding both have the name '%s'
    /// (Originally from FSComp.txt:759)
    static member tcMemberAndLocalClassBindingHaveSameName: a0: System.String -> int * string
    /// Type abbreviations cannot have interface declarations
    /// (Originally from FSComp.txt:760)
    static member tcTypeAbbreviationsCannotHaveInterfaceDeclaration: unit -> int * string
    /// Enumerations cannot have interface declarations
    /// (Originally from FSComp.txt:761)
    static member tcEnumerationsCannotHaveInterfaceDeclaration: unit -> int * string
    /// This type is not an interface type
    /// (Originally from FSComp.txt:762)
    static member tcTypeIsNotInterfaceType0: unit -> int * string
    /// All implemented interfaces should be declared on the initial declaration of the type
    /// (Originally from FSComp.txt:763)
    static member tcAllImplementedInterfacesShouldBeDeclared: unit -> int * string
    /// A default implementation of this interface has already been added because the explicit implementation of the interface was not specified at the definition of the type
    /// (Originally from FSComp.txt:764)
    static member tcDefaultImplementationForInterfaceHasAlreadyBeenAdded: unit -> int * string
    /// This member is not permitted in an interface implementation
    /// (Originally from FSComp.txt:765)
    static member tcMemberNotPermittedInInterfaceImplementation: unit -> int * string
    /// This declaration element is not permitted in an augmentation
    /// (Originally from FSComp.txt:766)
    static member tcDeclarationElementNotPermittedInAugmentation: unit -> int * string
    /// Types cannot contain nested type definitions
    /// (Originally from FSComp.txt:767)
    static member tcTypesCannotContainNestedTypes: unit -> int * string
    /// type, exception or module
    /// (Originally from FSComp.txt:768)
    static member tcTypeExceptionOrModule: unit -> string
    /// type or module
    /// (Originally from FSComp.txt:769)
    static member tcTypeOrModule: unit -> string
    /// The struct, record or union type '%s' implements the interface 'System.IStructuralEquatable' explicitly. Apply the 'CustomEquality' attribute to the type.
    /// (Originally from FSComp.txt:770)
    static member tcImplementsIStructuralEquatableExplicitly: a0: System.String -> int * string
    /// The struct, record or union type '%s' implements the interface 'System.IEquatable<_>' explicitly. Apply the 'CustomEquality' attribute to the type and provide a consistent implementation of the non-generic override 'System.Object.Equals(obj)'.
    /// (Originally from FSComp.txt:771)
    static member tcImplementsIEquatableExplicitly: a0: System.String -> int * string
    /// Explicit type specifications cannot be used for exception constructors
    /// (Originally from FSComp.txt:772)
    static member tcExplicitTypeSpecificationCannotBeUsedForExceptionConstructors: unit -> int * string
    /// Exception abbreviations should not have argument lists
    /// (Originally from FSComp.txt:773)
    static member tcExceptionAbbreviationsShouldNotHaveArgumentList: unit -> int * string
    /// Abbreviations for Common IL exceptions cannot take arguments
    /// (Originally from FSComp.txt:774)
    static member tcAbbreviationsFordotNetExceptionsCannotTakeArguments: unit -> int * string
    /// Exception abbreviations must refer to existing exceptions or F# types deriving from System.Exception
    /// (Originally from FSComp.txt:775)
    static member tcExceptionAbbreviationsMustReferToValidExceptions: unit -> int * string
    /// Abbreviations for Common IL exception types must have a matching object constructor
    /// (Originally from FSComp.txt:776)
    static member tcAbbreviationsFordotNetExceptionsMustHaveMatchingObjectConstructor: unit -> int * string
    /// Not an exception
    /// (Originally from FSComp.txt:777)
    static member tcNotAnException: unit -> int * string
    /// Invalid module name
    /// (Originally from FSComp.txt:778)
    static member tcInvalidModuleName: unit -> int * string
    /// Invalid type extension
    /// (Originally from FSComp.txt:779)
    static member tcInvalidTypeExtension: unit -> int * string
    /// The attributes of this type specify multiple kinds for the type
    /// (Originally from FSComp.txt:780)
    static member tcAttributesOfTypeSpecifyMultipleKindsForType: unit -> int * string
    /// The kind of the type specified by its attributes does not match the kind implied by its definition
    /// (Originally from FSComp.txt:781)
    static member tcKindOfTypeSpecifiedDoesNotMatchDefinition: unit -> int * string
    /// Measure definitions cannot have type parameters
    /// (Originally from FSComp.txt:782)
    static member tcMeasureDefinitionsCannotHaveTypeParameters: unit -> int * string
    /// This type requires a definition
    /// (Originally from FSComp.txt:783)
    static member tcTypeRequiresDefinition: unit -> int * string
    /// This type abbreviation has one or more declared type parameters that do not appear in the type being abbreviated. Type abbreviations must use all declared type parameters in the type being abbreviated. Consider removing one or more type parameters, or use a concrete type definition that wraps an underlying type, such as 'type C<'a> = C of ...'.
    /// (Originally from FSComp.txt:784)
    static member tcTypeAbbreviationHasTypeParametersMissingOnType: unit -> string
    /// Structs, interfaces, enums and delegates cannot inherit from other types
    /// (Originally from FSComp.txt:785)
    static member tcStructsInterfacesEnumsDelegatesMayNotInheritFromOtherTypes: unit -> int * string
    /// Types cannot inherit from multiple concrete types
    /// (Originally from FSComp.txt:786)
    static member tcTypesCannotInheritFromMultipleConcreteTypes: unit -> int * string
    /// Records, union, abbreviations and struct types cannot have the 'AllowNullLiteral' attribute
    /// (Originally from FSComp.txt:787)
    static member tcRecordsUnionsAbbreviationsStructsMayNotHaveAllowNullLiteralAttribute: unit -> int * string
    /// Types with the 'AllowNullLiteral' attribute may only inherit from or implement types which also allow the use of the null literal
    /// (Originally from FSComp.txt:788)
    static member tcAllowNullTypesMayOnlyInheritFromAllowNullTypes: unit -> int * string
    /// Generic types cannot be given the 'StructLayout' attribute
    /// (Originally from FSComp.txt:789)
    static member tcGenericTypesCannotHaveStructLayout: unit -> int * string
    /// Only structs and classes without primary constructors may be given the 'StructLayout' attribute
    /// (Originally from FSComp.txt:790)
    static member tcOnlyStructsCanHaveStructLayout: unit -> int * string
    /// The representation of this type is hidden by the signature. It must be given an attribute such as [<Sealed>], [<Class>] or [<Interface>] to indicate the characteristics of the type.
    /// (Originally from FSComp.txt:791)
    static member tcRepresentationOfTypeHiddenBySignature: unit -> int * string
    /// Only classes may be given the 'AbstractClass' attribute
    /// (Originally from FSComp.txt:792)
    static member tcOnlyClassesCanHaveAbstract: unit -> int * string
    /// Only types representing units-of-measure may be given the 'Measure' attribute
    /// (Originally from FSComp.txt:793)
    static member tcOnlyTypesRepresentingUnitsOfMeasureCanHaveMeasure: unit -> int * string
    /// Accessibility modifiers are not permitted on overrides or interface implementations
    /// (Originally from FSComp.txt:794)
    static member tcOverridesCannotHaveVisibilityDeclarations: unit -> int * string
    /// Discriminated union types are always sealed
    /// (Originally from FSComp.txt:795)
    static member tcTypesAreAlwaysSealedDU: unit -> int * string
    /// Record types are always sealed
    /// (Originally from FSComp.txt:796)
    static member tcTypesAreAlwaysSealedRecord: unit -> int * string
    /// Assembly code types are always sealed
    /// (Originally from FSComp.txt:797)
    static member tcTypesAreAlwaysSealedAssemblyCode: unit -> int * string
    /// Struct types are always sealed
    /// (Originally from FSComp.txt:798)
    static member tcTypesAreAlwaysSealedStruct: unit -> int * string
    /// Delegate types are always sealed
    /// (Originally from FSComp.txt:799)
    static member tcTypesAreAlwaysSealedDelegate: unit -> int * string
    /// Enum types are always sealed
    /// (Originally from FSComp.txt:800)
    static member tcTypesAreAlwaysSealedEnum: unit -> int * string
    /// Interface types and delegate types cannot contain fields
    /// (Originally from FSComp.txt:801)
    static member tcInterfaceTypesAndDelegatesCannotContainFields: unit -> int * string
    /// Abbreviated types cannot be given the 'Sealed' attribute
    /// (Originally from FSComp.txt:802)
    static member tcAbbreviatedTypesCannotBeSealed: unit -> int * string
    /// Cannot inherit a sealed type
    /// (Originally from FSComp.txt:803)
    static member tcCannotInheritFromSealedType: unit -> int * string
    /// Cannot inherit from interface type. Use interface ... with instead.
    /// (Originally from FSComp.txt:804)
    static member tcCannotInheritFromInterfaceType: unit -> int * string
    /// Struct types cannot contain abstract members
    /// (Originally from FSComp.txt:805)
    static member tcStructTypesCannotContainAbstractMembers: unit -> int * string
    /// Interface types cannot be sealed
    /// (Originally from FSComp.txt:806)
    static member tcInterfaceTypesCannotBeSealed: unit -> int * string
    /// Delegate specifications must be of the form 'typ -> typ'
    /// (Originally from FSComp.txt:807)
    static member tcInvalidDelegateSpecification: unit -> int * string
    /// Delegate specifications must not be curried types. Use 'typ * ... * typ -> typ' for multi-argument delegates, and 'typ -> (typ -> typ)' for delegates returning function values.
    /// (Originally from FSComp.txt:808)
    static member tcDelegatesCannotBeCurried: unit -> int * string
    /// Literal enumerations must have type int, uint, int16, uint16, int64, uint64, byte, sbyte or char
    /// (Originally from FSComp.txt:809)
    static member tcInvalidTypeForLiteralEnumeration: unit -> int * string
    /// This type definition involves an immediate cyclic reference through an abbreviation
    /// (Originally from FSComp.txt:810)
    static member tcTypeDefinitionIsCyclic: unit -> int * string
    /// This type definition involves an immediate cyclic reference through a struct field or inheritance relation
    /// (Originally from FSComp.txt:811)
    static member tcTypeDefinitionIsCyclicThroughInheritance: unit -> int * string
    /// The syntax 'type X with ...' is reserved for augmentations. Types whose representations are hidden but which have members are now declared in signatures using 'type X = ...'. You may also need to add the '[<Sealed>] attribute to the type definition in the signature
    /// (Originally from FSComp.txt:812)
    static member tcReservedSyntaxForAugmentation: unit -> string
    /// Members that extend interface, delegate or enum types must be placed in a module separate to the definition of the type. This module must either have the AutoOpen attribute or be opened explicitly by client code to bring the extension members into scope.
    /// (Originally from FSComp.txt:813)
    static member tcMembersThatExtendInterfaceMustBePlacedInSeparateModule: unit -> int * string
    /// One or more of the declared type parameters for this type extension have a missing or wrong type constraint not matching the original type constraints on '%s'
    /// (Originally from FSComp.txt:814)
    static member tcDeclaredTypeParametersForExtensionDoNotMatchOriginal: a0: System.String -> int * string
    /// Type definitions may only have one 'inherit' specification and it must be the first declaration
    /// (Originally from FSComp.txt:815)
    static member tcTypeDefinitionsWithImplicitConstructionMustHaveOneInherit: unit -> int * string
    /// 'let' and 'do' bindings must come before member and interface definitions in type definitions
    /// (Originally from FSComp.txt:816)
    static member tcTypeDefinitionsWithImplicitConstructionMustHaveLocalBindingsBeforeMembers: unit -> int * string
    /// This 'inherit' declaration specifies the inherited type but no arguments. Consider supplying arguments, e.g. 'inherit BaseType(args)'.
    /// (Originally from FSComp.txt:817)
    static member tcInheritDeclarationMissingArguments: unit -> int * string
    /// This 'inherit' declaration has arguments, but is not in a type with a primary constructor. Consider adding arguments to your type definition, e.g. 'type X(args) = ...'.
    /// (Originally from FSComp.txt:818)
    static member tcInheritConstructionCallNotPartOfImplicitSequence: unit -> int * string
    /// This definition may only be used in a type with a primary constructor. Consider adding arguments to your type definition, e.g. 'type X(args) = ...'.
    /// (Originally from FSComp.txt:819)
    static member tcLetAndDoRequiresImplicitConstructionSequence: unit -> int * string
    /// Type abbreviations cannot have augmentations
    /// (Originally from FSComp.txt:820)
    static member tcTypeAbbreviationsCannotHaveAugmentations: unit -> int * string
    /// The path '%s' is a namespace. A module abbreviation may not abbreviate a namespace.
    /// (Originally from FSComp.txt:821)
    static member tcModuleAbbreviationForNamespace: a0: System.String -> int * string
    /// The type '%s' is used in an invalid way. A value prior to '%s' has an inferred type involving '%s', which is an invalid forward reference.
    /// (Originally from FSComp.txt:822)
    static member tcTypeUsedInInvalidWay: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The member '%s' is used in an invalid way. A use of '%s' has been inferred prior to the definition of '%s', which is an invalid forward reference.
    /// (Originally from FSComp.txt:823)
    static member tcMemberUsedInInvalidWay: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The attribute 'AutoOpen(\"%s\")' in the assembly '%s' did not refer to a valid module or namespace in that assembly and has been ignored
    /// (Originally from FSComp.txt:824)
    static member tcAttributeAutoOpenWasIgnored: a0: System.String * a1: System.String -> int * string
    /// Undefined value '%s'
    /// (Originally from FSComp.txt:825)
    static member ilUndefinedValue: a0: System.String -> int * string
    /// Label %s not found
    /// (Originally from FSComp.txt:826)
    static member ilLabelNotFound: a0: System.String -> int * string
    /// Incorrect number of type arguments to local call
    /// (Originally from FSComp.txt:827)
    static member ilIncorrectNumberOfTypeArguments: unit -> int * string
    /// Dynamic invocation of %s is not supported
    /// (Originally from FSComp.txt:828)
    static member ilDynamicInvocationNotSupported: a0: System.String -> string
    /// Taking the address of a literal field is invalid
    /// (Originally from FSComp.txt:829)
    static member ilAddressOfLiteralFieldIsInvalid: unit -> int * string
    /// This operation involves taking the address of a value '%s' represented using a local variable or other special representation. This is invalid.
    /// (Originally from FSComp.txt:830)
    static member ilAddressOfValueHereIsInvalid: a0: System.String -> int * string
    /// Custom marshallers cannot be specified in F# code. Consider using a C# helper function.
    /// (Originally from FSComp.txt:831)
    static member ilCustomMarshallersCannotBeUsedInFSharp: unit -> int * string
    /// The MarshalAs attribute could not be decoded
    /// (Originally from FSComp.txt:832)
    static member ilMarshalAsAttributeCannotBeDecoded: unit -> int * string
    /// The signature for this external function contains type parameters. Constrain the argument and return types to indicate the types of the corresponding C function.
    /// (Originally from FSComp.txt:833)
    static member ilSignatureForExternalFunctionContainsTypeParameters: unit -> int * string
    /// The DllImport attribute could not be decoded
    /// (Originally from FSComp.txt:834)
    static member ilDllImportAttributeCouldNotBeDecoded: unit -> int * string
    /// Literal fields cannot be set
    /// (Originally from FSComp.txt:835)
    static member ilLiteralFieldsCannotBeSet: unit -> int * string
    /// GenSetStorage: %s was represented as a static method but was not an appropriate lambda expression
    /// (Originally from FSComp.txt:836)
    static member ilStaticMethodIsNotLambda: a0: System.String -> int * string
    /// Mutable variables cannot escape their method
    /// (Originally from FSComp.txt:837)
    static member ilMutableVariablesCannotEscapeMethod: unit -> int * string
    /// Compiler error: unexpected unrealized value
    /// (Originally from FSComp.txt:838)
    static member ilUnexpectedUnrealizedValue: unit -> int * string
    /// Main module of program is empty: nothing will happen when it is run
    /// (Originally from FSComp.txt:839)
    static member ilMainModuleEmpty: unit -> int * string
    /// This type cannot be used for a literal field
    /// (Originally from FSComp.txt:840)
    static member ilTypeCannotBeUsedForLiteralField: unit -> int * string
    /// Unexpected GetSet annotation on a property
    /// (Originally from FSComp.txt:841)
    static member ilUnexpectedGetSetAnnotation: unit -> int * string
    /// The FieldOffset attribute could not be decoded
    /// (Originally from FSComp.txt:842)
    static member ilFieldOffsetAttributeCouldNotBeDecoded: unit -> int * string
    /// The StructLayout attribute could not be decoded
    /// (Originally from FSComp.txt:843)
    static member ilStructLayoutAttributeCouldNotBeDecoded: unit -> int * string
    /// The DefaultAugmentation attribute could not be decoded
    /// (Originally from FSComp.txt:844)
    static member ilDefaultAugmentationAttributeCouldNotBeDecoded: unit -> int * string
    /// Reflected definitions cannot contain uses of the prefix splice operator '%%'
    /// (Originally from FSComp.txt:845)
    static member ilReflectedDefinitionsCannotUseSliceOperator: unit -> int * string
    /// Package manager key '%s' was not registered in %s. Currently registered: %s. You can provide extra path(s) by passing '--compilertool:<extensionsfolder>' to the command line. To learn more about extensions, visit: https://aka.ms/dotnetdepmanager
    /// (Originally from FSComp.txt:846)
    static member packageManagerUnknown: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// %s
    /// (Originally from FSComp.txt:847)
    static member packageManagerError: a0: System.String -> int * string
    /// Problem with codepage '%d': %s
    /// (Originally from FSComp.txt:848)
    static member optsProblemWithCodepage: a0: System.Int32 * a1: System.String -> int * string
    /// Copyright (c) Microsoft Corporation. All Rights Reserved.
    /// (Originally from FSComp.txt:849)
    static member optsCopyright: unit -> string
    /// Freely distributed under the MIT Open Source License.  https://github.com/Microsoft/visualfsharp/blob/master/License.txt
    /// (Originally from FSComp.txt:850)
    static member optsCopyrightCommunity: unit -> string
    /// Name of the output file (Short form: -o)
    /// (Originally from FSComp.txt:851)
    static member optsNameOfOutputFile: unit -> string
    /// Build a console executable
    /// (Originally from FSComp.txt:852)
    static member optsBuildConsole: unit -> string
    /// Build a Windows executable
    /// (Originally from FSComp.txt:853)
    static member optsBuildWindows: unit -> string
    /// Build a library (Short form: -a)
    /// (Originally from FSComp.txt:854)
    static member optsBuildLibrary: unit -> string
    /// Build a module that can be added to another assembly
    /// (Originally from FSComp.txt:855)
    static member optsBuildModule: unit -> string
    /// Delay-sign the assembly using only the public portion of the strong name key (%s by default)
    /// (Originally from FSComp.txt:856)
    static member optsDelaySign: a0: System.String -> string
    /// Public-sign the assembly using only the public portion of the strong name key, and mark the assembly as signed (%s by default)
    /// (Originally from FSComp.txt:857)
    static member optsPublicSign: a0: System.String -> string
    /// Write the xmldoc of the assembly to the given file
    /// (Originally from FSComp.txt:858)
    static member optsWriteXml: unit -> string
    /// Specify a strong name key file
    /// (Originally from FSComp.txt:859)
    static member optsStrongKeyFile: unit -> string
    /// Specify a strong name key container
    /// (Originally from FSComp.txt:860)
    static member optsStrongKeyContainer: unit -> string
    /// Compress interface and optimization data files (%s by default)
    /// (Originally from FSComp.txt:861)
    static member optsCompressMetadata: a0: System.String -> string
    /// Limit which platforms this code can run on: x86, x64, Arm, Arm64, Itanium, anycpu32bitpreferred, or anycpu. The default is anycpu.
    /// (Originally from FSComp.txt:862)
    static member optsPlatform: unit -> string
    /// Only include optimization information essential for implementing inlined constructs. Inhibits cross-module inlining but improves binary compatibility.
    /// (Originally from FSComp.txt:863)
    static member optsNoOpt: unit -> string
    /// Don't add a resource to the generated assembly containing F#-specific metadata
    /// (Originally from FSComp.txt:864)
    static member optsNoInterface: unit -> string
    /// Print the inferred interface of the assembly to a file
    /// (Originally from FSComp.txt:865)
    static member optsSig: unit -> string
    /// Print the inferred interfaces of all compilation files to associated signature files
    /// (Originally from FSComp.txt:866)
    static member optsAllSigs: unit -> string
    /// Reference an assembly (Short form: -r)
    /// (Originally from FSComp.txt:867)
    static member optsReference: unit -> string
    /// Reference an assembly or directory containing a design time tool (Short form: -t)
    /// (Originally from FSComp.txt:868)
    static member optsCompilerTool: unit -> string
    /// Specify a Win32 icon file (.ico)
    /// (Originally from FSComp.txt:869)
    static member optsWin32icon: unit -> string
    /// Specify a Win32 resource file (.res)
    /// (Originally from FSComp.txt:870)
    static member optsWin32res: unit -> string
    /// Specify a Win32 manifest file
    /// (Originally from FSComp.txt:871)
    static member optsWin32manifest: unit -> string
    /// Do not include the default Win32 manifest
    /// (Originally from FSComp.txt:872)
    static member optsNowin32manifest: unit -> string
    /// Embed all source files in the portable PDB file (%s by default)
    /// (Originally from FSComp.txt:873)
    static member optsEmbedAllSource: a0: System.String -> string
    /// Embed specific source files in the portable PDB file
    /// (Originally from FSComp.txt:874)
    static member optsEmbedSource: unit -> string
    /// Source link information file to embed in the portable PDB file
    /// (Originally from FSComp.txt:875)
    static member optsSourceLink: unit -> string
    /// The pdb output file name cannot match the build output filename use --pdb:filename.pdb
    /// (Originally from FSComp.txt:876)
    static member optsPdbMatchesOutputFileName: unit -> int * string
    /// Source file is too large to embed in a portable PDB
    /// (Originally from FSComp.txt:877)
    static member srcFileTooLarge: unit -> string
    /// Embed the specified managed resource
    /// (Originally from FSComp.txt:878)
    static member optsResource: unit -> string
    /// Link the specified resource to this assembly where the resinfo format is <file>[,<string name>[,public|private]]
    /// (Originally from FSComp.txt:879)
    static member optsLinkresource: unit -> string
    /// Emit debug information (Short form: -g) (%s by default)
    /// (Originally from FSComp.txt:880)
    static member optsDebugPM: a0: System.String -> string
    /// Specify debugging type: full, portable, embedded, pdbonly. ('%s' is the default if no debugging type specified and enables attaching a debugger to a running program, 'portable' is a cross-platform format, 'embedded' is a cross-platform format embedded into the output file).
    /// (Originally from FSComp.txt:881)
    static member optsDebug: a0: System.String -> string
    /// Enable optimizations (Short form: -O) (%s by default)
    /// (Originally from FSComp.txt:882)
    static member optsOptimize: a0: System.String -> string
    /// Enable or disable tailcalls (%s by default)
    /// (Originally from FSComp.txt:883)
    static member optsTailcalls: a0: System.String -> string
    /// Produce a deterministic assembly (including module version GUID and timestamp) (%s by default)
    /// (Originally from FSComp.txt:884)
    static member optsDeterministic: a0: System.String -> string
    /// Generate assembly with IL visibility that matches the source code visibility (%s by default)
    /// (Originally from FSComp.txt:885)
    static member optsRealsig: a0: System.String -> string
    /// Produce a reference assembly, instead of a full assembly, as the primary output (%s by default)
    /// (Originally from FSComp.txt:886)
    static member optsRefOnly: a0: System.String -> string
    /// Produce a reference assembly with the specified file path.
    /// (Originally from FSComp.txt:887)
    static member optsRefOut: unit -> string
    /// Maps physical paths to source path names output by the compiler
    /// (Originally from FSComp.txt:888)
    static member optsPathMap: unit -> string
    /// Enable or disable cross-module optimizations (%s by default)
    /// (Originally from FSComp.txt:889)
    static member optsCrossoptimize: a0: System.String -> string
    /// Disable implicit generation of constructs using reflection
    /// (Originally from FSComp.txt:890)
    static member optsReflectionFree: unit -> string
    /// Report all warnings as errors (%s by default)
    /// (Originally from FSComp.txt:891)
    static member optsWarnaserrorPM: a0: System.String -> string
    /// Report specific warnings as errors
    /// (Originally from FSComp.txt:892)
    static member optsWarnaserror: unit -> string
    /// Set a warning level (0-5)
    /// (Originally from FSComp.txt:893)
    static member optsWarn: unit -> string
    /// Disable specific warning messages
    /// (Originally from FSComp.txt:894)
    static member optsNowarn: unit -> string
    /// Enable specific warnings that may be off by default
    /// (Originally from FSComp.txt:895)
    static member optsWarnOn: unit -> string
    /// Generate overflow checks (%s by default)
    /// (Originally from FSComp.txt:896)
    static member optsChecked: a0: System.String -> string
    /// Define conditional compilation symbols (Short form: -d)
    /// (Originally from FSComp.txt:897)
    static member optsDefine: unit -> string
    /// Ignore ML compatibility warnings
    /// (Originally from FSComp.txt:898)
    static member optsMlcompatibility: unit -> string
    /// Suppress compiler copyright message
    /// (Originally from FSComp.txt:899)
    static member optsNologo: unit -> string
    /// Display this usage message (Short form: -?)
    /// (Originally from FSComp.txt:900)
    static member optsHelp: unit -> string
    /// Display compiler version banner and exit
    /// (Originally from FSComp.txt:901)
    static member optsVersion: unit -> string
    /// Read response file for more options
    /// (Originally from FSComp.txt:902)
    static member optsResponseFile: unit -> string
    /// Specify the codepage used to read source files
    /// (Originally from FSComp.txt:903)
    static member optsCodepage: unit -> string
    /// Clear the package manager results cache
    /// (Originally from FSComp.txt:904)
    static member optsClearResultsCache: unit -> string
    /// Perform type checking only, do not execute code
    /// (Originally from FSComp.txt:905)
    static member optsTypecheckOnly: unit -> string
    /// Output messages in UTF-8 encoding
    /// (Originally from FSComp.txt:906)
    static member optsUtf8output: unit -> string
    /// Output messages with fully qualified paths
    /// (Originally from FSComp.txt:907)
    static member optsFullpaths: unit -> string
    /// Specify a directory for the include path which is used to resolve source files and assemblies (Short form: -I)
    /// (Originally from FSComp.txt:908)
    static member optsLib: unit -> string
    /// Base address for the library to be built
    /// (Originally from FSComp.txt:909)
    static member optsBaseaddress: unit -> string
    /// Specify algorithm for calculating source file checksum stored in PDB. Supported values are: SHA1 or SHA256 (default)
    /// (Originally from FSComp.txt:910)
    static member optsChecksumAlgorithm: unit -> string
    /// Do not reference the default CLI assemblies by default
    /// (Originally from FSComp.txt:911)
    static member optsNoframework: unit -> string
    /// Statically link the F# library and all referenced DLLs that depend on it into the assembly being generated
    /// (Originally from FSComp.txt:912)
    static member optsStandalone: unit -> string
    /// Statically link the given assembly and all referenced DLLs that depend on this assembly. Use an assembly name e.g. mylib, not a DLL name.
    /// (Originally from FSComp.txt:913)
    static member optsStaticlink: unit -> string
    /// Use a resident background compilation service to improve compiler startup times.
    /// (Originally from FSComp.txt:914)
    static member optsResident: unit -> string
    /// Name the output debug file
    /// (Originally from FSComp.txt:915)
    static member optsPdb: unit -> string
    /// Resolve assembly references using directory-based rules rather than MSBuild resolution
    /// (Originally from FSComp.txt:916)
    static member optsSimpleresolution: unit -> string
    /// Short form of '%s'
    /// (Originally from FSComp.txt:917)
    static member optsShortFormOf: a0: System.String -> string
    /// The command-line option '--cliroot' has been deprecated. Use an explicit reference to a specific copy of mscorlib.dll instead.
    /// (Originally from FSComp.txt:918)
    static member optsClirootDeprecatedMsg: unit -> string
    /// Use to override where the compiler looks for mscorlib.dll and framework components
    /// (Originally from FSComp.txt:919)
    static member optsClirootDescription: unit -> string
    /// - OUTPUT FILES -
    /// (Originally from FSComp.txt:920)
    static member optsHelpBannerOutputFiles: unit -> string
    /// - INPUT FILES -
    /// (Originally from FSComp.txt:921)
    static member optsHelpBannerInputFiles: unit -> string
    /// - RESOURCES -
    /// (Originally from FSComp.txt:922)
    static member optsHelpBannerResources: unit -> string
    /// - CODE GENERATION -
    /// (Originally from FSComp.txt:923)
    static member optsHelpBannerCodeGen: unit -> string
    /// - ADVANCED -
    /// (Originally from FSComp.txt:924)
    static member optsHelpBannerAdvanced: unit -> string
    /// - MISCELLANEOUS -
    /// (Originally from FSComp.txt:925)
    static member optsHelpBannerMisc: unit -> string
    /// - LANGUAGE -
    /// (Originally from FSComp.txt:926)
    static member optsHelpBannerLanguage: unit -> string
    /// - ERRORS AND WARNINGS -
    /// (Originally from FSComp.txt:927)
    static member optsHelpBannerErrsAndWarns: unit -> string
    /// The command-line option '%s' is for test purposes only
    /// (Originally from FSComp.txt:928)
    static member optsInternalNoDescription: a0: System.String -> string
    /// The command-line option '%s' has been deprecated
    /// (Originally from FSComp.txt:929)
    static member optsDCLONoDescription: a0: System.String -> string
    /// The command-line option '%s' has been deprecated. Use '%s' instead.
    /// (Originally from FSComp.txt:930)
    static member optsDCLODeprecatedSuggestAlternative: a0: System.String * a1: System.String -> string
    /// The command-line option '%s' has been deprecated. HTML document generation is now part of the F# Power Pack, via the tool FsHtmlDoc.exe.
    /// (Originally from FSComp.txt:931)
    static member optsDCLOHtmlDoc: a0: System.String -> string
    /// Output warning and error messages in color (%s by default)
    /// (Originally from FSComp.txt:932)
    static member optsConsoleColors: a0: System.String -> string
    /// Enable high-entropy ASLR (%s by default)
    /// (Originally from FSComp.txt:933)
    static member optsUseHighEntropyVA: a0: System.String -> string
    /// Specify subsystem version of this assembly
    /// (Originally from FSComp.txt:934)
    static member optsSubSystemVersion: unit -> string
    /// Specify target framework profile of this assembly. Valid values are mscorlib, netcore or netstandard. Default - mscorlib
    /// (Originally from FSComp.txt:935)
    static member optsTargetProfile: unit -> string
    /// Emit debug information in quotations (%s by default)
    /// (Originally from FSComp.txt:936)
    static member optsEmitDebugInfoInQuotations: a0: System.String -> string
    /// Specify the preferred output language culture name (e.g. es-ES, ja-JP)
    /// (Originally from FSComp.txt:937)
    static member optsPreferredUiLang: unit -> string
    /// Don't copy FSharp.Core.dll along the produced binaries
    /// (Originally from FSComp.txt:938)
    static member optsNoCopyFsharpCore: unit -> string
    /// Include F# interface information, the default is file. Essential for distributing libraries.
    /// (Originally from FSComp.txt:939)
    static member optsSignatureData: unit -> string
    /// Invalid value '%s' for --interfacedata, valid value are: none, file, compress.
    /// (Originally from FSComp.txt:940)
    static member optsUnknownSignatureData: a0: System.String -> int * string
    /// Specify included optimization information, the default is file. Important for distributed libraries.
    /// (Originally from FSComp.txt:941)
    static member optsOptimizationData: unit -> string
    /// Invalid value '%s' for --optimizationdata, valid value are: none, file, compress.
    /// (Originally from FSComp.txt:942)
    static member optsUnknownOptimizationData: a0: System.String -> int * string
    /// Unrecognized target '%s', expected 'exe', 'winexe', 'library' or 'module'
    /// (Originally from FSComp.txt:943)
    static member optsUnrecognizedTarget: a0: System.String -> int * string
    /// Unrecognized debug type '%s', expected 'pdbonly' or 'full'
    /// (Originally from FSComp.txt:944)
    static member optsUnrecognizedDebugType: a0: System.String -> int * string
    /// Invalid warning level '%d'
    /// (Originally from FSComp.txt:945)
    static member optsInvalidWarningLevel: a0: System.Int32 -> int * string
    /// Invalid version '%s' for '--subsystemversion'. The version must be 4.00 or greater.
    /// (Originally from FSComp.txt:946)
    static member optsInvalidSubSystemVersion: a0: System.String -> int * string
    /// Invalid value '%s' for '--targetprofile', valid values are 'mscorlib', 'netcore' or 'netstandard'.
    /// (Originally from FSComp.txt:947)
    static member optsInvalidTargetProfile: a0: System.String -> int * string
    /// Unknown --test argument: '%s'
    /// (Originally from FSComp.txt:948)
    static member optsUnknownArgumentToTheTestSwitch: a0: System.String -> int * string
    /// Unrecognized platform '%s', valid values are 'x86', 'x64', 'Arm', 'Arm64', 'Itanium', 'anycpu32bitpreferred', and 'anycpu'. The default is anycpu.
    /// (Originally from FSComp.txt:949)
    static member optsUnknownPlatform: a0: System.String -> int * string
    /// Algorithm '%s' is not supported
    /// (Originally from FSComp.txt:950)
    static member optsUnknownChecksumAlgorithm: a0: System.String -> int * string
    /// Full name
    /// (Originally from FSComp.txt:951)
    static member typeInfoFullName: unit -> string
    /// and %d other overloads
    /// (Originally from FSComp.txt:955)
    static member typeInfoOtherOverloads: a0: System.Int32 -> string
    /// union case
    /// (Originally from FSComp.txt:956)
    static member typeInfoUnionCase: unit -> string
    /// active pattern result
    /// (Originally from FSComp.txt:957)
    static member typeInfoActivePatternResult: unit -> string
    /// active recognizer
    /// (Originally from FSComp.txt:958)
    static member typeInfoActiveRecognizer: unit -> string
    /// field
    /// (Originally from FSComp.txt:959)
    static member typeInfoField: unit -> string
    /// event
    /// (Originally from FSComp.txt:960)
    static member typeInfoEvent: unit -> string
    /// property
    /// (Originally from FSComp.txt:961)
    static member typeInfoProperty: unit -> string
    /// extension
    /// (Originally from FSComp.txt:962)
    static member typeInfoExtension: unit -> string
    /// custom operation
    /// (Originally from FSComp.txt:963)
    static member typeInfoCustomOperation: unit -> string
    /// argument
    /// (Originally from FSComp.txt:964)
    static member typeInfoArgument: unit -> string
    /// anonymous record field
    /// (Originally from FSComp.txt:965)
    static member typeInfoAnonRecdField: unit -> string
    /// patvar
    /// (Originally from FSComp.txt:966)
    static member typeInfoPatternVariable: unit -> string
    /// namespace
    /// (Originally from FSComp.txt:967)
    static member typeInfoNamespace: unit -> string
    /// module
    /// (Originally from FSComp.txt:968)
    static member typeInfoModule: unit -> string
    /// namespace/module
    /// (Originally from FSComp.txt:969)
    static member typeInfoNamespaceOrModule: unit -> string
    /// from %s
    /// (Originally from FSComp.txt:970)
    static member typeInfoFromFirst: a0: System.String -> string
    /// also from %s
    /// (Originally from FSComp.txt:971)
    static member typeInfoFromNext: a0: System.String -> string
    /// generated property
    /// (Originally from FSComp.txt:972)
    static member typeInfoGeneratedProperty: unit -> string
    /// generated type
    /// (Originally from FSComp.txt:973)
    static member typeInfoGeneratedType: unit -> string
    /// (Suggested name)
    /// (Originally from FSComp.txt:974)
    static member suggestedName: unit -> string
    /// Recursive class hierarchy in type '%s'
    /// (Originally from FSComp.txt:975)
    static member recursiveClassHierarchy: a0: System.String -> int * string
    /// Invalid recursive reference to an abstract slot
    /// (Originally from FSComp.txt:976)
    static member InvalidRecursiveReferenceToAbstractSlot: unit -> int * string
    /// The event '%s' has a non-standard type. If this event is declared in another CLI language, you may need to access this event using the explicit %s and %s methods for the event. If this event is declared in F#, make the type of the event an instantiation of either 'IDelegateEvent<_>' or 'IEvent<_,_>'.
    /// (Originally from FSComp.txt:977)
    static member eventHasNonStandardType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The type '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:978)
    static member typeIsNotAccessible: a0: System.String -> int * string
    /// The union cases or fields of the type '%s' are not accessible from this code location
    /// (Originally from FSComp.txt:979)
    static member unionCasesAreNotAccessible: a0: System.String -> int * string
    /// The value '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:980)
    static member valueIsNotAccessible: a0: System.String -> int * string
    /// The union case '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:981)
    static member unionCaseIsNotAccessible: a0: System.String -> int * string
    /// The record, struct or class field '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:982)
    static member fieldIsNotAccessible: a0: System.String -> int * string
    /// The struct or class field '%s' is not accessible from this code location
    /// (Originally from FSComp.txt:983)
    static member structOrClassFieldIsNotAccessible: a0: System.String -> int * string
    /// This construct is experimental
    /// (Originally from FSComp.txt:984)
    static member experimentalConstruct: unit -> string
    /// No Invoke methods found for delegate type
    /// (Originally from FSComp.txt:985)
    static member noInvokeMethodsFound: unit -> int * string
    /// More than one Invoke method found for delegate type
    /// (Originally from FSComp.txt:986)
    static member moreThanOneInvokeMethodFound: unit -> string
    /// Delegates are not allowed to have curried signatures
    /// (Originally from FSComp.txt:987)
    static member delegatesNotAllowedToHaveCurriedSignatures: unit -> int * string
    /// Unexpected Expr.TyChoose
    /// (Originally from FSComp.txt:988)
    static member tlrUnexpectedTExpr: unit -> int * string
    /// Note: Lambda-lifting optimizations have not been applied because of the use of this local constrained generic function as a first class value. Adding type constraints may resolve this condition.
    /// (Originally from FSComp.txt:989)
    static member tlrLambdaLiftingOptimizationsNotApplied: unit -> int * string
    /// Identifiers containing '@' are reserved for use in F# code generation
    /// (Originally from FSComp.txt:990)
    static member lexhlpIdentifiersContainingAtSymbolReserved: unit -> int * string
    /// The identifier '%s' is reserved for future use by F#
    /// (Originally from FSComp.txt:991)
    static member lexhlpIdentifierReserved: a0: System.String -> string
    /// Missing variable '%s'
    /// (Originally from FSComp.txt:992)
    static member patcMissingVariable: a0: System.String -> int * string
    /// Partial active patterns may only generate one result
    /// (Originally from FSComp.txt:993)
    static member patcPartialActivePatternsGenerateOneResult: unit -> int * string
    /// The type '%s' is required here and is unavailable. You must add a reference to assembly '%s'.
    /// (Originally from FSComp.txt:994)
    static member impTypeRequiredUnavailable: a0: System.String * a1: System.String -> int * string
    /// A reference to the type '%s' in assembly '%s' was found, but the type could not be found in that assembly
    /// (Originally from FSComp.txt:995)
    static member impReferencedTypeCouldNotBeFoundInAssembly: a0: System.String * a1: System.String -> int * string
    /// Internal error or badly formed metadata: not enough type parameters were in scope while importing
    /// (Originally from FSComp.txt:996)
    static member impNotEnoughTypeParamsInScopeWhileImporting: unit -> int * string
    /// A reference to the DLL %s is required by assembly %s. The imported type %s is located in the first assembly and could not be resolved.
    /// (Originally from FSComp.txt:997)
    static member impReferenceToDllRequiredByAssembly: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// An imported assembly uses the type '%s' but that type is not public
    /// (Originally from FSComp.txt:998)
    static member impImportedAssemblyUsesNotPublicType: a0: System.String -> int * string
    /// The value '%s' was marked inline but its implementation makes use of an internal or private function which is not sufficiently accessible
    /// (Originally from FSComp.txt:999)
    static member optValueMarkedInlineButIncomplete: a0: System.String -> int * string
    /// The value '%s' was marked inline but was not bound in the optimization environment
    /// (Originally from FSComp.txt:1000)
    static member optValueMarkedInlineButWasNotBoundInTheOptEnv: a0: System.String -> int * string
    /// A value marked as 'inline' has an unexpected value
    /// (Originally from FSComp.txt:1001)
    static member optValueMarkedInlineHasUnexpectedValue: unit -> int * string
    /// A value marked as 'inline' could not be inlined
    /// (Originally from FSComp.txt:1002)
    static member optValueMarkedInlineCouldNotBeInlined: unit -> int * string
    /// Failed to inline the value '%s' marked 'inline', perhaps because a recursive value was marked 'inline'
    /// (Originally from FSComp.txt:1003)
    static member optFailedToInlineValue: a0: System.String -> int * string
    /// Recursive ValValue %s
    /// (Originally from FSComp.txt:1004)
    static member optRecursiveValValue: a0: System.String -> int * string
    /// The indentation of this 'in' token is incorrect with respect to the corresponding 'let'
    /// (Originally from FSComp.txt:1005)
    static member lexfltIncorrentIndentationOfIn: unit -> string
    /// Unexpected syntax or possible incorrect indentation: this token is offside of context started at position %s. Try indenting this further.\nTo continue using non-conforming indentation, pass the '--strict-indentation-' flag to the compiler, or set the language version to F# 7.
    /// (Originally from FSComp.txt:1006)
    static member lexfltTokenIsOffsideOfContextStartedEarlier: a0: System.String -> string
    /// The '|' tokens separating rules of this pattern match are misaligned by one column. Consider realigning your code or using further indentation.
    /// (Originally from FSComp.txt:1007)
    static member lexfltSeparatorTokensOfPatternMatchMisaligned: unit -> string
    /// Nested type definitions are not allowed. Types must be defined at module or namespace level.
    /// (Originally from FSComp.txt:1008)
    static member lexfltInvalidNestedTypeDefinition: unit -> string
    /// Modules cannot be nested inside types. Define modules at module or namespace level.
    /// (Originally from FSComp.txt:1009)
    static member lexfltInvalidNestedModule: unit -> string
    /// Exceptions must be defined at module level, not inside types.
    /// (Originally from FSComp.txt:1010)
    static member lexfltInvalidNestedExceptionDefinition: unit -> string
    /// 'open' declarations must appear at module level, not inside types.
    /// (Originally from FSComp.txt:1011)
    static member lexfltInvalidNestedOpenDeclaration: unit -> string
    /// '%s' must be defined at module level, not inside a type.
    /// (Originally from FSComp.txt:1012)
    static member lexfltInvalidNestedConstruct: a0: System.String -> string
    /// Invalid module/expression/type
    /// (Originally from FSComp.txt:1013)
    static member nrInvalidModuleExprType: unit -> int * string
    /// Multiple types exist called '%s', taking different numbers of generic parameters. Provide a type instantiation to disambiguate the type resolution, e.g. '%s'.
    /// (Originally from FSComp.txt:1014)
    static member nrTypeInstantiationNeededToDisambiguateTypesWithSameName: a0: System.String * a1: System.String -> int * string
    /// The instantiation of the generic type '%s' is missing and can't be inferred from the arguments or return type of this member. Consider providing a type instantiation when accessing this type, e.g. '%s'.
    /// (Originally from FSComp.txt:1015)
    static member nrTypeInstantiationIsMissingAndCouldNotBeInferred: a0: System.String * a1: System.String -> int * string
    /// 'global' may only be used as the first name in a qualified path
    /// (Originally from FSComp.txt:1016)
    static member nrGlobalUsedOnlyAsFirstName: unit -> int * string
    /// This is not a constructor or literal, or a constructor is being used incorrectly
    /// (Originally from FSComp.txt:1017)
    static member nrIsNotConstructorOrLiteral: unit -> int * string
    /// Unexpected empty long identifier
    /// (Originally from FSComp.txt:1018)
    static member nrUnexpectedEmptyLongId: unit -> int * string
    /// The record type '%s' does not contain a label '%s'.
    /// (Originally from FSComp.txt:1019)
    static member nrRecordDoesNotContainSuchLabel: a0: System.String * a1: System.String -> int * string
    /// Invalid field label
    /// (Originally from FSComp.txt:1020)
    static member nrInvalidFieldLabel: unit -> int * string
    /// Invalid expression '%s'
    /// (Originally from FSComp.txt:1021)
    static member nrInvalidExpression: a0: System.String -> int * string
    /// The union type for union case '%s' was defined with the RequireQualifiedAccessAttribute. Include the name of the union type ('%s') in the name you are using.
    /// (Originally from FSComp.txt:1022)
    static member nrUnionTypeNeedsQualifiedAccess: a0: System.String * a1: System.String -> int * string
    /// The record type for the record field '%s' was defined with the RequireQualifiedAccessAttribute. Include the name of the record type ('%s') in the name you are using.
    /// (Originally from FSComp.txt:1023)
    static member nrRecordTypeNeedsQualifiedAccess: a0: System.String * a1: System.String -> int * string
    /// Unexpected error creating debug information file '%s'
    /// (Originally from FSComp.txt:1024)
    static member ilwriteErrorCreatingPdb: a0: System.String -> int * string
    /// This number is outside the allowable range for this integer type
    /// (Originally from FSComp.txt:1025)
    static member lexOutsideIntegerRange: unit -> int * string
    /// '%s' is not permitted as a character in operator names and is reserved for future use
    /// (Originally from FSComp.txt:1029)
    static member lexCharNotAllowedInOperatorNames: a0: System.String -> string
    /// Unexpected character '%s'
    /// (Originally from FSComp.txt:1030)
    static member lexUnexpectedChar: a0: System.String -> string
    /// This byte array literal contains %d characters that do not encode as a single byte
    /// (Originally from FSComp.txt:1031)
    static member lexByteArrayCannotEncode: a0: System.Int32 -> int * string
    /// Identifiers followed by '%s' are reserved for future use
    /// (Originally from FSComp.txt:1032)
    static member lexIdentEndInMarkReserved: a0: System.String -> int * string
    /// This number is outside the allowable range for 8-bit signed integers
    /// (Originally from FSComp.txt:1033)
    static member lexOutsideEightBitSigned: unit -> int * string
    /// This number is outside the allowable range for hexadecimal 8-bit signed integers
    /// (Originally from FSComp.txt:1034)
    static member lexOutsideEightBitSignedHex: unit -> int * string
    /// This number is outside the allowable range for 8-bit unsigned integers
    /// (Originally from FSComp.txt:1035)
    static member lexOutsideEightBitUnsigned: unit -> int * string
    /// This number is outside the allowable range for 16-bit signed integers
    /// (Originally from FSComp.txt:1036)
    static member lexOutsideSixteenBitSigned: unit -> int * string
    /// This number is outside the allowable range for 16-bit unsigned integers
    /// (Originally from FSComp.txt:1037)
    static member lexOutsideSixteenBitUnsigned: unit -> int * string
    /// This number is outside the allowable range for 32-bit signed integers
    /// (Originally from FSComp.txt:1038)
    static member lexOutsideThirtyTwoBitSigned: unit -> int * string
    /// This number is outside the allowable range for 32-bit unsigned integers
    /// (Originally from FSComp.txt:1039)
    static member lexOutsideThirtyTwoBitUnsigned: unit -> int * string
    /// This number is outside the allowable range for 64-bit signed integers
    /// (Originally from FSComp.txt:1040)
    static member lexOutsideSixtyFourBitSigned: unit -> int * string
    /// This number is outside the allowable range for 64-bit unsigned integers
    /// (Originally from FSComp.txt:1041)
    static member lexOutsideSixtyFourBitUnsigned: unit -> int * string
    /// This number is outside the allowable range for signed native integers
    /// (Originally from FSComp.txt:1042)
    static member lexOutsideNativeSigned: unit -> int * string
    /// This number is outside the allowable range for unsigned native integers
    /// (Originally from FSComp.txt:1043)
    static member lexOutsideNativeUnsigned: unit -> int * string
    /// Invalid floating point number
    /// (Originally from FSComp.txt:1044)
    static member lexInvalidFloat: unit -> int * string
    /// This number is outside the allowable range for decimal literals
    /// (Originally from FSComp.txt:1045)
    static member lexOutsideDecimal: unit -> int * string
    /// This number is outside the allowable range for 32-bit floats
    /// (Originally from FSComp.txt:1046)
    static member lexOutsideThirtyTwoBitFloat: unit -> int * string
    /// This is not a valid numeric literal. Valid numeric literals include 1, 0x1, 0o1, 0b1, 1l (int/int32), 1u (uint/uint32), 1L (int64), 1UL (uint64), 1s (int16), 1us (uint16), 1y (int8/sbyte), 1uy (uint8/byte), 1.0 (float/double), 1.0f (float32/single), 1.0m (decimal), 1I (bigint).
    /// (Originally from FSComp.txt:1047)
    static member lexInvalidNumericLiteral: unit -> int * string
    /// This is not a valid byte character literal. The value must be less than or equal to '\127'B.
    /// (Originally from FSComp.txt:1048)
    static member lexInvalidAsciiByteLiteral: unit -> int * string
    /// This is not a valid byte character literal. The value must be less than or equal to '\127'B.\nNote: In a future F# version this warning will be promoted to an error.
    /// (Originally from FSComp.txt:1049)
    static member lexInvalidTrigraphAsciiByteLiteral: unit -> int * string
    /// This is not a valid character literal
    /// (Originally from FSComp.txt:1050)
    static member lexInvalidCharLiteral: unit -> int * string
    /// This Unicode encoding is only valid in string literals
    /// (Originally from FSComp.txt:1051)
    static member lexThisUnicodeOnlyInStringLiterals: unit -> int * string
    /// This token is reserved for future use
    /// (Originally from FSComp.txt:1052)
    static member lexTokenReserved: unit -> int * string
    /// TABs are not allowed in F# code unless the #indent \"off\" option is used
    /// (Originally from FSComp.txt:1053)
    static member lexTabsNotAllowed: unit -> int * string
    /// Invalid line number: '%s'
    /// (Originally from FSComp.txt:1054)
    static member lexInvalidLineNumber: a0: System.String -> int * string
    /// #if directive must appear as the first non-whitespace character on a line
    /// (Originally from FSComp.txt:1055)
    static member lexHashIfMustBeFirst: unit -> int * string
    /// #else has no matching #if
    /// (Originally from FSComp.txt:1056)
    static member lexHashElseNoMatchingIf: unit -> string
    /// #endif required for #else
    /// (Originally from FSComp.txt:1057)
    static member lexHashEndifRequiredForElse: unit -> string
    /// #else directive must appear as the first non-whitespace character on a line
    /// (Originally from FSComp.txt:1058)
    static member lexHashElseMustBeFirst: unit -> int * string
    /// #endif has no matching #if
    /// (Originally from FSComp.txt:1059)
    static member lexHashEndingNoMatchingIf: unit -> string
    /// #endif directive must appear as the first non-whitespace character on a line
    /// (Originally from FSComp.txt:1060)
    static member lexHashEndifMustBeFirst: unit -> int * string
    /// #if directive should be immediately followed by an identifier
    /// (Originally from FSComp.txt:1061)
    static member lexHashIfMustHaveIdent: unit -> int * string
    /// Syntax error. Wrong nested #endif, unexpected tokens before it.
    /// (Originally from FSComp.txt:1062)
    static member lexWrongNestedHashEndif: unit -> int * string
    /// #! may only appear as the first line at the start of a file.
    /// (Originally from FSComp.txt:1063)
    static member lexHashBangMustBeFirstInFile: unit -> string
    /// Expected single line comment or end of line
    /// (Originally from FSComp.txt:1064)
    static member pplexExpectedSingleLineComment: unit -> int * string
    /// Infix operator member '%s' has no arguments. Expected a tuple of 2 arguments, e.g. static member (+) (x,y) = ...
    /// (Originally from FSComp.txt:1065)
    static member memberOperatorDefinitionWithNoArguments: a0: System.String -> int * string
    /// Infix operator member '%s' has %d initial argument(s). Expected a tuple of 2 arguments, e.g. static member (+) (x,y) = ...
    /// (Originally from FSComp.txt:1066)
    static member memberOperatorDefinitionWithNonPairArgument: a0: System.String * a1: System.Int32 -> int * string
    /// Infix operator member '%s' has extra curried arguments. Expected a tuple of 2 arguments, e.g. static member (+) (x,y) = ...
    /// (Originally from FSComp.txt:1067)
    static member memberOperatorDefinitionWithCurriedArguments: a0: System.String -> int * string
    /// All record, union and struct types in FSharp.Core.dll must be explicitly labelled with 'StructuralComparison' or 'NoComparison'
    /// (Originally from FSComp.txt:1068)
    static member tcFSharpCoreRequiresExplicit: unit -> int * string
    /// The struct, record or union type '%s' has the 'StructuralComparison' attribute but the type parameter '%s' does not satisfy the 'comparison' constraint. Consider adding the 'comparison' constraint to the type parameter
    /// (Originally from FSComp.txt:1069)
    static member tcStructuralComparisonNotSatisfied1: a0: System.String * a1: System.String -> int * string
    /// The struct, record or union type '%s' has the 'StructuralComparison' attribute but the component type '%s' does not satisfy the 'comparison' constraint
    /// (Originally from FSComp.txt:1070)
    static member tcStructuralComparisonNotSatisfied2: a0: System.String * a1: System.String -> int * string
    /// The struct, record or union type '%s' is not structurally comparable because the type parameter %s does not satisfy the 'comparison' constraint. Consider adding the 'NoComparison' attribute to the type '%s' to clarify that the type is not comparable
    /// (Originally from FSComp.txt:1071)
    static member tcNoComparisonNeeded1: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The struct, record or union type '%s' is not structurally comparable because the type '%s' does not satisfy the 'comparison' constraint. Consider adding the 'NoComparison' attribute to the type '%s' to clarify that the type is not comparable
    /// (Originally from FSComp.txt:1072)
    static member tcNoComparisonNeeded2: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The struct, record or union type '%s' does not support structural equality because the type parameter %s does not satisfy the 'equality' constraint. Consider adding the 'NoEquality' attribute to the type '%s' to clarify that the type does not support structural equality
    /// (Originally from FSComp.txt:1073)
    static member tcNoEqualityNeeded1: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The struct, record or union type '%s' does not support structural equality because the type '%s' does not satisfy the 'equality' constraint. Consider adding the 'NoEquality' attribute to the type '%s' to clarify that the type does not support structural equality
    /// (Originally from FSComp.txt:1074)
    static member tcNoEqualityNeeded2: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The struct, record or union type '%s' has the 'StructuralEquality' attribute but the type parameter '%s' does not satisfy the 'equality' constraint. Consider adding the 'equality' constraint to the type parameter
    /// (Originally from FSComp.txt:1075)
    static member tcStructuralEqualityNotSatisfied1: a0: System.String * a1: System.String -> int * string
    /// The struct, record or union type '%s' has the 'StructuralEquality' attribute but the component type '%s' does not satisfy the 'equality' constraint
    /// (Originally from FSComp.txt:1076)
    static member tcStructuralEqualityNotSatisfied2: a0: System.String * a1: System.String -> int * string
    /// Each argument of the primary constructor for a struct must be given a type, for example 'type S(x1:int, x2: int) = ...'. These arguments determine the fields of the struct.
    /// (Originally from FSComp.txt:1077)
    static member tcStructsMustDeclareTypesOfImplicitCtorArgsExplicitly: unit -> int * string
    /// The value '%s' is unused
    /// (Originally from FSComp.txt:1078)
    static member chkUnusedValue: a0: System.String -> int * string
    /// The recursive object reference '%s' is unused. The presence of a recursive object reference adds runtime initialization checks to members in this and derived types. Consider removing this recursive object reference.
    /// (Originally from FSComp.txt:1079)
    static member chkUnusedThisVariable: a0: System.String -> int * string
    /// A getter property may have at most one argument group
    /// (Originally from FSComp.txt:1080)
    static member parsGetterAtMostOneArgument: unit -> int * string
    /// A setter property may have at most two argument groups
    /// (Originally from FSComp.txt:1081)
    static member parsSetterAtMostTwoArguments: unit -> int * string
    /// Invalid property getter or setter
    /// (Originally from FSComp.txt:1082)
    static member parsInvalidProperty: unit -> int * string
    /// An indexer property must be given at least one argument
    /// (Originally from FSComp.txt:1083)
    static member parsIndexerPropertyRequiresAtLeastOneArgument: unit -> int * string
    /// This operation accesses a mutable top-level value defined in another assembly in an unsupported way. The value cannot be accessed through its address. Consider copying the expression to a mutable local, e.g. 'let mutable x = ...', and if necessary assigning the value back after the completion of the operation
    /// (Originally from FSComp.txt:1084)
    static member tastInvalidAddressOfMutableAcrossAssemblyBoundary: unit -> int * string
    /// Remove spaces between the type name and type parameter, e.g. \"type C<'T>\", not type \"C   <'T>\". Type parameters must be placed directly adjacent to the type name.
    /// (Originally from FSComp.txt:1085)
    static member parsNonAdjacentTypars: unit -> int * string
    /// Remove spaces between the type name and type parameter, e.g. \"C<'T>\", not \"C <'T>\". Type parameters must be placed directly adjacent to the type name.
    /// (Originally from FSComp.txt:1086)
    static member parsNonAdjacentTyargs: unit -> int * string
    /// The use of the type syntax 'int C' and 'C  <int>' is not permitted here. Consider adjusting this type to be written in the form 'C<int>'
    /// (Originally from FSComp.txt:1087)
    static member parsNonAtomicType: unit -> string
    /// The module/namespace '%s' from compilation unit '%s' did not contain the module/namespace '%s'
    /// (Originally from FSComp.txt:1088)
    static member tastUndefinedItemRefModuleNamespace: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The module/namespace '%s' from compilation unit '%s' did not contain the val '%s'
    /// (Originally from FSComp.txt:1089)
    static member tastUndefinedItemRefVal: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The module/namespace '%s' from compilation unit '%s' did not contain the namespace, module or type '%s'
    /// (Originally from FSComp.txt:1090)
    static member tastUndefinedItemRefModuleNamespaceType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The 'UseNullAsTrueValue' attribute flag may only be used with union types that have one nullary case and at least one non-nullary case
    /// (Originally from FSComp.txt:1091)
    static member tcInvalidUseNullAsTrueValue: unit -> int * string
    /// The parameter '%s' was inferred to have byref type. Parameters of byref type must be given an explicit type annotation, e.g. 'x1: byref<int>'. When used, a byref parameter is implicitly dereferenced.
    /// (Originally from FSComp.txt:1092)
    static member tcParameterInferredByref: a0: System.String -> int * string
    /// The generic member '%s' has been used at a non-uniform instantiation prior to this program point. Consider reordering the members so this member occurs first. Alternatively, specify the full type of the member explicitly, including argument types, return type and any additional generic parameters and constraints.
    /// (Originally from FSComp.txt:1093)
    static member tcNonUniformMemberUse: a0: System.String -> int * string
    /// The attribute '%s' appears in both the implementation and the signature, but the attribute arguments differ. Only the attribute from the signature will be included in the compiled code.
    /// (Originally from FSComp.txt:1094)
    static member tcAttribArgsDiffer: a0: System.String -> int * string
    /// Cannot call an abstract base member: '%s'
    /// (Originally from FSComp.txt:1095)
    static member tcCannotCallAbstractBaseMember: a0: System.String -> int * string
    /// Could not resolve the ambiguity in the use of a generic construct with an 'unmanaged' constraint at or near this position
    /// (Originally from FSComp.txt:1096)
    static member typrelCannotResolveAmbiguityInUnmanaged: unit -> int * string
    /// This construct is for ML compatibility. %s. You can disable this warning by using '--mlcompatibility' or '--nowarn:62'.
    /// (Originally from FSComp.txt:1099)
    static member mlCompatMessage: a0: System.String -> string
    /// This construct is deprecated. %s. You can enable this feature by using '--langversion:5.0' and '--mlcompatibility'.
    /// (Originally from FSComp.txt:1100)
    static member mlCompatError: a0: System.String -> string
    /// In previous versions of F# '%s' was a reserved keyword but the use of this keyword is now deprecated
    /// (Originally from FSComp.txt:1101)
    static member mlCompatKeyword: a0: System.String -> string
    /// The use of '#light \"off\"' or '#indent \"off\"' was deprecated in F# 2.0 and is no longer supported
    /// (Originally from FSComp.txt:1102)
    static member mlCompatLightOffNoLongerSupported: unit -> string
    /// The use of 'module M: sig ... end ' was deprecated in F# 2.0 and is no longer supported. Change the ':' to an '=' and remove the 'sig' and 'end' and use indentation instead
    /// (Originally from FSComp.txt:1103)
    static member mlCompatSigColonNoLongerSupported: unit -> string
    /// The use of 'module M = sig ... end ' was deprecated in F# 2.0 and is no longer supported. Remove the 'sig' and 'end' and use indentation instead
    /// (Originally from FSComp.txt:1104)
    static member mlCompatSigEndNoLongerSupported: unit -> string
    /// The use of multiple parenthesized type parameters before a generic type name such as '(int, int) Map' was deprecated in F# 2.0 and is no longer supported
    /// (Originally from FSComp.txt:1105)
    static member mlCompatMultiPrefixTyparsNoLongerSupported: unit -> string
    /// The use of 'module M = struct ... end ' was deprecated in F# 2.0 and is no longer supported. Remove the 'struct' and 'end' and use indentation instead
    /// (Originally from FSComp.txt:1106)
    static member mlCompatStructEndNoLongerSupported: unit -> string
    /// The type '%s' has been marked as having an Explicit layout, but the field '%s' has not been marked with the 'FieldOffset' attribute
    /// (Originally from FSComp.txt:1107)
    static member ilFieldDoesNotHaveValidOffsetForStructureLayout: a0: System.String * a1: System.String -> int * string
    /// Interfaces inherited by other interfaces should be declared using 'inherit ...' instead of 'interface ...'
    /// (Originally from FSComp.txt:1108)
    static member tcInterfacesShouldUseInheritNotInterface: unit -> int * string
    /// Invalid prefix operator
    /// (Originally from FSComp.txt:1109)
    static member parsInvalidPrefixOperator: unit -> int * string
    /// Invalid operator definition. Prefix operator definitions must use a valid prefix operator name.
    /// (Originally from FSComp.txt:1110)
    static member parsInvalidPrefixOperatorDefinition: unit -> int * string
    /// The file extensions '.ml' and '.mli' are for ML compatibility
    /// (Originally from FSComp.txt:1111)
    static member buildCompilingExtensionIsForML: unit -> string
    /// Consider using a file with extension '.ml' or '.mli' instead
    /// (Originally from FSComp.txt:1112)
    static member lexIndentOffForML: unit -> string
    /// IF-FSHARP/IF-CAML regions are no longer supported
    /// (Originally from FSComp.txt:1113)
    static member lexIfOCaml: unit -> string
    /// Active pattern '%s' is not a function
    /// (Originally from FSComp.txt:1114)
    static member activePatternIdentIsNotFunctionTyped: a0: System.String -> int * string
    /// Active pattern '%s' has a result type containing type variables that are not determined by the input. The common cause is a when a result case is not mentioned, e.g. 'let (|A|B|) (x:int) = A x'. This can be fixed with a type constraint, e.g. 'let (|A|B|) (x:int) : Choice<int,unit> = A x'
    /// (Originally from FSComp.txt:1115)
    static member activePatternChoiceHasFreeTypars: a0: System.String -> int * string
    /// The FieldOffset attribute can only be placed on members of types marked with the StructLayout(LayoutKind.Explicit)
    /// (Originally from FSComp.txt:1116)
    static member ilFieldHasOffsetForSequentialLayout: unit -> int * string
    /// Optional arguments must come at the end of the argument list, after any non-optional arguments
    /// (Originally from FSComp.txt:1117)
    static member tcOptionalArgsMustComeAfterNonOptionalArgs: unit -> int * string
    /// Attribute 'System.Diagnostics.ConditionalAttribute' is only valid on methods or attribute classes
    /// (Originally from FSComp.txt:1118)
    static member tcConditionalAttributeUsage: unit -> int * string
    /// Extension members cannot provide operator overloads.  Consider defining the operator as part of the type definition instead.
    /// (Originally from FSComp.txt:1119)
    static member tcMemberOperatorDefinitionInExtrinsic: unit -> int * string
    /// The union case named '%s' conflicts with the generated type '%s'
    /// (Originally from FSComp.txt:1120)
    static member tcUnionCaseNameConflictsWithGeneratedType: a0: System.String * a1: System.String -> int * string
    /// ReflectedDefinitionAttribute may not be applied to an instance member on a struct type, because the instance member takes an implicit 'this' byref parameter
    /// (Originally from FSComp.txt:1121)
    static member chkNoReflectedDefinitionOnStructMember: unit -> int * string
    /// DLLImport bindings must be static members in a class or function definitions in a module
    /// (Originally from FSComp.txt:1122)
    static member tcDllImportNotAllowed: unit -> int * string
    /// FSharp.Core.sigdata not found alongside FSharp.Core. File expected in %s. Consider upgrading to a more recent version of FSharp.Core, where this file is no longer be required.
    /// (Originally from FSComp.txt:1123)
    static member buildExpectedSigdataFile: a0: System.String -> int * string
    /// File '%s' not found alongside FSharp.Core. File expected in %s. Consider upgrading to a more recent version of FSharp.Core, where this file is no longer be required.
    /// (Originally from FSComp.txt:1124)
    static member buildExpectedFileAlongSideFSharpCore: a0: System.String * a1: System.String -> int * string
    /// Filename '%s' contains invalid character '%s'
    /// (Originally from FSComp.txt:1125)
    static member buildUnexpectedFileNameCharacter: a0: System.String * a1: System.String -> int * string
    /// 'use!' bindings must be of the form 'use! <var> = <expr>'
    /// (Originally from FSComp.txt:1126)
    static member tcInvalidUseBangBinding: unit -> int * string
    /// Inner generic functions are not permitted in quoted expressions. Consider adding some type constraints until this function is no longer generic.
    /// (Originally from FSComp.txt:1127)
    static member crefNoInnerGenericsInQuotations: unit -> int * string
    /// The type '%s' is not a valid enumerator type , i.e. does not have a 'MoveNext()' method returning a bool, and a 'Current' property
    /// (Originally from FSComp.txt:1128)
    static member tcEnumTypeCannotBeEnumerated: a0: System.String -> int * string
    /// End of file in triple-quote string begun at or before here
    /// (Originally from FSComp.txt:1129)
    static member parsEofInTripleQuoteString: unit -> int * string
    /// End of file in triple-quote string embedded in comment begun at or before here
    /// (Originally from FSComp.txt:1130)
    static member parsEofInTripleQuoteStringInComment: unit -> int * string
    /// This type test or downcast will ignore the unit-of-measure '%s'
    /// (Originally from FSComp.txt:1131)
    static member tcTypeTestLosesMeasures: a0: System.String -> int * string
    /// Expected type argument or static argument
    /// (Originally from FSComp.txt:1132)
    static member parsMissingTypeArgs: unit -> int * string
    /// Unmatched '<'. Expected closing '>'
    /// (Originally from FSComp.txt:1133)
    static member parsMissingGreaterThan: unit -> int * string
    /// Unexpected quotation operator '<@' in type definition. If you intend to pass a verbatim string as a static argument to a type provider, put a space between the '<' and '@' characters.
    /// (Originally from FSComp.txt:1134)
    static member parsUnexpectedQuotationOperatorInTypeAliasDidYouMeanVerbatimString: unit -> int * string
    /// Attempted to parse this as an operator name, but failed
    /// (Originally from FSComp.txt:1135)
    static member parsErrorParsingAsOperatorName: unit -> int * string
    /// \U%s is not a valid Unicode character escape sequence
    /// (Originally from FSComp.txt:1136)
    static member lexInvalidUnicodeLiteral: a0: System.String -> int * string
    /// '%s' must be applied to an argument of type '%s', but has been applied to an argument of type '%s'
    /// (Originally from FSComp.txt:1137)
    static member tcCallerInfoWrongType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// '%s' can only be applied to optional arguments
    /// (Originally from FSComp.txt:1138)
    static member tcCallerInfoNotOptional: a0: System.String -> int * string
    /// The interpolated triple quoted string literal does not start with enough '$' characters to allow this many consecutive opening braces as content.
    /// (Originally from FSComp.txt:1139)
    static member lexTooManyLBracesInTripleQuote: unit -> int * string
    /// The interpolated string contains unmatched closing braces.
    /// (Originally from FSComp.txt:1140)
    static member lexUnmatchedRBracesInTripleQuote: unit -> int * string
    /// The interpolated triple quoted string literal does not start with enough '$' characters to allow this many consecutive '%%' characters.
    /// (Originally from FSComp.txt:1141)
    static member lexTooManyPercentsInTripleQuote: unit -> int * string
    /// Extended string interpolation is not supported in this version of F#.
    /// (Originally from FSComp.txt:1142)
    static member lexExtendedStringInterpolationNotSupported: unit -> int * string
    /// '%s' is not a valid character literal.\nNote: Currently the value is wrapped around byte range to '%s'. In a future F# version this warning will be promoted to an error.
    /// (Originally from FSComp.txt:1143)
    static member lexInvalidCharLiteralInString: a0: System.String * a1: System.String -> int * string
    /// This byte array literal contains %d non-ASCII characters. All characters should be < 128y.
    /// (Originally from FSComp.txt:1144)
    static member lexByteArrayOutisdeAscii: a0: System.Int32 -> int * string
    /// The specified .NET Framework version '%s' is not supported. Please specify a value from the enumeration Microsoft.Build.Utilities.TargetDotNetFrameworkVersion.
    /// (Originally from FSComp.txt:1146)
    static member toolLocationHelperUnsupportedFrameworkVersion: a0: System.String -> int * string
    /// Invalid Magic value in CLR Header
    /// (Originally from FSComp.txt:1150)
    static member ilSignInvalidMagicValue: unit -> int * string
    /// Bad image format
    /// (Originally from FSComp.txt:1151)
    static member ilSignBadImageFormat: unit -> int * string
    /// Private key expected
    /// (Originally from FSComp.txt:1152)
    static member ilSignPrivateKeyExpected: unit -> int * string
    /// RSA key expected
    /// (Originally from FSComp.txt:1153)
    static member ilSignRsaKeyExpected: unit -> int * string
    /// Invalid bit Length
    /// (Originally from FSComp.txt:1154)
    static member ilSignInvalidBitLen: unit -> int * string
    /// Invalid RSAParameters structure - '{0}' expected
    /// (Originally from FSComp.txt:1155)
    static member ilSignInvalidRSAParams: unit -> int * string
    /// Invalid algId - 'Exponent' expected
    /// (Originally from FSComp.txt:1156)
    static member ilSignInvalidAlgId: unit -> int * string
    /// Invalid signature size
    /// (Originally from FSComp.txt:1157)
    static member ilSignInvalidSignatureSize: unit -> int * string
    /// No signature directory
    /// (Originally from FSComp.txt:1158)
    static member ilSignNoSignatureDirectory: unit -> int * string
    /// Invalid Public Key blob
    /// (Originally from FSComp.txt:1159)
    static member ilSignInvalidPKBlob: unit -> int * string
    /// Exiting - too many errors
    /// (Originally from FSComp.txt:1161)
    static member fscTooManyErrors: unit -> string
    /// The documentation file has no .xml suffix
    /// (Originally from FSComp.txt:1162)
    static member docfileNoXmlSuffix: unit -> int * string
    /// No implementation files specified
    /// (Originally from FSComp.txt:1163)
    static member fscNoImplementationFiles: unit -> int * string
    /// The attribute %s specified version '%s', but this value is invalid and has been ignored
    /// (Originally from FSComp.txt:1164)
    static member fscBadAssemblyVersion: a0: System.String * a1: System.String -> int * string
    /// Conflicting options specified: 'win32manifest' and 'win32res'. Only one of these can be used.
    /// (Originally from FSComp.txt:1165)
    static member fscTwoResourceManifests: unit -> int * string
    /// The code in assembly '%s' makes uses of quotation literals. Static linking may not include components that make use of quotation literals unless all assemblies are compiled with at least F# 4.0.
    /// (Originally from FSComp.txt:1166)
    static member fscQuotationLiteralsStaticLinking: a0: System.String -> int * string
    /// Code in this assembly makes uses of quotation literals. Static linking may not include components that make use of quotation literals unless all assemblies are compiled with at least F# 4.0.
    /// (Originally from FSComp.txt:1167)
    static member fscQuotationLiteralsStaticLinking0: unit -> int * string
    /// Static linking may not include a .EXE
    /// (Originally from FSComp.txt:1168)
    static member fscStaticLinkingNoEXE: unit -> int * string
    /// Static linking may not include a mixed managed/unmanaged DLL
    /// (Originally from FSComp.txt:1169)
    static member fscStaticLinkingNoMixedDLL: unit -> int * string
    /// Ignoring mixed managed/unmanaged assembly '%s' during static linking
    /// (Originally from FSComp.txt:1170)
    static member fscIgnoringMixedWhenLinking: a0: System.String -> int * string
    /// Assembly '%s' was referenced transitively and the assembly could not be resolved automatically. Static linking will assume this DLL has no dependencies on the F# library or other statically linked DLLs. Consider adding an explicit reference to this DLL.
    /// (Originally from FSComp.txt:1171)
    static member fscAssumeStaticLinkContainsNoDependencies: a0: System.String -> int * string
    /// Assembly '%s' not found in dependency set of target binary. Statically linked roots should be specified using an assembly name, without a DLL or EXE extension. If this assembly was referenced explicitly then it is possible the assembly was not actually required by the generated binary, in which case it should not be statically linked.
    /// (Originally from FSComp.txt:1172)
    static member fscAssemblyNotFoundInDependencySet: a0: System.String -> int * string
    /// The key file '%s' could not be opened
    /// (Originally from FSComp.txt:1173)
    static member fscKeyFileCouldNotBeOpened: a0: System.String -> int * string
    /// A problem occurred writing the binary '%s': %s
    /// (Originally from FSComp.txt:1174)
    static member fscProblemWritingBinary: a0: System.String * a1: System.String -> int * string
    /// The 'AssemblyVersionAttribute' has been ignored because a version was given using a command line option
    /// (Originally from FSComp.txt:1175)
    static member fscAssemblyVersionAttributeIgnored: unit -> int * string
    /// Error emitting 'System.Reflection.AssemblyCultureAttribute' attribute -- 'Executables cannot be satellite assemblies, Culture should always be empty'
    /// (Originally from FSComp.txt:1176)
    static member fscAssemblyCultureAttributeError: unit -> int * string
    /// Option '--delaysign' overrides attribute 'System.Reflection.AssemblyDelaySignAttribute' given in a source file or added module
    /// (Originally from FSComp.txt:1177)
    static member fscDelaySignWarning: unit -> int * string
    /// Option '--keyfile' overrides attribute 'System.Reflection.AssemblyKeyFileAttribute' given in a source file or added module
    /// (Originally from FSComp.txt:1178)
    static member fscKeyFileWarning: unit -> int * string
    /// Option '--keycontainer' overrides attribute 'System.Reflection.AssemblyNameAttribute' given in a source file or added module
    /// (Originally from FSComp.txt:1179)
    static member fscKeyNameWarning: unit -> int * string
    /// The assembly '%s' is listed on the command line. Assemblies should be referenced using a command line flag such as '-r'.
    /// (Originally from FSComp.txt:1180)
    static member fscReferenceOnCommandLine: a0: System.String -> int * string
    /// The resident compilation service was not used because a problem occurred in communicating with the server.
    /// (Originally from FSComp.txt:1181)
    static member fscRemotingError: unit -> int * string
    /// Problem with filename '%s': Illegal characters in path.
    /// (Originally from FSComp.txt:1182)
    static member pathIsInvalid: a0: System.String -> int * string
    /// Passing a .resx file (%s) as a source file to the compiler is deprecated. Use resgen.exe to transform the .resx file into a .resources file to pass as a --resource option. If you are using MSBuild, this can be done via an <EmbeddedResource> item in the .fsproj project file.
    /// (Originally from FSComp.txt:1183)
    static member fscResxSourceFileDeprecated: a0: System.String -> int * string
    /// Static linking may not be used on an assembly referencing mscorlib (e.g. a .NET Framework assembly) when generating an assembly that references System.Runtime (e.g. a .NET Core or Portable assembly).
    /// (Originally from FSComp.txt:1184)
    static member fscStaticLinkingNoProfileMismatches: unit -> int * string
    /// An %s specified version '%s', but this value is a wildcard, and you have requested a deterministic build, these are in conflict.
    /// (Originally from FSComp.txt:1185)
    static member fscAssemblyWildcardAndDeterminism: a0: System.String * a1: System.String -> int * string
    /// Invalid path map. Mappings must be comma separated and of the format 'path=sourcePath'
    /// (Originally from FSComp.txt:1186)
    static member optsInvalidPathMapFormat: unit -> int * string
    /// Invalid reference assembly path'
    /// (Originally from FSComp.txt:1187)
    static member optsInvalidRefOut: unit -> int * string
    /// Invalid use of emitting a reference assembly, do not use '--standalone or --staticlink' with '--refonly or --refout'.
    /// (Originally from FSComp.txt:1188)
    static member optsInvalidRefAssembly: unit -> int * string
    /// Character '%s' is not allowed in provided namespace name '%s'
    /// (Originally from FSComp.txt:1189)
    static member etIllegalCharactersInNamespaceName: a0: System.String * a1: System.String -> int * string
    /// The provided type '%s' returned a member with a null or empty member name
    /// (Originally from FSComp.txt:1190)
    static member etNullOrEmptyMemberName: a0: System.String -> int * string
    /// The provided type '%s' returned a null member
    /// (Originally from FSComp.txt:1191)
    static member etNullMember: a0: System.String -> int * string
    /// The provided type '%s' member info '%s' has null declaring type
    /// (Originally from FSComp.txt:1192)
    static member etNullMemberDeclaringType: a0: System.String * a1: System.String -> int * string
    /// The provided type '%s' has member '%s' which has declaring type '%s'. Expected declaring type to be the same as provided type.
    /// (Originally from FSComp.txt:1193)
    static member etNullMemberDeclaringTypeDifferentFromProvidedType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Referenced assembly '%s' has assembly level attribute '%s' but no public type provider classes were found
    /// (Originally from FSComp.txt:1194)
    static member etHostingAssemblyFoundWithoutHosts: a0: System.String * a1: System.String -> int * string
    /// Type '%s' from type provider '%s' has an empty namespace. Use 'null' for the global namespace.
    /// (Originally from FSComp.txt:1195)
    static member etEmptyNamespaceOfTypeNotAllowed: a0: System.String * a1: System.String -> int * string
    /// Empty namespace found from the type provider '%s'. Use 'null' for the global namespace.
    /// (Originally from FSComp.txt:1196)
    static member etEmptyNamespaceNotAllowed: a0: System.String -> int * string
    /// Provided type '%s' has 'IsGenericType' as true, but generic types are not supported.
    /// (Originally from FSComp.txt:1197)
    static member etMustNotBeGeneric: a0: System.String -> int * string
    /// Provided type '%s' has 'IsArray' as true, but array types are not supported.
    /// (Originally from FSComp.txt:1198)
    static member etMustNotBeAnArray: a0: System.String -> int * string
    /// Invalid member '%s' on provided type '%s'. Provided type members must be public, and not be generic, virtual, or abstract.
    /// (Originally from FSComp.txt:1199)
    static member etMethodHasRequirements: a0: System.String * a1: System.String -> int * string
    /// Invalid member '%s' on provided type '%s'. Only properties, methods and constructors are allowed
    /// (Originally from FSComp.txt:1200)
    static member etUnsupportedMemberKind: a0: System.String * a1: System.String -> int * string
    /// Property '%s' on provided type '%s' has CanRead=true but there was no value from GetGetMethod()
    /// (Originally from FSComp.txt:1201)
    static member etPropertyCanReadButHasNoGetter: a0: System.String * a1: System.String -> int * string
    /// Property '%s' on provided type '%s' has CanRead=false but GetGetMethod() returned a method
    /// (Originally from FSComp.txt:1202)
    static member etPropertyHasGetterButNoCanRead: a0: System.String * a1: System.String -> int * string
    /// Property '%s' on provided type '%s' has CanWrite=true but there was no value from GetSetMethod()
    /// (Originally from FSComp.txt:1203)
    static member etPropertyCanWriteButHasNoSetter: a0: System.String * a1: System.String -> int * string
    /// Property '%s' on provided type '%s' has CanWrite=false but GetSetMethod() returned a method
    /// (Originally from FSComp.txt:1204)
    static member etPropertyHasSetterButNoCanWrite: a0: System.String * a1: System.String -> int * string
    /// One or more errors seen during provided type setup
    /// (Originally from FSComp.txt:1205)
    static member etOneOrMoreErrorsSeenDuringExtensionTypeSetting: unit -> int * string
    /// Unexpected exception from provided type '%s' member '%s': %s
    /// (Originally from FSComp.txt:1206)
    static member etUnexpectedExceptionFromProvidedTypeMember: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Unsupported constant type '%s'. Quotations provided by type providers can only contain simple constants. The implementation of the type provider may need to be adjusted by moving a value declared outside a provided quotation literal to be a 'let' binding inside the quotation literal.
    /// (Originally from FSComp.txt:1207)
    static member etUnsupportedConstantType: a0: System.String -> int * string
    /// Unsupported expression '%s' from type provider. If you are the author of this type provider, consider adjusting it to provide a different provided expression.
    /// (Originally from FSComp.txt:1208)
    static member etUnsupportedProvidedExpression: a0: System.String -> int * string
    /// Expected provided type named '%s' but provided type has 'Name' with value '%s'
    /// (Originally from FSComp.txt:1209)
    static member etProvidedTypeHasUnexpectedName: a0: System.String * a1: System.String -> int * string
    /// Event '%s' on provided type '%s' has no value from GetAddMethod()
    /// (Originally from FSComp.txt:1210)
    static member etEventNoAdd: a0: System.String * a1: System.String -> int * string
    /// Event '%s' on provided type '%s' has no value from GetRemoveMethod()
    /// (Originally from FSComp.txt:1211)
    static member etEventNoRemove: a0: System.String * a1: System.String -> int * string
    /// Assembly attribute '%s' refers to a designer assembly '%s' which cannot be loaded or doesn't exist. The exception reported was: %s - %s
    /// (Originally from FSComp.txt:1212)
    static member etProviderHasWrongDesignerAssemblyNoPath: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// Assembly attribute '%s' refers to a designer assembly '%s' which cannot be loaded from path '%s'. The exception reported was: %s - %s
    /// (Originally from FSComp.txt:1213)
    static member etProviderHasWrongDesignerAssembly: a0: System.String * a1: System.String * a2: System.String * a3: System.String * a4: System.String -> int * string
    /// The type provider does not have a valid constructor. A constructor taking either no arguments or one argument of type 'TypeProviderConfig' was expected.
    /// (Originally from FSComp.txt:1214)
    static member etProviderDoesNotHaveValidConstructor: unit -> int * string
    /// The type provider '%s' reported an error: %s
    /// (Originally from FSComp.txt:1215)
    static member etProviderError: a0: System.String * a1: System.String -> int * string
    /// The type provider '%s' used an invalid parameter in the ParameterExpression: %s
    /// (Originally from FSComp.txt:1216)
    static member etIncorrectParameterExpression: a0: System.String * a1: System.String -> int * string
    /// The type provider '%s' provided a method with a name '%s' and metadata token '%d', which is not reported among its methods of its declaring type '%s'
    /// (Originally from FSComp.txt:1217)
    static member etIncorrectProvidedMethod: a0: System.String * a1: System.String * a2: System.Int32 * a3: System.String -> int * string
    /// The type provider '%s' provided a constructor which is not reported among the constructors of its declaring type '%s'
    /// (Originally from FSComp.txt:1218)
    static member etIncorrectProvidedConstructor: a0: System.String * a1: System.String -> int * string
    /// A direct reference to the generated type '%s' is not permitted. Instead, use a type definition, e.g. 'type TypeAlias = <path>'. This indicates that a type provider adds generated types to your assembly.
    /// (Originally from FSComp.txt:1219)
    static member etDirectReferenceToGeneratedTypeNotAllowed: a0: System.String -> int * string
    /// Expected provided type with path '%s' but provided type has path '%s'
    /// (Originally from FSComp.txt:1220)
    static member etProvidedTypeHasUnexpectedPath: a0: System.String * a1: System.String -> int * string
    /// Unexpected 'null' return value from provided type '%s' member '%s'
    /// (Originally from FSComp.txt:1221)
    static member etUnexpectedNullFromProvidedTypeMember: a0: System.String * a1: System.String -> int * string
    /// Unexpected exception from member '%s' of provided type '%s' member '%s': %s
    /// (Originally from FSComp.txt:1222)
    static member etUnexpectedExceptionFromProvidedMemberMember: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// Nested provided types do not take static arguments or generic parameters
    /// (Originally from FSComp.txt:1223)
    static member etNestedProvidedTypesDoNotTakeStaticArgumentsOrGenericParameters: unit -> int * string
    /// Invalid static argument to provided type. Expected an argument of kind '%s'.
    /// (Originally from FSComp.txt:1224)
    static member etInvalidStaticArgument: a0: System.String -> int * string
    /// An error occurred applying the static arguments to a provided type
    /// (Originally from FSComp.txt:1225)
    static member etErrorApplyingStaticArgumentsToType: unit -> int * string
    /// Unknown static argument kind '%s' when resolving a reference to a provided type or method '%s'
    /// (Originally from FSComp.txt:1226)
    static member etUnknownStaticArgumentKind: a0: System.String * a1: System.String -> int * string
    /// The type provider designer assembly '%s' could not be loaded from folder '%s' because a dependency was missing or could not loaded. All dependencies of the type provider designer assembly must be located in the same folder as that assembly. The exception reported was: %s - %s
    /// (Originally from FSComp.txt:1227)
    static member etProviderHasDesignerAssemblyDependency: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// The type provider designer assembly '%s' could not be loaded from folder '%s'. The exception reported was: %s - %s
    /// (Originally from FSComp.txt:1228)
    static member etProviderHasDesignerAssemblyException: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// invalid namespace for provided type
    /// (Originally from FSComp.txt:1229)
    static member invalidNamespaceForProvidedType: unit -> string
    /// invalid full name for provided type
    /// (Originally from FSComp.txt:1230)
    static member invalidFullNameForProvidedType: unit -> string
    /// The type provider returned 'null', which is not a valid return value from '%s'
    /// (Originally from FSComp.txt:1231)
    static member etProviderReturnedNull: a0: System.String -> int * string
    /// The type provider constructor has thrown an exception: %s
    /// (Originally from FSComp.txt:1232)
    static member etTypeProviderConstructorException: a0: System.String -> int * string
    /// Type provider '%s' returned null from GetInvokerExpression.
    /// (Originally from FSComp.txt:1233)
    static member etNullProvidedExpression: a0: System.String -> int * string
    /// The type provider '%s' returned an invalid type from 'ApplyStaticArguments'. A type with name '%s' was expected, but a type with name '%s' was returned.
    /// (Originally from FSComp.txt:1234)
    static member etProvidedAppliedTypeHadWrongName: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The type provider '%s' returned an invalid method from 'ApplyStaticArgumentsForMethod'. A method with name '%s' was expected, but a method with name '%s' was returned.
    /// (Originally from FSComp.txt:1235)
    static member etProvidedAppliedMethodHadWrongName: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// This type test or downcast will erase the provided type '%s' to the type '%s'
    /// (Originally from FSComp.txt:1236)
    static member tcTypeTestLossy: a0: System.String * a1: System.String -> int * string
    /// This downcast will erase the provided type '%s' to the type '%s'.
    /// (Originally from FSComp.txt:1237)
    static member tcTypeCastErased: a0: System.String * a1: System.String -> int * string
    /// This type test with a provided type '%s' is not allowed because this provided type will be erased to '%s' at runtime.
    /// (Originally from FSComp.txt:1238)
    static member tcTypeTestErased: a0: System.String * a1: System.String -> int * string
    /// Cannot inherit from erased provided type
    /// (Originally from FSComp.txt:1239)
    static member tcCannotInheritFromErasedType: unit -> int * string
    /// Assembly '%s' has TypeProviderAssembly attribute with invalid value '%s'. The value should be a valid assembly name
    /// (Originally from FSComp.txt:1240)
    static member etInvalidTypeProviderAssemblyName: a0: System.String * a1: System.String -> int * string
    /// Invalid member name. Members may not have name '.ctor' or '.cctor'
    /// (Originally from FSComp.txt:1241)
    static member tcInvalidMemberNameCtor: unit -> int * string
    /// The function or member '%s' is used in a way that requires further type annotations at its definition to ensure consistency of inferred types. The inferred signature is '%s'.
    /// (Originally from FSComp.txt:1242)
    static member tcInferredGenericTypeGivesRiseToInconsistency: a0: System.String * a1: System.String -> int * string
    /// The number of type arguments did not match: '%d' given, '%d' expected. This may be related to a previously reported error.
    /// (Originally from FSComp.txt:1243)
    static member tcInvalidTypeArgumentCount: a0: System.Int32 * a1: System.Int32 -> int * string
    /// Cannot override inherited member '%s' because it is sealed
    /// (Originally from FSComp.txt:1244)
    static member tcCannotOverrideSealedMethod: a0: System.String -> int * string
    /// The type provider '%s' reported an error in the context of provided type '%s', member '%s'. The error: %s
    /// (Originally from FSComp.txt:1245)
    static member etProviderErrorWithContext: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// An exception occurred when accessing the '%s' of a provided type: %s
    /// (Originally from FSComp.txt:1246)
    static member etProvidedTypeWithNameException: a0: System.String * a1: System.String -> int * string
    /// The '%s' of a provided type was null or empty.
    /// (Originally from FSComp.txt:1247)
    static member etProvidedTypeWithNullOrEmptyName: a0: System.String -> int * string
    /// Character '%s' is not allowed in provided type name '%s'
    /// (Originally from FSComp.txt:1248)
    static member etIllegalCharactersInTypeName: a0: System.String * a1: System.String -> int * string
    /// In queries, '%s' must use a simple pattern
    /// (Originally from FSComp.txt:1249)
    static member tcJoinMustUseSimplePattern: a0: System.String -> int * string
    /// A custom query operation for '%s' is required but not specified
    /// (Originally from FSComp.txt:1250)
    static member tcMissingCustomOperation: a0: System.String -> int * string
    /// Named static arguments must come after all unnamed static arguments
    /// (Originally from FSComp.txt:1251)
    static member etBadUnnamedStaticArgs: unit -> int * string
    /// The static parameter '%s' of the provided type or method '%s' requires a value. Static parameters to type providers may be optionally specified using named arguments, e.g. '%s<%s=...>'.
    /// (Originally from FSComp.txt:1252)
    static member etStaticParameterRequiresAValue: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// No static parameter exists with name '%s'
    /// (Originally from FSComp.txt:1253)
    static member etNoStaticParameterWithName: a0: System.String -> int * string
    /// The static parameter '%s' has already been given a value
    /// (Originally from FSComp.txt:1254)
    static member etStaticParameterAlreadyHasValue: a0: System.String -> int * string
    /// Multiple static parameters exist with name '%s'
    /// (Originally from FSComp.txt:1255)
    static member etMultipleStaticParameterWithName: a0: System.String -> int * string
    /// A custom operation may not be used in conjunction with a non-value or recursive 'let' binding in another part of this computation expression
    /// (Originally from FSComp.txt:1256)
    static member tcCustomOperationMayNotBeUsedInConjunctionWithNonSimpleLetBindings: unit -> int * string
    /// A custom operation may not be used in conjunction with 'use', 'try/with', 'try/finally', 'if/then/else' or 'match' operators within this computation expression
    /// (Originally from FSComp.txt:1257)
    static member tcCustomOperationMayNotBeUsedHere: unit -> int * string
    /// The custom operation '%s' refers to a method which is overloaded. The implementations of custom operations may not be overloaded.
    /// (Originally from FSComp.txt:1258)
    static member tcCustomOperationMayNotBeOverloaded: a0: System.String -> int * string
    /// overloads for custom operations
    /// (Originally from FSComp.txt:1259)
    static member featureOverloadsForCustomOperations: unit -> string
    /// more types support units of measure
    /// (Originally from FSComp.txt:1260)
    static member featureExpandedMeasurables: unit -> string
    /// binary formatting for integers
    /// (Originally from FSComp.txt:1261)
    static member featurePrintfBinaryFormat: unit -> string
    /// expr[idx] notation for indexing and slicing
    /// (Originally from FSComp.txt:1262)
    static member featureIndexerNotationWithoutDot: unit -> string
    /// informational messages related to reference cells
    /// (Originally from FSComp.txt:1263)
    static member featureRefCellNotationInformationals: unit -> string
    /// discard pattern in use binding
    /// (Originally from FSComp.txt:1264)
    static member featureDiscardUseValue: unit -> string
    /// non-variable patterns to the right of 'as' patterns
    /// (Originally from FSComp.txt:1265)
    static member featureNonVariablePatternsToRightOfAsPatterns: unit -> string
    /// attributes to the right of the 'module' keyword
    /// (Originally from FSComp.txt:1266)
    static member featureAttributesToRightOfModuleKeyword: unit -> string
    /// ML compatibility revisions
    /// (Originally from FSComp.txt:1267)
    static member featureMLCompatRevisions: unit -> string
    /// automatic generation of 'Message' property for 'exception' declarations
    /// (Originally from FSComp.txt:1268)
    static member featureBetterExceptionPrinting: unit -> string
    /// fix to resolution of delegate type names, see https://github.com/dotnet/fsharp/issues/10228
    /// (Originally from FSComp.txt:1269)
    static member featureDelegateTypeNameResolutionFix: unit -> string
    /// An if/then/else expression may not be used within queries. Consider using either an if/then expression, or use a sequence expression instead.
    /// (Originally from FSComp.txt:1270)
    static member tcIfThenElseMayNotBeUsedWithinQueries: unit -> int * string
    /// Invalid argument to 'methodhandleof' during codegen
    /// (Originally from FSComp.txt:1271)
    static member ilxgenUnexpectedArgumentToMethodHandleOfDuringCodegen: unit -> int * string
    /// A reference to a provided type was missing a value for the static parameter '%s'. You may need to recompile one or more referenced assemblies.
    /// (Originally from FSComp.txt:1272)
    static member etProvidedTypeReferenceMissingArgument: a0: System.String -> int * string
    /// A reference to a provided type had an invalid value '%s' for a static parameter. You may need to recompile one or more referenced assemblies.
    /// (Originally from FSComp.txt:1273)
    static member etProvidedTypeReferenceInvalidText: a0: System.String -> int * string
    /// '%s' is not used correctly. This is a custom operation in this query or computation expression.
    /// (Originally from FSComp.txt:1274)
    static member tcCustomOperationNotUsedCorrectly: a0: System.String -> int * string
    /// '%s' is not used correctly. Usage: %s. This is a custom operation in this query or computation expression.
    /// (Originally from FSComp.txt:1275)
    static member tcCustomOperationNotUsedCorrectly2: a0: System.String * a1: System.String -> int * string
    /// %s var in collection %s (outerKey = innerKey). Note that parentheses are required after '%s'
    /// (Originally from FSComp.txt:1276)
    static member customOperationTextLikeJoin: a0: System.String * a1: System.String * a2: System.String -> string
    /// %s var in collection %s (outerKey = innerKey) into group. Note that parentheses are required after '%s'
    /// (Originally from FSComp.txt:1277)
    static member customOperationTextLikeGroupJoin: a0: System.String * a1: System.String * a2: System.String -> string
    /// %s var in collection
    /// (Originally from FSComp.txt:1278)
    static member customOperationTextLikeZip: a0: System.String -> string
    /// '%s' must be followed by a variable name. Usage: %s.
    /// (Originally from FSComp.txt:1279)
    static member tcBinaryOperatorRequiresVariable: a0: System.String * a1: System.String -> int * string
    /// Incorrect syntax for '%s'. Usage: %s.
    /// (Originally from FSComp.txt:1280)
    static member tcOperatorIncorrectSyntax: a0: System.String * a1: System.String -> int * string
    /// '%s' must come after a 'for' selection clause and be followed by the rest of the query. Syntax: ... %s ...
    /// (Originally from FSComp.txt:1281)
    static member tcBinaryOperatorRequiresBody: a0: System.String * a1: System.String -> int * string
    /// '%s' is used with an incorrect number of arguments. This is a custom operation in this query or computation expression. Expected %d argument(s), but given %d.
    /// (Originally from FSComp.txt:1282)
    static member tcCustomOperationHasIncorrectArgCount: a0: System.String * a1: System.Int32 * a2: System.Int32 -> int * string
    /// Expected an expression after this point
    /// (Originally from FSComp.txt:1283)
    static member parsExpectedExpressionAfterToken: unit -> int * string
    /// Expected a type after this point
    /// (Originally from FSComp.txt:1284)
    static member parsExpectedTypeAfterToken: unit -> int * string
    /// Unmatched '[<'. Expected closing '>]'
    /// (Originally from FSComp.txt:1285)
    static member parsUnmatchedLBrackLess: unit -> int * string
    /// Unexpected end of input in 'match' expression. Expected 'match <expr> with | <pat> -> <expr> | <pat> -> <expr> ...'.
    /// (Originally from FSComp.txt:1286)
    static member parsUnexpectedEndOfFileMatch: unit -> int * string
    /// Unexpected end of input in 'try' expression. Expected 'try <expr> with <rules>' or 'try <expr> finally <expr>'.
    /// (Originally from FSComp.txt:1287)
    static member parsUnexpectedEndOfFileTry: unit -> int * string
    /// Unexpected end of input in 'while' expression. Expected 'while <expr> do <expr>'.
    /// (Originally from FSComp.txt:1288)
    static member parsUnexpectedEndOfFileWhile: unit -> int * string
    /// Unexpected end of input in 'for' expression. Expected 'for <pat> in <expr> do <expr>'.
    /// (Originally from FSComp.txt:1289)
    static member parsUnexpectedEndOfFileFor: unit -> int * string
    /// Unexpected end of input in 'match' or 'try' expression
    /// (Originally from FSComp.txt:1290)
    static member parsUnexpectedEndOfFileWith: unit -> int * string
    /// Unexpected end of input in 'then' branch of conditional expression. Expected 'if <expr> then <expr>' or 'if <expr> then <expr> else <expr>'.
    /// (Originally from FSComp.txt:1291)
    static member parsUnexpectedEndOfFileThen: unit -> int * string
    /// Unexpected end of input in 'else' branch of conditional expression. Expected 'if <expr> then <expr>' or 'if <expr> then <expr> else <expr>'.
    /// (Originally from FSComp.txt:1292)
    static member parsUnexpectedEndOfFileElse: unit -> int * string
    /// Unexpected end of input in body of lambda expression. Expected 'fun <pat> ... <pat> -> <expr>'.
    /// (Originally from FSComp.txt:1293)
    static member parsUnexpectedEndOfFileFunBody: unit -> int * string
    /// Unexpected end of input in type arguments
    /// (Originally from FSComp.txt:1294)
    static member parsUnexpectedEndOfFileTypeArgs: unit -> int * string
    /// Unexpected end of input in type signature
    /// (Originally from FSComp.txt:1295)
    static member parsUnexpectedEndOfFileTypeSignature: unit -> int * string
    /// Unexpected end of input in type definition
    /// (Originally from FSComp.txt:1296)
    static member parsUnexpectedEndOfFileTypeDefinition: unit -> int * string
    /// Unexpected end of input in object members
    /// (Originally from FSComp.txt:1297)
    static member parsUnexpectedEndOfFileObjectMembers: unit -> int * string
    /// Unexpected end of input in value, function or member definition
    /// (Originally from FSComp.txt:1298)
    static member parsUnexpectedEndOfFileDefinition: unit -> int * string
    /// Unexpected end of input in expression
    /// (Originally from FSComp.txt:1299)
    static member parsUnexpectedEndOfFileExpression: unit -> int * string
    /// Unexpected end of type. Expected a name after this point.
    /// (Originally from FSComp.txt:1300)
    static member parsExpectedNameAfterToken: unit -> int * string
    /// Incomplete value or function definition. If this is in an expression, the body of the expression must be indented to the same column as the 'let' keyword.
    /// (Originally from FSComp.txt:1301)
    static member parsUnmatchedLet: unit -> int * string
    /// Incomplete value definition. If this is in an expression, the body of the expression must be indented to the same column as the 'let!' keyword.
    /// (Originally from FSComp.txt:1302)
    static member parsUnmatchedLetBang: unit -> int * string
    /// Incomplete value definition. If this is in an expression, the body of the expression must be indented to the same column as the 'use!' keyword.
    /// (Originally from FSComp.txt:1303)
    static member parsUnmatchedUseBang: unit -> int * string
    /// Incomplete value definition. If this is in an expression, the body of the expression must be indented to the same column as the 'use' keyword.
    /// (Originally from FSComp.txt:1304)
    static member parsUnmatchedUse: unit -> int * string
    /// Missing 'do' in 'while' expression. Expected 'while <expr> do <expr>'.
    /// (Originally from FSComp.txt:1305)
    static member parsWhileDoExpected: unit -> int * string
    /// Missing 'do' in 'for' expression. Expected 'for <pat> in <expr> do <expr>'.
    /// (Originally from FSComp.txt:1306)
    static member parsForDoExpected: unit -> int * string
    /// Invalid join relation in '%s'. Expected 'expr <op> expr', where <op> is =, =?, ?= or ?=?.
    /// (Originally from FSComp.txt:1307)
    static member tcInvalidRelationInJoin: a0: System.String -> int * string
    /// Calls
    /// (Originally from FSComp.txt:1308)
    static member typeInfoCallsWord: unit -> string
    /// Invalid number of generic arguments to type '%s' in provided type. Expected '%d' arguments, given '%d'.
    /// (Originally from FSComp.txt:1309)
    static member impInvalidNumberOfGenericArguments: a0: System.String * a1: System.Int32 * a2: System.Int32 -> int * string
    /// Invalid value '%s' for unit-of-measure parameter '%s'
    /// (Originally from FSComp.txt:1310)
    static member impInvalidMeasureArgument1: a0: System.String * a1: System.String -> int * string
    /// Invalid value unit-of-measure parameter '%s'
    /// (Originally from FSComp.txt:1311)
    static member impInvalidMeasureArgument2: a0: System.String -> int * string
    /// Property '%s' on provided type '%s' is neither readable nor writable as it has CanRead=false and CanWrite=false
    /// (Originally from FSComp.txt:1312)
    static member etPropertyNeedsCanWriteOrCanRead: a0: System.String * a1: System.String -> int * string
    /// A use of 'into' must be followed by the remainder of the computation
    /// (Originally from FSComp.txt:1313)
    static member tcIntoNeedsRestOfQuery: unit -> int * string
    /// The operator '%s' does not accept the use of 'into'
    /// (Originally from FSComp.txt:1314)
    static member tcOperatorDoesntAcceptInto: a0: System.String -> int * string
    /// The definition of the custom operator '%s' does not use a valid combination of attribute flags
    /// (Originally from FSComp.txt:1315)
    static member tcCustomOperationInvalid: a0: System.String -> int * string
    /// This type definition may not have the 'CLIMutable' attribute. Only record types may have this attribute.
    /// (Originally from FSComp.txt:1316)
    static member tcThisTypeMayNotHaveACLIMutableAttribute: unit -> int * string
    /// 'member val' definitions are only permitted in types with a primary constructor. Consider adding arguments to your type definition, e.g. 'type X(args) = ...'.
    /// (Originally from FSComp.txt:1317)
    static member tcAutoPropertyRequiresImplicitConstructionSequence: unit -> int * string
    /// Property definitions may not be declared mutable. To indicate that this property can be set, use 'member val PropertyName = expr with get,set'.
    /// (Originally from FSComp.txt:1318)
    static member parsMutableOnAutoPropertyShouldBeGetSet: unit -> int * string
    /// To indicate that this property can be set, use 'member val PropertyName = expr with get,set'.
    /// (Originally from FSComp.txt:1319)
    static member parsMutableOnAutoPropertyShouldBeGetSetNotJustSet: unit -> int * string
    /// Type '%s' is illegal because in byref<T>, T cannot contain byref types.
    /// (Originally from FSComp.txt:1320)
    static member chkNoByrefsOfByrefs: a0: System.String -> int * string
    /// F# supports array ranks between 1 and 32. The value %d is not allowed.
    /// (Originally from FSComp.txt:1321)
    static member tastopsMaxArrayThirtyTwo: a0: System.Int32 -> int * string
    /// In queries, use the form 'for x in n .. m do ...' for ranging over integers
    /// (Originally from FSComp.txt:1322)
    static member tcNoIntegerForLoopInQuery: unit -> int * string
    /// 'while' expressions may not be used in queries
    /// (Originally from FSComp.txt:1323)
    static member tcNoWhileInQuery: unit -> int * string
    /// 'try/finally' expressions may not be used in queries
    /// (Originally from FSComp.txt:1324)
    static member tcNoTryFinallyInQuery: unit -> int * string
    /// 'use' expressions may not be used in queries
    /// (Originally from FSComp.txt:1325)
    static member tcUseMayNotBeUsedInQueries: unit -> int * string
    /// 'let!', 'use!' and 'do!' expressions may not be used in queries
    /// (Originally from FSComp.txt:1326)
    static member tcBindMayNotBeUsedInQueries: unit -> int * string
    /// 'return' and 'return!' may not be used in queries
    /// (Originally from FSComp.txt:1327)
    static member tcReturnMayNotBeUsedInQueries: unit -> int * string
    /// This is not a known query operator. Query operators are identifiers such as 'select', 'where', 'sortBy', 'thenBy', 'groupBy', 'groupValBy', 'join', 'groupJoin', 'sumBy' and 'averageBy', defined using corresponding methods on the 'QueryBuilder' type.
    /// (Originally from FSComp.txt:1328)
    static member tcUnrecognizedQueryOperator: unit -> int * string
    /// 'try/with' expressions may not be used in queries
    /// (Originally from FSComp.txt:1329)
    static member tcTryWithMayNotBeUsedInQueries: unit -> int * string
    /// This 'let' definition may not be used in a query. Only simple value definitions may be used in queries.
    /// (Originally from FSComp.txt:1330)
    static member tcNonSimpleLetBindingInQuery: unit -> int * string
    /// Too many static parameters. Expected at most %d parameters, but got %d unnamed and %d named parameters.
    /// (Originally from FSComp.txt:1331)
    static member etTooManyStaticParameters: a0: System.Int32 * a1: System.Int32 * a2: System.Int32 -> int * string
    /// Invalid provided literal value '%s'
    /// (Originally from FSComp.txt:1332)
    static member infosInvalidProvidedLiteralValue: a0: System.String -> int * string
    /// The 'anycpu32bitpreferred' platform can only be used with EXE targets. You must use 'anycpu' instead.
    /// (Originally from FSComp.txt:1333)
    static member invalidPlatformTarget: unit -> int * string
    /// This member, function or value declaration may not be declared 'inline'
    /// (Originally from FSComp.txt:1334)
    static member tcThisValueMayNotBeInlined: unit -> int * string
    /// The provider '%s' returned a non-generated type '%s' in the context of a set of generated types. Consider adjusting the type provider to only return generated types.
    /// (Originally from FSComp.txt:1335)
    static member etErasedTypeUsedInGeneration: a0: System.String * a1: System.String -> int * string
    /// Arguments to query operators may require parentheses, e.g. 'where (x > y)' or 'groupBy (x.Length / 10)'
    /// (Originally from FSComp.txt:1336)
    static member tcUnrecognizedQueryBinaryOperator: unit -> int * string
    /// A quotation may not involve an assignment to or taking the address of a captured local variable
    /// (Originally from FSComp.txt:1337)
    static member crefNoSetOfHole: unit -> int * string
    /// + 1 overload
    /// (Originally from FSComp.txt:1338)
    static member nicePrintOtherOverloads1: unit -> string
    /// + %d overloads
    /// (Originally from FSComp.txt:1339)
    static member nicePrintOtherOverloadsN: a0: System.Int32 -> string
    /// Erased to
    /// (Originally from FSComp.txt:1340)
    static member erasedTo: unit -> string
    /// Unexpected token '%s' or incomplete expression
    /// (Originally from FSComp.txt:1341)
    static member parsUnfinishedExpression: a0: System.String -> int * string
    /// Cannot find code target for this attribute, possibly because the code after the attribute is incomplete.
    /// (Originally from FSComp.txt:1342)
    static member parsAttributeOnIncompleteCode: unit -> int * string
    /// Type name cannot be empty.
    /// (Originally from FSComp.txt:1343)
    static member parsTypeNameCannotBeEmpty: unit -> int * string
    /// Problem reading assembly '%s': %s
    /// (Originally from FSComp.txt:1344)
    static member buildProblemReadingAssembly: a0: System.String * a1: System.String -> int * string
    /// Invalid provided field. Provided fields of erased provided types must be literals.
    /// (Originally from FSComp.txt:1345)
    static member tcTPFieldMustBeLiteral: unit -> int * string
    /// (loading description...)
    /// (Originally from FSComp.txt:1346)
    static member loadingDescription: unit -> string
    /// (description unavailable...)
    /// (Originally from FSComp.txt:1347)
    static member descriptionUnavailable: unit -> string
    /// A type variable has been constrained by multiple different class types. A type variable may only have one class constraint.
    /// (Originally from FSComp.txt:1348)
    static member chkTyparMultipleClassConstraints: unit -> int * string
    /// 'match' expressions may not be used in queries
    /// (Originally from FSComp.txt:1349)
    static member tcMatchMayNotBeUsedWithQuery: unit -> int * string
    /// Infix operator member '%s' has %d initial argument(s). Expected a tuple of 3 arguments
    /// (Originally from FSComp.txt:1350)
    static member memberOperatorDefinitionWithNonTripleArgument: a0: System.String * a1: System.Int32 -> int * string
    /// The operator '%s' cannot be resolved. Consider opening the module 'Microsoft.FSharp.Linq.NullableOperators'.
    /// (Originally from FSComp.txt:1351)
    static member cannotResolveNullableOperators: a0: System.String -> int * string
    /// '%s' must be followed by 'in'. Usage: %s.
    /// (Originally from FSComp.txt:1352)
    static member tcOperatorRequiresIn: a0: System.String * a1: System.String -> int * string
    /// Neither 'member val' nor 'override val' definitions are permitted in object expressions.
    /// (Originally from FSComp.txt:1353)
    static member parsIllegalMemberVarInObjectImplementation: unit -> int * string
    /// Copy-and-update record expressions must include at least one field.
    /// (Originally from FSComp.txt:1354)
    static member tcEmptyCopyAndUpdateRecordInvalid: unit -> int * string
    /// '_' cannot be used as field name
    /// (Originally from FSComp.txt:1355)
    static member parsUnderscoreInvalidFieldName: unit -> int * string
    /// The provided types generated by this use of a type provider may not be used from other F# assemblies and should be marked internal or private. Consider using 'type internal TypeName = ...' or 'type private TypeName = ...'.
    /// (Originally from FSComp.txt:1356)
    static member tcGeneratedTypesShouldBeInternalOrPrivate: unit -> int * string
    /// A property's getter and setter must have the same type. Property '%s' has getter of type '%s' but setter of type '%s'.
    /// (Originally from FSComp.txt:1357)
    static member chkGetterAndSetterHaveSamePropertyType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Array method '%s' is supplied by the runtime and cannot be directly used in code. For operations with array elements consider using family of GetArray/SetArray functions from LanguagePrimitives.IntrinsicFunctions module.
    /// (Originally from FSComp.txt:1358)
    static member tcRuntimeSuppliedMethodCannotBeUsedInUserCode: a0: System.String -> int * string
    /// The union case '%s' does not have a field named '%s'.
    /// (Originally from FSComp.txt:1359)
    static member tcUnionCaseConstructorDoesNotHaveFieldWithGivenName: a0: System.String * a1: System.String -> int * string
    /// The exception '%s' does not have a field named '%s'.
    /// (Originally from FSComp.txt:1360)
    static member tcExceptionConstructorDoesNotHaveFieldWithGivenName: a0: System.String * a1: System.String -> int * string
    /// Active patterns do not have fields. This syntax is invalid.
    /// (Originally from FSComp.txt:1361)
    static member tcActivePatternsDoNotHaveFields: unit -> int * string
    /// The constructor does not have a field named '%s'.
    /// (Originally from FSComp.txt:1362)
    static member tcConstructorDoesNotHaveFieldWithGivenName: a0: System.String -> int * string
    /// Union case/exception field '%s' cannot be used more than once.
    /// (Originally from FSComp.txt:1363)
    static member tcUnionCaseFieldCannotBeUsedMoreThanOnce: a0: System.String -> int * string
    /// Named field '%s' is used more than once.
    /// (Originally from FSComp.txt:1364)
    static member tcFieldNameIsUsedModeThanOnce: a0: System.String -> int * string
    /// Named field '%s' conflicts with autogenerated name for anonymous field.
    /// (Originally from FSComp.txt:1365)
    static member tcFieldNameConflictsWithGeneratedNameForAnonymousField: a0: System.String -> int * string
    /// This literal expression or attribute argument results in an arithmetic overflow.
    /// (Originally from FSComp.txt:1366)
    static member tastConstantExpressionOverflow: unit -> int * string
    /// This is not valid literal expression. The [<Literal>] attribute will be ignored.
    /// (Originally from FSComp.txt:1367)
    static member tcIllegalStructTypeForConstantExpression: unit -> int * string
    /// System.Runtime.InteropServices assembly is required to use UnknownWrapper\DispatchWrapper classes.
    /// (Originally from FSComp.txt:1368)
    static member fscSystemRuntimeInteropServicesIsRequired: unit -> int * string
    /// The mutable local '%s' is implicitly allocated as a reference cell because it has been captured by a closure. This warning is for informational purposes only to indicate where implicit allocations are performed.
    /// (Originally from FSComp.txt:1369)
    static member abImplicitHeapAllocation: a0: System.String -> int * string
    /// A type provider implemented GetStaticParametersForMethod, but ApplyStaticArgumentsForMethod was not implemented or invalid
    /// (Originally from FSComp.txt:1370)
    static member estApplyStaticArgumentsForMethodNotImplemented: unit -> string
    /// An error occurred applying the static arguments to a provided method
    /// (Originally from FSComp.txt:1371)
    static member etErrorApplyingStaticArgumentsToMethod: unit -> int * string
    /// Unexpected character '%s' in preprocessor expression
    /// (Originally from FSComp.txt:1372)
    static member pplexUnexpectedChar: a0: System.String -> int * string
    /// Unexpected token '%s' in preprocessor expression
    /// (Originally from FSComp.txt:1373)
    static member ppparsUnexpectedToken: a0: System.String -> int * string
    /// Incomplete preprocessor expression
    /// (Originally from FSComp.txt:1374)
    static member ppparsIncompleteExpression: unit -> int * string
    /// Missing token '%s' in preprocessor expression
    /// (Originally from FSComp.txt:1375)
    static member ppparsMissingToken: a0: System.String -> int * string
    /// An error occurred while reading the F# metadata node at position %d in table '%s' of assembly '%s'. The node had no matching declaration. Please report this warning. You may need to recompile the F# assembly you are using.
    /// (Originally from FSComp.txt:1376)
    static member pickleMissingDefinition: a0: System.Int32 * a1: System.String * a2: System.String -> int * string
    /// Type inference caused the type variable %s to escape its scope. Consider adding an explicit type parameter declaration or adjusting your code to be less generic.
    /// (Originally from FSComp.txt:1377)
    static member checkNotSufficientlyGenericBecauseOfScope: a0: System.String -> int * string
    /// Type inference caused an inference type variable to escape its scope. Consider adding type annotations to make your code less generic.
    /// (Originally from FSComp.txt:1378)
    static member checkNotSufficientlyGenericBecauseOfScopeAnon: unit -> int * string
    /// Redundant arguments are being ignored in function '%s'. Expected %d but got %d arguments.
    /// (Originally from FSComp.txt:1379)
    static member checkRaiseFamilyFunctionArgumentCount: a0: System.String * a1: System.Int32 * a2: System.Int32 -> int * string
    /// Lowercase literal '%s' is being shadowed by a new pattern with the same name. Only uppercase and module-prefixed literals can be used as named patterns.
    /// (Originally from FSComp.txt:1380)
    static member checkLowercaseLiteralBindingInPattern: a0: System.String -> int * string
    /// This literal pattern does not take arguments
    /// (Originally from FSComp.txt:1381)
    static member tcLiteralDoesNotTakeArguments: unit -> int * string
    /// Constructors are not permitted as extension members - they must be defined as part of the original definition of the type
    /// (Originally from FSComp.txt:1382)
    static member tcConstructorsIllegalInAugmentation: unit -> int * string
    /// Invalid response file '%s' ( '%s' )
    /// (Originally from FSComp.txt:1383)
    static member optsInvalidResponseFile: a0: System.String * a1: System.String -> int * string
    /// Response file '%s' not found in '%s'
    /// (Originally from FSComp.txt:1384)
    static member optsResponseFileNotFound: a0: System.String * a1: System.String -> int * string
    /// Response file name '%s' is empty, contains invalid characters, has a drive specification without an absolute path, or is too long
    /// (Originally from FSComp.txt:1385)
    static member optsResponseFileNameInvalid: a0: System.String -> int * string
    /// Cannot find FSharp.Core.dll in compiler's directory
    /// (Originally from FSComp.txt:1386)
    static member fsharpCoreNotFoundToBeCopied: unit -> int * string
    /// One tuple type is a struct tuple, the other is a reference tuple
    /// (Originally from FSComp.txt:1387)
    static member tcTupleStructMismatch: unit -> string
    /// This provided method requires static parameters
    /// (Originally from FSComp.txt:1388)
    static member etMissingStaticArgumentsToMethod: unit -> int * string
    /// The conversion from %s to %s is a compile-time safe upcast, not a downcast. Consider using 'upcast' instead of 'downcast'.
    /// (Originally from FSComp.txt:1389)
    static member considerUpcast: a0: System.String * a1: System.String -> int * string
    /// The conversion from %s to %s is a compile-time safe upcast, not a downcast. Consider using the :> (upcast) operator instead of the :?> (downcast) operator.
    /// (Originally from FSComp.txt:1390)
    static member considerUpcastOperator: a0: System.String * a1: System.String -> int * string
    /// The 'rec' on this module is implied by an outer 'rec' declaration and is being ignored
    /// (Originally from FSComp.txt:1391)
    static member tcRecImplied: unit -> int * string
    /// In a recursive declaration group, 'open' declarations must come first in each module
    /// (Originally from FSComp.txt:1392)
    static member tcOpenFirstInMutRec: unit -> int * string
    /// In a recursive declaration group, module abbreviations must come after all 'open' declarations and before other declarations
    /// (Originally from FSComp.txt:1393)
    static member tcModuleAbbrevFirstInMutRec: unit -> int * string
    /// This declaration is not supported in recursive declaration groups
    /// (Originally from FSComp.txt:1394)
    static member tcUnsupportedMutRecDecl: unit -> int * string
    /// Invalid use of 'rec' keyword
    /// (Originally from FSComp.txt:1395)
    static member parsInvalidUseOfRec: unit -> int * string
    /// If a multicase union type is a struct, then all union cases must have unique names. For example: 'type A = B of b: int | C of c: int'.
    /// (Originally from FSComp.txt:1396)
    static member tcStructUnionMultiCaseDistinctFields: unit -> int * string
    /// The CallerMemberNameAttribute applied to parameter '%s' will have no effect. It is overridden by the CallerFilePathAttribute.
    /// (Originally from FSComp.txt:1397)
    static member CallerMemberNameIsOverridden: a0: System.String -> int * string
    /// Invalid use of 'fixed'. 'fixed' may only be used in a declaration of the form 'use x = fixed expr' where the expression is one of the following: an array, the address of an array element, a string, a byref, an inref, or a type implementing GetPinnableReference()
    /// (Originally from FSComp.txt:1398)
    static member tcFixedNotAllowed: unit -> int * string
    /// Could not find method System.Runtime.CompilerServices.OffsetToStringData in references when building 'fixed' expression.
    /// (Originally from FSComp.txt:1399)
    static member tcCouldNotFindOffsetToStringData: unit -> int * string
    /// The address of the variable '%s' or a related expression cannot be used at this point. This is to ensure the address of the local value does not escape its scope.
    /// (Originally from FSComp.txt:1400)
    static member chkNoByrefAddressOfLocal: a0: System.String -> int * string
    /// %s is an active pattern and cannot be treated as a discriminated union case with named fields.
    /// (Originally from FSComp.txt:1401)
    static member tcNamedActivePattern: a0: System.String -> int * string
    /// The default value does not have the same type as the argument. The DefaultParameterValue attribute and any Optional attribute will be ignored. Note: 'null' needs to be annotated with the correct type, e.g. 'DefaultParameterValue(null:obj)'.
    /// (Originally from FSComp.txt:1402)
    static member DefaultParameterValueNotAppropriateForArgument: unit -> int * string
    /// The system type '%s' was required but no referenced system DLL contained this type
    /// (Originally from FSComp.txt:1403)
    static member tcGlobalsSystemTypeNotFound: a0: System.String -> string
    /// The member '%s' matches multiple overloads of the same method.\nPlease restrict it to one of the following:%s.
    /// (Originally from FSComp.txt:1404)
    static member typrelMemberHasMultiplePossibleDispatchSlots: a0: System.String * a1: System.String -> int * string
    /// Method or object constructor '%s' is not static
    /// (Originally from FSComp.txt:1405)
    static member methodIsNotStatic: a0: System.String -> int * string
    /// Unexpected symbol '=' in expression. Did you intend to use 'for x in y .. z do' instead?
    /// (Originally from FSComp.txt:1406)
    static member parsUnexpectedSymbolEqualsInsteadOfIn: unit -> int * string
    /// Invalid Anonymous Record type declaration.
    /// (Originally from FSComp.txt:1407)
    static member tcAnonRecdInvalid: unit -> string
    /// Two anonymous record types are from different assemblies '%s' and '%s'
    /// (Originally from FSComp.txt:1408)
    static member tcAnonRecdCcuMismatch: a0: System.String * a1: System.String -> string
    /// This anonymous record does not exactly match the expected shape. Add the missing fields %s and remove the extra fields %s.
    /// (Originally from FSComp.txt:1409)
    static member tcAnonRecdFieldNameMismatch: a0: System.String * a1: System.String -> string
    /// This anonymous record is missing field '%s'.
    /// (Originally from FSComp.txt:1410)
    static member tcAnonRecdSingleFieldNameSubset: a0: System.String -> string
    /// This anonymous record is missing fields %s.
    /// (Originally from FSComp.txt:1411)
    static member tcAnonRecdMultipleFieldsNameSubset: a0: System.String -> string
    /// This anonymous record has an extra field. Remove field '%s'.
    /// (Originally from FSComp.txt:1412)
    static member tcAnonRecdSingleFieldNameSuperset: a0: System.String -> string
    /// This anonymous record has extra fields. Remove fields %s.
    /// (Originally from FSComp.txt:1413)
    static member tcAnonRecdMultipleFieldsNameSuperset: a0: System.String -> string
    /// This anonymous record should have field '%s' but here has field '%s'.
    /// (Originally from FSComp.txt:1414)
    static member tcAnonRecdSingleFieldNameSingleDifferent: a0: System.String * a1: System.String -> string
    /// This anonymous record should have field '%s' but here has fields %s.
    /// (Originally from FSComp.txt:1415)
    static member tcAnonRecdSingleFieldNameMultipleDifferent: a0: System.String * a1: System.String -> string
    /// This anonymous record should have fields %s; but here has field '%s'.
    /// (Originally from FSComp.txt:1416)
    static member tcAnonRecdMultipleFieldNameSingleDifferent: a0: System.String * a1: System.String -> string
    /// This anonymous record should have fields %s; but here has fields %s.
    /// (Originally from FSComp.txt:1417)
    static member tcAnonRecdMultipleFieldNameMultipleDifferent: a0: System.String * a1: System.String -> string
    /// Indicates a method that either has no implementation in the type in which it is declared or that is virtual and has a default implementation.
    /// (Originally from FSComp.txt:1418)
    static member keywordDescriptionAbstract: unit -> string
    /// Used in mutually recursive bindings, in property declarations, and with multiple constraints on generic parameters.
    /// (Originally from FSComp.txt:1419)
    static member keywordDescriptionAnd: unit -> string
    /// Used to give the current class object an object name. Also used to give a name to a whole pattern within a pattern match.
    /// (Originally from FSComp.txt:1420)
    static member keywordDescriptionAs: unit -> string
    /// Used to verify code during debugging.
    /// (Originally from FSComp.txt:1421)
    static member keywordDescriptionAssert: unit -> string
    /// Used as the name of the base class object.
    /// (Originally from FSComp.txt:1422)
    static member keywordDescriptionBase: unit -> string
    /// In verbose syntax, indicates the start of a code block.
    /// (Originally from FSComp.txt:1423)
    static member keywordDescriptionBegin: unit -> string
    /// In verbose syntax, indicates the start of a class definition.
    /// (Originally from FSComp.txt:1424)
    static member keywordDescriptionClass: unit -> string
    /// Keyword to specify a constant literal as a type parameter argument in Type Providers.
    /// (Originally from FSComp.txt:1425)
    static member keywordDescriptionConst: unit -> string
    /// Indicates an implementation of an abstract method; used together with an abstract method declaration to create a virtual method.
    /// (Originally from FSComp.txt:1426)
    static member keywordDescriptionDefault: unit -> string
    /// Used to declare a delegate.
    /// (Originally from FSComp.txt:1427)
    static member keywordDescriptionDelegate: unit -> string
    /// Used in looping constructs or to execute imperative code.
    /// (Originally from FSComp.txt:1428)
    static member keywordDescriptionDo: unit -> string
    /// In verbose syntax, indicates the end of a block of code in a looping expression.
    /// (Originally from FSComp.txt:1429)
    static member keywordDescriptionDone: unit -> string
    /// Used to convert to a type that is lower in the inheritance chain.
    /// (Originally from FSComp.txt:1430)
    static member keywordDescriptionDowncast: unit -> string
    /// In a for expression, used when counting in reverse.
    /// (Originally from FSComp.txt:1431)
    static member keywordDescriptionDownto: unit -> string
    /// Used in conditional branching. A short form of else if.
    /// (Originally from FSComp.txt:1432)
    static member keywordDescriptionElif: unit -> string
    /// Used in conditional branching.
    /// (Originally from FSComp.txt:1433)
    static member keywordDescriptionElse: unit -> string
    /// In type definitions and type extensions, indicates the end of a section of member definitions. In verbose syntax, used to specify the end of a code block that starts with the begin keyword.
    /// (Originally from FSComp.txt:1434)
    static member keywordDescriptionEnd: unit -> string
    /// Used to declare an exception type.
    /// (Originally from FSComp.txt:1435)
    static member keywordDescriptionException: unit -> string
    /// Indicates that a declared program element is defined in another binary or assembly.
    /// (Originally from FSComp.txt:1436)
    static member keywordDescriptionExtern: unit -> string
    /// Used as a Boolean literal.
    /// (Originally from FSComp.txt:1437)
    static member keywordDescriptionTrueFalse: unit -> string
    /// Used together with try to introduce a block of code that executes regardless of whether an exception occurs.
    /// (Originally from FSComp.txt:1438)
    static member keywordDescriptionFinally: unit -> string
    /// Used in looping constructs.
    /// (Originally from FSComp.txt:1439)
    static member keywordDescriptionFor: unit -> string
    /// Used in lambda expressions, also known as anonymous functions.
    /// (Originally from FSComp.txt:1440)
    static member keywordDescriptionFun: unit -> string
    /// Used as a shorter alternative to the fun keyword and a match expression in a lambda expression that has pattern matching on a single argument.
    /// (Originally from FSComp.txt:1441)
    static member keywordDescriptionFunction: unit -> string
    /// Used to reference the top-level .NET namespace.
    /// (Originally from FSComp.txt:1442)
    static member keywordDescriptionGlobal: unit -> string
    /// Used in conditional branching constructs.
    /// (Originally from FSComp.txt:1443)
    static member keywordDescriptionIf: unit -> string
    /// Used for sequence expressions and, in verbose syntax, to separate expressions from bindings.
    /// (Originally from FSComp.txt:1444)
    static member keywordDescriptionIn: unit -> string
    /// Used to specify a base class or base interface.
    /// (Originally from FSComp.txt:1445)
    static member keywordDescriptionInherit: unit -> string
    /// Used to indicate a function that should be integrated directly into the caller's code.
    /// (Originally from FSComp.txt:1446)
    static member keywordDescriptionInline: unit -> string
    /// Used to declare and implement interfaces.
    /// (Originally from FSComp.txt:1447)
    static member keywordDescriptionInterface: unit -> string
    /// Used to specify that a member is visible inside an assembly but not outside it.
    /// (Originally from FSComp.txt:1448)
    static member keywordDescriptionInternal: unit -> string
    /// Used to specify a computation that is to be performed only when a result is needed.
    /// (Originally from FSComp.txt:1449)
    static member keywordDescriptionLazy: unit -> string
    /// Used to associate, or bind, a name to a value or function.
    /// (Originally from FSComp.txt:1450)
    static member keywordDescriptionLet: unit -> string
    /// Used in computation expressions to bind a name to the result of another computation expression.
    /// (Originally from FSComp.txt:1451)
    static member keywordDescriptionLetBang: unit -> string
    /// Used to branch by comparing a value to a pattern.
    /// (Originally from FSComp.txt:1452)
    static member keywordDescriptionMatch: unit -> string
    /// Used in computation expressions to pattern match directly over the result of another computation expression.
    /// (Originally from FSComp.txt:1453)
    static member keywordDescriptionMatchBang: unit -> string
    /// Used to declare a property or method in an object type.
    /// (Originally from FSComp.txt:1454)
    static member keywordDescriptionMember: unit -> string
    /// Used to associate a name with a group of related types, values, and functions, to logically separate it from other code.
    /// (Originally from FSComp.txt:1455)
    static member keywordDescriptionModule: unit -> string
    /// Used to declare a variable, that is, a value that can be changed.
    /// (Originally from FSComp.txt:1456)
    static member keywordDescriptionMutable: unit -> string
    /// Used to associate a name with a group of related types and modules, to logically separate it from other code.
    /// (Originally from FSComp.txt:1457)
    static member keywordDescriptionNamespace: unit -> string
    /// Used to declare, define, or invoke a constructor that creates or that can create an object. Also used in generic parameter constraints to indicate that a type must have a certain constructor.
    /// (Originally from FSComp.txt:1458)
    static member keywordDescriptionNew: unit -> string
    /// Not actually a keyword. However, not struct in combination is used as a generic parameter constraint.
    /// (Originally from FSComp.txt:1459)
    static member keywordDescriptionNot: unit -> string
    /// Indicates the absence of an object. Also used in generic parameter constraints.
    /// (Originally from FSComp.txt:1460)
    static member keywordDescriptionNull: unit -> string
    /// Used in discriminated unions to indicate the type of categories of values, and in delegate and exception declarations.
    /// (Originally from FSComp.txt:1461)
    static member keywordDescriptionOf: unit -> string
    /// Used to make the contents of a namespace or module available without qualification.
    /// (Originally from FSComp.txt:1462)
    static member keywordDescriptionOpen: unit -> string
    /// Used with Boolean conditions as a Boolean or operator. Equivalent to ||. Also used in member constraints.
    /// (Originally from FSComp.txt:1463)
    static member keywordDescriptionOr: unit -> string
    /// Used to implement a version of an abstract or virtual method that differs from the base version.
    /// (Originally from FSComp.txt:1464)
    static member keywordDescriptionOverride: unit -> string
    /// Restricts access to a member to code in the same type or module.
    /// (Originally from FSComp.txt:1465)
    static member keywordDescriptionPrivate: unit -> string
    /// Allows access to a member from outside the type.
    /// (Originally from FSComp.txt:1466)
    static member keywordDescriptionPublic: unit -> string
    /// Used to indicate that a function is recursive.
    /// (Originally from FSComp.txt:1467)
    static member keywordDescriptionRec: unit -> string
    /// Used to provide a value for the result of the containing computation expression.
    /// (Originally from FSComp.txt:1468)
    static member keywordDescriptionReturn: unit -> string
    /// Used to provide a value for the result of the containing computation expression, where that value itself comes from the result another computation expression.
    /// (Originally from FSComp.txt:1469)
    static member keywordDescriptionReturnBang: unit -> string
    /// Used in query expressions to specify what fields or columns to extract. Note that this is a contextual keyword, which means that it is not actually a reserved word and it only acts like a keyword in appropriate context.
    /// (Originally from FSComp.txt:1470)
    static member keywordDescriptionSelect: unit -> string
    /// Keyword reserved for ML-compatibility.
    /// (Originally from FSComp.txt:1471)
    static member keywordDescriptionSig: unit -> string
    /// Used to indicate a method or property that can be called without an instance of a type, or a value member that is shared among all instances of a type.
    /// (Originally from FSComp.txt:1472)
    static member keywordDescriptionStatic: unit -> string
    /// Used to declare a structure type. Also used in generic parameter constraints.
    /// (Originally from FSComp.txt:1473)
    static member keywordDescriptionStruct: unit -> string
    /// Used in conditional expressions. Also used to perform side effects after object construction.
    /// (Originally from FSComp.txt:1474)
    static member keywordDescriptionThen: unit -> string
    /// Used in for loops to indicate a range.
    /// (Originally from FSComp.txt:1475)
    static member keywordDescriptionTo: unit -> string
    /// Used to introduce a block of code that might generate an exception. Used together with 'with' or 'finally'.
    /// (Originally from FSComp.txt:1476)
    static member keywordDescriptionTry: unit -> string
    /// Used to declare a class, record, structure, discriminated union, enumeration type, unit of measure, or type abbreviation.
    /// (Originally from FSComp.txt:1477)
    static member keywordDescriptionType: unit -> string
    /// Used to check if an object is of the given type in a pattern or binding.
    /// (Originally from FSComp.txt:1478)
    static member keywordDescriptionTypeTest: unit -> string
    /// Used to convert to a type that is higher in the inheritance chain.
    /// (Originally from FSComp.txt:1479)
    static member keywordDescriptionUpcast: unit -> string
    /// Used instead of let for values that implement IDisposable
    /// (Originally from FSComp.txt:1480)
    static member keywordDescriptionUse: unit -> string
    /// Used instead of let! in computation expressions for computation expression results that implement IDisposable.
    /// (Originally from FSComp.txt:1481)
    static member keywordDescriptionUseBang: unit -> string
    /// Used in a signature to indicate a value, or in a type to declare a member, in limited situations.
    /// (Originally from FSComp.txt:1482)
    static member keywordDescriptionVal: unit -> string
    /// Indicates the .NET void type. Used when interoperating with other .NET languages.
    /// (Originally from FSComp.txt:1483)
    static member keywordDescriptionVoid: unit -> string
    /// Used for Boolean conditions (when guards) on pattern matches and to introduce a constraint clause for a generic type parameter.
    /// (Originally from FSComp.txt:1484)
    static member keywordDescriptionWhen: unit -> string
    /// Introduces a looping construct.
    /// (Originally from FSComp.txt:1485)
    static member keywordDescriptionWhile: unit -> string
    /// Used in computation expressions to introduce a looping construct where the condition is the result of another computation expression.
    /// (Originally from FSComp.txt:1486)
    static member keywordDescriptionWhileBang: unit -> string
    /// Used together with the match keyword in pattern matching expressions. Also used in object expressions, record copying expressions, and type extensions to introduce member definitions, and to introduce exception handlers.
    /// (Originally from FSComp.txt:1487)
    static member keywordDescriptionWith: unit -> string
    /// Used in a sequence expression to produce a value for a sequence.
    /// (Originally from FSComp.txt:1488)
    static member keywordDescriptionYield: unit -> string
    /// Used in a computation expression to append the result of a given computation expression to a collection of results for the containing computation expression.
    /// (Originally from FSComp.txt:1489)
    static member keywordDescriptionYieldBang: unit -> string
    /// In function types, delimits arguments and return values. Yields an expression (in sequence expressions); equivalent to the yield keyword. Used in match expressions
    /// (Originally from FSComp.txt:1490)
    static member keywordDescriptionRightArrow: unit -> string
    /// Assigns a value to a variable.
    /// (Originally from FSComp.txt:1491)
    static member keywordDescriptionLeftArrow: unit -> string
    /// Converts a type to type that is higher in the hierarchy.
    /// (Originally from FSComp.txt:1492)
    static member keywordDescriptionCast: unit -> string
    /// Converts a type to a type that is lower in the hierarchy.
    /// (Originally from FSComp.txt:1493)
    static member keywordDescriptionDynamicCast: unit -> string
    /// Delimits a typed code quotation.
    /// (Originally from FSComp.txt:1494)
    static member keywordDescriptionTypedQuotation: unit -> string
    /// Delimits a untyped code quotation.
    /// (Originally from FSComp.txt:1495)
    static member keywordDescriptionUntypedQuotation: unit -> string
    /// %s '%s' not found in assembly '%s'. A possible cause may be a version incompatibility. You may need to explicitly reference the correct version of this assembly to allow all referenced components to use the correct version.
    /// (Originally from FSComp.txt:1496)
    static member itemNotFoundDuringDynamicCodeGen: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// %s '%s' not found in type '%s' from assembly '%s'. A possible cause may be a version incompatibility. You may need to explicitly reference the correct version of this assembly to allow all referenced components to use the correct version.
    /// (Originally from FSComp.txt:1497)
    static member itemNotFoundInTypeDuringDynamicCodeGen: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// is
    /// (Originally from FSComp.txt:1498)
    static member descriptionWordIs: unit -> string
    /// This value is not a function and cannot be applied.
    /// (Originally from FSComp.txt:1499)
    static member notAFunction: unit -> string
    /// This value is not a function and cannot be applied. Did you intend to access the indexer via '%s.[index]'?
    /// (Originally from FSComp.txt:1500)
    static member notAFunctionButMaybeIndexerWithName: a0: System.String -> string
    /// This expression is not a function and cannot be applied. Did you intend to access the indexer via 'expr.[index]'?
    /// (Originally from FSComp.txt:1501)
    static member notAFunctionButMaybeIndexer: unit -> string
    /// This value is not a function and cannot be applied. Did you intend to access the indexer via '%s[index]'?
    /// (Originally from FSComp.txt:1502)
    static member notAFunctionButMaybeIndexerWithName2: a0: System.String -> string
    /// This expression is not a function and cannot be applied. Did you intend to access the indexer via 'expr[index]'?
    /// (Originally from FSComp.txt:1503)
    static member notAFunctionButMaybeIndexer2: unit -> string
    /// 
    /// (Originally from FSComp.txt:1504)
    static member notAFunctionButMaybeIndexerErrorCode: unit -> int * string
    /// This value is not a function and cannot be applied. Did you forget to terminate a declaration?
    /// (Originally from FSComp.txt:1505)
    static member notAFunctionButMaybeDeclaration: unit -> string
    /// An error occurred while reading the F# metadata of assembly '%s'. A reserved construct was utilized. You may need to upgrade your F# compiler or use an earlier version of the assembly that doesn't make use of a specific construct.
    /// (Originally from FSComp.txt:1506)
    static member pickleUnexpectedNonZero: a0: System.String -> int * string
    /// This method or property is not normally used from F# code, use an explicit tuple pattern for deconstruction instead.
    /// (Originally from FSComp.txt:1507)
    static member tcTupleMemberNotNormallyUsed: unit -> int * string
    /// This expression returns a value of type '%s' but is implicitly discarded. Consider using 'let' to bind the result to a name, e.g. 'let result = expression'. If you intended to use the expression as a value in the sequence then use an explicit 'yield'.
    /// (Originally from FSComp.txt:1508)
    static member implicitlyDiscardedInSequenceExpression: a0: System.String -> int * string
    /// This expression returns a value of type '%s' but is implicitly discarded. Consider using 'let' to bind the result to a name, e.g. 'let result = expression'. If you intended to use the expression as a value in the sequence then use an explicit 'yield!'.
    /// (Originally from FSComp.txt:1509)
    static member implicitlyDiscardedSequenceInSequenceExpression: a0: System.String -> int * string
    /// The file '%s' changed on disk unexpectedly, please reload.
    /// (Originally from FSComp.txt:1510)
    static member ilreadFileChanged: a0: System.String -> int * string
    /// The byref pointer is readonly, so this write is not permitted.
    /// (Originally from FSComp.txt:1511)
    static member writeToReadOnlyByref: unit -> int * string
    /// A ReadOnly attribute has been applied to a struct type with a mutable field.
    /// (Originally from FSComp.txt:1512)
    static member readOnlyAttributeOnStructWithMutableField: unit -> int * string
    /// A byref pointer returned by a function or method is implicitly dereferenced as of F# 4.5. To acquire the return value as a pointer, use the address-of operator, e.g. '&f(x)' or '&obj.Method(arg1, arg2)'.
    /// (Originally from FSComp.txt:1513)
    static member tcByrefReturnImplicitlyDereferenced: unit -> int * string
    /// A type annotated with IsByRefLike must also be a struct. Consider adding the [<Struct>] attribute to the type.
    /// (Originally from FSComp.txt:1514)
    static member tcByRefLikeNotStruct: unit -> int * string
    /// The address of a value returned from the expression cannot be used at this point. This is to ensure the address of the local value does not escape its scope.
    /// (Originally from FSComp.txt:1515)
    static member chkNoByrefAddressOfValueFromExpression: unit -> int * string
    /// This value can't be assigned because the target '%s' may refer to non-stack-local memory, while the expression being assigned is assessed to potentially refer to stack-local memory. This is to help prevent pointers to stack-bound memory escaping their scope.
    /// (Originally from FSComp.txt:1516)
    static member chkNoWriteToLimitedSpan: a0: System.String -> int * string
    /// A value defined in a module must be mutable in order to take its address, e.g. 'let mutable x = ...'
    /// (Originally from FSComp.txt:1517)
    static member tastValueMustBeLocal: unit -> int * string
    /// A type annotated with IsReadOnly must also be a struct. Consider adding the [<Struct>] attribute to the type.
    /// (Originally from FSComp.txt:1518)
    static member tcIsReadOnlyNotStruct: unit -> int * string
    /// Struct members cannot return the address of fields of the struct by reference
    /// (Originally from FSComp.txt:1519)
    static member chkStructsMayNotReturnAddressesOfContents: unit -> int * string
    /// The function or method call cannot be used at this point, because one argument that is a byref of a non-stack-local Span or IsByRefLike type is used with another argument that is a stack-local Span or IsByRefLike type. This is to ensure the address of the local value does not escape its scope.
    /// (Originally from FSComp.txt:1520)
    static member chkNoByrefLikeFunctionCall: unit -> int * string
    /// The Span or IsByRefLike variable '%s' cannot be used at this point. This is to ensure the address of the local value does not escape its scope.
    /// (Originally from FSComp.txt:1521)
    static member chkNoSpanLikeVariable: a0: System.String -> int * string
    /// A Span or IsByRefLike value returned from the expression cannot be used at ths point. This is to ensure the address of the local value does not escape its scope.
    /// (Originally from FSComp.txt:1522)
    static member chkNoSpanLikeValueFromExpression: unit -> int * string
    /// Cannot take the address of the value returned from the expression. Assign the returned value to a let-bound value before taking the address.
    /// (Originally from FSComp.txt:1523)
    static member tastCantTakeAddressOfExpression: unit -> int * string
    /// Cannot call the byref extension method '%s. 'this' parameter requires the value to be mutable or a non-readonly byref type.
    /// (Originally from FSComp.txt:1524)
    static member tcCannotCallExtensionMethodInrefToByref: a0: System.String -> int * string
    /// Byref types are not allowed to have optional type extensions.
    /// (Originally from FSComp.txt:1525)
    static member tcByrefsMayNotHaveTypeExtensions: unit -> int * string
    /// Cannot partially apply the extension method '%s' because the first parameter is a byref type.
    /// (Originally from FSComp.txt:1526)
    static member tcCannotPartiallyApplyExtensionMethodForByref: a0: System.String -> int * string
    /// This type does not inherit Attribute, it will not work correctly with other .NET languages.
    /// (Originally from FSComp.txt:1527)
    static member tcTypeDoesNotInheritAttribute: unit -> int * string
    /// Invalid anonymous record expression
    /// (Originally from FSComp.txt:1528)
    static member parsInvalidAnonRecdExpr: unit -> int * string
    /// Invalid anonymous record type
    /// (Originally from FSComp.txt:1529)
    static member parsInvalidAnonRecdType: unit -> int * string
    /// The input to a copy-and-update expression that creates an anonymous record must be either an anonymous record or a record
    /// (Originally from FSComp.txt:1530)
    static member tcCopyAndUpdateNeedsRecordType: unit -> int * string
    /// Attributes cannot be applied to type extensions.
    /// (Originally from FSComp.txt:1531)
    static member tcAugmentationsCannotHaveAttributes: unit -> int * string
    /// The dependency manager extension %s could not be loaded. Message: %s
    /// (Originally from FSComp.txt:1532)
    static member couldNotLoadDependencyManagerExtension: a0: System.String * a1: System.String -> int * string
    /// Property '%s' cannot be set because the setter is private
    /// (Originally from FSComp.txt:1533)
    static member tcPropertyCannotBeSetPrivateSetter: a0: System.String -> int * string
    /// Expression does not have a name.
    /// (Originally from FSComp.txt:1534)
    static member expressionHasNoName: unit -> int * string
    /// Using the 'nameof' operator as a first-class function value is not permitted.
    /// (Originally from FSComp.txt:1535)
    static member chkNoFirstClassNameOf: unit -> int * string
    /// Byref types are not allowed in an open type declaration.
    /// (Originally from FSComp.txt:1536)
    static member tcIllegalByrefsInOpenTypeDeclaration: unit -> int * string
    /// The type '%s' does not support a nullness qualification.
    /// (Originally from FSComp.txt:1537)
    static member tcTypeDoesNotHaveAnyNull: a0: System.String -> int * string
    /// Value known to be without null passed to a function meant for nullables: %s
    /// (Originally from FSComp.txt:1542)
    static member tcPassingWithoutNullToANullableExpectingFunc: a0: System.String -> int * string
    /// You can create 'Some value' directly instead of 'ofObj', or consider not using an option for this value.
    /// (Originally from FSComp.txt:1543)
    static member tcPassingWithoutNullToOptionOfObj: unit -> string
    /// You can create 'ValueSome value' directly instead of 'ofObj', or consider not using a voption for this value.
    /// (Originally from FSComp.txt:1544)
    static member tcPassingWithoutNullToValueOptionOfObj: unit -> string
    /// You can remove this |Null|NonNull| pattern usage.
    /// (Originally from FSComp.txt:1545)
    static member tcPassingWithoutNullToNonNullAP: unit -> string
    /// You can remove this |NonNullQuick| pattern usage.
    /// (Originally from FSComp.txt:1546)
    static member tcPassingWithoutNullToNonNullQuickAP: unit -> string
    /// You can remove this `nonNull` assertion.
    /// (Originally from FSComp.txt:1547)
    static member tcPassingWithoutNullTononNullFunction: unit -> string
    /// With nullness checking enabled, overrides of .ToString() method must return a non-nullable string. You can handle potential nulls via the built-in string function.
    /// (Originally from FSComp.txt:1548)
    static member tcNullableToStringOverride: unit -> int * string
    /// Nullness warning: Downcasting from '%s' into '%s' can introduce unexpected null values. Cast to '%s|null' instead or handle the null before downcasting.
    /// (Originally from FSComp.txt:1549)
    static member tcDowncastFromNullableToWithoutNull: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Application of method '%s' attempted to create a nullable type ('T | null) for '%s'. Nullness warnings won't be reported correctly for such types.
    /// (Originally from FSComp.txt:1550)
    static member tcDisallowedNullableApplication: a0: System.String * a1: System.String -> int * string
    /// The constraints 'null' and 'not null' are inconsistent
    /// (Originally from FSComp.txt:1551)
    static member csNullNotNullConstraintInconsistent: unit -> int * string
    /// The 'nullness checking' language feature is not enabled. This use of a nullness checking construct will be ignored.
    /// (Originally from FSComp.txt:1552)
    static member tcNullnessCheckingNotEnabled: unit -> int * string
    /// The type '%s' uses 'null' as a representation value but a non-null type is expected
    /// (Originally from FSComp.txt:1553)
    static member csTypeHasNullAsTrueValue: a0: System.String -> string
    /// The type '%s' supports 'null' but a non-null type is expected
    /// (Originally from FSComp.txt:1554)
    static member csTypeHasNullAsExtraValue: a0: System.String -> string
    /// The parameter '%s' has an invalid type '%s'. This is not permitted by the rules of Common IL.
    /// (Originally from FSComp.txt:1555)
    static member chkInvalidFunctionParameterType: a0: System.String * a1: System.String -> int * string
    /// The function or method has an invalid return type '%s'. This is not permitted by the rules of Common IL.
    /// (Originally from FSComp.txt:1556)
    static member chkInvalidFunctionReturnType: a0: System.String -> int * string
    /// The 'package management' feature requires language version 5.0 or above
    /// (Originally from FSComp.txt:1557)
    static member packageManagementRequiresVFive: unit -> int * string
    /// The 'from the end slicing' feature requires language version 'preview'.
    /// (Originally from FSComp.txt:1558)
    static member fromEndSlicingRequiresVFive: unit -> int * string
    /// #i is not supported by the registered PackageManagers
    /// (Originally from FSComp.txt:1559)
    static member poundiNotSupportedByRegisteredDependencyManagers: unit -> int * string
    /// The 'let! ... and! ...' construct may only be used if the computation expression builder defines either a '%s' method or appropriate 'MergeSources' and 'Bind' methods
    /// (Originally from FSComp.txt:1560)
    static member tcRequireMergeSourcesOrBindN: a0: System.String -> int * string
    /// This feature is not supported in this version of F#. You may need to add /langversion:preview to use this feature.
    /// (Originally from FSComp.txt:1561)
    static member tcAndBangNotSupported: unit -> int * string
    /// use! may not be combined with and!
    /// (Originally from FSComp.txt:1562)
    static member tcInvalidUseBangBindingNoAndBangs: unit -> int * string
    /// Feature '%s' requires the F# library for language version %s or greater.
    /// (Originally from FSComp.txt:1563)
    static member chkFeatureNotSupportedInLibrary: a0: System.String * a1: System.String -> int * string
    /// Feature '%s' is not available in F# %s. Please use language version %s or greater.
    /// (Originally from FSComp.txt:1564)
    static member chkFeatureNotLanguageSupported: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Feature '%s' is not supported by target runtime.
    /// (Originally from FSComp.txt:1565)
    static member chkFeatureNotRuntimeSupported: a0: System.String -> int * string
    /// Interface member '%s' does not have a most specific implementation.
    /// (Originally from FSComp.txt:1566)
    static member typrelInterfaceMemberNoMostSpecificImplementation: a0: System.String -> int * string
    /// Invalid directive '#%s %s'
    /// (Originally from FSComp.txt:1567)
    static member fsiInvalidDirective: a0: System.String * a1: System.String -> int * string
    /// Use reference assemblies for .NET framework references when available (Enabled by default).
    /// (Originally from FSComp.txt:1568)
    static member useSdkRefs: unit -> string
    /// Enable nullness declarations and checks (%s by default)
    /// (Originally from FSComp.txt:1569)
    static member optsCheckNulls: a0: System.String -> string
    /// %s for F# %s
    /// (Originally from FSComp.txt:1570)
    static member fSharpBannerVersion: a0: System.String * a1: System.String -> string
    /// Display the allowed values for language version.
    /// (Originally from FSComp.txt:1571)
    static member optsGetLangVersions: unit -> string
    /// Specify language version such as 'latest' or 'preview'.
    /// (Originally from FSComp.txt:1572)
    static member optsSetLangVersion: unit -> string
    /// Supported language versions:
    /// (Originally from FSComp.txt:1573)
    static member optsSupportedLangVersions: unit -> string
    /// Override indentation rules implied by the language version (%s by default)
    /// (Originally from FSComp.txt:1574)
    static member optsStrictIndentation: a0: System.String -> string
    /// Stream does not begin with a null resource and is not in '.RES' format.
    /// (Originally from FSComp.txt:1575)
    static member nativeResourceFormatError: unit -> string
    /// Resource header beginning at offset %s is malformed.
    /// (Originally from FSComp.txt:1576)
    static member nativeResourceHeaderMalformed: a0: System.String -> string
    ///  - %s
    /// (Originally from FSComp.txt:1577)
    static member formatDashItem: a0: System.String -> string
    /// single underscore pattern
    /// (Originally from FSComp.txt:1578)
    static member featureSingleUnderscorePattern: unit -> string
    /// wild card in for loop
    /// (Originally from FSComp.txt:1579)
    static member featureWildCardInForLoop: unit -> string
    /// whitespace relaxation
    /// (Originally from FSComp.txt:1580)
    static member featureRelaxWhitespace: unit -> string
    /// nameof
    /// (Originally from FSComp.txt:1581)
    static member featureNameOf: unit -> string
    /// implicit yield
    /// (Originally from FSComp.txt:1582)
    static member featureImplicitYield: unit -> string
    /// open type declaration
    /// (Originally from FSComp.txt:1583)
    static member featureOpenTypeDeclaration: unit -> string
    /// dotless float32 literal
    /// (Originally from FSComp.txt:1584)
    static member featureDotlessFloat32Literal: unit -> string
    /// package management
    /// (Originally from FSComp.txt:1585)
    static member featurePackageManagement: unit -> string
    /// from-end slicing
    /// (Originally from FSComp.txt:1586)
    static member featureFromEndSlicing: unit -> string
    /// fixed-index slice 3d/4d
    /// (Originally from FSComp.txt:1587)
    static member featureFixedIndexSlice3d4d: unit -> string
    /// applicative computation expressions
    /// (Originally from FSComp.txt:1588)
    static member featureAndBang: unit -> string
    /// nullness checking
    /// (Originally from FSComp.txt:1589)
    static member featureNullnessChecking: unit -> string
    /// resumable state machines
    /// (Originally from FSComp.txt:1590)
    static member featureResumableStateMachines: unit -> string
    /// nullable optional interop
    /// (Originally from FSComp.txt:1591)
    static member featureNullableOptionalInterop: unit -> string
    /// default interface member consumption
    /// (Originally from FSComp.txt:1592)
    static member featureDefaultInterfaceMemberConsumption: unit -> string
    /// string interpolation
    /// (Originally from FSComp.txt:1593)
    static member featureStringInterpolation: unit -> string
    /// witness passing for trait constraints in F# quotations
    /// (Originally from FSComp.txt:1594)
    static member featureWitnessPassing: unit -> string
    /// additional type-directed conversions
    /// (Originally from FSComp.txt:1595)
    static member featureAdditionalImplicitConversions: unit -> string
    /// struct representation for active patterns
    /// (Originally from FSComp.txt:1596)
    static member featureStructActivePattern: unit -> string
    /// whitespace relaxation v2
    /// (Originally from FSComp.txt:1597)
    static member featureRelaxWhitespace2: unit -> string
    /// list literals of any size
    /// (Originally from FSComp.txt:1598)
    static member featureReallyLongList: unit -> string
    /// give error on deprecated access of construct with RequireQualifiedAccess attribute
    /// (Originally from FSComp.txt:1599)
    static member featureErrorOnDeprecatedRequireQualifiedAccess: unit -> string
    /// static abstract interface members
    /// (Originally from FSComp.txt:1600)
    static member featureInterfacesWithAbstractStaticMembers: unit -> string
    /// self type constraints
    /// (Originally from FSComp.txt:1601)
    static member featureSelfTypeConstraints: unit -> string
    /// support for required properties
    /// (Originally from FSComp.txt:1602)
    static member featureRequiredProperties: unit -> string
    /// support for consuming init properties
    /// (Originally from FSComp.txt:1603)
    static member featureInitProperties: unit -> string
    /// Allow lowercase DU when RequireQualifiedAccess attribute
    /// (Originally from FSComp.txt:1604)
    static member featureLowercaseDUWhenRequireQualifiedAccess: unit -> string
    /// Pattern match discard is not allowed for union case that takes no data.
    /// (Originally from FSComp.txt:1605)
    static member featureMatchNotAllowedForUnionCaseWithNoData: unit -> string
    /// Allow implicit Extension attribute on declaring types, modules
    /// (Originally from FSComp.txt:1606)
    static member featureCSharpExtensionAttributeNotRequired: unit -> string
    /// Raises errors for non-virtual members overrides
    /// (Originally from FSComp.txt:1607)
    static member featureErrorForNonVirtualMembersOverrides: unit -> string
    /// Raises warnings when 'let inline ... =' is used together with [<MethodImpl(MethodImplOptions.NoInlining)>] attribute. Function is not getting inlined.
    /// (Originally from FSComp.txt:1608)
    static member featureWarningWhenInliningMethodImplNoInlineMarkedFunction: unit -> string
    /// Arithmetic and logical operations in literals, enum definitions and attributes
    /// (Originally from FSComp.txt:1609)
    static member featureArithmeticInLiterals: unit -> string
    /// Error reporting on static classes
    /// (Originally from FSComp.txt:1610)
    static member featureErrorReportingOnStaticClasses: unit -> string
    /// Support for try-with in sequence expressions
    /// (Originally from FSComp.txt:1611)
    static member featureTryWithInSeqExpressions: unit -> string
    /// Raises warnings when an copy-and-update record expression changes all fields of a record.
    /// (Originally from FSComp.txt:1612)
    static member featureWarningWhenCopyAndUpdateRecordChangesAllFields: unit -> string
    /// Static members in interfaces
    /// (Originally from FSComp.txt:1613)
    static member featureStaticMembersInInterfaces: unit -> string
    /// String values marked as literals and IL constants as printf format
    /// (Originally from FSComp.txt:1614)
    static member featureNonInlineLiteralsAsPrintfFormat: unit -> string
    /// Nested record field copy-and-update
    /// (Originally from FSComp.txt:1615)
    static member featureNestedCopyAndUpdate: unit -> string
    /// Extended string interpolation similar to C# raw string literals.
    /// (Originally from FSComp.txt:1616)
    static member featureExtendedStringInterpolation: unit -> string
    /// Raises warnings when multiple record type matches were found during name resolution because of overlapping field names.
    /// (Originally from FSComp.txt:1617)
    static member featureWarningWhenMultipleRecdTypeChoice: unit -> string
    /// Improved implied argument names
    /// (Originally from FSComp.txt:1618)
    static member featureImprovedImpliedArgumentNames: unit -> string
    /// Raises errors on incorrect indentation, allows better recovery and analysis during editing
    /// (Originally from FSComp.txt:1619)
    static member featureStrictIndentation: unit -> string
    /// Constraint intersection on flexible types
    /// (Originally from FSComp.txt:1620)
    static member featureConstraintIntersectionOnFlexibleTypes: unit -> string
    /// Raises warnings if a member or function has the 'TailCall' attribute, but is not being used in a tail recursive way.
    /// (Originally from FSComp.txt:1621)
    static member featureChkNotTailRecursive: unit -> string
    /// 'while!' expression
    /// (Originally from FSComp.txt:1622)
    static member featureWhileBang: unit -> string
    /// extended fixed bindings for byref and GetPinnableReference
    /// (Originally from FSComp.txt:1623)
    static member featureExtendedFixedBindings: unit -> string
    /// prefer String.GetPinnableReference in fixed bindings
    /// (Originally from FSComp.txt:1624)
    static member featurePreferStringGetPinnableReference: unit -> string
    /// prefer extension method over plain property
    /// (Originally from FSComp.txt:1625)
    static member featurePreferExtensionMethodOverPlainProperty: unit -> string
    /// Indexed properties getter and setter must have the same type
    /// (Originally from FSComp.txt:1626)
    static member featureWarningIndexedPropertiesGetSetSameType: unit -> string
    /// Raises warnings if the 'TailCall' attribute is used on non-recursive functions.
    /// (Originally from FSComp.txt:1627)
    static member featureChkTailCallAttrOnNonRec: unit -> string
    /// Union case test properties
    /// (Originally from FSComp.txt:1628)
    static member featureUnionIsPropertiesVisible: unit -> string
    /// Boolean-returning and return-type-directed partial active patterns
    /// (Originally from FSComp.txt:1629)
    static member featureBooleanReturningAndReturnTypeDirectedPartialActivePattern: unit -> string
    /// Enforce AttributeTargets
    /// (Originally from FSComp.txt:1630)
    static member featureEnforceAttributeTargets: unit -> string
    /// Optimizes interpolated strings in certain cases, by lowering to concatenation
    /// (Originally from FSComp.txt:1631)
    static member featureLowerInterpolatedStringToConcat: unit -> string
    /// Optimizes certain uses of the integral range (..) and range-step (.. ..) operators to fast while-loops.
    /// (Originally from FSComp.txt:1632)
    static member featureLowerIntegralRangesToFastLoops: unit -> string
    /// Lowers [for x in xs -> f x] and [|for x in xs -> f x|] to fast loops when xs is a list or an array, respectively.
    /// (Originally from FSComp.txt:1633)
    static member featureLowerSimpleMappingsInComprehensionsToFastLoops: unit -> string
    /// This value supports indexing, e.g. '%s.[index]'. The syntax '%s[index]' requires /langversion:preview. See https://aka.ms/fsharp-index-notation.
    /// (Originally from FSComp.txt:1634)
    static member tcNotAFunctionButIndexerNamedIndexingNotYetEnabled: a0: System.String * a1: System.String -> int * string
    /// This expression supports indexing, e.g. 'expr.[index]'. The syntax 'expr[index]' requires /langversion:preview. See https://aka.ms/fsharp-index-notation.
    /// (Originally from FSComp.txt:1635)
    static member tcNotAFunctionButIndexerIndexingNotYetEnabled: unit -> int * string
    /// The value '%s' is not a function and does not support index notation.
    /// (Originally from FSComp.txt:1636)
    static member tcNotAnIndexerNamedIndexingNotYetEnabled: a0: System.String -> int * string
    /// This expression is not a function and does not support index notation.
    /// (Originally from FSComp.txt:1637)
    static member tcNotAnIndexerIndexingNotYetEnabled: unit -> int * string
    /// '%s' cannot implement the interface '%s' with the two instantiations '%s' and '%s' because they may unify.
    /// (Originally from FSComp.txt:1638)
    static member typrelInterfaceWithConcreteAndVariable: a0: System.String * a1: System.String * a2: System.String * a3: System.String -> int * string
    /// You cannot implement the interface '%s' with the two instantiations '%s' and '%s' because they may unify.
    /// (Originally from FSComp.txt:1639)
    static member typrelInterfaceWithConcreteAndVariableObjectExpression: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// interfaces with multiple generic instantiation
    /// (Originally from FSComp.txt:1640)
    static member featureInterfacesWithMultipleGenericInstantiation: unit -> string
    /// Cannot assign '%s' to a value marked literal
    /// (Originally from FSComp.txt:1641)
    static member tcLiteralFieldAssignmentWithArg: a0: System.String -> int * string
    /// Cannot assign a value to another value marked literal
    /// (Originally from FSComp.txt:1642)
    static member tcLiteralFieldAssignmentNoArg: unit -> int * string
    /// Invalid use of reverse index in list expression.
    /// (Originally from FSComp.txt:1643)
    static member tcInvalidUseOfReverseIndex: unit -> int * string
    /// The syntax 'expr1[expr2]' is used for indexing. Consider adding a type annotation to enable indexing, or if calling a function add a space, e.g. 'expr1 [expr2]'.
    /// (Originally from FSComp.txt:1644)
    static member tcHighPrecedenceFunctionApplicationToListDeprecated: unit -> int * string
    /// The syntax 'arr.[idx]' is now revised to 'arr[idx]'. Please update your code.
    /// (Originally from FSComp.txt:1645)
    static member tcIndexNotationDeprecated: unit -> int * string
    /// The syntax 'expr1[expr2]' is now reserved for indexing. See https://aka.ms/fsharp-index-notation. If calling a function, add a space between the function and argument, e.g. 'someFunction [expr]'.
    /// (Originally from FSComp.txt:1646)
    static member tcHighPrecedenceFunctionApplicationToListReserved: unit -> int * string
    /// The syntax '(expr1)[expr2]' is now reserved for indexing and is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction (expr1) [expr2]'.
    /// (Originally from FSComp.txt:1647)
    static member tcParenThenAdjacentListArgumentReserved: unit -> int * string
    /// The syntax '[expr1][expr2]' is now reserved for indexing and is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction [expr1] [expr2]'.
    /// (Originally from FSComp.txt:1648)
    static member tcListThenAdjacentListArgumentReserved: unit -> int * string
    /// The syntax 'expr1[expr2]' is now reserved for indexing and is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction expr1 [expr2]'.
    /// (Originally from FSComp.txt:1649)
    static member tcOtherThenAdjacentListArgumentReserved: unit -> int * string
    /// The syntax '(expr1)[expr2]' is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If you intend indexing or slicing then you must use '(expr1).[expr2]' in argument position. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction (expr1) [expr2]'.
    /// (Originally from FSComp.txt:1650)
    static member tcParenThenAdjacentListArgumentNeedsAdjustment: unit -> int * string
    /// The syntax '[expr1][expr2]' is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If you intend indexing or slicing then you must use '(expr1).[expr2]' in argument position. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction [expr1] [expr2]'.
    /// (Originally from FSComp.txt:1651)
    static member tcListThenAdjacentListArgumentNeedsAdjustment: unit -> int * string
    /// The syntax 'expr1[expr2]' is ambiguous when used as an argument. See https://aka.ms/fsharp-index-notation. If you intend indexing or slicing then you must use 'expr1.[expr2]' in argument position. If calling a function with multiple curried arguments, add a space between them, e.g. 'someFunction expr1 [expr2]'.
    /// (Originally from FSComp.txt:1652)
    static member tcOtherThenAdjacentListArgumentNeedsAdjustment: unit -> int * string
    /// The use of '!' from the F# library is deprecated. See https://aka.ms/fsharp-refcell-ops. For example, please change '!cell' to 'cell.Value'.
    /// (Originally from FSComp.txt:1653)
    static member chkInfoRefcellDeref: unit -> int * string
    /// The use of ':=' from the F# library is deprecated. See https://aka.ms/fsharp-refcell-ops. For example, please change 'cell := expr' to 'cell.Value <- expr'.
    /// (Originally from FSComp.txt:1654)
    static member chkInfoRefcellAssign: unit -> int * string
    /// The use of 'incr' from the F# library is deprecated. See https://aka.ms/fsharp-refcell-ops. For example, please change 'incr cell' to 'cell.Value <- cell.Value + 1'.
    /// (Originally from FSComp.txt:1655)
    static member chkInfoRefcellIncr: unit -> int * string
    /// The use of 'decr' from the F# library is deprecated. See https://aka.ms/fsharp-refcell-ops. For example, please change 'decr cell' to 'cell.Value <- cell.Value - 1'.
    /// (Originally from FSComp.txt:1656)
    static member chkInfoRefcellDecr: unit -> int * string
    /// Interpolated strings may not use '%%' format specifiers unless each is given an expression, e.g. '%%d{1+1}'.
    /// (Originally from FSComp.txt:1657)
    static member forFormatInvalidForInterpolated: unit -> string
    /// .NET-style format specifiers such as '{x,3}' or '{x:N5}' may not be mixed with '%%' format specifiers.
    /// (Originally from FSComp.txt:1658)
    static member forFormatInvalidForInterpolated2: unit -> string
    /// The '%%P' specifier may not be used explicitly.
    /// (Originally from FSComp.txt:1659)
    static member forFormatInvalidForInterpolated3: unit -> string
    /// Interpolated strings used as type IFormattable or type FormattableString may not use '%%' specifiers, only .NET-style interpolands such as '{expr}', '{expr,3}' or '{expr:N5}' may be used.
    /// (Originally from FSComp.txt:1660)
    static member forFormatInvalidForInterpolated4: unit -> string
    /// Mismatch in interpolated string. Interpolated strings may not use '%%' format specifiers unless each is given an expression, e.g. '%%d{1+1}'
    /// (Originally from FSComp.txt:1661)
    static member tcInterpolationMixedWithPercent: unit -> int * string
    /// Invalid alignment in interpolated string
    /// (Originally from FSComp.txt:1662)
    static member tcInvalidAlignmentInInterpolatedString: unit -> int * string
    /// Invalid interpolated string. Single quote or verbatim string literals may not be used in interpolated expressions in single quote or verbatim strings. Consider using an explicit 'let' binding for the interpolation expression or use a triple quote string as the outer string literal.
    /// (Originally from FSComp.txt:1663)
    static member lexSingleQuoteInSingleQuote: unit -> int * string
    /// Invalid interpolated string. Triple quote string literals may not be used in interpolated expressions. Consider using an explicit 'let' binding for the interpolation expression.
    /// (Originally from FSComp.txt:1664)
    static member lexTripleQuoteInTripleQuote: unit -> int * string
    /// Invalid interpolated string. %s
    /// (Originally from FSComp.txt:1665)
    static member tcUnableToParseInterpolatedString: a0: System.String -> int * string
    /// a byte string may not be interpolated
    /// (Originally from FSComp.txt:1666)
    static member lexByteStringMayNotBeInterpolated: unit -> int * string
    /// Incomplete interpolated string expression fill begun at or before here
    /// (Originally from FSComp.txt:1667)
    static member parsEofInInterpolatedStringFill: unit -> int * string
    /// Incomplete interpolated string begun at or before here
    /// (Originally from FSComp.txt:1668)
    static member parsEofInInterpolatedString: unit -> int * string
    /// Incomplete interpolated verbatim string begun at or before here
    /// (Originally from FSComp.txt:1669)
    static member parsEofInInterpolatedVerbatimString: unit -> int * string
    /// Incomplete interpolated triple-quote string begun at or before here
    /// (Originally from FSComp.txt:1670)
    static member parsEofInInterpolatedTripleQuoteString: unit -> int * string
    /// Invalid interpolated string. This interpolated string expression fill is empty, an expression was expected.
    /// (Originally from FSComp.txt:1671)
    static member parsEmptyFillInInterpolatedString: unit -> int * string
    /// A '}' character must be escaped (by doubling) in an interpolated string.
    /// (Originally from FSComp.txt:1672)
    static member lexRBraceInInterpolatedString: unit -> int * string
    /// The .NET SDK for this script could not be determined. If the script is in a directory using a 'global.json' then ensure the relevant .NET SDK is installed. The output from '%s --version' in the directory '%s' was: '%s' and the exit code was '%d'.
    /// (Originally from FSComp.txt:1673)
    static member scriptSdkNotDetermined: a0: System.String * a1: System.String * a2: System.String * a3: System.Int32 -> int * string
    /// The .NET SDK for this script could not be determined. If the script is in a directory using a 'global.json' then ensure the relevant .NET SDK is installed. Unexpected error '%s'.
    /// (Originally from FSComp.txt:1674)
    static member scriptSdkNotDeterminedUnexpected: a0: System.String -> int * string
    /// The .NET SDK for this script could not be determined. dotnet.exe could not be found ensure a .NET SDK is installed.
    /// (Originally from FSComp.txt:1675)
    static member scriptSdkNotDeterminedNoHost: unit -> int * string
    /// The use of '[<Struct>]' on values, functions and methods is only allowed on partial active pattern definitions
    /// (Originally from FSComp.txt:1676)
    static member tcInvalidStructReturn: unit -> int * string
    /// This expression has type '%s' and is only made compatible with type '%s' through an ambiguous implicit conversion. Consider using an explicit call to 'op_Implicit'. The applicable implicit conversions are:%s
    /// (Originally from FSComp.txt:1677)
    static member tcAmbiguousImplicitConversion: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// This expression implicitly converts type '%s' to type '%s'. See https://aka.ms/fsharp-implicit-convs.
    /// (Originally from FSComp.txt:1678)
    static member tcSubsumptionImplicitConversionUsed: a0: System.String * a1: System.String -> int * string
    /// This expression uses a built-in implicit conversion to convert type '%s' to type '%s'. See https://aka.ms/fsharp-implicit-convs.
    /// (Originally from FSComp.txt:1679)
    static member tcBuiltInImplicitConversionUsed: a0: System.String * a1: System.String -> int * string
    /// This XML comment is invalid: '%s'
    /// (Originally from FSComp.txt:1680)
    static member xmlDocBadlyFormed: a0: System.String -> int * string
    /// This XML comment is invalid: missing 'name' attribute for parameter or parameter reference
    /// (Originally from FSComp.txt:1681)
    static member xmlDocMissingParameterName: unit -> int * string
    /// This XML comment is invalid: missing 'cref' attribute for cross-reference
    /// (Originally from FSComp.txt:1682)
    static member xmlDocMissingCrossReference: unit -> int * string
    /// This XML comment is invalid: unknown parameter '%s'
    /// (Originally from FSComp.txt:1683)
    static member xmlDocInvalidParameterName: a0: System.String -> int * string
    /// This XML comment is invalid: multiple documentation entries for parameter '%s'
    /// (Originally from FSComp.txt:1684)
    static member xmlDocDuplicateParameter: a0: System.String -> int * string
    /// This XML comment is invalid: unresolved cross-reference '%s'
    /// (Originally from FSComp.txt:1685)
    static member xmlDocUnresolvedCrossReference: a0: System.String -> int * string
    /// This XML comment is incomplete: no documentation for parameter '%s'
    /// (Originally from FSComp.txt:1686)
    static member xmlDocMissingParameter: a0: System.String -> int * string
    /// This expression uses the implicit conversion '%s' to convert type '%s' to type '%s'. See https://aka.ms/fsharp-implicit-convs. This warning may be disabled using '#nowarn \"3391\".
    /// (Originally from FSComp.txt:1687)
    static member tcImplicitConversionUsedForNonMethodArg: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// The 'AssemblyKeyNameAttribute' has been deprecated. Use 'AssemblyKeyFileAttribute' instead.
    /// (Originally from FSComp.txt:1688)
    static member containerDeprecated: unit -> int * string
    /// Key container signing is not supported on this platform.
    /// (Originally from FSComp.txt:1689)
    static member containerSigningUnsupportedOnThisPlatform: unit -> int * string
    /// This member access is ambiguous. Please use parentheses around the object creation, e.g. '(new SomeType(args)).MemberName'
    /// (Originally from FSComp.txt:1690)
    static member parsNewExprMemberAccess: unit -> int * string
    /// This expression uses the implicit conversion '%s' to convert type '%s' to type '%s'.
    /// (Originally from FSComp.txt:1691)
    static member tcImplicitConversionUsedForMethodArg: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// A [<Literal>] declaration cannot use an active pattern for its identifier
    /// (Originally from FSComp.txt:1692)
    static member tcLiteralAttributeCannotUseActivePattern: unit -> int * string
    /// This expression uses 'unit' for an 'obj'-typed argument. This will lead to passing 'null' at runtime. This warning may be disabled using '#nowarn \"3397\".
    /// (Originally from FSComp.txt:1693)
    static member tcUnitToObjSubsumption: unit -> int * string
    /// The resumable code construct '%s' may only be used in inlined code protected by 'if __useResumableCode then ...' and the overall composition must form valid resumable code.
    /// (Originally from FSComp.txt:1694)
    static member ilxgenInvalidConstructInStateMachineDuringCodegen: a0: System.String -> int * string
    /// The construct '%s' may only be used in valid resumable code.
    /// (Originally from FSComp.txt:1695)
    static member tcInvalidResumableConstruct: a0: System.String -> int * string
    /// Invalid resumable code. Any method of function accepting or returning resumable code must be marked 'inline'
    /// (Originally from FSComp.txt:1696)
    static member tcResumableCodeFunctionMustBeInline: unit -> int * string
    /// Invalid resumable code. Resumable code parameter must have name beginning with '__expand'
    /// (Originally from FSComp.txt:1697)
    static member tcResumableCodeArgMustHaveRightName: unit -> int * string
    /// Invalid resumable code. A resumable code parameter must be of delegate or function type
    /// (Originally from FSComp.txt:1698)
    static member tcResumableCodeArgMustHaveRightKind: unit -> int * string
    /// Invalid resumable code. A 'let rec' occurred in the resumable code specification
    /// (Originally from FSComp.txt:1699)
    static member tcResumableCodeContainsLetRec: unit -> int * string
    /// Using resumable code or resumable state machines requires /langversion:preview
    /// (Originally from FSComp.txt:1700)
    static member tcResumableCodeNotSupported: unit -> int * string
    /// Using methods with 'NoEagerConstraintApplicationAttribute' requires /langversion:6.0 or later
    /// (Originally from FSComp.txt:1701)
    static member tcNoEagerConstraintApplicationAttribute: unit -> int * string
    /// This state machine is not statically compilable. %s. An alternative dynamic implementation will be used, which may be slower. Consider adjusting your code to ensure this state machine is statically compilable, or else suppress this warning.
    /// (Originally from FSComp.txt:1702)
    static member reprStateMachineNotCompilable: a0: System.String -> int * string
    /// This state machine is not statically compilable and no alternative is available. %s. Use an 'if __useResumableCode then <state-machine> else <alternative>' to give an alternative.
    /// (Originally from FSComp.txt:1703)
    static member reprStateMachineNotCompilableNoAlternative: a0: System.String -> int * string
    /// Resumable code invocation. Suppress this warning if you are defining new low-level resumable code in terms of existing resumable code.
    /// (Originally from FSComp.txt:1704)
    static member tcResumableCodeInvocation: unit -> int * string
    /// Unknown debug point '%s'. The available debug points are '%s'.
    /// (Originally from FSComp.txt:1705)
    static member ilxGenUnknownDebugPoint: a0: System.String * a1: System.String -> int * string
    /// A resumable code invocation at '%s' could not be reduced
    /// (Originally from FSComp.txt:1706)
    static member reprResumableCodeInvokeNotReduced: a0: System.String -> string
    /// A 'let rec' occurred in the resumable code specification
    /// (Originally from FSComp.txt:1707)
    static member reprResumableCodeContainsLetRec: unit -> string
    /// A constrained generic construct occurred in the resumable code specification
    /// (Originally from FSComp.txt:1708)
    static member reprResumableCodeContainsConstrainedGenericLet: unit -> string
    /// A target label for __resumeAt was not statically determined. A __resumeAt with a non-static target label may only appear at the start of a resumable code method
    /// (Originally from FSComp.txt:1709)
    static member reprResumableCodeContainsDynamicResumeAtInBody: unit -> string
    /// A try/finally may not contain resumption points
    /// (Originally from FSComp.txt:1710)
    static member reprResumableCodeContainsResumptionInTryFinally: unit -> string
    /// The 'with' block of a try/with may not contain resumption points
    /// (Originally from FSComp.txt:1711)
    static member reprResumableCodeContainsResumptionInHandlerOrFilter: unit -> string
    /// A fast integer for loop may not contain resumption points
    /// (Originally from FSComp.txt:1712)
    static member reprResumableCodeContainsFastIntegerForLoop: unit -> string
    /// The resumable code value(s) '%s' does not have a definition
    /// (Originally from FSComp.txt:1713)
    static member reprResumableCodeValueHasNoDefinition: a0: System.String -> string
    /// A delegate or function producing resumable code in a state machine has type parameters
    /// (Originally from FSComp.txt:1714)
    static member reprResumableCodeDefinitionWasGeneric: unit -> string
    /// The state machine has an unexpected form
    /// (Originally from FSComp.txt:1715)
    static member reprStateMachineInvalidForm: unit -> string
    /// The value '%s' was marked 'InlineIfLambda' but was not determined to have a lambda value. This warning is for informational purposes only.
    /// (Originally from FSComp.txt:1716)
    static member optFailedToInlineSuggestedValue: a0: System.String -> int * string
    /// The 'InlineIfLambda' attribute is present in the signature but not the implementation.
    /// (Originally from FSComp.txt:1717)
    static member implMissingInlineIfLambda: unit -> int * string
    /// The 'InlineIfLambda' attribute may only be used on parameters of inlined functions of methods whose type is a function or F# delegate type.
    /// (Originally from FSComp.txt:1718)
    static member tcInlineIfLambdaUsedOnNonInlineFunctionOrMethod: unit -> int * string
    /// XML comment is not placed on a valid language element.
    /// (Originally from FSComp.txt:1719)
    static member invalidXmlDocPosition: unit -> int * string
    /// Invalid member declaration. The name of the member is missing or has parentheses.
    /// (Originally from FSComp.txt:1720)
    static member tcInvalidMemberDeclNameMissingOrHasParen: unit -> int * string
    /// The field '%s' appears multiple times in this record expression.
    /// (Originally from FSComp.txt:1721)
    static member tcAnonRecdDuplicateFieldId: a0: System.String -> int * string
    /// The field '%s' appears multiple times in this anonymous record type.
    /// (Originally from FSComp.txt:1722)
    static member tcAnonRecdTypeDuplicateFieldId: a0: System.String -> int * string
    /// Expecting expression
    /// (Originally from FSComp.txt:1723)
    static member parsExpectingExpression: unit -> int * string
    /// Trait '%s' is static
    /// (Originally from FSComp.txt:1724)
    static member tcTraitIsStatic: a0: System.String -> int * string
    /// Trait '%s' is not static
    /// (Originally from FSComp.txt:1725)
    static member tcTraitIsNotStatic: a0: System.String -> int * string
    /// A trait may not specify optional, in, out, ParamArray, CallerInfo or Quote arguments
    /// (Originally from FSComp.txt:1726)
    static member tcTraitMayNotUseComplexThings: unit -> int * string
    /// Invalid constraint. Valid constraint forms include \"'T :> ISomeInterface\" for interface constraints and \"SomeConstrainingType<'T>\" for self-constraints. See https://aka.ms/fsharp-type-constraints.
    /// (Originally from FSComp.txt:1727)
    static member tcInvalidSelfConstraint: unit -> int * string
    /// Invocation of a static constraint should use \"'T.Ident\" and not \"^T.Ident\", even for statically resolved type parameters.
    /// (Originally from FSComp.txt:1728)
    static member tcTraitInvocationShouldUseTick: unit -> int * string
    /// Declaring \"interfaces with static abstract methods\" is an advanced feature. See https://aka.ms/fsharp-iwsams for guidance. You can disable this warning by using '#nowarn \"3535\"' or '--nowarn:3535'.
    /// (Originally from FSComp.txt:1729)
    static member tcUsingInterfacesWithStaticAbstractMethods: unit -> int * string
    /// '%s' is normally used as a type constraint in generic code, e.g. \"'T when ISomeInterface<'T>\" or \"let f (x: #ISomeInterface<_>)\". See https://aka.ms/fsharp-iwsams for guidance. You can disable this warning by using '#nowarn \"3536\"' or '--nowarn:3536'.
    /// (Originally from FSComp.txt:1730)
    static member tcUsingInterfaceWithStaticAbstractMethodAsType: a0: System.String -> int * string
    /// The trait '%s' invoked by this call has multiple support types. This invocation syntax is not permitted for such traits. See https://aka.ms/fsharp-srtp for guidance.
    /// (Originally from FSComp.txt:1731)
    static member tcTraitHasMultipleSupportTypes: a0: System.String -> int * string
    /// The following required properties have to be initialized:%s
    /// (Originally from FSComp.txt:1732)
    static member tcMissingRequiredMembers: a0: System.String -> int * string
    /// Expecting pattern
    /// (Originally from FSComp.txt:1733)
    static member parsExpectingPattern: unit -> int * string
    /// Expected a pattern after this point
    /// (Originally from FSComp.txt:1734)
    static member parsExpectedPatternAfterToken: unit -> int * string
    /// Pattern discard is not allowed for union case that takes no data.
    /// (Originally from FSComp.txt:1735)
    static member matchNotAllowedForUnionCaseWithNoData: unit -> int * string
    /// SynType.Or is not permitted in this declaration
    /// (Originally from FSComp.txt:1736)
    static member tcSynTypeOrInvalidInDeclaration: unit -> int * string
    /// Duplicate parameter. The parameter '%s' has been used more that once in this method.
    /// (Originally from FSComp.txt:1737)
    static member chkDuplicatedMethodParameter: a0: System.String -> int * string
    /// Escapes curly braces before calling FormattableStringFactory.Create when interpolated string literal is typed as FormattableString
    /// (Originally from FSComp.txt:1738)
    static member featureEscapeBracesInFormattableString: unit -> string
    /// The source file '%s' (at position %d/%d) already appeared in the compilation list (at position %d/%d). Please verify that it is included only once in the project file.
    /// (Originally from FSComp.txt:1739)
    static member buildDuplicateFile: a0: System.String * a1: System.Int32 * a2: System.Int32 * a3: System.Int32 * a4: System.Int32 -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Constructor with arguments is not allowed.
    /// (Originally from FSComp.txt:1740)
    static member chkConstructorWithArgumentsOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Additional constructor is not allowed.
    /// (Originally from FSComp.txt:1741)
    static member chkAdditionalConstructorOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Instance members are not allowed.
    /// (Originally from FSComp.txt:1742)
    static member chkInstanceMemberOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Instance let bindings are not allowed.
    /// (Originally from FSComp.txt:1743)
    static member chkInstanceLetBindingOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Implementing interfaces is not allowed.
    /// (Originally from FSComp.txt:1744)
    static member chkImplementingInterfacesOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Abstract member declarations are not allowed.
    /// (Originally from FSComp.txt:1745)
    static member chkAbstractMembersDeclarationsOnStaticClasses: unit -> int * string
    /// If a type uses both [<Sealed>] and [<AbstractClass>] attributes, it means it is static. Explicit field declarations are not allowed.
    /// (Originally from FSComp.txt:1746)
    static member chkExplicitFieldsDeclarationsOnStaticClasses: unit -> int * string
    /// A type has been implicitly inferred as 'obj', which may be unintended. Consider adding explicit type annotations. You can disable this warning by using '#nowarn \"3559\"' or '--nowarn:3559'.
    /// (Originally from FSComp.txt:1747)
    static member typrelNeverRefinedAwayFromTop: unit -> int * string
    /// This copy-and-update record expression changes all fields of record type '%s'. Consider using the record construction syntax instead.
    /// (Originally from FSComp.txt:1748)
    static member tcCopyAndUpdateRecordChangesAllFields: a0: System.String -> int * string
    /// %s should not be aliased.
    /// (Originally from FSComp.txt:1749)
    static member chkAttributeAliased: a0: System.String -> int * string
    /// Unexpected end of input in 'else if' or 'elif' branch of conditional expression. Expected 'elif <expr> then <expr>' or 'else if <expr> then <expr>'.
    /// (Originally from FSComp.txt:1750)
    static member parsUnexpectedEndOfFileElif: unit -> int * string
    /// This is not a valid identifier
    /// (Originally from FSComp.txt:1751)
    static member lexInvalidIdentifier: unit -> int * string
    /// Missing union case name
    /// (Originally from FSComp.txt:1752)
    static member parsMissingUnionCaseName: unit -> int * string
    /// Expecting type
    /// (Originally from FSComp.txt:1753)
    static member parsExpectingType: unit -> int * string
    /// Diagnostic 3559 (warn when obj inferred) at informational level, off by default
    /// (Originally from FSComp.txt:1754)
    static member featureInformationalObjInferenceDiagnostic: unit -> string
    /// Allow static let bindings in union, record, struct, non-incremental-class types
    /// (Originally from FSComp.txt:1755)
    static member featureStaticLetInRecordsDusEmptyTypes: unit -> string
    /// Multiple type matches were found:\n%s\nThe type '%s' was used. Due to the overlapping field names\n%s\nconsider using type annotations or change the order of open statements.
    /// (Originally from FSComp.txt:1756)
    static member tcMultipleRecdTypeChoice: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// Expecting member body
    /// (Originally from FSComp.txt:1757)
    static member parsMissingMemberBody: unit -> int * string
    /// Missing keyword '%s'
    /// (Originally from FSComp.txt:1758)
    static member parsMissingKeyword: a0: System.String -> int * string
    /// The member or function '%s' has the 'TailCallAttribute' attribute, but is not being used in a tail recursive way.
    /// (Originally from FSComp.txt:1759)
    static member chkNotTailRecursive: a0: System.String -> int * string
    /// The meaning of _ is ambiguous here. It cannot be used for a discarded variable and a function shorthand in the same scope.
    /// (Originally from FSComp.txt:1760)
    static member tcAmbiguousDiscardDotLambda: unit -> int * string
    /// underscore dot shorthand for accessor only function
    /// (Originally from FSComp.txt:1761)
    static member featureAccessorFunctionShorthand: unit -> string
    /// Constraint intersection syntax may only be used with flexible types, e.g. '#IDisposable & #ISomeInterface'.
    /// (Originally from FSComp.txt:1762)
    static member parsConstraintIntersectionSyntaxUsedWithNonFlexibleType: unit -> int * string
    /// Static bindings cannot be added to extrinsic augmentations. Consider using a 'static member' instead.
    /// (Originally from FSComp.txt:1763)
    static member tcStaticBindingInExtrinsicAugmentation: unit -> int * string
    /// Newly added pickle state cannot be used in FSharp.Core, since it must be working in older compilers+tooling as well. The time window is at least 3 years after feature introduction. Violation: %s . Context: \n %s 
    /// (Originally from FSComp.txt:1764)
    static member pickleFsharpCoreBackwardsCompatible: a0: System.String * a1: System.String -> int * string
    /// This override takes a tuple instead of multiple arguments. Try to add an additional layer of parentheses at the method definition (e.g. 'member _.Foo((x, y))'), or remove parentheses at the abstract method declaration (e.g. 'abstract member Foo: 'a * 'b -> 'c').
    /// (Originally from FSComp.txt:1765)
    static member tcOverrideUsesMultipleArgumentsInsteadOfTuple: unit -> int * string
    /// Interop between C#'s and F#'s unmanaged generic constraint (emit additional modreq)
    /// (Originally from FSComp.txt:1766)
    static member featureUnmanagedConstraintCsharpInterop: unit -> string
    /// This expression is an anonymous record, use {|...|} instead of {...}.
    /// (Originally from FSComp.txt:1767)
    static member chkCopyUpdateSyntaxInAnonRecords: unit -> int * string
    /// Interpolated string contains untyped identifiers. Adding typed format specifiers is recommended.
    /// (Originally from FSComp.txt:1768)
    static member alwaysUseTypedStringInterpolation: unit -> int * string
    /// Unexpected function type in union case field definition. If you intend the field to be a function, consider wrapping the function signature with parens, e.g. | Case of a -> b into | Case of (a -> b).
    /// (Originally from FSComp.txt:1769)
    static member tcUnexpectedFunTypeInUnionCaseField: unit -> int * string
    /// An indexed property's getter and setter must have the same type. Property '%s' has getter of type '%s' but setter of type '%s'.
    /// (Originally from FSComp.txt:1770)
    static member chkIndexedGetterAndSetterHaveSamePropertyType: a0: System.String * a1: System.String * a2: System.String -> int * string
    /// This is a function definition that shadows a union case. If this is what you want, ignore or suppress this warning. If you want it to be a union case deconstruction, add parentheses.
    /// (Originally from FSComp.txt:1771)
    static member tcInfoIfFunctionShadowsUnionCase: unit -> int * string
    /// Parentheses can be removed.
    /// (Originally from FSComp.txt:1772)
    static member unnecessaryParentheses: unit -> int * string
    /// Shorthand lambda syntax is only supported for atomic expressions, such as method, property, field or indexer on the implied '_' argument. For example: 'let f = _.Length'.
    /// (Originally from FSComp.txt:1773)
    static member tcDotLambdaAtNotSupportedExpression: unit -> int * string
    /// If a multicase union type is a struct, then all fields with the same name must be of the same type. This rule applies also to the generated 'Item' name in case of unnamed fields.
    /// (Originally from FSComp.txt:1774)
    static member tcStructUnionMultiCaseFieldsSameType: unit -> int * string
    /// Share underlying fields in a [<Struct>] discriminated union as long as they have same name and type
    /// (Originally from FSComp.txt:1775)
    static member featureReuseSameFieldsInStructUnions: unit -> string
    /// No static abstract member was found that corresponds to this override
    /// (Originally from FSComp.txt:1776)
    static member tcNoStaticMemberFoundForOverride: unit -> int * string
    /// No static abstract property was found that corresponds to this override
    /// (Originally from FSComp.txt:1777)
    static member tcNoStaticPropertyFoundForOverride: unit -> int * string
    /// Object expressions cannot implement interfaces with static abstract members or declare static members.
    /// (Originally from FSComp.txt:1778)
    static member chkStaticMembersOnObjectExpressions: unit -> int * string
    /// The TailCall attribute should only be applied to recursive functions.
    /// (Originally from FSComp.txt:1779)
    static member chkTailCallAttrOnNonRec: unit -> int * string
    /// Incomplete declaration of a static construct. Use 'static let','static do','static member' or 'static val' for declaration.
    /// (Originally from FSComp.txt:1780)
    static member parsStaticMemberImcompleteSyntax: unit -> int * string
    /// Expecting record field
    /// (Originally from FSComp.txt:1781)
    static member parsExpectingRecordField: unit -> int * string
    /// The type '%s' has too many methods. Found: '%d', maximum: '%d'
    /// (Originally from FSComp.txt:1782)
    static member tooManyMethodsInDotNetTypeWritingAssembly: a0: System.String * a1: System.Int32 * a2: System.Int32 -> int * string
    /// Only simple patterns are allowed in primary constructors
    /// (Originally from FSComp.txt:1783)
    static member parsOnlySimplePatternsAreAllowedInConstructors: unit -> int * string
    /// A static abstract non-virtual interface member should only be called via type parameter (for example: 'T.%s).
    /// (Originally from FSComp.txt:1784)
    static member chkStaticAbstractInterfaceMembers: a0: System.String -> int * string
    /// Classes cannot contain static abstract members.
    /// (Originally from FSComp.txt:1785)
    static member chkStaticAbstractMembersOnClasses: unit -> int * string
    /// This active pattern does not expect any arguments, i.e., it should be used like '%s' instead of '%s x'.
    /// (Originally from FSComp.txt:1786)
    static member tcActivePatternArgsCountNotMatchNoArgsNoPat: a0: System.String * a1: System.String -> int * string
    /// This active pattern expects exactly one pattern argument, e.g., '%s pat'.
    /// (Originally from FSComp.txt:1787)
    static member tcActivePatternArgsCountNotMatchOnlyPat: a0: System.String -> int * string
    /// This active pattern expects %d expression argument(s), e.g., '%s%s'.
    /// (Originally from FSComp.txt:1788)
    static member tcActivePatternArgsCountNotMatchArgs: a0: System.Int32 * a1: System.String * a2: System.String -> int * string
    /// This active pattern expects %d expression argument(s) and a pattern argument, e.g., '%s%s pat'.
    /// (Originally from FSComp.txt:1789)
    static member tcActivePatternArgsCountNotMatchArgsAndPat: a0: System.Int32 * a1: System.String * a2: System.String -> int * string
    /// # directives with non-quoted string arguments
    /// (Originally from FSComp.txt:1790)
    static member featureParsedHashDirectiveArgumentNonString: unit -> string
    /// Unexpected integer literal '%d'.
    /// (Originally from FSComp.txt:1791)
    static member featureParsedHashDirectiveUnexpectedInteger: a0: System.Int32 -> int * string
    /// Unexpected identifier '%s'.
    /// (Originally from FSComp.txt:1792)
    static member featureParsedHashDirectiveUnexpectedIdentifier: a0: System.String -> int * string
    /// Support for computation expressions with empty bodies: builder { }
    /// (Originally from FSComp.txt:1793)
    static member featureEmptyBodiedComputationExpressions: unit -> string
    /// Expecting union case field
    /// (Originally from FSComp.txt:1794)
    static member parsExpectingUnionCaseField: unit -> int * string
    /// Allow access modifiers to auto properties getters and setters
    /// (Originally from FSComp.txt:1795)
    static member featureAllowAccessModifiersToAutoPropertiesGettersAndSetters: unit -> string
    /// Access modifiers cannot be applied to an SRTP constraint.
    /// (Originally from FSComp.txt:1796)
    static member tcAccessModifiersNotAllowedInSRTPConstraint: unit -> int * string
    /// Allow object expressions without overrides
    /// (Originally from FSComp.txt:1797)
    static member featureAllowObjectExpressionWithoutOverrides: unit -> string
    /// Use type conversion cache during compilation
    /// (Originally from FSComp.txt:1798)
    static member featureUseTypeSubsumptionCache: unit -> string
    /// Multi-case partial active patterns are not supported. Consider using a single-case partial active pattern or a full active pattern.
    /// (Originally from FSComp.txt:1799)
    static member tcPartialActivePattern: unit -> int * string
    /// Don't warn on uppercase identifiers in binding patterns
    /// (Originally from FSComp.txt:1800)
    static member featureDontWarnOnUppercaseIdentifiersInBindingPatterns: unit -> string
    /// This construct is deprecated. Sequence expressions should be of the form 'seq { ... }'
    /// (Originally from FSComp.txt:1801)
    static member chkDeprecatePlacesWhereSeqCanBeOmitted: unit -> int * string
    /// Expected unit-of-measure type parameter must be marked with the [<Measure>] attribute.
    /// (Originally from FSComp.txt:1802)
    static member tcExpectedTypeParamMarkedWithUnitOfMeasureAttribute: unit -> int * string
    /// Deprecate places where 'seq' can be omitted
    /// (Originally from FSComp.txt:1803)
    static member featureDeprecatePlacesWhereSeqCanBeOmitted: unit -> string
    /// Support ValueOption as valid type for optional member parameters
    /// (Originally from FSComp.txt:1804)
    static member featureSupportValueOptionsAsOptionalParameters: unit -> string
    /// Warn when unit is passed to a member accepting `obj` argument, e.g. `Method(o:obj)` will warn if called via `Method()`.
    /// (Originally from FSComp.txt:1805)
    static member featureSupportWarnWhenUnitPassedToObjArg: unit -> string
    /// Allows use! _ = ... in computation expressions
    /// (Originally from FSComp.txt:1806)
    static member featureUseBangBindingValueDiscard: unit -> string
    /// Support for better anonymous record parsing
    /// (Originally from FSComp.txt:1807)
    static member featureBetterAnonymousRecordParsing: unit -> string
    /// Support for scoped enabling / disabling of warnings by #warn and #nowarn directives, also inside modules
    /// (Originally from FSComp.txt:1808)
    static member featureScopedNowarn: unit -> string
    /// Error when invalid declarations are used in type definitions.
    /// (Originally from FSComp.txt:1809)
    static member featureErrorOnInvalidDeclsInTypeDefinitions: unit -> string
    /// Allow let! and use! type annotations without requiring parentheses
    /// (Originally from FSComp.txt:1810)
    static member featureAllowLetOrUseBangTypeAnnotationWithoutParens: unit -> string
    /// #nowarn/#warnon directives must appear as the first non-whitespace characters on a line
    /// (Originally from FSComp.txt:1811)
    static member lexWarnDirectiveMustBeFirst: unit -> int * string
    /// Warn directives must have warning number(s) as argument(s)
    /// (Originally from FSComp.txt:1812)
    static member lexWarnDirectiveMustHaveArgs: unit -> int * string
    /// There is another %s for this warning already in line %d.
    /// (Originally from FSComp.txt:1813)
    static member lexWarnDirectivesMustMatch: a0: System.String * a1: System.Int32 -> int * string
    /// The file '%s' was also pointed to in a line directive in '%s'. Proper warn directive application may not be possible.
    /// (Originally from FSComp.txt:1814)
    static member lexLineDirectiveMappingIsNotUnique: a0: System.String * a1: System.String -> int * string
    /// This attribute is not valid for use on union cases with fields.
    /// (Originally from FSComp.txt:1815)
    static member tcAttributeIsNotValidForUnionCaseWithFields: unit -> int * string
    /// Support for ReturnFromFinal/YieldFromFinal in computation expressions to enable tailcall optimization when available on the builder.
    /// (Originally from FSComp.txt:1816)
    static member featureReturnFromFinal: unit -> string
    static member RunStartupValidation: unit -> unit
