namespace MakeSure.Tests

open Xunit
open Swensen.Unquote.Assertions
open MakeSure.Validation
open MakeSure.Utilities

module Validation =

    [<Fact>]
    let ``We are in the correct universe`` () =
        test <@ 1 + 1 = 2 @>

    [<Fact>]
    let ``If valid input is passed to "makeSure" it returns a Success result that matches input`` () =
        test <@ 
                let validInput = "test input"
                makeSure validInput hasValue "Test failure message" = Success validInput @>

    [<Fact>]
    let ``If invalid input is passed to "makeSure" it returns a Failure result that matches failureMessage`` () =
        test <@ 
                let invalidInput = ""
                let failureMessage = "Test failure message"
                makeSure invalidInput hasValue failureMessage = Failure failureMessage @>