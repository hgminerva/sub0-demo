//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.Base;
using System.Collections.Generic;


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue
{
    
    
    /// <summary>
    /// >> 199 - Composite[cumulus_pallet_xcmp_queue.InboundChannelDetails]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InboundChannelDetails : BaseType
    {
        
        /// <summary>
        /// >> sender
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id Sender { get; set; }
        /// <summary>
        /// >> state
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumInboundState State { get; set; }
        /// <summary>
        /// >> message_metadata
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat>> MessageMetadata { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "InboundChannelDetails";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Sender.Encode());
            result.AddRange(State.Encode());
            result.AddRange(MessageMetadata.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Sender = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
            Sender.Decode(byteArray, ref p);
            State = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumInboundState();
            State.Decode(byteArray, ref p);
            MessageMetadata = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat>>();
            MessageMetadata.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            global::System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
