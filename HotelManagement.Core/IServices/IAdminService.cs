using HotelManagement.Core.DTOs;
using HotelManagement.Core.Enums;

namespace HotelManagement.Core.IServices
{
    public interface IAdminService
    {
        Task<Response<string>> CreateRole(RoleDTO role);
        Task<Response<string>> AddUserRole(string userId, Roles role);
        Task<Response<string>> RemoveUserRole(string userId, Roles role);
    }
}
