using Faza.Treasury.Common.Entities;
using Faza.Treasury.Shared.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade.Mappers.Profiles
{
    class __EntityName__Profile : Profile
    {
        public __EntityName__Profile()
        {
            CreateMap<__EntityName__, __EntityName__GetDto>();
            CreateMap<__EntityName__AddDto, __EntityName__>();
            CreateMap<__EntityName__ChangeDto, __EntityName__>();
        }
    }
}
