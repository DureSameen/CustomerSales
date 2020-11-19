using CustomerSales.Data.Infrastructure;
using CustomerSales.Data.ViewModels;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSales.Services
{
    public class DataService : IDataService
    {
        private readonly AppSettings _appSettings;
        public DataService(IOptions<AppSettings> appSettings)
        { _appSettings = appSettings.Value; }



        public CustomerGroupResponseViewModel GetCustomerGroup(CustomerGroupRequestViewModel request)
        {
            CustomerGroupResponseViewModel response = new CustomerGroupResponseViewModel();
            response.records = new List<Record>();
            string query = @$"select Top {request.Criteria.Top} sum({request.Criteria.Measure}) as Measure, 0 as MeasureLast, CustomerId as Id, CustomerName as Name, '' as Description from CustSales
where RegistrantId ='{request.Criteria.Id}'
and CompanyId = 'usrt'
and CustomerGroup in ('20', '30')
and ItemGroup = 'Equipment Mats'
and LocationId = 'NEWYORK'
group by CustomerId, CustomerName 
Order by CustomerName {request.Criteria.Order}";

            using (var connection = new SqlConnection(_appSettings.ConnectionStrings.DPBIPOC_ConnectingString))
            {

                response.records = connection.Query<Record>(query).ToList();   
              
            }


            return response;

        }
    }
}
