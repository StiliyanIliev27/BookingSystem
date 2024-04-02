namespace BookingSystem.Core.Exceptions
{
    public class NoLongerActiveReservationException : Exception
    {
        public const string NoLongerActiveReservationErrorMessage = "The reservation is no longer available!";
        public NoLongerActiveReservationException() 
            : base(NoLongerActiveReservationErrorMessage)
        {
            
        }
    }
}
