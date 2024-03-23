namespace BookingSystem.Core.Services
{
    using BookingSystem.Core.Contracts;
    using BookingSystem.Infrastructure.Common;

    public class FlightService : IFlightService
    {
        private readonly IRepository repository;

        public FlightService(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
