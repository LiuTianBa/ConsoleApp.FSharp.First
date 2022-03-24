module Module

(*
// Top-level module declaration.
module [accessibility-modifier] [qualified-namespace.]module-name
   declarations
// Local module declaration.
module [accessibility-modifier] module-name =
   declarations
*)
let add x y =x + y
let sub x y =x - y
let mult x y =x * y
let div x y =x / y


// Module1
module module1 =
   // Indent all program elements within modules that are declared with an equal sign.
   let value1 = 100
   let module1Function x =
      x + value1

// Module2
module module2 =
   let value2 = 200

   // Use a qualified name to access the function.
   // from module1.
   let module2Function x =
      x + (module1.module1Function value2)

let result = module1.module1Function 25
printfn "%d" result

let result2 = module2.module2Function 25
printfn "%d" result2