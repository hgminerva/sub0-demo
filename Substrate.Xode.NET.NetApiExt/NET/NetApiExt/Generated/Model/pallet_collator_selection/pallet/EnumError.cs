//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> TooManyCandidates
        /// Too many candidates
        /// </summary>
        TooManyCandidates = 0,
        
        /// <summary>
        /// >> TooFewCandidates
        /// Too few candidates
        /// </summary>
        TooFewCandidates = 1,
        
        /// <summary>
        /// >> Unknown
        /// Unknown error
        /// </summary>
        Unknown = 2,
        
        /// <summary>
        /// >> Permission
        /// Permission issue
        /// </summary>
        Permission = 3,
        
        /// <summary>
        /// >> AlreadyCandidate
        /// User is already a candidate
        /// </summary>
        AlreadyCandidate = 4,
        
        /// <summary>
        /// >> NotCandidate
        /// User is not a candidate
        /// </summary>
        NotCandidate = 5,
        
        /// <summary>
        /// >> TooManyInvulnerables
        /// Too many invulnerables
        /// </summary>
        TooManyInvulnerables = 6,
        
        /// <summary>
        /// >> AlreadyInvulnerable
        /// User is already an Invulnerable
        /// </summary>
        AlreadyInvulnerable = 7,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// Account has no associated validator ID
        /// </summary>
        NoAssociatedValidatorId = 8,
        
        /// <summary>
        /// >> ValidatorNotRegistered
        /// Validator ID is not yet registered
        /// </summary>
        ValidatorNotRegistered = 9,
    }
    
    /// <summary>
    /// >> 184 - Variant[pallet_collator_selection.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
