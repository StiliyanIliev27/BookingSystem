namespace BookingSystem.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public static class Continent
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 15;
        }

        public static class Country
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int CapitalMinLength = 3;
            public const int CapitalMaxLength = 50;

            public const int DetailsMinLength = 10;
            public const int DetailsMaxLength = 1500;
        }

        public static class Language
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }

        public static class City
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int AreaMinLength = 3;
            public const int AreaMaxLength = 50;

            public const int DetailsMaxLength = 700;
        }

        public static class Landmark
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 80;

            public const int DetailsMaxLength = 1000;
        }

        public static class Hotel
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 80;

            public const int StarRateMinValue = 1;
            public const int StarRateMaxValue = 5;

            public const int DetailsMaxLength = 1000;

            public const string TimeFormat = "HH:mm";
        }

        public static class Room
        {
            public const int CountMaxValue = 5;
            public const int CountMinValue = 0;
        }

        public static class Airline
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }

        public static class Airport
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;
        }
    }
}
