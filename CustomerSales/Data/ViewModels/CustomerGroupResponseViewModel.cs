using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSales.Data.ViewModels
{
   
    public class Record
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Measure { get; set; }
        public int MeasureLast { get; set; }
    }

    public class CustomerGroupResponseViewModel
    {
        public List<Record> records { get; set; }
    }

}
