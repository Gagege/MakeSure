namespace MakeSure.Tests

open Xunit
open Swensen.Unquote.Assertions

module Validation =

    [<Fact>]
    let ``We are in the correct universe`` () =
        test <@ 1 + 1 = 2 @>