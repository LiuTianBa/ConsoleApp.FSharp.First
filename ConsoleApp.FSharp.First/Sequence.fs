module Sequence

let seq1 =  seq { 1 .. 10 }
let seq2 = seq {1..5..50}
let seq3 = seq {50..-5..1}
let seq4 = seq{ for a in 1..10 do yield a,a*a,a*a*a }

printfn "The Sequence: %A" seq1
printfn "The Sequence: %A" seq2
printfn "The Sequence: %A" seq3
printfn "The Sequence: %A" seq4



let isprime n = 
    let rec check i =
        i > n/2 || (n % i <> 0 && check(i + 1))
    check 2

let primeIn50 = seq { for n in 1..50 do if isprime n then yield n }
for x in primeIn50 do
   printfn "%d" x 


let emptySeq = Seq.empty
let seq5 = Seq.singleton 20
printfn"The singleton sequence:"
printfn "%A " seq5

let seq6 = Seq.init 5( fun n -> n * 3)
Seq.iter(fun i -> printf "%d " i) seq6
printf "\n"

let seq7 = [|1..10|] :> seq<int>
Seq.iter(fun i -> printfn "%d " i) seq7
printf "\n"

let seq8 = [|2..2..20|] |> Seq.ofArray
Seq.iter (fun i -> printf "%d " i) seq8


let seq9 = Seq.unfold(fun state -> if (state> 20) then None else Some(state,state+1)) 0
for x in seq9 do printf "%d " x
printfn ""

let mySeq = seq {for i in 1..10 -> 3*i}
let truncateSeq = Seq.truncate 5 mySeq
let takeSeq = Seq.take 5 mySeq

printfn"The original sequence"
Seq.iter (fun i -> printf "%d " i) mySeq
printfn""

printfn"The truncated sequence"
Seq.iter (fun i -> printf "%d " i) truncateSeq
printfn""

printfn"The take sequence"
Seq.iter (fun i -> printf "%d " i) takeSeq
printfn""