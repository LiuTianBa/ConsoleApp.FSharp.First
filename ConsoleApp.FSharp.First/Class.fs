module Class

(*
// Class definition:
type [access-modifier] type-name [type-params] [access-modifier] ( parameter-list ) [ as identifier ] =
   [ class ]
      [ inherit base-type-name(base-constructor-args) ]
      [ let-bindings ]
      [ do-bindings ]
      member-list
      ...
   [ end ]

// Mutually recursive class definitions:
type [access-modifier] type-name1 ...
and [access-modifier] type-name2 ...
...
*)

type Line = class
    val X1 : float
    val Y1 : float
    val X2 : float
    val Y2 : float

    new (x1,y1,x2,y2) as this = 
        {X1 = x1;Y1=y1;X2=x2;Y2=y2;}
        then
            printfn" Creating Line: {(%g, %g), (%g, %g)} Length: %g"  this.X1 this.Y1 this.X2 this.Y2 this.length


    member x.length = 
        let sqr x = x * x
        sqrt(sqr(x.X1-x.X2) + sqr(x.Y1 - x.Y2))
end

let aLine  = new Line(1.0,1.0,4.0,5.0)


type Greetings(name) as gr = 
    let data = name
    do
        gr.PrintMessage()
    member this.PrintMessage() =
        printfn "Hello %s" data

let gtr = new Greetings("Zara")