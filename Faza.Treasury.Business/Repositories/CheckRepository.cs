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
        public List<Check> AddCheckRang(CheckAddRangDto obj)
        {
            List<Check> listCheck = new List<Check>();
            for (long i = obj.FromNo; i <= obj.ToNo; i++)
            {
                CheckAddDto NewCheck = new CheckAddDto
                {
                    BankAccountId = obj.BankBranchId,
                    CheckBook = obj.CheckBook,
                    CheckNo = i,
                    Status = true,
                    CancelDate = null,
                    DeliveryDate = null,
                    IssuingDate = null
                };
                Check check = new Check();
                listCheck.Add(AddCheck(NewCheck));
                SaveChanges();
            }
            return listCheck;
        }


    }
}
