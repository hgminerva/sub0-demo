//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.NET.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   
   public interface IDmpQueueControllerMockupClient
   {
      Task<bool> SetConfiguration(ConfigData value);
      Task<bool> SetPageIndex(PageIndexData value);
      Task<bool> SetPages(BaseVec<BaseTuple<U32, BaseVec<U8>>> value, U32 key);
      Task<bool> SetOverweight(BaseTuple<U32, BaseVec<U8>> value, U64 key);
      Task<bool> SetCounterForOverweight(U32 value);
   }
}
