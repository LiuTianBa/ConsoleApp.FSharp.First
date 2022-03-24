module Enum

type Days = 
    | Sum = 0
    | Mon = 1
    | Tues = 2
    | Wed =3
    | Thurs = 4
    | Fri = 5
    | Sat = 6

let weekend1 : Days = Days.Sat
let weekend2 : Days = Days.Sum
let weekDay1 : Days = Days.Mon

printfn "Monday: %A" weekDay1
printfn "Saturday: %A" weekend1
printfn "Sunday: %A" weekend2