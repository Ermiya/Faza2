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
    [RoutePrefix("BankAccounts")]
    public class BankAccountsController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<BankAccountGetDto>> Select() => new OperationResultCount<List<BankAccountGetDto>>()
        {
            Data = Controller.SelectBankAccount(QueryOptions),
            Count = Controller.CountOfBankAccount(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<BankAccountGetDto> Get(int id) => Controller.GetBankAccountById(id);
        [HttpPost, Route("")]
        public OperationResult<BankAccountGetDto> Add([FromBody] BankAccountAddDto obj) => Controller.AddBankAccount(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<BankAccountGetDto> Change(int id, [FromBody] BankAccountChangeDto obj) => Controller.ChangeBankAccount(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<BankAccountGetDto> Remove(int id) => Controller.RemoveBankAccount(id);
    }
}
