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


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.pallet
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
        /// >> FailedToSend
        /// Failed to send XCM message.
        /// </summary>
        FailedToSend = 0,
        
        /// <summary>
        /// >> BadXcmOrigin
        /// Bad XCM origin.
        /// </summary>
        BadXcmOrigin = 1,
        
        /// <summary>
        /// >> BadXcm
        /// Bad XCM data.
        /// </summary>
        BadXcm = 2,
        
        /// <summary>
        /// >> BadOverweightIndex
        /// Bad overweight index.
        /// </summary>
        BadOverweightIndex = 3,
        
        /// <summary>
        /// >> WeightOverLimit
        /// Provided weight is possibly not enough to execute the message.
        /// </summary>
        WeightOverLimit = 4,
    }
    
    /// <summary>
    /// >> 212 - Variant[cumulus_pallet_xcmp_queue.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
