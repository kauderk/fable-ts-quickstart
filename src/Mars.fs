// ts2fable 0.7.1
module rec Mars
open System
open Fable.Core
open Fable.Core.JS

let [<Import("mars","./Mars.ts")>] mars: (unit -> string) = jsNative
