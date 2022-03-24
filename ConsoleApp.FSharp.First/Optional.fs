module Optional

let div x y = x / y
let res = div 20 0
printfn "Result: %d" res


let div2 x y =
    match y with 
    | 0 -> None
    | _ -> Some(x/y)

let res2 : int option  = div2 20 4
printfn "%A" res2
printfn "%A" res2.Value

let checkPositive (a : int) =
   if a > 0 then
      Some(a)
   else
      None
let res3 : int option =checkPositive(-31)
printfn "Result: %A" res3

let isHundred  = function
    | Some(100) -> true
    | Some(_) | None -> false

printfn "%A" (isHundred (Some(45)))
printfn "%A" (isHundred (Some(100)))
printfn "%A" (isHundred None)