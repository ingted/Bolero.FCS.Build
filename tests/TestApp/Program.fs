open System
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Text

[<EntryPoint>]
let main argv =
    printfn "Initializing FSharpChecker..."
    let checker = FSharpChecker.Create()
    
    let source = """
module Test
let x = 42
"""
    let sourceText = SourceText.ofString source
    let options, _ = checker.GetProjectOptionsFromScript("test.fsx", sourceText, assumeDotNetFramework=false) |> Async.RunSynchronously
    
    printfn "Parsing..."
    let parseResults, answer = checker.ParseAndCheckFileInProject("test.fsx", 0, sourceText, options) |> Async.RunSynchronously
    
    match answer with
    | FSharpCheckFileAnswer.Aborted -> 
        printfn "Aborted"
        1
    | FSharpCheckFileAnswer.Succeeded(checkResults) ->
        printfn "Checked!"
        if checkResults.Diagnostics.Length = 0 then
            printfn "Success: No errors."
            0
        else
            printfn "Errors found:"
            for e in checkResults.Diagnostics do
                printfn "%s" e.Message
            1