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
   using Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class DmpQueueControllerMockupClient : MockupBaseClient, IDmpQueueControllerMockupClient
   {
      private HttpClient _httpClient;
      public DmpQueueControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetConfiguration(ConfigData value)
      {
         return await SendMockupRequestAsync(_httpClient, "DmpQueue/Configuration", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.ConfigurationParams());
      }
      public async Task<bool> SetPageIndex(PageIndexData value)
      {
         return await SendMockupRequestAsync(_httpClient, "DmpQueue/PageIndex", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.PageIndexParams());
      }
      public async Task<bool> SetPages(BaseVec<BaseTuple<U32, BaseVec<U8>>> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "DmpQueue/Pages", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.PagesParams(key));
      }
      public async Task<bool> SetOverweight(BaseTuple<U32, BaseVec<U8>> value, U64 key)
      {
         return await SendMockupRequestAsync(_httpClient, "DmpQueue/Overweight", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.OverweightParams(key));
      }
      public async Task<bool> SetCounterForOverweight(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "DmpQueue/CounterForOverweight", value.Encode(), Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.CounterForOverweightParams());
      }
   }
}
