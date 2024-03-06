using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckSchedule.Infrastructure.Data.Models;

namespace TruckSchedule.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser DespatcherUser { get; set; }

        public IdentityUser DriverUser { get; set; }

        public IdentityUser ClientUser { get; set; }

        public Despatcher Despatcher { get; set; }

        public Category Tanker { get; set; }

        public Category Jumbo {  get; set; }

        public Category SemiTrailer { get; set; }

        public Category Tautliner { get; set; }

        public Category Conestoga { get; set; }

        public Driver JuniorDriver { get; set; }

        public Driver SeniorDriver { get; set; }

        public Driver ProfesionalDriver { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedDespatchers();
            SeedCategories();
            SeedDrivers();
        }

        private void SeedDespatchers()
        {
            Despatcher = new Despatcher()
            {
                Id = 1,
                Name = "Nikola NIkolov Nikolov",
                PersonalNumber = "1234567",
                PhoneNumber = "359894000000",
                UserId = DespatcherUser.Id
            };
        }

        private void SeedCategories()
        {
            Tanker = new Category()
            {
                Id = 1,
                Name = "Tanker"
            };
            Jumbo = new Category()
            {
                Id = 2,
                Name = "Jumbo"
            };
            SemiTrailer = new Category()
            {
                Id = 3,
                Name = "SemiTrailer"
            };
            Tautliner = new Category()
            {
                Id = 4,
                Name = "Tautliner"
            };
            Conestoga = new Category()
            {
                Id = 5,
                Name = "Conestoga"
            };
        }

        private void SeedDrivers()
        {
            JuniorDriver = new Driver()
            {
                Id = 1,
                Name = "Ivan Ivanov Ivanov",
                LicenseNumber = 23456789,
                IsBusy = false,
                DespatcherId = Despatcher.Id
            };

            SeniorDriver = new Driver()
            {
                Id = 2,
                Name = "Stoyan Stoyanov Stoyanov",
                LicenseNumber = 67890123,
                IsBusy = false,
                DespatcherId = Despatcher.Id
            };

            ProfesionalDriver = new Driver()
            {
                Id = 3,
                Name = "Ivailo Ivailov Ivailov",
                LicenseNumber = 098765432,
                IsBusy = false,
                DespatcherId = Despatcher.Id
            };
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();
            DespatcherUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "despatcher01@mail.com",
                NormalizedUserName = "despatcher01@mail.com",
                Email = "despatcher01@mail.com",
                NormalizedEmail = "despatcher01@mail.com"
            };

            DespatcherUser.PasswordHash = hasher.HashPassword(DespatcherUser, "despatcher001");

            DriverUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "juniorDriver@mail.com",
                NormalizedUserName = "juniorDriver@mail.com",
                Email = "juniorDriver@mail.com",
                NormalizedEmail = "juniorDriver@mail.com"
            };
            DriverUser.PasswordHash = hasher.HashPassword(DespatcherUser, "juniordriver001");

            ClientUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-83d9-d6b3ac1f591e",
                UserName = "client001@mail.com",
                NormalizedUserName = "client001@mail.com",
                Email = "client001@mail.com",
                NormalizedEmail = "client001@mail.com"
            };

            ClientUser.PasswordHash = hasher.HashPassword(DespatcherUser, "client001");
        }
    }
}
