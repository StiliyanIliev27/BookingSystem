namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Core.Models.Landmark;
    using BookingSystem.Infrastructure.Common;
    using BookingSystem.Infrastructure.Data.Models.Landmarks;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.LandmarkReservation;

    public class LandmarkService : ILandmarkService
    {
        private readonly IRepository repository;
       
        public LandmarkService(IRepository repository)
        {
             this.repository = repository; 
        }
       
        public async Task<IEnumerable<LandmarkViewModel>> AllAsync(int cityId)
        {
            return await repository.AllReadOnly<Landmark>()
                .Where(l => l.City_Id == cityId)
                .Include(l => l.City)
                .Select(l => new LandmarkViewModel()
                {
                    Id = l.Id,
                    Name = l.Name,
                    CityName = l.City.Name,
                    ImageUrl = l.ImageUrl,
                    TicketPrice = l.TicketPrice,
                })
                .ToListAsync();
        }

        public async Task<LandmarkDetailsViewModel> DetailsAsync(int landmarkId)
        {
            var landmark = await repository.AllReadOnly<Landmark>()
                .Where(l => l.Id == landmarkId)
                .Include(l => l.City)
                .FirstOrDefaultAsync();

            if(landmark == null)
            {
                throw new ArgumentException("Landmark does not exist!");
            }

            return new LandmarkDetailsViewModel()
            {
                Id = landmark.Id,
                Name = landmark.Name,
                CityName = landmark.City.Name,
                ImageUrl = landmark.ImageUrl,
                Address = landmark.Address,
                Details = landmark.Details,
                TicketPrice = landmark.TicketPrice
            };
        }

        public async Task<bool> LandmarkExistsAsync(int landmarkId)
        {
            return await repository.AllReadOnly<Landmark>()
                .AnyAsync(l => l.Id == landmarkId);
        }

        public async Task<bool> ReservationExistsAsync(int landmarkId, string userId)
        {
            return await repository.AllReadOnly<LandmarkReservation>()
                .AnyAsync(lr => lr.Landmark_Id == landmarkId && lr.User_Id == userId && lr.IsActive == true);
        }

        public async Task<LandmarkReserveInputModel> GetForReserveAsync(int landmarkId)
        {
            var landmark = await repository.AllReadOnly<Landmark>()
                .FirstOrDefaultAsync(l => l.Id == landmarkId);

            if(landmark == null)
            {
                throw new ArgumentException("The landmark does not exist!");
            }

            return new LandmarkReserveInputModel()
            {
                Landmark_Id = landmarkId,
                AvailableHours = GetAvailableHours()
            };
        }

        public async Task ReserveAsync(string userId, int landmarkId, LandmarkReserveInputModel model)
        {
            var landmark = await repository.AllReadOnly<Landmark>()
                .FirstOrDefaultAsync(l => l.Id == landmarkId);

            if (landmark == null)
            {
                throw new ArgumentException("The landmark does not exist!");
            }

            var reservation = new LandmarkReservation()
            {
                User_Id = userId,
                Landmark_Id = landmark.Id,
                CreatedOn = DateTime.Now,
                ReservationDate = DateTime.ParseExact(model.ReservationDate, DateFormat,
                    CultureInfo.InvariantCulture, DateTimeStyles.None),
                ReservationTime = DateTime.ParseExact(model.ReservationTime, TimeFormat,
                    CultureInfo.InvariantCulture, DateTimeStyles.None),
                GroupCount = model.GroupCount,
                TotalPrice = landmark.TicketPrice * model.GroupCount,
                IsActive = true
            };

            if (await ReservationExistsAsync(reservation.Landmark_Id, reservation.User_Id))
            {
                throw new ArgumentException("You have already a reservation on this landmark!");
            }

            await repository.AddAsync(reservation);
            await repository.SaveChangesAsync();
        }

        public IEnumerable<string> GetAvailableHours()
        {
            return new HashSet<string>()
            {
                "10:00",
                "11:00",
                "12:00",
                "13:00",
                "14:00",
                "15:00",
                "16:00",
                "17:00"
            };
        }

        public async Task<IEnumerable<LandmarkReservationsViewModel>> AllReservationsAsync(string userId)
        {
            return await repository.AllReadOnly<LandmarkReservation>()
                .Where(lr => lr.User_Id == userId && lr.IsActive == true)
                .Include(lr => lr.Landmark)
                .Select(lr => new LandmarkReservationsViewModel()
                {
                    GroupCount = lr.GroupCount,
                    CreatedOn = lr.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
                    LandmarkImageUrl = lr.Landmark.ImageUrl,
                    ReservationDate = lr.ReservationDate.ToString(DateFormat),
                    ReservationTime = lr.ReservationTime.ToString(TimeFormat),
                    TotalPrice = lr.TotalPrice                    
                })
                .ToListAsync();
        }
    }
}
