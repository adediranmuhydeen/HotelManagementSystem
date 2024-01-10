namespace HotelManagement.Core.DTOs
{
    public class UpdateAmenityDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string HotelId { get; set; }

    }
}
