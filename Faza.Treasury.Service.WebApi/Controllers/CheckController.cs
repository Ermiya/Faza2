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
    [RoutePrefix("Checks")]
    public class ChecksController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<CheckGetDto>> Select() => new OperationResultCount<List<CheckGetDto>>()
        {
            Data = Controller.SelectCheck(QueryOptions),
            Count = Controller.CountOfCheck(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<CheckGetDto> Get(int id) => Controller.GetCheckById(id);
        [HttpPost, Route("")]
        public OperationResult<CheckGetDto> Add([FromBody] CheckAddDto obj) => Controller.AddCheck(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<CheckGetDto> Change(int id, [FromBody] CheckChangeDto obj) => Controller.ChangeCheck(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<CheckGetDto> Remove(int id) => Controller.RemoveCheck(id);
    }
}
