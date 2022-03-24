module Struct

(*
[ attributes ]
type [accessibility-modifier] type-name =
   struct
      type-definition-elements
   end
// or
[ attributes ]
[<StructAttribute>]
type [accessibility-modifier] type-name =
   type-definition-elements
*)

type Line = struct
   val X1 : float
   val Y1 : float
   val X2 : float
   val Y2 : float

   new (x1, y1, x2, y2) =
      {X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;}
end


let calcLength(a : Line)=
   let sqr a = a * a
   sqrt(sqr(a.X1 - a.X2) + sqr(a.Y1 - a.Y2) )

let aLine = new Line(1.0, 1.0, 4.0, 5.0)
let length = calcLength aLine
printfn "Length of the Line: %g " length