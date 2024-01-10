namespace HotelManagement.Core.Domains
{
    public class Room : BaseEntity
    {
        public string RoomTypeId { get; set; }
        public string RoomNo { get; set; }
        public bool IsBooked { get; set; }
        public RoomType Roomtype { get; set; }
      
    }
}
