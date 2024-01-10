using HotelManagement.Core;

namespace HotelManagement.Api.Extensions
{
    public static class MailServiceExtension
    {
        public static void ConfigureMailService(this IServiceCollection services, IConfiguration Configuration)
        {
            //EmailService registration
            var emailConfig = Configuration
               .GetSection("EmailConfiguration")
               .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

        }

    }
}
