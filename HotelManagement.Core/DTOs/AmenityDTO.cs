namespace HotelManagement.Core.DTOs
{
    public class AmenityDTO
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        //public string HotelId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        //public Hotel Hotel { get; set; }
    }
}
