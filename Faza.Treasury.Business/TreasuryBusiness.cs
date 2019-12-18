using Faza.Treasury.Common.Interfaces;
using AutoMapper;
using Bitspco.Framework.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Business
{
    public partial class TreasuryBusiness : BaseBusiness
    {
        private Mapper mapper;

        public TreasuryBusiness(ITreasuryDataAdapter adapter, Mapper mapper) : base(adapter)
        {
            this.mapper = mapper;
        }

        protected override T MapTo<T>(object obj)
        {
            return mapper.Map<T>(obj);
        }

        protected override TR MapTo<T, TR>(T obj1, TR obj2)
        {
            return mapper.Map(obj1, obj2);
        }
    }
}
