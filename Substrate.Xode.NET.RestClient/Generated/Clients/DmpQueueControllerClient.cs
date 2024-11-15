//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.NET.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.RestClient.Generated.Interfaces;
   
   public sealed class DmpQueueControllerClient : BaseClient, IDmpQueueControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public DmpQueueControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<ConfigData> GetConfiguration()
      {
         return await SendRequestAsync<ConfigData>(_httpClient, "dmpqueue/configuration");
      }
      public async Task<bool> SubscribeConfiguration()
      {
         return await _subscriptionClient.SubscribeAsync("DmpQueue.Configuration");
      }
      public async Task<PageIndexData> GetPageIndex()
      {
         return await SendRequestAsync<PageIndexData>(_httpClient, "dmpqueue/pageindex");
      }
      public async Task<bool> SubscribePageIndex()
      {
         return await _subscriptionClient.SubscribeAsync("DmpQueue.PageIndex");
      }
      public async Task<BaseVec<BaseTuple<U32, BaseVec<U8>>>> GetPages(U32 key)
      {
         return await SendRequestAsync<BaseVec<BaseTuple<U32, BaseVec<U8>>>>(_httpClient, "dmpqueue/pages", Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.PagesParams(key));
      }
      public async Task<bool> SubscribePages(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("DmpQueue.Pages", Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.PagesParams(key));
      }
      public async Task<BaseTuple<U32, BaseVec<U8>>> GetOverweight(U64 key)
      {
         return await SendRequestAsync<BaseTuple<U32, BaseVec<U8>>>(_httpClient, "dmpqueue/overweight", Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.OverweightParams(key));
      }
      public async Task<bool> SubscribeOverweight(U64 key)
      {
         return await _subscriptionClient.SubscribeAsync("DmpQueue.Overweight", Substrate.Xode.NET.NetApiExt.Generated.Storage.DmpQueueStorage.OverweightParams(key));
      }
      public async Task<U32> GetCounterForOverweight()
      {
         return await SendRequestAsync<U32>(_httpClient, "dmpqueue/counterforoverweight");
      }
      public async Task<bool> SubscribeCounterForOverweight()
      {
         return await _subscriptionClient.SubscribeAsync("DmpQueue.CounterForOverweight");
      }
   }
}
