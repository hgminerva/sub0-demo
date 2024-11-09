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
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Success
        /// Some XCM was executed ok.
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// >> Fail
        /// Some XCM failed.
        /// </summary>
        Fail = 1,
        
        /// <summary>
        /// >> BadVersion
        /// Bad XCM version used.
        /// </summary>
        BadVersion = 2,
        
        /// <summary>
        /// >> BadFormat
        /// Bad XCM format used.
        /// </summary>
        BadFormat = 3,
        
        /// <summary>
        /// >> XcmpMessageSent
        /// An HRMP message was sent to a sibling parachain.
        /// </summary>
        XcmpMessageSent = 4,
        
        /// <summary>
        /// >> OverweightEnqueued
        /// An XCM exceeded the individual message weight budget.
        /// </summary>
        OverweightEnqueued = 5,
        
        /// <summary>
        /// >> OverweightServiced
        /// An XCM from the overweight queue was executed with the given actual weight used.
        /// </summary>
        OverweightServiced = 6,
    }
    
    /// <summary>
    /// >> 38 - Variant[cumulus_pallet_xcmp_queue.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumRust<Event>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumEvent()
        {
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Xode.NET.NetApiExt.Generated.Types.Base.Arr32U8>, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Event.Success);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Xode.NET.NetApiExt.Generated.Types.Base.Arr32U8>, Substrate.Xode.NET.NetApiExt.Generated.Model.xcm.v3.traits.EnumError, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Event.Fail);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Xode.NET.NetApiExt.Generated.Types.Base.Arr32U8>>(Event.BadVersion);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Xode.NET.NetApiExt.Generated.Types.Base.Arr32U8>>(Event.BadFormat);
				AddTypeDecoder<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.Xode.NET.NetApiExt.Generated.Types.Base.Arr32U8>>(Event.XcmpMessageSent);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Event.OverweightEnqueued);
				AddTypeDecoder<BaseTuple<Substrate.NetApi.Model.Types.Primitive.U64, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Event.OverweightServiced);
        }
    }
}
