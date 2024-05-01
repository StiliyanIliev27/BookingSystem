namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Reservation;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Flights;
    using BookingSystem.Infrastructure.Data.Models.Hotels;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using Microsoft.EntityFrameworkCore;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.LandmarkReservation;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.HotelReservation;


    public class ReservationService : IReservationService
    {
        private readonly IRepository repository;

        public ReservationService(IRepository repository)
        {
            this.repository = repository; 
        }

        public async Task<IEnumerable<FlightReservationViewModel>> AllFlightReservationsAsync()
        {
            return await repository.AllReadOnly<FlightReservation>()
                .Include(fr => fr.User)
                .Include(fr => fr.Flight.DepartureAirport.City)
                .Include(fr => fr.Flight.ArrivalAirport.City)
                .Include(fr => fr.Flight.Airline)
                .Select(fr => new FlightReservationViewModel()
                {
                    ReserverFullName = $"{fr.FirstName} {fr.LastName}",
                    UserEmail = fr.User.UserName,
                    UserFullName = $"{fr.User.FirstName} {fr.User.LastName}",
                    Flight_Id = fr.Flight_Id,
                    Flight = $"{fr.Flight.DepartureAirport.City.Name} - {fr.Flight.ArrivalAirport.City.Name}",
                    Airline = fr.Flight.Airline.Name,
                    AirlineImageUrl = fr.Flight.Airline.ImageUrl,
                    DepartureAirport = fr.Flight.DepartureAirport.Name,
                    ArrivalAirport = fr.Flight.ArrivalAirport.Name,
                    SeatNumber = fr.SeatNumber,
                    TotalPrice = fr.TotalPrice,
                    ReservationDate = fr.ReservationDate.ToString(DateTimeFormat),
                    CreatedOn = fr.CreatedOn.ToString(CreatedOnFormat),
                    CreatedOnDateFormat = fr.CreatedOn,
                    IsActive = fr.IsActive ? "Active" : "Not active",
                    IsVerfied = fr.IsVerified
                })
                .ToListAsync(); 
        }

        public async Task<IEnumerable<HotelReservationViewModel>> AllHotelReservationsAsync()
        {
            return await repository.AllReadOnly<HotelReservation>()
                .Include(hr => hr.Hotel)
                .Include(hr => hr.Room)
                .Include(hr => hr.User)
                .Select(hr => new HotelReservationViewModel()
                {
                    ReserverFullName = $"{hr.FirstName} {hr.LastName}",
                    RoomType = hr.Room.Type.ToString(),
                    Name = hr.Hotel.Name,
                    Address = hr.Hotel.Address,
                    Hotel_Id = hr.Hotel_Id,
                    HotelImageUrl = hr.Hotel.ImageUrl,
                    UserFullName = $"{hr.User.FirstName} {hr.User.LastName}",
                    UserEmail = hr.User.UserName,
                    Price = hr.Price,
                    StartDate = hr.StartDate.ToString(DateTimeFormat),
                    EndDate = hr.EndDate.ToString(DateTimeFormat),
                    CreatedOn = hr.CreatedOn.ToString(CreatedOnFormat),
                    CreatedOnDateFormat = hr.CreatedOn,
                    IsActive = hr.IsActive ? "Active" : "Not active",
                    IsVerfied = hr.IsVerified
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<LandmarkReservationViewModel>> AllLandmarkReservationsAsync()
        {
            return await repository.AllReadOnly<LandmarkReservation>()
               .Include(hr => hr.User)
               .Include(hr => hr.Landmark)
               .ThenInclude(hr => hr.City)
               .Select(hr => new LandmarkReservationViewModel()
               {
                   ReserverFullName = $"{hr.FirstName} {hr.LastName}",
                   Landmark_Id = hr.Landmark_Id,
                   Name = hr.Landmark.Name,
                   City = hr.Landmark.City.Name,
                   LandmarkImageUrl = hr.Landmark.ImageUrl,
                   UserFullName = $"{hr.User.FirstName} {hr.User.LastName}",
                   UserEmail = hr.User.UserName,
                   ReservationDateTime = $"{hr.ReservationDate.ToString(DateFormat)} {hr.ReservationTime.ToString(TimeFormat)}",
                   GroupCount = hr.GroupCount,
                   TotalPrice = hr.TotalPrice,
                   CreatedOn = hr.CreatedOn.ToString(CreatedOnFormat),
                   CreatedOnDateFormat = hr.CreatedOn,
                   IsActive = hr.IsActive ? "Active" : "Not active"
               })
                .ToListAsync();
        }

        public async Task RemoveExpiredReservations()
        {
            await RemoveExpiredHotelReservations();
            await RemoveExpiredHotelVerifications();
            await RemoveExpiredFlightVerifications();   
            await RemoveExpiredFlightReservations();
            await RemoveExpiredLandmarkReservations();
        }

        private async Task RemoveExpiredLandmarkReservations()
        {
            var invalidRes = await repository.All<LandmarkReservation>()
                .Where(r => r.ReservationDate.Date < DateTime.Now.Date && r.IsActive == true)
                .ToListAsync();

            if(invalidRes.Any())
            {
                foreach (var res in invalidRes)
                {
                    res.IsActive = false;
                }

                await repository.SaveChangesAsync();
            }
        }
        private async Task RemoveExpiredFlightReservations()
        {
            var reservationsNoLongerAvailable = await repository.All<FlightReservation>()
                .Where(fr => fr.IsVerified == true && fr.IsActive == true && fr.ReservationDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(reservationsNoLongerAvailable.Any())
            {
                foreach (var res in reservationsNoLongerAvailable)
                {
                    res.IsActive = false;
                }

                await repository.SaveChangesAsync();
            }
        }

        private async Task RemoveExpiredFlightVerifications()
        {
            var verificationsToRemove = await repository.All<FlightReservation>()
                .Where(fr => fr.IsVerified == false && fr.ReservationDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(verificationsToRemove.Any())
            {
                foreach (var ver in verificationsToRemove)
                {
                    repository.Delete(ver);
                }

                await repository.SaveChangesAsync();
            }
        }

        private async Task RemoveExpiredHotelReservations()
        {
            var invalidRes = await repository.All<HotelReservation>()
                .Where(hr => hr.EndDate.Date < DateTime.Now.Date && hr.IsVerified == true && hr.IsActive == true)
                .Include(hr => hr.Room)
                .ToListAsync();

            if(invalidRes.Any())
            {
                foreach(var res in invalidRes)
                {
                    res.IsActive = false;

                    if(res.Room.Count < 5)
                    {
                        res.Room.Count += 1;
                    }
                }

                await repository.SaveChangesAsync();
            }
        }

        private async Task RemoveExpiredHotelVerifications()
        {
            var verToRemove = await repository.All<HotelReservation>()
                .Where(hr => hr.IsVerified == false && hr.EndDate.Date < DateTime.Now.Date)
                .ToListAsync();

            if(verToRemove.Any())
            {
                foreach(var ver in verToRemove)
                {
                    repository.Delete(ver);
                }

                await repository.SaveChangesAsync();
            }
        }
    }
}
