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


namespace PolkadotAssetHub.NetApi.Generated.Model.pallet_asset_conversion.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Pallet's callable functions.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> create_pool
        /// See [`Pallet::create_pool`].
        /// </summary>
        create_pool = 0,
        
        /// <summary>
        /// >> add_liquidity
        /// See [`Pallet::add_liquidity`].
        /// </summary>
        add_liquidity = 1,
        
        /// <summary>
        /// >> remove_liquidity
        /// See [`Pallet::remove_liquidity`].
        /// </summary>
        remove_liquidity = 2,
        
        /// <summary>
        /// >> swap_exact_tokens_for_tokens
        /// See [`Pallet::swap_exact_tokens_for_tokens`].
        /// </summary>
        swap_exact_tokens_for_tokens = 3,
        
        /// <summary>
        /// >> swap_tokens_for_exact_tokens
        /// See [`Pallet::swap_tokens_for_exact_tokens`].
        /// </summary>
        swap_tokens_for_exact_tokens = 4,
    }
    
    /// <summary>
    /// >> 382 - Variant[pallet_asset_conversion.pallet.Call]
    /// Pallet's callable functions.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<PolkadotAssetHub.NetApi.Generated.Model.staging_xcm.v3.multilocation.MultiLocation>, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128, PolkadotAssetHub.NetApi.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.Bool>>
    {
    }
}
