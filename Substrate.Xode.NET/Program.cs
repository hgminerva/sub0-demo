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
using System.Text.Json;
using System.Text;

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

        /*
        User user = new User { 
            username = "xgame1",
            password = "password123",
            confirm_password = "password123",
        };

        try
        {
            using var http_client = new HttpClient();
            var user_json = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(user_json, System.Text.Encoding.UTF8, "application/json");
            var response = await http_client.PostAsync("https://dev.xgame.live/user/create", content);
            if (response.IsSuccessStatusCode) {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            else {
                Console.WriteLine($"Failed with status code {response.StatusCode}");
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }
        */

        // Login
        UserLogin user_login = new UserLogin { 
            username = "xgame1",
            password = "password123",
        };
        AccessToken access_token = new AccessToken();
        try
        {
            using var http_client = new HttpClient();
            var user_json = JsonSerializer.Serialize(user_login);
            HttpContent content = new StringContent(user_json, System.Text.Encoding.UTF8, "application/json");
            var response = await http_client.PostAsync("https://dev.xgame.live/user/login", content);
            if (response.IsSuccessStatusCode) {
                var result = await response.Content.ReadAsStringAsync();
                access_token = JsonSerializer.Deserialize<AccessToken>(result);
                Console.WriteLine(access_token.access_token);
            }
            else {
                Console.WriteLine($"Failed with status code {response.StatusCode}");
            }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }


    }
}

class User
{
   public string username { get; set; } = string.Empty;
   public string password { get; set; } = string.Empty;
   public string confirm_password { get; set; } = string.Empty;
}

class UserLogin
{
   public string username { get; set; } = string.Empty;
   public string password { get; set; } = string.Empty;
}

class AccessToken
{
   public string access_token { get; set; } = string.Empty;
}



