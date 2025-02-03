module MyLib.Tests

open Xunit
open FsUnit
open MyLib

[<Fact>]
let ``Greet function should return correct string`` () =
    Greeter.greet "Adam" |> should equal "Hello, Adam!"
