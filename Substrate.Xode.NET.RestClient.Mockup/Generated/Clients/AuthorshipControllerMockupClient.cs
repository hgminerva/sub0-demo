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
   using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.Xode.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class AuthorshipControllerMockupClient : MockupBaseClient, IAuthorshipControllerMockupClient
   {
      private HttpClient _httpClient;
      public AuthorshipControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAuthor(AccountId32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Authorship/Author", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.AuthorshipStorage.AuthorParams());
      }
   }
}
