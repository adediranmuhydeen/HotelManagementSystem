﻿namespace HotelManagement.Core.DTOs
{
    public class GetCustomersByHotelDto
    {
        public string  CustomerFirstName { get; set; }

        public string CustomerLastName { get; set; }

        public string EmailAddress { get; set; }
        public string Gender { get; set; }

        public string State { get; set; }

    }
}
