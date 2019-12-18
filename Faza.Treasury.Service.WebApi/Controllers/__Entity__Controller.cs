using Faza.Treasury.Shared.Models;
using Bitspco.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Faza.Treasury.Service.WebApi.Controllers
{
    [RoutePrefix("__EntityNames__")]
    public class __EntityNames__Controller : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<__EntityName__GetDto>> Select() => new OperationResultCount<List<__EntityName__GetDto>>()
        {
            Data = Controller.Select__EntityName__(QueryOptions),
            Count = Controller.CountOf__EntityName__(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<__EntityName__GetDto> Get(int id) => Controller.Get__EntityName__ById(id);
        [HttpPost, Route("")]
        public OperationResult<__EntityName__GetDto> Add([FromBody] __EntityName__AddDto obj) => Controller.Add__EntityName__(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<__EntityName__GetDto> Change(int id, [FromBody] __EntityName__ChangeDto obj) => Controller.Change__EntityName__(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<__EntityName__GetDto> Remove(int id) => Controller.Remove__EntityName__(id);
    }
}
