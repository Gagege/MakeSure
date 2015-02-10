namespace MakeSure

open MakeSure.Utilities

module Validation =
    
    // run the validationFunction on the input
    // if valid, return Success with validated input
    // if not valid, return Failure with failureMessage
    let makeSure input validationFunction failureMessage =
        if validationFunction input then Success input
        else Failure failureMessage