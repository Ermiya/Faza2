using Faza.Treasury.Common.Interfaces;
using Faza.Treasury.Data.Contexts;
using Bitspco.Framework.Net.Logger;
using Bitspco.Framework.Net.Logger.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Data
{
    public class TreasuryDataAdapter : LoggerDataAdapter<TreasuryDbContext>, ITreasuryDataAdapter
    {
        public TreasuryDataAdapter(TreasuryDbContext context) : base(context)
        {
        }
    }
}
