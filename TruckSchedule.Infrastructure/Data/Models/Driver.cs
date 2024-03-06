using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckSchedule.Infrastructure.Constants.DataConstants.Driver;

namespace TruckSchedule.Infrastructure.Data.Models
{
    public class Driver
    {
        [Key]
        [Comment("Driver identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Driver`s name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Driver`s license number")]
        [MaxLength(DriverLicenseMaxLength)]
        public int LicenseNumber { get; set; }

        [Comment("Point if the driver is available")]
        public bool IsBusy { get; set; }

        public ICollection<DriverTruck> DriversTrucks { get; set; } = new List<DriverTruck>();

        [Required]
        public int DespatcherId { get; set; }

        [ForeignKey(nameof(DespatcherId))]
        public Despatcher Despatcher { get; set; } = null!;

        public ICollection<Route> Routes { get; set; } = new List<Route>();

     
    }
}
