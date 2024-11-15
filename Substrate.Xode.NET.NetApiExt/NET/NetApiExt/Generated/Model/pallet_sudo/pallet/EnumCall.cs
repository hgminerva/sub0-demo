//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Xode.NET.NetApiExt.Generated.Model.pallet_sudo.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> sudo
        /// Authenticates the sudo key and dispatches a function call with `Root` origin.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        sudo = 0,
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// Authenticates the sudo key and dispatches a function call with `Root` origin.
        /// This function does not check the weight of the call, and instead allows the
        /// Sudo user to specify the weight of the call.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        sudo_unchecked_weight = 1,
        
        /// <summary>
        /// >> set_key
        /// Authenticates the current sudo key and sets the given AccountId (`new`) as the new sudo
        /// key.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        set_key = 2,
        
        /// <summary>
        /// >> sudo_as
        /// Authenticates the sudo key and dispatches a function call with `Signed` origin from
        /// a given account.
        /// 
        /// The dispatch origin for this call must be _Signed_.
        /// 
        /// ## Complexity
        /// - O(1).
        /// </summary>
        sudo_as = 3,
    }
    
    /// <summary>
    /// >> 295 - Variant[pallet_sudo.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumRust<Call>
    {
        
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public EnumCall()
        {
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.humidefi_runtime.EnumRuntimeCall>(Call.sudo);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.humidefi_runtime.EnumRuntimeCall, Substrate.Xode.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight>>(Call.sudo_unchecked_weight);
				AddTypeDecoder<Substrate.Xode.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>(Call.set_key);
				AddTypeDecoder<BaseTuple<Substrate.Xode.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Substrate.Xode.NET.NetApiExt.Generated.Model.humidefi_runtime.EnumRuntimeCall>>(Call.sudo_as);
        }
    }
}
