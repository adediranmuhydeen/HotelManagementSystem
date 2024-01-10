using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<Response<List<Customer>>> GetTopHotelCustomers(string hotelId);
        //Task<Response<List<Customer>>> GetCustomers(int pageNo);

        Task<IQueryable<Customer>> GetCustomers(int pageNo);

        Task<List<Customer>>GetCustomersByHotel(string hotelId);
        Task<Customer> GetCustomer(string Id);
       
    }
}
