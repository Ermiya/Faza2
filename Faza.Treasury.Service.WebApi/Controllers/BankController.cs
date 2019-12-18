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
    [RoutePrefix("Banks")]
    public class BanksController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<BankGetDto>> Select() => new OperationResultCount<List<BankGetDto>>()
        {
            Data = Controller.SelectBank(QueryOptions),
            Count = Controller.CountOfBank(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<BankGetDto> Get(int id) => Controller.GetBankById(id);
        [HttpPost, Route("")]
        public OperationResult<BankGetDto> Add([FromBody] BankAddDto obj) => Controller.AddBank(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<BankGetDto> Change(int id, [FromBody] BankChangeDto obj) => Controller.ChangeBank(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<BankGetDto> Remove(int id) => Controller.RemoveBank(id);
    }
}
