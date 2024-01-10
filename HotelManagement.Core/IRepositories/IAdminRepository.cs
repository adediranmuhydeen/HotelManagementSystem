using HotelManagement.Core.DTOs;
using HotelManagement.Core.Enums;

namespace HotelManagement.Core.IRepositories
{
    public interface IAdminRepository
    {
        Task<bool> CreateRole(RoleDTO role);
        Task<bool> AddUserRole(string userId, Roles role);
        Task<bool> RemoveUserRole(string userId, Roles role);
    }
}
