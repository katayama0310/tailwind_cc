#load "/work/Types.fsx"
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

type Num = int
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

type PersonalName = {
    First: string
    Last: string
    MiddleInitial: string option
}


 




