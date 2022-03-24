module Record

// define record
type website =
    { title : string;
        url : string }

// create record
let homePage ={
    title = "TutorialsPoint"; url = "www.baidu.com"}

type human = 
    {name: string; sex : int ; age : int }
let h1 = {name = "zhangsan"; sex = 0 ; age = 27}
let h2 = {name = "lisi" ; sex =1 ; age = 27}

printfn "%s %d" h1.name h1.age
printfn "%s %d" h2.name h2.age

type student =
    { Name : string;
        ID : int;
        RegistrationText : string ;
        IsRegistered : bool}

let getStudent name id =
    {Name = name; ID = id ;RegistrationText = null; IsRegistered= false}

let registerStudent st = 
    {
    st with 
        RegistrationText = "Registered";
        IsRegistered = true}

let printStudent msg st =   
    printfn "%s: %A" msg st

let main() =
    let preRegisteredStudent = getStudent "Zara" 10
    let postRegisteredStudent = registerStudent preRegisteredStudent

    printStudent "Before Registration: " preRegisteredStudent
    printStudent "After Registration: " postRegisteredStudent

main()