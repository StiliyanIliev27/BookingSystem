namespace BookingSystem.Core.Exceptions
{
    public class UnauthorizedActionException : Exception
    {
        public const string UnauthorizedErrorMessage = "The current user is not the owner of the reservation!";
        public UnauthorizedActionException() 
            : base(UnauthorizedErrorMessage)
        {
            
        }
    }
}
