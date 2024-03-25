namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Flight;

    public class FlightService : IFlightService
    {
        private readonly IRepository repository;

        public FlightService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<FlightQueryServiceModel> AllAsync(string? departureCity = null, 
            string? arrivalCity = null, 
            FlightSorting sorting = FlightSorting.PriceAscending, 
            int currentPage = 1, 
            int flightsPerPage = 4)
        {
            var flightsToShow = repository.AllReadOnly<Flight>();

            if (departureCity != null)
            {
                flightsToShow = flightsToShow
                    .Where(f => f.DepartureAirport.City.Name == departureCity);
            }
         
            if (arrivalCity != null)
            {
                flightsToShow = flightsToShow
                    .Where(f => f.ArrivalAirport.City.Name == arrivalCity);
            }

            flightsToShow = sorting switch
            {
                FlightSorting.PriceAscending => flightsToShow.OrderBy(f => f.TicketPrice),
                _ => flightsToShow.OrderByDescending(f => f.TicketPrice)
            };

            var flights = await flightsToShow
                .Skip((currentPage - 1) * flightsPerPage)
                .Take(flightsPerPage)
                .Include(f => f.Airline)
                .Include(f => f.DepartureAirport)
                .ThenInclude(f => f.City)
                .Include(f => f.ArrivalAirport)
                .ThenInclude(f => f.City)
                .Select(f => new FlightServiceModel()
                {
                    Id = f.Id,
                    Airline = f.Airline.Name,
                    AirlineLogoUrl = f.Airline.ImageUrl,
                    Airline_Id = f.Airline_Id,
                    DepartureAirport = f.DepartureAirport.ShorterName,
                    DepartureAirport_Id = f.DepartureAirport_Id,
                    DepartureTime = f.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                    ArrivalAirport = f.ArrivalAirport.ShorterName,
                    ArrivalAirport_Id = f.Airline_Id,
                    ArrivalTime = f.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                    FlightDuration = f.FlightDuration,
                    TicketPrice = f.TicketPrice
                }).ToListAsync();

            int totalFlights = await flightsToShow.CountAsync();

            return new FlightQueryServiceModel()
            {
                TotalFlightsCount = totalFlights,
                Flights = flights
            };
        }
    }
}
