module Variable

(*
let x = 10 
let y = 20
let z = x + y

printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z


let x = 15
let y = 20
let z = x + y

printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z
*)

(*
let x:int32 = 10
let y:int32 = 20
let z:int32 = x + y

printfn "x: %d" x
printfn "y: %d" y
printfn "z: %d" z

let p:float = 15.99
let q:float = 20.78
let r:float=p+q

printfn "p: %g" p
printfn "q: %g" q
printfn "r: %g" r
*)

let mutable a = 18
let b = 10
a <- 5

printfn "a: %d" a

let mutable x  =10
let y = 20
let mutable z = x + y

printfn "Original Values:"
printfn "x: %i" x
printfn "y: %d" y
printfn "z: %i" z

printfn "Let us change the value of x"
printfn "Value of z will change too."

x <- 15
z <- x + y

printfn "New Values:"
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z