module PatternMatching

(*
match expr with
    | pat1 - result1
    | pat2 -> result2
    | pat3 when expr2 -> result3
    | _ -> defaultResult
*)

let rec fib n =
    match n with
    | n when n <1 -> 0
    | 1 -> 1
    | _ -> fib(n-1) + fib(n-2)

for i = 1 to 10 do
    printfn "Fibonacii %d: %d" i (fib i)

let printSeason month = 
    match month with
    | "December" | "January" | "February" -> printfn "Winter"
    | "March" | "April" -> printfn "Spring"
    | "May" | "June" -> printfn "Summer"
    | "July" | "August" -> printfn "Rainy"
    | "September" | "October" | "November" -> printfn "Autumn"
    | _ -> printfn "Season depends on month!"

printSeason "February"
printSeason "April"
printSeason "November"
printSeason "July"

let getRate = function
| "potato" -> 10.00
| "brinjal" -> 20.50
| "cauliflower" -> 21.00
| "cabbage" -> 8.75
| "carrot" -> 15.00
| _ -> nan (* nan is a special value meaning "not a number" *)

printfn "%g"(getRate "potato")
printfn "%g"(getRate "brinjal")
printfn "%g"(getRate "cauliflower")
printfn "%g"(getRate "cabbage")
printfn "%g"(getRate "carrot")


let sign = function
| 0 -> 0
| x when x < 0 -> -1
| x when x > 0 -> 1

printfn "%d" (sign -20)
printfn "%d" (sign 20)
printfn "%d" (sign 0)

let compareInt x = 
    match x with
    | (var1,var2) when var1 > var2 ->  printfn "%d is greater than %d" var1 var2
    | (var1,var2) when var1 < var2 -> printfn "%d is less than %d" var1 var2
    | (var1,var2) -> printfn "%d equals %d" var1 var2

compareInt(11,25)
compareInt(72,10)
compareInt(0,0)


type Point = {x: float ; y : float}
let evaluatePoint (point: Point) = 
    match point with
    | {x = 0.0;y =0.0} -> printfn "Point is at the origin."
    | { x = xVal; y = 0.0 } -> printfn "Point is on the x-axis. Value is %f." xVal
    | { x = 0.0; y = yVal } -> printfn "Point is on the y-axis. Value is %f." yVal
    | { x = xVal; y = yVal } -> printfn "Point is at (%f, %f)." xVal yVal

evaluatePoint { x = 0.0; y = 0.0 }
evaluatePoint { x = 10.0; y = 0.0 }
evaluatePoint { x = 0.0; y = 10.0 }
evaluatePoint { x = 10.0; y = 10.0 }