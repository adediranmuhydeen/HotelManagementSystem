using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IManagerRepository:IGenericRepository<Manager>
    {
        Task<Manager> GetManager(string Id);

        Manager GetBookingPerManager(string Id);
    }
}
