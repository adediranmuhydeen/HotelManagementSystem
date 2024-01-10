using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IHotelRepository : IGenericRepository<Hotel>
    {
        void AddHotel(string Manager_ID, Hotel hotel);
        void UpdateAsync(Hotel hotel);
    }
}
