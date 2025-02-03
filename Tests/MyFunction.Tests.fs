module Library.Tests

open Xunit
open FsUnit.Xunit
open MyFunction

[<Fact>]
let ``Greet function should return correct string`` () =
    Greeter.greet "Adam" |> should equal "Hello, Adam!"
