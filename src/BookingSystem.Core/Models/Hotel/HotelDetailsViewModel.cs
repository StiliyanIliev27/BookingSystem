﻿using BookingSystem.Infrastructure.Data.Models.Hotels;
using BookingSystem.Infrastructure.Data.Models.Location;

namespace BookingSystem.Core.Models.Hotel
{
    public class HotelDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public int StarRate { get; set; }
        public string? Details { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string CheckIn { get; set; } = null!;
        public string CheckOut { get; set; } = null!;
        public bool? Parking { get; set; }
        public bool? Pets { get; set; }
        public IEnumerable<Room> Rooms { get; set; } = null!;
        public int HotelsCount { get; set; }
    }
}