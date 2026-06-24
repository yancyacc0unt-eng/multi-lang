open System.Runtime.InteropServices
open CS_Library
open VB_Library

[<DllImport("C:/Users/yancy/Documents/MyProjects/multi-lang/x64/Debug/cppDLL.dll", CallingConvention = CallingConvention.StdCall)>]
extern int64 random(int64 ticks)

let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    printfn "Hello world %s" (from "F#")
    let number = random(System.DateTime.Now.Ticks)
    printfn "Random number from C++ : %d" number
    let testobj = new CS_Library.test()
    printfn "Hello world %s" (from (testobj.getmsg()))
    let class1obj = new Class1()
    class1obj.SayHello() |> ignore
    0
