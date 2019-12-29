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
        //[Auth("Check_Get")]
        public int CountOfCheck(QueryOptions options) => Count<Check>(options);
        //[Auth("Check_Get")]
        public List<CheckGetDto> SelectCheck(QueryOptions options) => Select<Check, CheckGetDto>(options);
        //[Auth("Check_Get")]
        public List<CheckGetDto> GetAllCheck() => GetAll<Check, CheckGetDto>();
        //[Auth("Check_Get")]
        public CheckGetDto GetCheckById(int id) => GetById<Check, CheckGetDto>(id);
        //[Auth("Check_Add")]
        public CheckGetDto AddCheck(CheckAddDto obj) => Add<Check, CheckGetDto, CheckAddDto>(obj);
        public List<CheckGetDto> AddCheckRang(CheckAddRangDto obj)
        {
            List<CheckGetDto> ListCheckGetDtos = new List<CheckGetDto>();
            
            var lst = Business.AddCheckRang(obj);
            foreach (var item in lst)
            {
                ListCheckGetDtos.Add(Mapper.Map<CheckGetDto>(item));
            }
            //Mapper.Map<List<CheckGetDto>>(lst);
            return Mapper.Map<List<CheckGetDto>>(lst); 
        }
        //[Auth("Check_Change")]
        public CheckGetDto ChangeCheck(int id, CheckChangeDto obj) => Change<Check, CheckGetDto, CheckChangeDto>(id, obj);
        //[Auth("Check_Remove")]
        public CheckGetDto RemoveCheck(int id) => Remove<Check, CheckGetDto>(id);
    }
}
