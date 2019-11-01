open System
open Suave
open Suave.Sockets
open YoLo

[<EntryPoint>]
let main _argv =
    let portByEnv =
        match Env.var ("PORT") with
        | Some(x) -> x
        | None -> "8080"

    let ip : Net.IPAddress = Net.IPAddress.Parse("0.0.0.0")
    let port : Port = uint16 portByEnv

    let socketBinding : Sockets.SocketBinding =
        { ip = ip
          port = port }

    let httpBinding : Http.HttpBinding =
        { scheme = Protocol.HTTP
          socketBinding = socketBinding }

    let conf = { defaultConfig with bindings = [ httpBinding ] }
    startWebServer conf (Successful.OK "Hello World")
    0
