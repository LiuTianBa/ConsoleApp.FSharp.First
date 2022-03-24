module Delegate

// type  delegate-typename = delegate of type1 -> type2


type MyClass() =
    static member add(a : int,b : int) =
        a + b
    static member sub( a : int )( b : int) =
        a - b
    member x.Add( a : int, b : int ) = 
        a + b
    member x.Sub(a:int)(b:int) =
        a - b

// Delegate1 works with tuple arguments.
type Delegate1 = delegate of (int * int) -> int

// Delegate2 works with curried arguments.
type  Delegate2 = delegate of int * int -> int

let InvokeDelegate1 (dlg : Delegate1) (a : int) (b: int) = dlg.Invoke(a, b)
let InvokeDelegate2 (dlg : Delegate2) (a : int) (b: int) = dlg.Invoke(a, b)

let del1 : Delegate1 = new Delegate1(MyClass.add)
let del2 : Delegate2 = new Delegate2(MyClass.sub)

let mc = MyClass()

let del3 : Delegate1 = new Delegate1(mc.Add)
let del4 : Delegate2 = new Delegate2(mc.Sub)

for (a , b) in  [(400,200);(100,45)] do
    printfn "%d + %d = %d" a b (InvokeDelegate1 del1 a b)
    printfn "%d - %d = %d" a b (InvokeDelegate2 del2 a b)
    printfn "%d + %d = %d" a b (InvokeDelegate1 del3 a b)
    printfn "%d - %d = %d" a b (InvokeDelegate2 del4 a b)