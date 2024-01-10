using HotelManagement.Application.Utilities;

namespace HotelManagement.Api.Extensions
{
    public static class AutoMapperServiceExtension
    {
        public static void ConfigureAutoMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapInitializer));
        }
    }
}
