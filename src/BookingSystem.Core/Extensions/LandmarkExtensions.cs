namespace BookingSystem.Core.Extensions
{
    using BookingSystem.Core.Contracts;
    public static class LandmarkExtensions
    {
        public static string GetInformation(this ILandmarkModel landmark)
        {
            return landmark.Name.Replace(" ", "-") + GetCity(landmark.City);
        }
        private static string GetCity(string city)
        {
            city = string.Join("-", city.Split(' '));

            return city;
        }
    }
}
