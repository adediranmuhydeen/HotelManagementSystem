namespace HotelManagement.Core.DTOs.BookingDtos
{
    public class BookingRequestDto
    {
      
        public int NoOfPeople { get; set; }
        public string ServiceName { get; set; }
        public string CustomerId { get; set; }
        public string RoomTypeId { get; set; }
        public string HotelId { get; set; }
    }
}
