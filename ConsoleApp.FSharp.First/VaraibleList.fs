module VaraibleList

open System.Collections.Generic

let booksList = new List<string>()
booksList.Add("Gone with the Wind")
booksList.Add("Atlas Shrugged")
booksList.Add("Fountainhead")
booksList.Add("Thornbirds")
booksList.Add("Rebecca")
booksList.Add("Narnia");

printfn "Total %d books" booksList.Count
booksList |> Seq.iteri(fun index item ->printfn "%i: %s" index item)
booksList.Insert(2,"Roots")

printfn ("after inserting at index 2")
printfn "Total %d books" booksList.Count

booksList |> Seq.iteri(fun index item -> printfn "%i: %s" index booksList.[index])
booksList.RemoveAt(3)

printfn("after removing from index 3")
printfn"Total %d books" booksList.Count

booksList |> Seq.iteri (fun index item -> printfn "%i: %s" index booksList.[index])