//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Substrate.Xode.NET.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Substrate.Xode.NET.RestClient.Mockup.Generated.Clients;
   using Substrate.Xode.NET.RestClient.Generated.Clients;
   using Substrate.NetApi.Model.Types.Base;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue;
   using Substrate.NetApi.Model.Types.Primitive;
   using Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   
   public class XcmpQueueControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> GetTestValue2()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails>();
         result.Create(new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails[] {
                  this.GetTestValue3()});
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails GetTestValue3()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails();
         result.Sender = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Sender = this.GetTestValue4();
         result.State = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumInboundState();
         result.State.Create(this.GetTestValueEnum<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundState>());
         result.MessageMetadata = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat>>();
         result.MessageMetadata.Create(new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat>[] {
                  this.GetTestValue5()});
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue4()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat> GetTestValue5()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat>();
         result.Create(this.GetTestValueU32(), this.GetTestValue6());
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat GetTestValue6()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.EnumXcmpMessageFormat();
         result.Create(this.GetTestValueEnum<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.XcmpMessageFormat>());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestInboundXcmpStatus()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeInboundXcmpStatus());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetInboundXcmpStatus(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.InboundChannelDetails> rpcResult = await rpcClient.GetInboundXcmpStatus();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetTestValue8()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32> GetTestValue9()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValue10(), this.GetTestValueU32());
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue10()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestInboundXcmpMessages()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> mockupValue = this.GetTestValue8();
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32> mockupKey = this.GetTestValue9();

         Assert.IsTrue(await rpcClient.SubscribeInboundXcmpMessages(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetInboundXcmpMessages(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> rpcResult = await rpcClient.GetInboundXcmpMessages(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> GetTestValue12()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails>();
         result.Create(new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails[] {
                  this.GetTestValue13()});
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails GetTestValue13()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails();
         result.Recipient = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Recipient = this.GetTestValue14();
         result.State = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.EnumOutboundState();
         result.State.Create(this.GetTestValueEnum<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundState>());
         result.SignalsExist = this.GetTestValueBool();
         result.FirstIndex = this.GetTestValueU16();
         result.LastIndex = this.GetTestValueU16();
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue14()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestOutboundXcmpStatus()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> mockupValue = this.GetTestValue12();


         Assert.IsTrue(await rpcClient.SubscribeOutboundXcmpStatus());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOutboundXcmpStatus(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.OutboundChannelDetails> rpcResult = await rpcClient.GetOutboundXcmpStatus();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetTestValue16()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U16> GetTestValue17()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U16> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U16>();
         result.Create(this.GetTestValue18(), this.GetTestValueU16());
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue18()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestOutboundXcmpMessages()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> mockupValue = this.GetTestValue16();
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U16> mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeOutboundXcmpMessages(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOutboundXcmpMessages(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> rpcResult = await rpcClient.GetOutboundXcmpMessages(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetTestValue20()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue21()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSignalMessages()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> mockupValue = this.GetTestValue20();
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id mockupKey = this.GetTestValue21();

         Assert.IsTrue(await rpcClient.SubscribeSignalMessages(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSignalMessages(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> rpcResult = await rpcClient.GetSignalMessages(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData GetTestValue23()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData();
         result.SuspendThreshold = this.GetTestValueU32();
         result.DropThreshold = this.GetTestValueU32();
         result.ResumeThreshold = this.GetTestValueU32();
         result.ThresholdWeight = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.ThresholdWeight = this.GetTestValue24();
         result.WeightRestrictDecay = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.WeightRestrictDecay = this.GetTestValue25();
         result.XcmpMaxIndividualWeight = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.XcmpMaxIndividualWeight = this.GetTestValue26();
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight GetTestValue24()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.RefTime = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.RefTime.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         result.ProofSize = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.ProofSize.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight GetTestValue25()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.RefTime = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.RefTime.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         result.ProofSize = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.ProofSize.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight GetTestValue26()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight();
         result.RefTime = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.RefTime.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         result.ProofSize = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>();
         result.ProofSize.Create(new Substrate.NetApi.CompactInteger(this.GetTestValueU64().Value));
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestQueueConfig()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData mockupValue = this.GetTestValue23();


         Assert.IsTrue(await rpcClient.SubscribeQueueConfig());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueueConfig(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_xcmp_queue.QueueConfigData rpcResult = await rpcClient.GetQueueConfig();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetTestValue28()
      {
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>();
         result.Create(this.GetTestValue29(), this.GetTestValueU32(), this.GetTestValue30());
         return result;
      }
      public Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue29()
      {
         Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> GetTestValue30()
      {
         Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> result;
         result = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Substrate.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestOverweight()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> mockupValue = this.GetTestValue28();
         Substrate.NetApi.Model.Types.Primitive.U64 mockupKey = this.GetTestValueU64();

         Assert.IsTrue(await rpcClient.SubscribeOverweight(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOverweight(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> rpcResult = await rpcClient.GetOverweight(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCounterForOverweight()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeCounterForOverweight());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCounterForOverweight(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetCounterForOverweight();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestOverweightCount()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeOverweightCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOverweightCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetOverweightCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestQueueSuspended()
      {
         // Construct new Mockup client to test with.
         XcmpQueueControllerMockupClient mockupClient = new XcmpQueueControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         XcmpQueueControllerClient rpcClient = new XcmpQueueControllerClient(_httpClient, subscriptionClient);
         Substrate.NetApi.Model.Types.Primitive.Bool mockupValue = this.GetTestValueBool();


         Assert.IsTrue(await rpcClient.SubscribeQueueSuspended());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetQueueSuspended(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Substrate.NetApi.Model.Types.Primitive.Bool rpcResult = await rpcClient.GetQueueSuspended();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
