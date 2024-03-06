using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSchedule.Infrastructure.Constants
{
    public static class DataConstants
    {
        public static class Truck
        {
            public const string RegexRegistrationNumber = "@[A-Z]+\\d{4}[A-Z]{2}";

            public const int BrandNameMinLength = 3;
            public const int BrandNameMaxLength = 30;

            public const int CragoCapacityMinValue = 5;
            public const int CargoCapacityMaxValue = 2500;

            public const int LevelOfLoadingMaxValue = 100;
        }

        public static class Category
        {
            public const int NameMinLength = 3;
            public const int NameMaxLength = 40;

        }
        public static class Client
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;
            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 15;
            public const int NationalityMinLength = 5;
            public const int NationalityMaxLength = 50;
        }
        public static class Despatcher
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int PersonalNumberMinLength = 3;
            public const int PersonalNumberMaxLength = 13;
            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 15;
        }

        public static class Driver
        {
            public const int NameMinLength = 5;
            public const int NameMaxLength = 50;

            public const int DriverLicenseMinLength = 8; 
            public const int DriverLicenseMaxLength = 8;
        }
        public static class Route
        {
            public const int DeparturePlaceMinLength = 5;
            public const int DeparturePlaceMaxLength = 50;

            public const int ArrivalPlaceMinLength = 5;
            public const int ArrivalPlaceMaxLength = 50;

            public const string DateFormat = "yyyy-MM-dd H:mm";

            public const int DistanceMinLength = 10;
            public const int DistanceMaxLength = 5000;
        }
    }
}
