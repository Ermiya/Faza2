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
    [RoutePrefix("BankBranchs")]
    public class BankBranchsController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<BankBranchGetDto>> Select() => new OperationResultCount<List<BankBranchGetDto>>()
        {
            Data = Controller.SelectBankBranch(QueryOptions),
            Count = Controller.CountOfBankBranch(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<BankBranchGetDto> Get(int id) => Controller.GetBankBranchById(id);
        [HttpPost, Route("")]
        public OperationResult<BankBranchGetDto> Add([FromBody] BankBranchAddDto obj) => Controller.AddBankBranch(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<BankBranchGetDto> Change(int id, [FromBody] BankBranchChangeDto obj) => Controller.ChangeBankBranch(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<BankBranchGetDto> Remove(int id) => Controller.RemoveBankBranch(id);
    }
}
