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
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.humidefi_runtime;
   using Substrate.Xode.NET.RestClient.Generated.Interfaces;
   
   public sealed class SessionControllerClient : BaseClient, ISessionControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public SessionControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseVec<AccountId32>> GetValidators()
      {
         return await SendRequestAsync<BaseVec<AccountId32>>(_httpClient, "session/validators");
      }
      public async Task<bool> SubscribeValidators()
      {
         return await _subscriptionClient.SubscribeAsync("Session.Validators");
      }
      public async Task<U32> GetCurrentIndex()
      {
         return await SendRequestAsync<U32>(_httpClient, "session/currentindex");
      }
      public async Task<bool> SubscribeCurrentIndex()
      {
         return await _subscriptionClient.SubscribeAsync("Session.CurrentIndex");
      }
      public async Task<Bool> GetQueuedChanged()
      {
         return await SendRequestAsync<Bool>(_httpClient, "session/queuedchanged");
      }
      public async Task<bool> SubscribeQueuedChanged()
      {
         return await _subscriptionClient.SubscribeAsync("Session.QueuedChanged");
      }
      public async Task<BaseVec<BaseTuple<AccountId32, SessionKeys>>> GetQueuedKeys()
      {
         return await SendRequestAsync<BaseVec<BaseTuple<AccountId32, SessionKeys>>>(_httpClient, "session/queuedkeys");
      }
      public async Task<bool> SubscribeQueuedKeys()
      {
         return await _subscriptionClient.SubscribeAsync("Session.QueuedKeys");
      }
      public async Task<BaseVec<U32>> GetDisabledValidators()
      {
         return await SendRequestAsync<BaseVec<U32>>(_httpClient, "session/disabledvalidators");
      }
      public async Task<bool> SubscribeDisabledValidators()
      {
         return await _subscriptionClient.SubscribeAsync("Session.DisabledValidators");
      }
      public async Task<SessionKeys> GetNextKeys(AccountId32 key)
      {
         return await SendRequestAsync<SessionKeys>(_httpClient, "session/nextkeys", Substrate.Xode.NET.NetApiExt.Generated.Storage.SessionStorage.NextKeysParams(key));
      }
      public async Task<bool> SubscribeNextKeys(AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Session.NextKeys", Substrate.Xode.NET.NetApiExt.Generated.Storage.SessionStorage.NextKeysParams(key));
      }
      public async Task<AccountId32> GetKeyOwner(BaseTuple<KeyTypeId, BaseVec<U8>> key)
      {
         return await SendRequestAsync<AccountId32>(_httpClient, "session/keyowner", Substrate.Xode.NET.NetApiExt.Generated.Storage.SessionStorage.KeyOwnerParams(key));
      }
      public async Task<bool> SubscribeKeyOwner(BaseTuple<KeyTypeId, BaseVec<U8>> key)
      {
         return await _subscriptionClient.SubscribeAsync("Session.KeyOwner", Substrate.Xode.NET.NetApiExt.Generated.Storage.SessionStorage.KeyOwnerParams(key));
      }
   }
}
