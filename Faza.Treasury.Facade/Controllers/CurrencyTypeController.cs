using Faza.Treasury.Common.Entities;
using Faza.Treasury.Shared.Models;
using Bitspco.Framework.Facade.Filters.Security.Authenticate;
using Bitspco.Framework.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade
{
    public partial class TreasuryController
    {
        //[Auth("CurrencyType_Get")]
        public int CountOfCurrencyType(QueryOptions options) => Count<CurrencyType>(options);
        //[Auth("CurrencyType_Get")]
        public List<CurrencyTypeGetDto> SelectCurrencyType(QueryOptions options) => Select<CurrencyType, CurrencyTypeGetDto>(options);
        //[Auth("CurrencyType_Get")]
        public List<CurrencyTypeGetDto> GetAllCurrencyType() => GetAll<CurrencyType, CurrencyTypeGetDto>();
        //[Auth("CurrencyType_Get")]
        public CurrencyTypeGetDto GetCurrencyTypeById(int id) => GetById<CurrencyType, CurrencyTypeGetDto>(id);
        //[Auth("CurrencyType_Add")]
        public CurrencyTypeGetDto AddCurrencyType(CurrencyTypeAddDto obj) => Add<CurrencyType, CurrencyTypeGetDto, CurrencyTypeAddDto>(obj);
        //[Auth("CurrencyType_Change")]
        public CurrencyTypeGetDto ChangeCurrencyType(int id, CurrencyTypeChangeDto obj) => Change<CurrencyType, CurrencyTypeGetDto, CurrencyTypeChangeDto>(id, obj);
        //[Auth("CurrencyType_Remove")]
        public CurrencyTypeGetDto RemoveCurrencyType(int id) => Remove<CurrencyType, CurrencyTypeGetDto>(id);
    }
}
