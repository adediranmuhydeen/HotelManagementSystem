namespace HotelManagement.Core.DTOs
{
    public class CreateAmenitiesDTO
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string HotelId { get; set; }
        
    }
}
