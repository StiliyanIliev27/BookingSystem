namespace BookingSystem.Core.Models.Reservation
{
    using Microsoft.EntityFrameworkCore;
    using BookingSystem.Core.Contracts;

    public class HotelReservationViewModel : IHotelModel
    {
        public string ReserverFullName { get; set; } = null!;

        public string RoomType { get; set; } = null!;

        public int Hotel_Id { get; set; }

        public string HotelImageUrl { get; set; } = null!;

        /// <summary>
        /// Hotel's name
        /// </summary>
        [Comment("Hotel's name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Hotel' address
        /// </summary>
        [Comment("Hotel's address")]
        public string Address { get; set; } = null!;

        public string UserFullName { get; set; } = null!;

        public string UserEmail { get; set; } = null!;

        public decimal Price { get; set; }

        public string StartDate { get; set; } = null!;

        public string EndDate { get; set; } = null!;

        public string CreatedOn { get; set; } = null!;

        public string IsActive { get; set; } = null!;

        public DateTime CreatedOnDateFormat { get; set; }
    }
}
