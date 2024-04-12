﻿namespace BookingSystem.Core.Models.QueryModels.Admin.Flight
{
    using BookingSystem.Core.Contracts;
    public class FlightViewModel : IFlightModel
    {
        public int Id { get; set; }

        public string DepartureAirport { get; set; } = null!;

        public string ArrivalAirport { get; set; } = null!;

        public string Airline { get; set; } = null!;

        public string DepartureTime { get; set; } = null!;

        public string ArrivalTime { get; set; } = null!;

        public int FlightDuration { get; set; }

        public string CabinClass { get; set; } = null!;

        public decimal TicketPrice { get; set; }
    }
}
