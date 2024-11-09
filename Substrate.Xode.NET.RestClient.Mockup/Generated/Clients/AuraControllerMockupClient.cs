//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.NET.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_consensus_slots;
   using Substrate.Xode.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuraControllerMockupClient : MockupBaseClient, IAuraControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuraControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthorities(BoundedVecT8 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Aura/Authorities", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.AuraStorage.AuthoritiesParams());
      }
      public async Task<bool> SetCurrentSlot(Slot value)
      {
         return await SendMockupRequestAsync(_httpClient, "Aura/CurrentSlot", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.AuraStorage.CurrentSlotParams());
      }
   }
}
