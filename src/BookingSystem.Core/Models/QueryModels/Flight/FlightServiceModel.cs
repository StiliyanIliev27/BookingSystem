using BookingSystem.Core.Contracts;

namespace BookingSystem.Core.Models.QueryModels.Flight
{
    public class FlightServiceModel : IFlightModel
    {
        public int Id { get; set; }

        public int Airline_Id { get; set; }

        public string Airline { get; set; } = null!;

        public string? AirlineLogoUrl { get; set; } = null!;

        public int DepartureAirport_Id { get; set; }

        public string DepartureAirport { get; set; } = null!;
     
        public string DepartureAirportShorterName { get; set; } = null!;

        public int ArrivalAirport_Id { get; set; }

        public string ArrivalAirport { get; set; } = null!;

        public string ArrivalAirportShorterName { get; set; } = null!;

        public string DepartureTime { get; set; } = null!;

        public string ArrivalTime { get; set; } = null!;

        public int FlightDuration { get; set; }

        public decimal TicketPrice { get; set; }
        
    }
}
