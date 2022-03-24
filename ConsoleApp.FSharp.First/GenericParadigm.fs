module GenericParadigm

let printFunc (x: 'a) = 
    do printfn "%A" x

//type genericClass<string> 'a

//let gr = new genericClass<string>("zara")
//let gs = genericClass(seq {for i in 1..10 -> (i,i*i)})