let triple x = x * 3
fun x -> x + 1
let convert (a: string) : int = int a

let num = convert "42"


let apply x y : int = x y
let add x y z = x + y + z
let add' = add 1 2
let add'' = add' 3

let apply' = apply triple

// 掛け算
let multiply x y : int = x * y

// 戻り値が関数
let returnFunc x = fun y -> x + y
let a = returnFunc 1
let b = a 2

let func1 x = x + 1
let func2 x = x * 2
let func3 x = x - 3
let funcArray = [ func1; func2; func3 ]

let applyFuncs x = List.map (fun f -> f x) funcArray

let func123 = func1 >> func2 >> func3

let list = [ 1..10 ] // 1〜10 までの値のリスト
let isEven x = x % 2 = 0 // 偶数判定用の関数
let evens = List.filter isEven list // list から偶数値のみ抽出
List.iter (printf "%i ") evens // evens を半角スペース区切りで出力

// pipeline
let result = list |> List.filter isEven |> List.map (fun x -> x * 2) |> List.sum
printfn "%i" result

// option
let addOption x y : int option = Some(x + y)
let addNormal x y = x + y

// compose addOption and addNormal
let addOption' x y =
    addOption x y |> Option.map (fun x -> addNormal x 1)


// generic
type Command<'data> =
    { userId: string
      timeStamp: System.DateTime
      data: 'data }

type UnvalidatedOrder =
    { orderId: string
      orderItems: string list }

type PlaceOrder = Command<UnvalidatedOrder>

// option
let optionNum = Some 42
// option map
let optionNum' = optionNum |> Option.map (fun x -> x + 1)
let num2 = optionNum' // Some 43
// unwrap option
let num3 = optionNum' |> Option.defaultValue 0 // 43

// list
let listNum = [ 1; 2; 3; 4; 5 ]
// list map
let listNum' = List.map (fun x -> x + 1) listNum

// list singleton
let listNum'' = [ 1 ]

// fun option to list
let optionToList x = x |> Option.toList
