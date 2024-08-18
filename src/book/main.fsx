printfn("functional domain modeling")

type Person = { Name: string; Age: int }
let person = { Name = "Alice"; Age = 20 }
// update age
let updated = { person with Age = 21 }
printfn "%A" updated