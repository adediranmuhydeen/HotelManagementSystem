using HotelManagement.Core.Domains;
namespace HotelManagement.Core.IRepositories
{
    public interface ITransactionsRepository : IGenericRepository<Payment>
    {

        Task<Manager> GetHotelManager(string managerId);
        Task<Hotel> GetAllRoomsTransaction(string hotelId);

        Task<IQueryable<Payment>> GetAllCustomerTransactionsForAHotel(string hotelId, string customerId);

        Task<IQueryable<Customer>> GetAllUsersTransaction();
    }
}


