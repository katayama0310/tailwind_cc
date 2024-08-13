#load "/work/src/types/Types.fsx"
open Types


let person: Person = { first = "John"; last = "Doe" }
let first = person.first
let last = person.last

type OrderQuantity = |UnitQuantity of int |KilogramQuantity of float

let anOrderQtyInUmits = UnitQuantity 10
let anOrderQtyInKg = KilogramQuantity 2.5

let qtyInUnits = 
    match anOrderQtyInUmits with
    | UnitQuantity qty -> 
        printfn "The quantity is %d" qty
    | KilogramQuantity qty -> 
        printfn "The quantity is %f" qty


type CheckNumber = CheckNumber of int
type CardNumber = CardNumber of int

type CardType = 
    | Visa 
    | MasterCard // OR

type CreditCardInfo = {
    CardType: CardType
    Number: CardNumber
}

type PaymentMethod = 
    | Cash
    | Check of CheckNumber
    | CreditCard of CreditCardInfo

type PaymentAmount  = PaymentAmount of decimal
type Currency = EUR | USD

type Payment = {
    Amount: PaymentAmount
    Currency: Currency
    Method: PaymentMethod
}

// type PaymentInvoice = UnpaidInvoice -> Payment -> PaidInvoice
// type ConvertPaymentCurrency = Payment -> Currency -> Payment


type PersonalName = {
    First: string
    Last: string
    MiddleInitial: string option
}


 




