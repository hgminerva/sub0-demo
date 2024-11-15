//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.NET.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   
   public interface IXcmpQueueControllerClient
   {
      Task<BaseVec<InboundChannelDetails>> GetInboundXcmpStatus();
      Task<bool> SubscribeInboundXcmpStatus();
      Task<BaseVec<U8>> GetInboundXcmpMessages(BaseTuple<Id, U32> key);
      Task<bool> SubscribeInboundXcmpMessages(BaseTuple<Id, U32> key);
      Task<BaseVec<OutboundChannelDetails>> GetOutboundXcmpStatus();
      Task<bool> SubscribeOutboundXcmpStatus();
      Task<BaseVec<U8>> GetOutboundXcmpMessages(BaseTuple<Id, U16> key);
      Task<bool> SubscribeOutboundXcmpMessages(BaseTuple<Id, U16> key);
      Task<BaseVec<U8>> GetSignalMessages(Id key);
      Task<bool> SubscribeSignalMessages(Id key);
      Task<QueueConfigData> GetQueueConfig();
      Task<bool> SubscribeQueueConfig();
      Task<BaseTuple<Id, U32, BaseVec<U8>>> GetOverweight(U64 key);
      Task<bool> SubscribeOverweight(U64 key);
      Task<U32> GetCounterForOverweight();
      Task<bool> SubscribeCounterForOverweight();
      Task<U64> GetOverweightCount();
      Task<bool> SubscribeOverweightCount();
      Task<Bool> GetQueueSuspended();
      Task<bool> SubscribeQueueSuspended();
   }
}
