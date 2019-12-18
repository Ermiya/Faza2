using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faza.Treasury.Facade
{
    public class TreasuryConfiguration
    {
        public string Symbol { get; set; }
        public string ConnectionString { get; set; }
        public TreasuryConfigurationIdentity Identity { get; set; }
    }
    public class TreasuryConfigurationIdentity
    {
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
