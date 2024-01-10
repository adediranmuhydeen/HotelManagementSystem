using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IAmenityRepository : IGenericRepository<Amenity>
    {
        // CREATE
        Task<Amenity> UpdateAsync(Amenity entity);
        Task SaveChangesAsync();
      
        Task DeleteAsync(Amenity entity);

    }
}
