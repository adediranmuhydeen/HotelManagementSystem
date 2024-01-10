using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IManagerRequestRepository:IGenericRepository<ManagerRequest>
    {
        Task<ManagerRequest> GetManagerRequestById(string managerId);
    }
}
