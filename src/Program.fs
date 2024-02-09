open Browser
open MyModule

let result = add 2 3
let div = document.createElement "div"
div.innerHTML <- "Hello !" + result.ToString()
document.body.appendChild div |> ignore