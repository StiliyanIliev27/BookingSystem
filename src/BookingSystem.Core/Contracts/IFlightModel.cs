namespace BookingSystem.Core.Contracts
{
    public interface IFlightModel
    {
        public string DepartureAirport { get; set; }
      
        public string ArrivalAirport { get; set; }

    }
}
