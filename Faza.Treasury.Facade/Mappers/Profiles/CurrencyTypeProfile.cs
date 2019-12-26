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
    class CurrencyTypeProfile : Profile
    {
        public CurrencyTypeProfile()
        {
            CreateMap<CurrencyType, CurrencyTypeGetDto>();
            CreateMap<CurrencyTypeAddDto, CurrencyType>();
            CreateMap<CurrencyTypeChangeDto, CurrencyType>();
        }
    }
}
