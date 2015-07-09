// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv =
    let x = (new ClassLibrary1.Class1()).GetFromClassLibrary2()
 
    printfn "%A" argv
    0 // return an integer exit code
