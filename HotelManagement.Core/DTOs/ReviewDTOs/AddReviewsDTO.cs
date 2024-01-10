using HotelManagement.Core.Domains;
using System.ComponentModel.DataAnnotations;

namespace HotelManagement.Core.DTOs.ReviewDTOs
{
    public class AddReviewsDTO
    {
        [DataType(DataType.Text)]
        public string Comment { get; set; }
        public string HotelId { get; set; }
        public string CustomerId { get; set; }
        public Hotel Hotel { get; set; }

    }
}
