namespace BookingSystem.Core.Models.QueryModels.Hotel
{
    using BookingSystem.Core.Models.Hotel;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.Hotel;
    using BookingSystem.Infrastructure.Data.Constants;

    public class HotelServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = DataConstants.RequiredMessage)]        
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = DataConstants.LengthErrorMessage)]
        [Display(Name = "Hotel name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = DataConstants.RequiredMessage)]       
        [StringLength(DataConstants.City.NameMaxLength,
            MinimumLength = DataConstants.City.NameMinLength,
            ErrorMessage = DataConstants.LengthErrorMessage)]
        [Display(Name = "City name")]
        public string CityName { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        [Required(ErrorMessage = DataConstants.RequiredMessage)]        
        [Range(typeof(int),
            StarRateMinValue,
            StarRateMaxValue,
            ErrorMessage = "Star rate must be positive number and less than {2} star rates")]
        [Display(Name = "Star rate")]
        public int StarRate { get; set; }

        [Required(ErrorMessage = DataConstants.RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;
        public IEnumerable<RoomTypeViewModel> RoomsTypes { get; set; } = null!;
    }
}
