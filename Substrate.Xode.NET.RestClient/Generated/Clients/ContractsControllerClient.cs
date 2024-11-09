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
   using Substrate.Xode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_contracts.wasm;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_contracts.storage;
   using Substrate.Xode.NET.RestClient.Generated.Interfaces;
   
   public sealed class ContractsControllerClient : BaseClient, IContractsControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ContractsControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT13> GetPristineCode(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<BoundedVecT13>(_httpClient, "contracts/pristinecode", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.PristineCodeParams(key));
      }
      public async Task<bool> SubscribePristineCode(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.PristineCode", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.PristineCodeParams(key));
      }
      public async Task<PrefabWasmModule> GetCodeStorage(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<PrefabWasmModule>(_httpClient, "contracts/codestorage", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.CodeStorageParams(key));
      }
      public async Task<bool> SubscribeCodeStorage(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.CodeStorage", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.CodeStorageParams(key));
      }
      public async Task<OwnerInfo> GetOwnerInfoOf(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await SendRequestAsync<OwnerInfo>(_httpClient, "contracts/ownerinfoof", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.OwnerInfoOfParams(key));
      }
      public async Task<bool> SubscribeOwnerInfoOf(Substrate.Xode.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.OwnerInfoOf", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.OwnerInfoOfParams(key));
      }
      public async Task<U64> GetNonce()
      {
         return await SendRequestAsync<U64>(_httpClient, "contracts/nonce");
      }
      public async Task<bool> SubscribeNonce()
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.Nonce");
      }
      public async Task<ContractInfo> GetContractInfoOf(Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await SendRequestAsync<ContractInfo>(_httpClient, "contracts/contractinfoof", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.ContractInfoOfParams(key));
      }
      public async Task<bool> SubscribeContractInfoOf(Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.ContractInfoOf", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.ContractInfoOfParams(key));
      }
      public async Task<BoundedVecT14> GetDeletionQueue(U32 key)
      {
         return await SendRequestAsync<BoundedVecT14>(_httpClient, "contracts/deletionqueue", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.DeletionQueueParams(key));
      }
      public async Task<bool> SubscribeDeletionQueue(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.DeletionQueue", Substrate.Xode.NET.NetApiExt.Generated.Storage.ContractsStorage.DeletionQueueParams(key));
      }
      public async Task<DeletionQueueManager> GetDeletionQueueCounter()
      {
         return await SendRequestAsync<DeletionQueueManager>(_httpClient, "contracts/deletionqueuecounter");
      }
      public async Task<bool> SubscribeDeletionQueueCounter()
      {
         return await _subscriptionClient.SubscribeAsync("Contracts.DeletionQueueCounter");
      }
   }
}