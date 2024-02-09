// ts2fable 0.7.1
module rec Mars
open System
open Fable.Core
open Fable.Core.JS

let [<Import("*","Mars")>] mars: (unit -> string) = jsNative
