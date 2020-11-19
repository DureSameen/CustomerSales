using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSales.Data.Infrastructure
{
    public class AppSettings
    {
        public ConnectionString ConnectionStrings { get; set; }
    }


    public class ConnectionString
    {
        public string DPBIPOC_ConnectingString { get; set; }
    }
}
