﻿namespace BookingSystem.Core.Models.Hotel
{
    public class HotelReservationVerifyViewModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string RoomType { get; set; } = null!;
        public string HotelName { get; set; } = null!;
        public int HotelStarRate { get; set; } 
        public string HotelImageUrl { get; set; } = null!; 
        public decimal Price { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public int Nights {  get; set; }    
    }
}
