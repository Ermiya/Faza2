using Faza.Treasury.Common.Entities;
using Faza.Treasury.Shared.Models;
using Bitspco.Framework.Service.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Business
{
    public partial class TreasuryBusiness
    {
        public int CountOfCurrencyType(QueryOptions options) => Count<CurrencyType>(options);
        public List<CurrencyType> SelectCurrencyType(QueryOptions options) => Select<CurrencyType>(options);
        public List<CurrencyType> GetAllCurrencyType() => GetAll<CurrencyType>();
        public CurrencyType GetCurrencyTypeById(int id) => GetById<CurrencyType>(id);
        public CurrencyType AddCurrencyType(CurrencyTypeAddDto obj) => Add<CurrencyType, CurrencyTypeAddDto>(obj);
        public CurrencyType ChangeCurrencyType(int id, CurrencyTypeChangeDto obj) => Change<CurrencyType, CurrencyTypeChangeDto>(id, obj);
        public CurrencyType RemoveCurrencyType(int id) => Remove<CurrencyType>(id);
    }
}
