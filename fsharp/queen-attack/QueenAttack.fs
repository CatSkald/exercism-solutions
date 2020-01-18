module QueenAttack

let create (position: int * int) = 
    let withinBoard a = a >= 0 && a < 8
    match position with
    | (x, y) -> withinBoard(x) && withinBoard(y)

let canAttack (queen1: int * int) (queen2: int * int) = 
    match queen1 with
    | (x1, y1) ->
        match queen2 with
        | (x2, y2) ->
            x1 = x2 || y1 = y2 || x1 + y1 = x2 + y2 || abs(x1 - y1) = abs(x2 - y2)
