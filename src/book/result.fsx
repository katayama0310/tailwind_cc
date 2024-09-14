let bind switchFn twoTrackInput =
    match twoTrackInput with
    | Ok success -> switchFn success
    | Error failure -> Error failure


let double x =
    if x > 0 then
        Ok(x * 2)
    else
        Error "Negative number not allowed"

let result1 = bind double (Ok 10)
printfn "%A" result1

let result2 = bind double (Error "Initial failure")
printfn "%A" result2

let result3 = bind double (Ok -5)
printfn "%A" result3

type Apple = Apple of int
type Banana = Banana of int
type Lemon = Lemon of int
type Cherry = Cherry of int

type funA = Apple -> Result<Banana, string>
type funB = Banana -> Result<Lemon, string>
type funC = Lemon -> Result<Cherry, string>

let funA: funA = fun (Apple a) -> Ok(Banana a)
let funB: funB = fun (Banana b) -> Ok(Lemon b)
let funC: funC = fun (Lemon l) -> Ok(Cherry l)

let functionABC input =
    input
    |> funA
    |> bind funB
    |> bind funC

let result4 = functionABC (Apple 10)



// map --------------------------------------------
let map f aResult =
    match aResult with
    | Ok s -> Ok(f s)
    | Error failure -> Error failure

type funcE = int -> int option
type funcF = int -> int option



let mapError f aResult =
    match aResult with
    | Ok success -> Ok success
    | Error failure -> Error(f failure)


let mapp f xR =
    match xR with
    | Ok x -> Ok (f x)
    | Error e -> Error e 

let bindd f xR =
    match xR with
    | Ok x -> f x
    | Error e -> Error e 

let add1 x = x + 1
let safeDiv x = if x = 0 then Error "Division by zero" else Ok (10 / x)

let result = 
    Ok 2
    |> mapp add1  // Ok 2 -> Ok 3 (add1 を適用)
    |> bindd safeDiv  // Ok 3 -> Ok 3 (safeDiv では問題なし)

// パイプライン演算子例


let add x = x + 1
let add2 x = x + 2

let result = 
    Ok 2
    |> mapp add  // Ok 2 -> Ok 3 (add1 を適用)
    |> mapp add2  // Ok 3 -> Ok 5 (add2 を適用)

printfn "%A" result