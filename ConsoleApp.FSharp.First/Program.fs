// Learn more about F# at http://fsharp.org

open System

type student =
    { Name : string;
        ID : int;
        RegistrationText : string ;
        IsRegistered : bool}

let getStudent name id =
    {Name = name; ID = id ;RegistrationText = null; IsRegistered= false}

let registerStudent st = 
    {
    st with 
        RegistrationText = "Registered";
        IsRegistered = true}

let printStudent msg st =   
    printfn "%s: %A" msg st

let main() =
    let preRegisteredStudent = getStudent "Zara" 10
    let postRegisteredStudent = registerStudent preRegisteredStudent

    printStudent "Before Registration: " preRegisteredStudent
    printStudent "After Registration: " postRegisteredStudent

//main()
open System.Collections.Generic
let dict = new  Dictionary<string,string>()
dict.Add("1501","Zara Ali")
dict.Add("1502","Rishita Gupta")
dict.Add("1503","Robin Sahoo")
dict.Add("1504","Gillian Megan")
printfn "Dictionary - students: %A" dict
printfn "Total Number of Students: %d" dict.Count
printfn "The keys: %A" dict.Keys
printfn "The Values: %A" dict.Values