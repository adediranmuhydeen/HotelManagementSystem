using System.Text.Json.Serialization;

namespace HotelManagement.Core.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Roles
    {
        Admin=0,
        Manager=1,
        Customer=2,
    }
}
