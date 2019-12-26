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
    [RoutePrefix("CurrencyTypes")]
    public class CurrencyTypesController : ApiController
    {
        [HttpGet, Route("")]
        public OperationResultCount<List<CurrencyTypeGetDto>> Select() => new OperationResultCount<List<CurrencyTypeGetDto>>()
        {
            Data = Controller.SelectCurrencyType(QueryOptions),
            Count = Controller.CountOfCurrencyType(QueryOptionsCount)
        };
        [HttpGet, Route("{id:int}")]
        public OperationResult<CurrencyTypeGetDto> Get(int id) => Controller.GetCurrencyTypeById(id);
        [HttpPost, Route("")]
        public OperationResult<CurrencyTypeGetDto> Add([FromBody] CurrencyTypeAddDto obj) => Controller.AddCurrencyType(obj);
        [HttpPatch, Route("{id:int}")]
        public OperationResult<CurrencyTypeGetDto> Change(int id, [FromBody] CurrencyTypeChangeDto obj) => Controller.ChangeCurrencyType(id, obj);
        [HttpDelete, Route("{id:int}")]
        public OperationResult<CurrencyTypeGetDto> Remove(int id) => Controller.RemoveCurrencyType(id);
    }
}
