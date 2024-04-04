namespace BookingSystem.Infrastructure.Data.Models.Roles
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using BookingSystem.Core.Models.User;

    public class Administrator
    {
        /// <summary>
        /// Administrator's Identifier
        /// </summary>
        [Key]
        [Comment("Administrator's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// User's Identifier
        /// </summary>
        [Required]
        [Comment("User's Identifier")]
        public string UserId { get; set; } = null!;

        /// <summary>
        /// User
        /// </summary>
        [ForeignKey(nameof(UserId))]
        [Comment("User")]
        public ApplicationUser User { get; set; } = null!;
    }
}
