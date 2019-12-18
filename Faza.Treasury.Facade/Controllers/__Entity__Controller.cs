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
        [Auth("__EntityName___Get")]
        public int CountOf__EntityName__(QueryOptions options) => Count<__EntityName__>(options);
        [Auth("__EntityName___Get")]
        public List<__EntityName__GetDto> Select__EntityName__(QueryOptions options) => Select<__EntityName__, __EntityName__GetDto>(options);
        [Auth("__EntityName___Get")]
        public List<__EntityName__GetDto> GetAll__EntityName__() => GetAll<__EntityName__, __EntityName__GetDto>();
        [Auth("__EntityName___Get")]
        public __EntityName__GetDto Get__EntityName__ById(int id) => GetById<__EntityName__, __EntityName__GetDto>(id);
        [Auth("__EntityName___Add")]
        public __EntityName__GetDto Add__EntityName__(__EntityName__AddDto obj) => Add<__EntityName__, __EntityName__GetDto, __EntityName__AddDto>(obj);
        [Auth("__EntityName___Change")]
        public __EntityName__GetDto Change__EntityName__(int id, __EntityName__ChangeDto obj) => Change<__EntityName__, __EntityName__GetDto, __EntityName__ChangeDto>(id, obj);
        [Auth("__EntityName___Remove")]
        public __EntityName__GetDto Remove__EntityName__(int id) => Remove<__EntityName__, __EntityName__GetDto>(id);
    }
}
