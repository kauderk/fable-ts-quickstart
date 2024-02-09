open Browser

let div = document.createElement "div"
div.innerHTML <- "Hello Mars!"
document.body.appendChild div |> ignore