namespace HotelManagement.Core.Domains
{
    public class State : BaseEntity
    {

        public string Name { get; set; }

        public string code { get; set; }

        public Address Address { get; set; }
    }
}
