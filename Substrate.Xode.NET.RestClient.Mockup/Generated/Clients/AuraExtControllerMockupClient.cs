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
   using Substrate.Xode.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuraExtControllerMockupClient : MockupBaseClient, IAuraExtControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuraExtControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthorities(BoundedVecT8 value)
      {
         return await SendMockupRequestAsync(_httpClient, "AuraExt/Authorities", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.AuraExtStorage.AuthoritiesParams());
      }
   }
}
