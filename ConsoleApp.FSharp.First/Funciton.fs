module Funciton

let cylinderVolume radius length : float =
    
    let pi = 3.1415926
    length * pi * radius * radius

let vol = cylinderVolume 3.0 5.0
// printfn "Volume: %g " vol

let max num1 num2 =
    if num1 > num2 then
        num1
    else
        num2

let m = max 1 2
// printfn "max of 1,2: %d" m

let doubleint i:int32 =
    i * 2

printfn "double 27 is: %d" (doubleint(27))

let rec fib n:int32 = 
    if n<2 then
        1
    else
        fib(n-1) + fib(n-2)

for i = 1 to 10 do
    printfn "n = 1,fib(1) = %d" (fib(i))

open System
let  rec fact x:int = 
    if x < 1 then 1
    else x * fact(x - 1)

Console.WriteLine(fact 8);       
Console.WriteLine(fact(8));
Console.WriteLine((fact(8)));

let mydivfunction x y = (x / y).ToString()

let list = List.map ( fun i -> i + 1) [1;2;3]
printfn "%A" list

let applyFunction ( f: int -> int -> int) x y = f x y
let res = applyFunction (fun x y -> x * y ) 5 7
printfn "%d" res

let fun1 x = x + 1
let fun2 x = x * 5

let f= fun1 >> fun2
let r = f 9
printfn "%d" r

let fun3 x = x + 1
let fun4 x = x * 5

let rt = 9 |> fun3 |> fun4
printfn "%d" rt
