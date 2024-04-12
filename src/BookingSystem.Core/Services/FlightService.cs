namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Enumerations;
    using BookingSystem.Core.Exceptions;
    using BookingSystem.Core.Models.Flight;
    using BookingSystem.Core.Models.QueryModels.Admin.Flight;
    using BookingSystem.Core.Models.QueryModels.Flight;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Enums;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
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

        public async Task<bool> VerificationExistsByIdAsync(string verificationId)
        {
            return await repository.AllReadOnly<FlightReservation>()
                .AnyAsync(fr => fr.IsActive == false && fr.Id == verificationId);
        }

        public async Task<bool> ReservationExistsByIdAsync(string reservationId)
        {
            return await repository.AllReadOnly<FlightReservation>()
                .AnyAsync(fr => fr.IsActive == true && fr.Id == reservationId);
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
                    DepartureAirport = f.DepartureAirport.Name,
                    DepartureAirportShorterName = f.DepartureAirport.ShorterName,
                    DepartureAirport_Id = f.DepartureAirport_Id,
                    DepartureTime = f.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                    ArrivalAirport = f.ArrivalAirport.Name,
                    ArrivalAirportShorterName = f.ArrivalAirport.ShorterName,
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
                .Include(f => f.ArrivalAirport)
                .Include(f => f.ArrivalAirport.City)
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
                ArrivalAirport = flight.ArrivalAirport.Name,
                ArrivalAirportShorterName = flight.ArrivalAirport.ShorterName,
                DepartureAirport = flight.DepartureAirport.Name,
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

        public async Task<FlightReservationInputModel> GetForReserveAsync(int flightId)
        {
            var flight = await repository.GetByIdAsync<Flight>(flightId);

            if (flight == null)
            {
                throw new ArgumentException("The current flight was not found!");
            }

            return new FlightReservationInputModel()
            {
                Flight_Id = flightId,
                DetailsViewModel = await DetailsAsync(flightId)
            };
        }

        public async Task ReserveAsync(FlightReservationInputModel model, string userId, int flightId)
        {
            Random random = new Random();
            int seatNumber = random.Next(1, 100);

            var flight = await repository.GetByIdAsync<Flight>(flightId);

            if(flight == null)
            {
                throw new ArgumentNullException("The current flight does not exist!");
            }

            var reservation = new FlightReservation()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                SeatNumber = seatNumber,
                ReservationDate = DateTime.ParseExact(model.ReservationDate, DateTimeFormat,
                CultureInfo.CurrentCulture, DateTimeStyles.None),
                CreatedOn = DateTime.Now,
                TotalPrice = flight.TicketPrice,
                Flight_Id = flightId,
                User_Id = userId
            };

            await repository.AddAsync(reservation);
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<FlightReservationVerifyViewModel>> GetReservationsForVerifyAsync(string userId)
        {
            var verificationsToRemove = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == userId && fr.IsActive == false
                    && fr.ReservationDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(verificationsToRemove.Any())
            {
                foreach(var ver in verificationsToRemove)
                {
                    repository.Delete(ver);
                }
               
                await repository.SaveChangesAsync();
            }

            return await repository.AllReadOnly<FlightReservation>()
                .Where(fr => fr.User_Id == userId && fr.ReservationDate >= DateTime.Now.Date && fr.IsActive == false)
                .Include(fr => fr.Flight)
                .Include(fr => fr.Flight.Airline)
                .Include(fr => fr.Flight.DepartureAirport)
                .Include(fr => fr.Flight.ArrivalAirport)
                .Include(fr => fr.Flight.ArrivalAirport.City)
                .Select(fr => new FlightReservationVerifyViewModel()
                {
                    Id = fr.Id,
                    FirstName = fr.FirstName,
                    LastName = fr.LastName,
                    SeatNumber = fr.SeatNumber,
                    ArrivalAirport = fr.Flight.ArrivalAirport.Name,
                    DepartureAirport = fr.Flight.DepartureAirport.Name,
                    ReservationDate = fr.ReservationDate.ToString(DateTimeFormat),
                    DepartureTime = fr.Flight.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                    ArrivalTime = fr.Flight.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                    TotalPrice = fr.TotalPrice,
                    FlightId = fr.Flight_Id,
                    Flight = $"{fr.Flight.DepartureAirport.City.Name} ({fr.Flight.DepartureAirport.ShorterName}) - {fr.Flight.ArrivalAirport.City.Name} ({fr.Flight.ArrivalAirport.ShorterName})",
                    ArrivalCityImageUrl = fr.Flight.ArrivalAirport.City.ImageUrl,
                    AirlineLogoUrl = fr.Flight.Airline.ImageUrl
                })
                .ToListAsync();           
        }

        public async Task VerifyAsync(string reservationId, string userId)
        {
            var reservation = await repository.GetByIdAsync<FlightReservation>(reservationId);

            if(reservation == null)
            {
                throw new ArgumentNullException("The current reservation was not found!");
            }

            if(reservation.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            reservation.CreatedOn = DateTime.Now;
            reservation.IsActive = true;
            
            await repository.SaveChangesAsync();
        }

        public async Task CancellVerificationAsync(string reservationId, string userId)
        {
            var reservation = await repository.GetByIdAsync<FlightReservation>(reservationId);

            if (reservation == null)
            {
                throw new ArgumentNullException("The current reservation was not found!");
            }

            if (reservation.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            repository.Delete(reservation);
            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<FlightReservationViewModel>> MyReservations(string userId)
        {
            var reservationsNoLongerAvailable = await repository.All<FlightReservation>()
                .Where(fr => fr.User_Id == userId && fr.IsActive == true
                    && fr.ReservationDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(reservationsNoLongerAvailable.Any())
            {
                foreach(var res in reservationsNoLongerAvailable)
                {
                    res.IsActive = false;
                }

                await repository.SaveChangesAsync();
            }

            return await repository.AllReadOnly<FlightReservation>()
                .Where(fr => fr.User_Id == userId && fr.ReservationDate >= DateTime.Now.Date && fr.IsActive == true)
                .Include(fr => fr.Flight)
                .Include(fr => fr.Flight.Airline)
                .Include(fr => fr.Flight.DepartureAirport)
                .Include(fr => fr.Flight.ArrivalAirport)
                .Include(fr => fr.Flight.ArrivalAirport.City)
                .Select(fr => new FlightReservationViewModel()
                {
                    Id = fr.Id,
                    FirstName = fr.FirstName,
                    LastName = fr.LastName,
                    SeatNumber = fr.SeatNumber,
                    ArrivalAirport = fr.Flight.ArrivalAirport.Name,
                    DepartureAirport = fr.Flight.DepartureAirport.Name,
                    ReservationDate = fr.ReservationDate.ToString(DateTimeFormat),
                    DepartureTime = fr.Flight.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                    ArrivalTime = fr.Flight.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                    CityId = fr.Flight.ArrivalAirport.City.Id,
                    CreatedOn = fr.CreatedOn.ToString(CreatedOnFormat),
                    TotalPrice = fr.TotalPrice,
                    FlightId = fr.Flight_Id,
                    Flight = $"{fr.Flight.DepartureAirport.City.Name} ({fr.Flight.DepartureAirport.ShorterName}) - {fr.Flight.ArrivalAirport.City.Name} ({fr.Flight.ArrivalAirport.ShorterName})",
                    ArrivalCityImageUrl = fr.Flight.ArrivalAirport.City.ImageUrl,
                    AirlineLogoUrl = fr.Flight.Airline.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<FlightReservationEditInputModel> GetForEditReservationAsync(string reservationId, string userId)
        {
            var reservation = await repository.GetByIdAsync<FlightReservation>(reservationId);

            if(reservation == null)
            {
                throw new ArgumentNullException("The current flight reservation was not found!");
            }

            if(reservation.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if(reservation.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            return new FlightReservationEditInputModel()
            {
                Id = reservation.Id,
                FirstName = reservation.FirstName,
                LastName = reservation.LastName,
                TotalChangesNameCnt = reservation.TotalChangedNameCount
            };
        }

        public async Task EditReservationAsync(FlightReservationEditInputModel model, string userId)
        {
            var reservation = await repository.GetByIdAsync<FlightReservation>(model.Id);

            if(reservation == null)
            {
                throw new ArgumentNullException("The current flight reservation was not found!");
            }

            if (reservation.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if (reservation.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            if (reservation.TotalChangedNameCount == 0)
            {
                reservation.FirstName = model.FirstName;
                reservation.LastName = model.LastName;
                
                reservation.TotalChangedNameCount += 1;
            }

            await repository.SaveChangesAsync();
        }

        public async Task CancellReservationAsync(string reservationId, string userId)
        {
            var reservation = await repository.GetByIdAsync<FlightReservation>(reservationId);

            if (reservation == null)
            {
                throw new ArgumentNullException("The current reservation was not found!");
            }

            if (reservation.User_Id != userId)
            {
                throw new UnauthorizedActionException();
            }

            if(reservation.IsActive == false)
            {
                throw new NoLongerActiveReservationException();
            }

            repository.Delete(reservation);
            await repository.SaveChangesAsync();
        }

        public async Task<FlightQueryViewModel> AllFlightsForAdminAsync(
            string? departureCity = null,
            string? arrivalCity = null,
            FlightSorting sorting = FlightSorting.PriceAscending)
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
                FlightSorting.IdentifierAscending => flightsToShow.OrderBy(f => f.Id),
                FlightSorting.PriceAscending => flightsToShow.OrderBy(f => f.TicketPrice),             
                _ => flightsToShow.OrderByDescending(f => f.TicketPrice)
            };

            var flights = await flightsToShow
                .Include(f => f.Airline)
                .Include(f => f.DepartureAirport)
                .ThenInclude(f => f.City)
                .Include(f => f.ArrivalAirport)
                .ThenInclude(f => f.City)
                .Select(f => new FlightViewModel()
                {
                    Id = f.Id,
                    Airline = f.Airline.Name,
                    DepartureAirport = f.DepartureAirport.Name,
                    DepartureTime = f.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                    ArrivalAirport = f.ArrivalAirport.Name,
                    ArrivalTime = f.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                    FlightDuration = f.FlightDuration,
                    TicketPrice = f.TicketPrice,
                    CabinClass = f.CabinClass.ToString()
                    
                }).ToListAsync();


            return new FlightQueryViewModel()
            {
                Flights = flights
            };
        }

        public async Task<FlightEditInputModel> GetForEditAsync(int flightId)
        {
            var flight = await repository.GetByIdAsync<Flight>(flightId);

            if(flight == null)
            {
                throw new ArgumentException("Flight was not found!");
            }

            return new FlightEditInputModel()
            {
                Id = flight.Id,
                DepartureTime = flight.DepartureTime.ToString(ArrivalDepartureTimeFormat),
                ArrivalTime = flight.ArrivalTime.ToString(ArrivalDepartureTimeFormat),
                FlightDuration = flight.FlightDuration,
                CabinClass = flight.CabinClass.ToString(),
                TicketPrice = flight.TicketPrice,
                Airline_Id = flight.Airline_Id,
                Airlines = await GetAllAirlinesAsync(),
                CabinClasses = GetAllCabinClasses()
            };
        }

        public async Task EditAsync(FlightEditInputModel model)
        {
            var flight = await repository.GetByIdAsync<Flight>(model.Id);

            if(flight == null)
            {
                throw new ArgumentException("Flight was not found!");
            }

            DateTime departureTime = DateTime.ParseExact(model.DepartureTime, ArrivalDepartureTimeFormat, CultureInfo.InvariantCulture);
            DateTime arrivalTime = DateTime.ParseExact(model.ArrivalTime, ArrivalDepartureTimeFormat, CultureInfo.InvariantCulture);

            CabinClass cabinClass;

            if (model.CabinClass == "Premium Economy")
            {
                cabinClass = CabinClass.PremiumEconomy;
            }
            else
            {
                _ = Enum.TryParse(model.CabinClass, out cabinClass);
            }

            flight.DepartureTime = departureTime;
            flight.ArrivalTime = arrivalTime;
            flight.CabinClass = cabinClass;
            flight.Airline_Id = model.Airline_Id;
            flight.TicketPrice = model.TicketPrice;
            flight.FlightDuration = model.FlightDuration;

            await repository.SaveChangesAsync();
        }

        public IEnumerable<string> GetAllCabinClasses()
        {
            var cabinClassesEnum = Enum.GetValues(typeof(CabinClass));

            ICollection<string> cabinClasses = new List<string>();

            foreach(var cabinClass in cabinClassesEnum)
            {
                cabinClasses.Add(cabinClass.ToString()!);
            }

            return cabinClasses;
        }
        
        public async Task<IEnumerable<AirlineViewModel>> GetAllAirlinesAsync()
        {
            return await repository.AllReadOnly<Airline>()
                .Select(a => new AirlineViewModel()
                {
                    Id = a.Id,
                    Name = a.Name
                })
                .ToListAsync();
        }

        public async Task DeleteAsync(int flightId)
        {
            var flight = await repository.GetByIdAsync<Flight>(flightId);

            if(flight == null)
            {
                throw new ArgumentException("The flight was not found!");
            }

            var flightReservations = await repository.All<FlightReservation>()
                .Where(fr => fr.Flight_Id == flight.Id).ToListAsync();

            if(flightReservations.Any())
            {
                foreach(var fr in flightReservations)
                {
                    repository.Delete(fr);
                }
            }

            repository.Delete(flight);
            await repository.SaveChangesAsync();
        }

        public async Task<FlightAddInputModel> GetForAddAsync()
        {
            return new FlightAddInputModel()
            {
                Airlines = await GetAllAirlinesAsync(),
                CabinClasses = GetAllCabinClasses(),
                Airports = await GetAllAirportsAsync()
            };
        }

        public async Task<IEnumerable<AirportViewModel>> GetAllAirportsAsync()
        {
            return await repository.AllReadOnly<Airport>()
                .Select(a => new AirportViewModel()
                {
                    Id = a.Id,
                    Name = a.Name,
                }).ToListAsync();
        }

        public async Task AddAsync(FlightAddInputModel model)
        {
            DateTime departureTime = DateTime.ParseExact(model.DepartureTime, ArrivalDepartureTimeFormat, CultureInfo.InvariantCulture);
            DateTime arrivalTime = DateTime.ParseExact(model.ArrivalTime, ArrivalDepartureTimeFormat, CultureInfo.InvariantCulture);

            CabinClass cabinClass;

            if (model.CabinClass == "Premium Economy")
            {
                cabinClass = CabinClass.PremiumEconomy;
            }
            else
            {
                _ = Enum.TryParse(model.CabinClass, out cabinClass);
            }

            var flight = new Flight()
            {
                DepartureAirport_Id = model.DepartureAirport_Id,
                ArrivalAirport_Id = model.ArrivalAirport_Id,
                Airline_Id = model.Airline_Id,
                DepartureTime = departureTime,
                ArrivalTime = arrivalTime,
                CabinClass = cabinClass,
                FlightDuration = model.FlightDuration,
                TicketPrice = model.TicketPrice,
                IsActive = true
            };

            await repository.AddAsync(flight);
            await repository.SaveChangesAsync();
        }
    }
}
