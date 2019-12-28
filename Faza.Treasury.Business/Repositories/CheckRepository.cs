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
        public int CountOfCheck(QueryOptions options) => Count<Check>(options);
        public List<Check> SelectCheck(QueryOptions options) => Select<Check>(options);
        public List<Check> GetAllCheck() => GetAll<Check>();
        public Check GetCheckById(int id) => GetById<Check>(id);
        public Check AddCheck(CheckAddDto obj) => Add<Check, CheckAddDto>(obj);
        public Check ChangeCheck(int id, CheckChangeDto obj) => Change<Check, CheckChangeDto>(id, obj);
        public Check RemoveCheck(int id) => Remove<Check>(id);
    }
}
