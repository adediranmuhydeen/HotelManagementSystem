using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IUpdateUserAppRepository : IGenericRepository<AppUser>
    {
        Task UpdateAsync(AppUser user);
    }
}
