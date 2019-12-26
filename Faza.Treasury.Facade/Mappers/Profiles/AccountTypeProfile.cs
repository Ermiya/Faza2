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
    class AccountTypeProfile : Profile
    {
        public AccountTypeProfile()
        {
            CreateMap<AccountType, AccountTypeGetDto>();
            CreateMap<AccountTypeAddDto, AccountType>();
            CreateMap<AccountTypeChangeDto, AccountType>();
        }
    }
}
