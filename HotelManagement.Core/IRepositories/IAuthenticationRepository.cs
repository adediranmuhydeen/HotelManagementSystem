using HotelManagement.Core.DTOs;

namespace HotelManagement.Core.IRepositories
{
    public interface IAuthenticationRepository
    {
        Task<Response<string>> Login(LoginDTO model);
        Task<bool> Register(RegisterDTO user);
        Task<Response<string>> RefreshToken();
        public Task<object> ChangePassword(ChangePasswordDTO changePasswordDTO);
        public Task<object> ResetPassword(UpdatePasswordDTO resetPasswordDTO);
        public Task<object> ForgottenPassword(ResetPasswordDTO model);
        Task Signout();
    }
}
