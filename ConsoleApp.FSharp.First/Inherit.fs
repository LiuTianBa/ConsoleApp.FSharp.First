module Inherit

[<AbstractClass>]
type Person(name) = 
    member x.Name = name    
    abstract Greet : unit -> unit
    // default x.Greet() = printfn "Hi, I'm %s" x.Name

type Student(name, studentID: int) = 
    inherit Person(name)
    let mutable _GPA = 0.0
    member x.StudentID = studentID
    member x.GPA
        with get() = _GPA
        and set value = _GPA <- value
    override    x.Greet() = printfn "Student %s" x.Name

type Teacher(name, expertise : string) = 
    inherit Person(name)

    let mutable _salary = 0.0
    member x.Salary
        with get() = _salary
        and set value = _salary <- value
    member x.Expertise  = expertise
    override x.Greet() = printfn "Teacher %s." x.Name

// let p = new Person("Mohan")
let st = new Student("Zara",1234)
let tr = new Teacher("Mariam","Java")

// p.Greet()
st.Greet()
tr.Greet()