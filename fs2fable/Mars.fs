module rec Glutinum

open Fable.Core
open System

[<Erase>]
type Exports =
    [<Import("mars", "module")>]
    static member mars: obj = nativeOnly
