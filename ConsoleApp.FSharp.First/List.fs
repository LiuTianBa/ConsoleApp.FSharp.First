module List

(* using list literals *)
let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
printfn "The list: %A" list1

(*using cons operator *)
let list2 = 1 :: 2 :: 3 :: []
printfn "The list: %A" list2

(* using range constructs*)
let list3 = [1 .. 10]
printfn "The list: %A" list3

(* using range constructs *)
let list4 = ['a' .. 'm']
printfn "The list: %A" list4

(* using init method *)
let list5 = List.init 5 (fun index -> (index, index * index, index * index * index))
printfn "The list: %A" list5

(* using yield operator *)
let list6 = [ for a in 1 .. 10 do yield (a * a) ]
printfn "The list: %A" list6

(* using yield operator *)
let list7 = [ for a in 1 .. 100 do if a % 3 = 0 && a % 5 = 0 then yield a]
printfn "The list: %A" list7

(* using yield! operator *)
let list8 = [for a in 1 .. 3 do yield! [ a .. a + 3 ] ]
printfn "The list: %A" list8

// use of properties
printfn "list1.isempty is %b" list1.IsEmpty
printfn "list1.Length is %d"  list1.Length
printfn "list1.Head is %d" list1.Head
printfn "list1.Tail.Head is %d" list1.Tail.Head
printfn "list1.Tail.Tail.Head is %d" list1.Tail.Tail.Head
printfn "list1.Item(1) is %d" (list1.Item(1))

let reverse lt =
    let rec loop acc = function
        |[] -> acc
        |hd :: tl -> loop (hd :: acc) tl
    loop [] lt
printfn "The reversed list: %A" (reverse list1)

let sumList list = List.fold(fun acc elem -> acc + elem) 0 list
printfn "Sum of the elements of list %A is %d." [ 1 .. 10 ] (sumList [ 1 .. 10 ])