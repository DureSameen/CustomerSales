using CustomerSales.Data.ViewModels;
using CustomerSales.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerSales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSalesController : ControllerBase
    {
        private readonly IDataService _dataService;
        public CustomerSalesController(IDataService dataService)
        { 
            _dataService = dataService;
        }

        // POST api/<CustomerSalesController>
        [HttpPost]
        public CustomerGroupResponseViewModel Post([FromBody] CustomerGroupRequestViewModel request)
        {

            return _dataService.GetCustomerGroup(request);
        }

        
        
    }
}
