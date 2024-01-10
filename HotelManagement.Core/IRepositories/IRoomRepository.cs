using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IRoomRepository: IGenericRepository<Room>
    {
        void Add(string Roomtype_ID, Room room);
        Task<Room> DeleteAsync(string Id);

    }
}
