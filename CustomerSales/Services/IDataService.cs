using CustomerSales.Data.ViewModels;

namespace CustomerSales.Services
{
    public interface IDataService
    {
        CustomerGroupResponseViewModel GetCustomerGroup(CustomerGroupRequestViewModel request);
    }
}