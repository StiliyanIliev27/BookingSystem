namespace BookingSystem.Core.Extensions
{
    using BookingSystem.Core.Contracts;
    using System.Text.RegularExpressions;

    public static class HotelExtensions
    {
        public static string GetInformation(this IHotelModel hotel)
        {
            return hotel.Name.Replace(" ", "-") + GetAddress(hotel.Address);
        }
        private static string GetAddress(string address)
        {
            address = string.Join("-", address.Split(' ').Take(3));

            return address;
        }
    }
}
