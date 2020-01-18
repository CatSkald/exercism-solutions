module Raindrops

let convert (number: int): string =
    let specialSounds = 
        Map.ofList[(3, "Pling"); (5, "Plang"); (7, "Plong")]
    let addSound current factor sound =
        match number with
        | number when number % factor = 0 -> current + sound
        | _ -> current
    let raindrops = Map.fold addSound "" specialSounds

    match raindrops with
    | "" -> number.ToString()
    | sounds -> sounds
