module IO

//%[flags][width][.precision][type]

printfn "%g" 2.33430020
printf "Hello "
printf "World"
printfn ""
printfn "Hello "
printfn "World"
printf  "Hi, I'm %s and I'm a %s" "Rohit" "Medical Student"

printfn "d: %f" 212.098f
printfn "e: %f" 504.768f

printfn "x: %g" 212.098f
printfn "y: %g" 504.768f

printfn "x: %e" 212.098f
printfn "y: %e" 504.768f
printfn "True: %b" true

// Console
open  System

Console.Write("What's your name? ")
let name = Console.ReadLine()
Console.Write("Hello, {0}",name)
Console.WriteLine(String.Format("Big Greetings from {0} and {1}", "TutorialsPoint", "Absoulte Classes"))
Console.WriteLine(String.Format("|{0:yyyy-MMM-dd}|", System.DateTime.Now))

// System.IO
open System.IO

File.WriteAllText("test.txt","Hello There 
Welcome to:
Tutorial Point
")
let msg = File.ReadAllText("test.txt")
printfn "%s" msg
