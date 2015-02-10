namespace MakeSure

open System
open MakeSure.Utilities
open Microsoft.FSharp.Linq.NullableOperators

module Validation =

    let hasValue input =
        input <> ""

    let beforeToday input =
        input ?< DateTime.Now
    
    // run the validationFunction on the input
    // if valid, return Success with validated input
    // if not valid, return Failure with failureMessage
    let makeSure input validationFunction failureMessage =
        if validationFunction input then Success input
        else Failure failureMessage
        
    // if input is not empty (eg. "hasValue input = false"), run the validationFunction on the input
    // if valid, return Success with validated input
    // if not valid, return Failure with failureMessage
    let ifNotEmptyMakeSure input validationFunction failureMessage =
        if hasValue input = false || validationFunction input then Success input
        else Failure failureMessage