namespace MakeSure

module Utilities =
    
     // the two-track type
    type Result<'TSuccess,'TFailure> = 
        | Success of 'TSuccess
        | Failure of 'TFailure

    // add two switches in parallel
    let plus addSuccess addFailure switch1 switch2 = 
        match (switch1),(switch2) with
        | Success s1,Success s2 -> Success (addSuccess s1 s2)
        | Failure f1,Success _  -> Failure f1
        | Success _ ,Failure f2 -> Failure f2
        | Failure f1,Failure f2 -> Failure (addFailure f1 f2)

    // Combine two validation functions
    // uses "plus" function which is located in MakeSure.Utilities
    // if both validation functions are of type Success, just return a Success containint first valid input
    // if one or both validation functions is/are of type Failure, concatenate the failure message(s) 
    //  and return a Failure containing the concatenated failure messages
    let (&&&) v1 v2 = 
        let addSuccess r1 r2 = r1 // return first
        let addFailure s1 s2 = s1 + "; " + s2  // concat
        plus addSuccess addFailure v1 v2