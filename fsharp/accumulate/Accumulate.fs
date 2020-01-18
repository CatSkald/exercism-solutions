module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec accumulateRecursively input acc =
        match input with
        | [] -> acc
        | [x] -> func x::acc
        | _::tail -> accumulateRecursively tail acc
    
    accumulateRecursively input []