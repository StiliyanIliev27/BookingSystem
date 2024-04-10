namespace BookingSystem.Core.Models.Hotel
{
    using BookingSystem.Core.Models.Location;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;
    public class HotelEditAddInputModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AddressMaxLength,
            MinimumLength = AddressMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Address { get; set; } = null!;


        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(int), StarRateMinValue, StarRateMaxValue,
            ErrorMessage = StarRateErrorMessage)]
        public int StarRate { get; set; }

        [MaxLength(DetailsMaxLength)]
        public string? Details { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public string CheckIn { get; set; } = null!;

        [Required]
        public string CheckOut { get; set; } = null!;

        [Required]
        public int City_Id {  get; set; }   

        public string? Parking { get; set; }

        public string? Pets { get; set; }

        public IEnumerable<string> PetsStatuses { get; set; } = new List<string>() { "Allowed", "Not Allowed" }; 
        
        public IEnumerable<string> ParkingAvailabilities { get; set; } = new List<string>() { "Available", "Not Available" };

        public IEnumerable<CityFormModel> Cities { get; set; } = new HashSet<CityFormModel>();
    }
}
