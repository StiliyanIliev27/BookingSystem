namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;
    using System.Threading.Tasks;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Flight;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.FlightReservation;

    public class FlightService : IFlightService
    {
        private readonly IRepository repository;

        public FlightService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> ExistsByIdAsync(int flightId)
        {
            return await repository.AllReadOnly<Flight>()
                .AnyAsync(f => f.Id == flightId);
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

        public async Task<FlightDetailsViewModel> DetailsAsync(int flightId)
        {
            var flight = await repository.AllReadOnly<Flight>()
                .Include(f => f.ArrivalAirport.City)
                .Include(f => f.ArrivalAirport)
                .Include(f => f.DepartureAirport)
                .Include(f => f.Airline)
                .FirstOrDefaultAsync(f => f.Id == flightId);

            if (flight == null)
            {
                throw new ArgumentException("The current flight is not found!");
            }

            return new FlightDetailsViewModel()
            {
                Id = flightId,
                City = flight.ArrivalAirport.City.Name,
                ArrivalAirportName = flight.ArrivalAirport.Name,
                ArrivalAirportShorterName = flight.ArrivalAirport.ShorterName,
                DepartureAirportName = flight.DepartureAirport.Name,
                DepartureAirportShorterName = flight.DepartureAirport.ShorterName,
                Airline = flight.Airline.Name,
                AirlineLogoUrl = flight.Airline.ImageUrl,
                DepartureTime = flight.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                ArrivalTime = flight.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                FlightDuration = flight.FlightDuration,
                CabinClass = flight.CabinClass.ToString(),
                TicketPrice = flight.TicketPrice,
            };
        }

        public async Task<FlightReserveInputModel> GetForReserveAsync(int flightId)
        {
            var flight = await repository.GetByIdAsync<Flight>(flightId);

            if (flight == null)
            {
                throw new ArgumentException("The current flight was not found!");
            }

            return new FlightReserveInputModel()
            {
                Flight_Id = flightId,
                DetailsViewModel = await DetailsAsync(flightId)
            };
        }

        public async Task ReserveAsync(FlightReserveInputModel model, string userId, int flightId)
        {
            Random random = new Random();
            int seatNumber = random.Next(1, 100);

            var reservation = new FlightReservation()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SeatNumber = seatNumber,
                ReservationDate = DateTime.ParseExact(model.ReservationDate, DateTimeFormat,
                CultureInfo.CurrentCulture, DateTimeStyles.None),
                CreatedOn = DateTime.Now,
                Flight_Id = flightId,
                User_Id = userId
            };

            await repository.AddAsync(reservation);
            await repository.SaveChangesAsync();
        }
    }
}
