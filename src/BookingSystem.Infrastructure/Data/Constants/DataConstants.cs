﻿using System.Data;

namespace BookingSystem.Infrastructure.Data.Constants
{
    public static class DataConstants
    {
        public const string RequiredMessage = "{0} field is required!";
        public const string LengthErrorMessage = "{0} must be between {2} and {1} characters long!";
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
            public const string NameErrorMessage = "{0} should be between {2} and {1} characters long!";

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 80;
            public const string AddressErrorMessage = "{0} should be between {2} and {1} characters long!";

            public const int DetailsMaxLength = 1000;
            public const string DetailsErrorMessage = "{0} should be less than {1} characters long!";

            public const double TicketMinPriceValue = 0.0;
            public const double TicketMaxPriceValue = 2000.0;
            public const string TicketErrorMessage = "{0} should be between {1} and {2} euros!";
        }

        public static class Hotel
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 50;

            public const int AddressMinLength = 5;
            public const int AddressMaxLength = 80;

            public const string StarRateMinValue = "1";
            public const string StarRateMaxValue = "5";
            public const string StarRateErrorMessage = "Hotel's star rate must be between {1} and {2} stars!";

            public const int DetailsMaxLength = 1000;

            public const string TimeFormat = "HH:mm";
        }

        public static class Room
        {
            public const int CountMaxValue = 5;
            public const int CountMinValue = 0;

            public const double MinPricePerNight = 15.00;
            public const double MaxPricePerNight = 5000.00;

            public const string PriceErrorMessage = "{0} must be between {1} and {2} Euro!";
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
            
            public const int ShorterNameMinLength = 3;
            public const int ShorterNameMaxLength = 3;
        }

        public static class Flight
        {
            public const double TicketPriceMinValue = 15;
            public const double TicketPriceMaxValue = 5000;

            public const string TicketPriceErrorMessage = "{0} must be between {1} and {2}";

            public const string ArrivalDepartureTimeFormat = "HH:mm";
        }

        public static class FlightReservation
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;

            public const string DateTimeFormat = "dd/MM/yyyy";

            public const string CreatedOnFormat = "dd/MM/yyyy HH:mm";
        }

        public static class HotelReservation
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;

            public const string DateTimeFormat = "dd/MM/yyyy";            

            public const string CreatedOnFormat = "dd/MM/yyyy HH:mm";
        }

        public static class LandmarkReservation
        {
            public const int MinimumPeoplePerReservation = 1;
            public const int MaximumPeoplePerReservation = 10;

            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;

            public const string DateFormat = "dd/MM/yyyy";
           
            public const string TimeFormat = "HH:mm";
        }

        public static class User
        {
            public const int FirstNameMinLength = 3;
            public const int FirstNameMaxLength = 50;

            public const int LastNameMinLength = 3;
            public const int LastNameMaxLength = 50;
        }
    }
}
