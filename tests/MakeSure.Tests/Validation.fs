namespace MakeSure.Tests

open Xunit
open MakeSure.Validation
open MakeSure.Utilities

module Validation =

    [<Fact>]
    let ``We are in the correct universe`` () =
        Assert.Equal(1 + 1, 2)

    [<Fact>]
    let ``If valid input is passed to "makeSure" it returns a Success result that matches input`` () =
        let validInput = "test input"
        Assert.Equal(makeSure validInput hasValue "Test failure message", Success validInput)

    [<Fact>]
    let ``If invalid input is passed to "makeSure" it returns a Failure result that matches failureMessage`` () =
        let invalidInput = ""
        let failureMessage = "Test failure message"
        Assert.Equal(makeSure invalidInput hasValue failureMessage, Failure failureMessage)