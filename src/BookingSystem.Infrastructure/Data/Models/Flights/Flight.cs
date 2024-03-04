namespace BookingSystem.Infrastructure.Data.Models.Flights
{
    using BookingSystem.Infrastructure.Data.Enums;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Flight
    /// </summary>
    [Comment("Flight")]
    public class Flight
    {
        /// <summary>
        /// Flight's Identifier
        /// </summary>
        [Key]
        [Comment("Flight's Identifier")]
        public int Id { get; set; }

        /// <summary>
        /// Flight's Airline's Identifier
        /// </summary>
        [Required]
        [Comment("Flight's Airline's Identifier")]
        public int Airline_Id { get; set; }

        /// <summary>
        /// Flight's Airline
        /// </summary>
        [ForeignKey(nameof(Airline_Id))]
        [Comment("Flight's Airline")]
        public Airline Airline { get; set; } = null!;

        /// <summary>
        /// Flight's DepartureAirport's Identifier
        /// </summary>
        [Required]
        [Comment("Flight's DepartureAirport's Identifier")]
        public int DepartureAirport_Id { get; set; }

        /// <summary>
        /// Flight's Departure Airport
        /// </summary>
        [ForeignKey(nameof(DepartureAirport_Id))]
        [Comment("Flight's Departure Airport")]
        public Airport DepartureAirport { get; set; } = null!;

        /// <summary>
        /// Flight's ArrivalAirport's Identifier
        /// </summary>
        [Required]
        [Comment("Flight's ArrivalAirport's Identifier")]
        public int ArrivalAirport_Id { get; set; }

        /// <summary>
        /// Flight's Arrival Airport
        /// </summary>
        [ForeignKey(nameof(ArrivalAirport_Id))]
        [Comment("Flight's Arrival Airport")]
        public Airport ArrivalAirport { get; set; } = null!;

        /// <summary>
        /// Flight's Departure Time
        /// </summary>
        [Required]
        [Comment("Flight's Departure Time")]
        public DateTime DepartureTime { get; set; }

        /// <summary>
        /// Flight's Arrival Time
        /// </summary>
        [Required]
        [Comment("Flight's Arrival Time")]
        public DateTime ArrivalTime { get; set; }

        /// <summary>
        /// Flight Duration in minutes
        /// </summary>
        [Required]
        [Comment("Flight Duration in minutes")]
        public int FlightDuration { get; set; }

        /// <summary>
        /// Flight's Cabin Class
        /// </summary>
        [Required]
        [Comment("Flight's Cabin Class")]
        public CabinClass CabinClass { get; set; }

        /// <summary>
        /// Flight's Ticket Price
        /// </summary>
        [Required]
        [Comment("Flight's Ticket Price")]
        public decimal TicketPrice { get; set; }

        /// <summary>
        /// Flight's Reservation Created Time
        /// </summary>
        [Required]
        [Comment("Flight's Reservation Created Time")]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Flight's Active Status
        /// </summary>
        [Required]
        [Comment("Flight's Active Status")]
        public bool IsActive { get; set; } = false;
    }
}
