module Exception

// exception exception-type of argument-type

let divisionprog x y =
    try
        Some(x/y)
    with
    | :? System.DivideByZeroException -> printfn "Division by zero!"; None

let res = divisionprog 100 0

exception Error1 of string
exception Error2 of string * int

let myFunction x y = 
    try
        if x = y then raise(Error1("Equal Number Error"))
        else raise (Error2("Error Not Detected",100))
    with
        | Error1(str) -> printfn "Error1 %s" str
        | Error2(str,i) -> printfn "Error2 %s %d" str i

myFunction 20 10
myFunction 5 5

exception InnerError of string 
exception OuterError of string 

let func1 x y =
    try 
       try
        if x = y then raise(InnerError("InnerError"))
        else raise(OuterError("OuterError"))
       with
       | InnerError(str) -> printfn "%s" str
    finally
        printfn "This is a finally note"

let func2 x y = 
    try
        func1 x y 
    with 
    | OuterError(str) -> printfn "%s" str

func2 100 150
func2 100 100
func2 100 120

let divFunc x y =
    if (y = 0) then failwith "Divisor cannot be zero."
    else x / y

let tryDivFunc x y =
    try
        divFunc x y 
    with
        | Failure(msg) -> printfn "%s" msg; 0

let result1 = tryDivFunc 100 0
let result2 = tryDivFunc 100 4
printfn "%A" result1
printfn "%A" result2

let days = [| "Sunday"; "Monday"; "Tuesday"; "Wednesday"; "Thursday"; "Friday"; "Saturday" |]
let findDay x = 
    if(x>7 || x<1) then invalidArg "days" (sprintf "You have entered %d." x)
    days.[x-1]
printfn "%s" (findDay 1)
printfn "%s" (findDay 5)
printfn "%s" (findDay 9)