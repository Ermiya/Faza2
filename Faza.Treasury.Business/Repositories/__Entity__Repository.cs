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
        public int CountOf__EntityName__(QueryOptions options) => Count<__EntityName__>(options);
        public List<__EntityName__> Select__EntityName__(QueryOptions options) => Select<__EntityName__>(options);
        public List<__EntityName__> GetAll__EntityName__() => GetAll<__EntityName__>();
        public __EntityName__ Get__EntityName__ById(int id) => GetById<__EntityName__>(id);
        public __EntityName__ Add__EntityName__(__EntityName__AddDto obj) => Add<__EntityName__, __EntityName__AddDto>(obj);
        public __EntityName__ Change__EntityName__(int id, __EntityName__ChangeDto obj) => Change<__EntityName__, __EntityName__ChangeDto>(id, obj);
        public __EntityName__ Remove__EntityName__(int id) => Remove<__EntityName__>(id);
    }
}
