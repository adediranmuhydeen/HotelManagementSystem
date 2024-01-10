using HotelManagement.Core.Domains;

namespace HotelManagement.Core.IRepositories
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        //void UpdateAsync(Review review);

        //Task<Review> CheckHotelExistence(string hotelId);
        Review AddReview(string review);

        public IQueryable<Review> GetHotelReviews(string hotelId);
    }
}
