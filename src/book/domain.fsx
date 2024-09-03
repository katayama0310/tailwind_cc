module Domain =
    type OrderId = private OrderId of string

    module OrderId =
        let create (str: string) =
            if System.String.IsNullOrEmpty(str) then
                failwith "OrderId cannot be empty"

            elif str.Length > 10 then
                failwith "OrderId must be less than 10 characters"

            else
                OrderId str

        let value (OrderId str) = str
