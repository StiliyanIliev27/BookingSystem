namespace BookingSystem.Core.Attributes
{
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class FlightReservationDateAttribute : ValidationAttribute
    {
        private readonly int _minimumDays;

        public FlightReservationDateAttribute(int minimumDays)
        {
            _minimumDays = minimumDays;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            DateTime reservationDate;
            
            bool isDate = DateTime.TryParseExact(value!.ToString()!,"dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out reservationDate);

            if(isDate)
            {
                DateTime minimumDate = DateTime.Now.AddDays(_minimumDays);

                if(reservationDate >= minimumDate)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult($"The {validationContext.DisplayName} must be at least {_minimumDays} days in the future.");
                }
            }

            return new ValidationResult($"Invalid type provided for {validationContext.DisplayName}. Expected DateTime.");
        }
    }
}
