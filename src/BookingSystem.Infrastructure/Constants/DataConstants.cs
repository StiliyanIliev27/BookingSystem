﻿

namespace BookingSystem.Infrastructure.Constants
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
            public const int DetailsMaxLength = 500;
        }
        public static class Language
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }
    }
}
