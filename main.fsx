printfn "Hello World from F#"

// for
for i in 1..10 do
    printfn "%d" i

// while
let mutable i = 0
while i < 10 do
    printfn "%d" i
    i <- i + 1

// if
let x = 10
if x > 5 then
    printfn "x is greater than 5"
else
    printfn "x is less than or equal to 5"