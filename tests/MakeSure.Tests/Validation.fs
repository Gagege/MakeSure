namespace MakeSure.Tests

open Xunit
open MakeSure.Validation
open MakeSure.Utilities

module Validation =

    [<Fact>]
    let ``We are in the correct universe`` () =
        Assert.Equal(1 + 1, 2)