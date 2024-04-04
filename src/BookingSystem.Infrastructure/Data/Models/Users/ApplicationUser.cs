namespace BookingSystem.Core.Models.User
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static BookingSystem.Infrastructure.Data.Constants.DataConstants.User;
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        [PersonalData]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        [PersonalData]
        public string LastName { get; set; } = null!;
    }
}
