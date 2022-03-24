

// namespace [rec] [parent-namespaces.]identifier

(*namespace Widgets

type MyWidget1 = 
    member this.WidgetName = "Widget1"
module WidgetsMoudule =
    let  widgetName = "Widget2"
*)
(*
module Widgets.WidgetModule
    let widgetFunction x y =
       printfn "%A %A" x y
       *)
namespace Widgets
module WidgetModule =
    let widgetFunction x y =
        printfn "%A %A" x y

namespace Widgets
module WidgetModule1 =
   let widgetFunction x y =
      printfn "Module1 %A %A" x y
module WidgetModule2 =
   let widgetFunction x y =
      printfn "Module2 %A %A" x y
module useWidgets =
  
     WidgetModule1.widgetFunction 10 20
     WidgetModule2.widgetFunction 5 6

namespace Outer
// Full name: Outer.MyClass
type MyClass() =
   member this.X(x) = x + 1
// Fully qualify any nested namespaces.
namespace Outer.Inner
// Full name: Outer.Inner.MyClass
type MyClass() =
   member this.Prop1 = "X"

namespace global
type SomeType() = member this.SomeMember = 0

//global.System.Console.WriteLine("Hello World!")


namespace rec MutualReferences
type Orientation = Up | Down
type PeelState = Peeled | Unpeeled
// This exception depends on the type below.
exception DontSqueezeTheBananaException of Banana

type Banana(orientation : Orientation) =
    member val IsPeeled = false with get, set
    member val Orientation = orientation with get, set
    member val Sides: PeelState list = [ Unpeeled; Unpeeled; Unpeeled; Unpeeled] with get, set

    member self.Peel() = BananaHelpers.peel self // Note the dependency on the BananaHelpers module.
    member self.SqueezeJuiceOut() = raise (DontSqueezeTheBananaException self) // This member depends on the exception above.
module BananaHelpers =
    let peel (b: Banana) =
        let flip (banana: Banana) =
            match banana.Orientation with
            | Up ->
                banana.Orientation <- Down
                banana
            | Down -> banana

        let peelSides (banana: Banana) =
            banana.Sides
            |> List.map (function
                         | Unpeeled -> Peeled
                         | Peeled -> Peeled)

        match b.Orientation with
        | Up ->   b |> flip |> peelSides
        | Down -> b |> peelSides