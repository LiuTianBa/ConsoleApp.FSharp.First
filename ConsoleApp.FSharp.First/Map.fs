module Map

let students = 
    Map.empty.
        Add("Zara Ali","1501").
       Add("Rishita Gupta", "1502").
         Add("Robin Sahoo", "1503").
         Add("Gillian Megan", "1504")
printfn "Map - students: %A" students

let capitals = 
    [ "Argentina","Buenos Aires";
        "Frace","Paris";
        "Chili","Santiago";
        "Malaysia","Kuala Lumpur";
        "Switzerland","Bern"]
    |> Map.ofList
printfn "Map capitals : %A" capitals

printfn "%A" students.["Zara Ali"]

printfn "Map - number of students: %d" students.Count

let found = students.TryFind "Malaysia"
match found with
 | Some x -> printfn "Found %s." x
 | None -> printfn "Do not find the specified value."