﻿namespace HotelManagement.Core.Domains
{
    public class PaymentDTO
    {
        public string BookingId { get; set; }
        public string TransactionReference { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string MethodOfPayment { get; set; }
        public DateTime CreatedAt { get; set; }
        
    }
}

