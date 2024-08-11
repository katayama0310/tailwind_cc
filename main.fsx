printfn "Hello World from F#"

// for loop
for i in 1..10 do
    printfn "%d" i

// while loop
let mutable i = 0

while i < 10 do
    printfn "%d" i
    i <- i + 1

// if-else expression
let x = 10
printfn "x is %s than 5" (if x > 5 then "greater" else "less than or equal")

// function to add two numbers
let add x y = x + y
let result = add 10 20

// function to convert a number to a string
let numToString =
    function
    | 1 -> "one"
    | 2 -> "two"
    | 3 -> "three"
    | _ -> "many"

let result2 = numToString 3

// function that returns an Ok or Error
let errableFunction x =
    if x > 5 then Ok x else Error "x is less than or equal to 5"

let result3 = errableFunction 5
let result4 = errableFunction 6
printfn "%A %A" result3 result4

result3 |> Result.iter (printfn "Success: %d")
result4 |> Result.iter (printfn "Success: %d")
