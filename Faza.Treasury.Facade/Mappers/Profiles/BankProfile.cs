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
    class BankProfile : Profile
    {
        public BankProfile()
        {
            CreateMap<Bank, BankGetDto>();
            CreateMap<BankAddDto, Bank>();
            CreateMap<BankChangeDto, Bank>();
        }
    }
}
