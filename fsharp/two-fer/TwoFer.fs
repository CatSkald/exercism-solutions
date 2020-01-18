module TwoFer

let (|?) (value: 'a option) (defaultValue: 'a): 'a =
    match value with
    | None -> defaultValue
    | Some(value) -> value

let twoFer (input: string option): string = 
    "One for " + (input |? "you") + ", one for me."
