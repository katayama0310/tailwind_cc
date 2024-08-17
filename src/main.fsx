#load "/work/src/types/Types.fsx"
open Types

// ラムダ
fun x -> x * x

// ラムダの適用
(fun x -> x * x) 3

// ラムダの適用
let square = fun x -> x * x
square 3

// パイプライン
let add x y = x + y
let square2 x = x * x
let addSquare x y = x |> add y |> square2
let ret = addSquare 3 4
printfn "%d" ret

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
