using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IRateHotelRepository : IGenericRepository<Rating>
    {
        Task RateHotel(Rating Rating);
    }
}
