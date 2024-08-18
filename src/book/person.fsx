type Age = private Age of int

module Age =
    /// スマートコンストラクタ: 有効な年齢を作成
    let create age =
        if age >= 0 && age <= 120 then
            Ok(Age age)
        else
            Error "Age must be between 0 and 120."

    /// 年齢を取得するメソッド
    let value (Age age) = age

    /// 年齢を1つ増やすメソッド
    let increment (Age age) =
        if age < 120 then
            Ok(Age(age + 1))
        else
            Error "Age cannot be greater than 120."

    /// 年齢を1つ減らすメソッド
    let decrement (Age age) =
        if age > 0 then
            Ok(Age(age - 1))
        else
            Error "Age cannot be less than 0."

    /// 2つの年齢を比較するメソッド
    let compare (Age age1) (Age age2) =
        if age1 > age2 then 1
        elif age1 < age2 then -1
        else 0

type Name = private Name of string

module Name =
    let create name =
        if System.String.IsNullOrWhiteSpace(name) |> not && name.Length <= 50 then
            Ok(Name name)
        else
            Error "Name must not be empty and must be 50 characters or less."

type Person = { Name: Name; Age: Age }

module Person =
    let create name age =
        match Name.create name, Age.create age with
        | Ok name, Ok age -> Ok { Name = name; Age = age }
        | Error msg, _ -> Error msg
        | _, Error msg -> Error msg

// 使用例
let validPerson = Person.create "John Doe" 30
let invalidPerson = Person.create "" -5

match validPerson with
| Ok person -> printfn "Valid person created"
| Error msg -> printfn "Failed to create person: %s" msg

match invalidPerson with
| Ok person -> printfn "Valid person created"
| Error msg -> printfn "Failed to create person: %s" msg
