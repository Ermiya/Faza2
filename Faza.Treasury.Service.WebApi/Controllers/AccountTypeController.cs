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
    [RoutePrefix("AccountTypes")]
    public class AccountTypesController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<AccountTypeGetDto>> Select() => new OperationResultCount<List<AccountTypeGetDto>>()
        {
            Data = Controller.SelectAccountType(QueryOptions),
            Count = Controller.CountOfAccountType(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<AccountTypeGetDto> Get(int id) => Controller.GetAccountTypeById(id);
        [HttpPost, Route("")]
        public OperationResult<AccountTypeGetDto> Add([FromBody] AccountTypeAddDto obj) => Controller.AddAccountType(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<AccountTypeGetDto> Change(int id, [FromBody] AccountTypeChangeDto obj) => Controller.ChangeAccountType(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<AccountTypeGetDto> Remove(int id) => Controller.RemoveAccountType(id);
    }
}
