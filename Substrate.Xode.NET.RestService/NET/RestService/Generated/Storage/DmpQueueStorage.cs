//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Xode.NET.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IDmpQueueStorage interface definition.
    /// </summary>
    public interface IDmpQueueStorage : IStorage
    {
        
        /// <summary>
        /// >> Configuration
        ///  The configuration.
        /// </summary>
        Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData GetConfiguration();
        
        /// <summary>
        /// >> PageIndex
        ///  The page index.
        /// </summary>
        Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData GetPageIndex();
        
        /// <summary>
        /// >> Pages
        ///  The queue pages.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> GetPages(string key);
        
        /// <summary>
        /// >> Overweight
        ///  The overweight messages.
        /// </summary>
        Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetOverweight(string key);
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForOverweight();
    }
    
    /// <summary>
    /// DmpQueueStorage class definition.
    /// </summary>
    public sealed class DmpQueueStorage : IDmpQueueStorage
    {
        
        /// <summary>
        /// _configurationTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData> _configurationTypedStorage;
        
        /// <summary>
        /// _pageIndexTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData> _pageIndexTypedStorage;
        
        /// <summary>
        /// _pagesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>> _pagesTypedStorage;
        
        /// <summary>
        /// _overweightTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> _overweightTypedStorage;
        
        /// <summary>
        /// _counterForOverweightTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> _counterForOverweightTypedStorage;
        
        /// <summary>
        /// DmpQueueStorage constructor.
        /// </summary>
        public DmpQueueStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ConfigurationTypedStorage = new TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData>("DmpQueue.Configuration", storageDataProvider, storageChangeDelegates);
            this.PageIndexTypedStorage = new TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData>("DmpQueue.PageIndex", storageDataProvider, storageChangeDelegates);
            this.PagesTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>>("DmpQueue.Pages", storageDataProvider, storageChangeDelegates);
            this.OverweightTypedStorage = new TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>("DmpQueue.Overweight", storageDataProvider, storageChangeDelegates);
            this.CounterForOverweightTypedStorage = new TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32>("DmpQueue.CounterForOverweight", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _configurationTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData> ConfigurationTypedStorage
        {
            get
            {
                return _configurationTypedStorage;
            }
            set
            {
                _configurationTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _pageIndexTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData> PageIndexTypedStorage
        {
            get
            {
                return _pageIndexTypedStorage;
            }
            set
            {
                _pageIndexTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _pagesTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>> PagesTypedStorage
        {
            get
            {
                return _pagesTypedStorage;
            }
            set
            {
                _pagesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _overweightTypedStorage property
        /// </summary>
        public TypedMapStorage<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> OverweightTypedStorage
        {
            get
            {
                return _overweightTypedStorage;
            }
            set
            {
                _overweightTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _counterForOverweightTypedStorage property
        /// </summary>
        public TypedStorage<Substrate.NetApi.Model.Types.Primitive.U32> CounterForOverweightTypedStorage
        {
            get
            {
                return _counterForOverweightTypedStorage;
            }
            set
            {
                _counterForOverweightTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Substrate.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ConfigurationTypedStorage.InitializeAsync("DmpQueue", "Configuration");
            await PageIndexTypedStorage.InitializeAsync("DmpQueue", "PageIndex");
            await PagesTypedStorage.InitializeAsync("DmpQueue", "Pages");
            await OverweightTypedStorage.InitializeAsync("DmpQueue", "Overweight");
            await CounterForOverweightTypedStorage.InitializeAsync("DmpQueue", "CounterForOverweight");
        }
        
        /// <summary>
        /// Implements any storage change for DmpQueue.Configuration
        /// </summary>
        [StorageChange("DmpQueue", "Configuration")]
        public void OnUpdateConfiguration(string data)
        {
            ConfigurationTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Configuration
        ///  The configuration.
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.ConfigData GetConfiguration()
        {
            return ConfigurationTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for DmpQueue.PageIndex
        /// </summary>
        [StorageChange("DmpQueue", "PageIndex")]
        public void OnUpdatePageIndex(string data)
        {
            PageIndexTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PageIndex
        ///  The page index.
        /// </summary>
        public Substrate.Xode.NET.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.PageIndexData GetPageIndex()
        {
            return PageIndexTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for DmpQueue.Pages
        /// </summary>
        [StorageChange("DmpQueue", "Pages")]
        public void OnUpdatePages(string key, string data)
        {
            PagesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Pages
        ///  The queue pages.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> GetPages(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (PagesTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for DmpQueue.Overweight
        /// </summary>
        [StorageChange("DmpQueue", "Overweight")]
        public void OnUpdateOverweight(string key, string data)
        {
            OverweightTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Overweight
        ///  The overweight messages.
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> GetOverweight(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (OverweightTypedStorage.Dictionary.TryGetValue(key, out Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for DmpQueue.CounterForOverweight
        /// </summary>
        [StorageChange("DmpQueue", "CounterForOverweight")]
        public void OnUpdateCounterForOverweight(string data)
        {
            CounterForOverweightTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CounterForOverweight
        /// Counter for the related counted storage map
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 GetCounterForOverweight()
        {
            return CounterForOverweightTypedStorage.Get();
        }
    }
}
