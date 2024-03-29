﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Core.Domains
{
    public class Address :BaseEntity 
    {
        public string  City { get; set; }

        public string Country { get; set; }

        public string Longitude { get; set; }

        public  string Latitude { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}
