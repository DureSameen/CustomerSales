using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSales.Data.ViewModels
{ 
    public class Criteria
    {
        public string Period { get; set; }
        public bool CompareWithLast { get; set; }
        public string GroupBy { get; set; }
        public string Measure { get; set; }
        public string Order { get; set; }
        public int Top { get; set; }
        public string Id { get; set; }
    }

    public class Filter
    {
        public string Column { get; set; }
        public string Value { get; set; }
    }

    public class DateRange
    {
        public string Type { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }

    public class CustomerGroupRequestViewModel
    {
        public Criteria Criteria { get; set; }
        public List<Filter> Filters { get; set; }
        public DateRange DateRange { get; set; }
    }

}
