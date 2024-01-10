using HotelManagement.Core.Domains;

namespace HotelManagement.Core.DTOs
{
    public class GetRoomDto
    {
        public string RoomNo { get; set; } = string.Empty;

        public bool IsBooked { get; set; } = false;

        public string RoomTypeId { get; set; } = string.Empty ;
        public RoomType RoomTypes { get; set; }
        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
