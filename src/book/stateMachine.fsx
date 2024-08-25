type Item = { Name: string; Price: decimal }
type ActiveCartData = { unpaidItems: Item list }

type PaidCartData =
    { paidItems: Item list; Payment: float }

type ShoppingCart =
    | EmptyCart
    | ActiveCart of ActiveCartData
    | PaidCart of PaidCartData

let addItem cart item =
    match cart with
    | EmptyCart -> ActiveCart { unpaidItems = [ item ] }
    | ActiveCart data -> ActiveCart { unpaidItems = item :: data.unpaidItems }
    | PaidCart _ -> cart

let makePayment cart payment =
    match cart with
    | EmptyCart -> cart
    | ActiveCart { unpaidItems = items } -> PaidCart { paidItems = items; Payment = payment }
    | PaidCart _ -> cart
