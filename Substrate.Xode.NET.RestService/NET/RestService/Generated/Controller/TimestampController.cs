//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.ServiceLayer.Attributes;
using Substrate.Xode.NET.RestService.Generated.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Substrate.Xode.NET.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// TimestampController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TimestampController : ControllerBase
    {
        
        private ITimestampStorage _timestampStorage;
        
        /// <summary>
        /// TimestampController constructor.
        /// </summary>
        public TimestampController(ITimestampStorage timestampStorage)
        {
            _timestampStorage = timestampStorage;
        }
        
        /// <summary>
        /// >> Now
        ///  Current time for the current block.
        /// </summary>
        [HttpGet("Now")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.U64), 200)]
        [StorageKeyBuilder(typeof(Substrate.Xode.NET.NetApiExt.Generated.Storage.TimestampStorage), "NowParams")]
        public IActionResult GetNow()
        {
            return this.Ok(_timestampStorage.GetNow());
        }
        
        /// <summary>
        /// >> DidUpdate
        ///  Did the timestamp get updated in this block?
        /// </summary>
        [HttpGet("DidUpdate")]
        [ProducesResponseType(typeof(Substrate.NetApi.Model.Types.Primitive.Bool), 200)]
        [StorageKeyBuilder(typeof(Substrate.Xode.NET.NetApiExt.Generated.Storage.TimestampStorage), "DidUpdateParams")]
        public IActionResult GetDidUpdate()
        {
            return this.Ok(_timestampStorage.GetDidUpdate());
        }
    }
}
