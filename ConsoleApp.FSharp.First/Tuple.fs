module Tuple
let a = 1
let b = 2

// Tuple of two integers.
( 4, 5 )

// Tuple  of strings.
( "one", "two", "three")

// Tuple of unknown types.
(a, b)

// Tuple that has mixed types.
("Absolute Classes", 1, 2.0)

// Tuple of integer expressions.

(a * 4, b + 7)

let averageFour (a,b,c,d) = 
    let sum = a + b + c + d
    sum / 4.0

let avg:float = averageFour (4.5,5.1,5.6,7.8)
printfn "Avg of four numbers: %f" avg

let display tuple1 = 
    match tuple1 with
    | (a,b,c) -> printfn "Detail Info: %A %A %A" a b c
display ("Zara Ali", "Hyderabad", 10)
printfn "%A" ("Zara Ali", "Hyderabad", 10)

printfn "First member: %A" ((fst(27,39)))
printfn "Second member: %A" ((snd(27,39)))

printfn "First member: %A" (fst("Hello","World"))
printfn "Second member: %A" (snd("Hello","World"))

let nameTuple  = ("Lau","Sion")
printfn "First Name: %A" (fst nameTuple)
printfn "Second Name: %A" (snd nameTuple)