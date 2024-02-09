open Browser
open MyModule
open Mars


let result = add 2 3
let marsResult = "mars()"
let marsResult2 = mars()

let div = document.createElement "div"
div.innerHTML <- "Hello !" + marsResult + marsResult2 + result.ToString()
document.body.appendChild div |> ignore