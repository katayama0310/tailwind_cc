#load "/work/src/types/Types.fsx"
open Types

// ラムダ
fun x -> x * x

// ラムダの適用
(fun x -> x * x) 3

// ラムダの適用
let square = fun x -> x * x
square 3

// パイプライ
let square2 x = x * x

let syaGreeet greet name = printfn "%s %s" greet name
syaGreeet "Hello" "World"

let sayHello = syaGreeet "Hello"
let sayGoodbye = syaGreeet "Goodbye"
sayHello "World"
sayGoodbye "World"

// unit
fun func x -> ()
// 未払い請求書の支払い処理に関する型の定義
// 未払いの請求書に対して支払い処理を実施する→
//    成功時の出力:支払い済みの請求書
//    失敗時の出力：支払いエラー
type UnpaidInvoice = { InvoiceId: int; Amount: decimal }
type PaidInvoice = { InvoiceId: int; Amount: decimal }
type Payment = { Amount: decimal }

type PaymentError =
    { InvoiceId: int
      Amount: decimal
      Error: string }

type PayInvoice = UnpaidInvoice -> Payment -> Result<PaidInvoice, PaymentError>

// use PayInvoice
let payInvoice: PayInvoice =
    fun unpaid payment ->
        if unpaid.Amount > payment.Amount then
            Error
                { InvoiceId = unpaid.InvoiceId
                  Amount = unpaid.Amount
                  Error = "Payment amount is not enough" }
        else
            Ok
                { InvoiceId = unpaid.InvoiceId
                  Amount = unpaid.Amount }

type add1 = int -> int -> int
let add1 = fun x y -> x + y
let add2: add1 = fun x y -> x + y

// and
type Person = { Name: string; Age: int }
let person = { Name = "Alice"; Age = 20 }

// or
type PayMethod =
    | CreditCard of string
    | BankTransfer of string

let payMethod = CreditCard "1234-5678-9012-3456"

// Shapeという型の値を定義する際に
// Rectangle, Circle, Prismのいずれかの型である必要がある(OR型)
type Shape =
    | Rectangle of width: float * length: float
    | Circle of radius: float
    | Prism of width: float * float * height: float

let shape = Rectangle(1.0, 2.0)

let str = String.replicate 10 "a"
printfn "%s" str

let square3 x = x * x
let square4 = fun x -> x * x

let add x y = fun z -> x + y + z
add 1 2 3

let add3 = add 3

// スマートコンストラクタ
// Age 型を定義する
type Age private (value: int) =
    member this.Value = value
    static member Create (value: int) =
        if value < 0 then
            invalidArg "value" "Age must be greater than or equal to 0"
        else
            Age(value)

let age = Age.Create 20
// print age
printfn "%A" age
