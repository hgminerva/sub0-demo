using Substrate.NET.Wallet.Keyring;

using Substrate.Xode.NET.NetApiExt.Generated;
using Substrate.NetApi.Model.Extrinsics;

using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.NetApi;

using Substrate.NET.Schnorrkel.Keys;
using Substrate.Xode.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress;
using Substrate.Xode.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Rpc;

using System.Net.Http;
using System.Net.Http.Headers;

using static Substrate.NetApi.Mnemonic;

class Program
{
   static void OnExtrinsicStateUpdateEvent(string subscriptionId, ExtrinsicStatus extrinsicStatus) {

    }

    static async Task Main(string[] args)
    {
        // Create mnemonic phrase
        var mnemonic = GenerateMnemonic(MnemonicSize.Words12);
        var mnemonicString = string.Join(" ", mnemonic);
        Console.WriteLine(mnemonicString);

        // Create seed/wallet
        var keyring = new Keyring();
        var wallet = keyring.AddFromMnemonic(mnemonicString, new Meta() {}, 
        Substrate.NetApi.Model.Types.KeyType.Sr25519);
        Console.WriteLine(wallet.Address);

        // Connect to Xode
        var rpc = "wss://rpcnodea01.xode.net/n7yoxCmcIrCF6VziCcDmYTwL8R03a/rpc";
        var client = new SubstrateClientExt(new System.Uri(rpc),ChargeTransactionPayment.Default());
        await client.ConnectAsync();
        var tokenSymbol = client.Properties.TokenSymbol;
        var tokenDecimals = client.Properties.TokenDecimals;

        // Query Balance
        var accountId = new AccountId32();
        accountId.Create(Utils.GetPublicKeyFrom("5FugSbd7aSpvdDDduULQSUKo1W3QGLX5ftnECrUT1L9zUnmA"));
        var accountBalance = await client.SystemStorage.Account(accountId, null, CancellationToken.None);
        double assetBalance = accountBalance != null ? (double)accountBalance.Data.Free.Value / Math.Pow(10, tokenDecimals) : 0;
        Console.WriteLine(String.Format("Account balance: {0:0.00} " + tokenSymbol, assetBalance));

        // Transfer XON from one account to another
        /*
        mnemonicString = "kick attract garment scare space pause sword bulb shove aware pause west";
        var secret = Mnemonic.GetSecretKeyFromMnemonic(mnemonicString, "password123", BIP39Wordlist.English);
        ExpandMode expandMode = ExpandMode.Ed25519;
        var miniSecret = new MiniSecret(secret, expandMode);
        Account sender = Account.Build(
                                            KeyType.Sr25519,
                                            miniSecret.ExpandToSecret().ToBytes(),
                                            miniSecret.GetPair().Public.Key); 
        */

        /*     
        var recepients = new EnumMultiAddress();
        recepients.Create(MultiAddress.Id, accountId);

        var amount = new BaseCom<U128>(1000000000000); 
        //Method transfer = BalancesCalls.TransferKeepAlive(multiAddress, amount);
        Method transfer = BalancesCalls.TransferKeepAlive(recepients, amount);
        try {      
            await client.Author.SubmitExtrinsicAsync(
                transfer,
                sender, 
                new ChargeTransactionPayment(0),
                128,
                CancellationToken.None);
        } catch(Exception err) {
            Console.WriteLine(err.ToString());
        } 
        */

        // Get the token
        string api = "http://dev.xgame.live/";
        using (var apiClient = new HttpClient()) {
             apiClient.BaseAddress = new System.Uri(api);
             apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             HttpResponseMessage httpResponse = await apiClient.GetAsync("api/Employee/GetAllEmployees");
            if (httpResponse.IsSuccessStatusCode) {
                    var httpResult = httpResponse.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(httpResult.ToString());
            }
        }
       



    }
}



