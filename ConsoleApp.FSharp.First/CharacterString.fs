module CharacterString

let xml = @"<book author=""Lewis, c.s"" title=""Narnia"">"
let xml2 = """<book author="Lewis, c.s" title="Narnia">"""
printfn "%s" xml
printfn "%s" xml2

let collectTesting inputS = 
    String.collect(fun c -> sprintf "%c " c) inputS
printfn "%s" (collectTesting "Hello World!")

let strings = ["Tutorials Point";"Coding Ground";"Absolute Classes"]
let ourProducts = String.concat "\n" strings
printfn "%s" ourProducts

printfn "%s" <| String.replicate 10 "*! "