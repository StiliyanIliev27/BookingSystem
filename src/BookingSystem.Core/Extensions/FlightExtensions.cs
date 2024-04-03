namespace BookingSystem.Core.Extensions
{
    using BookingSystem.Core.Contracts;
    public static class FlightExtensions
    {
        public static string GetInformation(this IFlightModel model)
        {
            return model.DepartureAirport.Replace(" ", "-") + "-" + GetArrivalAirport(model.ArrivalAirport);
        }

        private static string GetArrivalAirport(string arrivalAirport)
        {
            arrivalAirport = string.Join(" ", arrivalAirport.Split(' '));

            return arrivalAirport;
        }
    }
}
