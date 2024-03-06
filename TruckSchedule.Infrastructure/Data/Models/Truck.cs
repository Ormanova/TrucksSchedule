using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckSchedule.Infrastructure.Constants.DataConstants.Truck;

namespace TruckSchedule.Infrastructure.Data.Models
{
    public class Truck
    {
        [Key]
        [Comment("Truck Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Truck license plate number")]
        [RegularExpression(RegexRegistrationNumber)]
        public string RegistrationNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Company manufactured the truck")]
        [MaxLength(BrandNameMaxLength)]
        public string Brand { get; set; } = string.Empty;

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Cargo capacity")]
        [MaxLength(CargoCapacityMaxValue)]
        public int CargoCapacity { get; set; }

        [Required]
        [Comment("Cargo type")]
        public string CargoType { get; set; } = string.Empty;

        [Required]
        [MaxLength(LevelOfLoadingMaxValue)]
        public int LevelOfLoading { get; set; }

        [Required]
        [Comment("Point out if the Truck is available")]
        public bool NotAvailable { get; set; }

        [Required]
        public int DespatcherId { get; set; }

        [ForeignKey(nameof(DespatcherId))]
        public virtual Despatcher Despatcher { get; set; } = null!;

        [Comment("User id of the client, rented the truck")]
        public string? ClientId { get; set; }


        public virtual ICollection<DriverTruck> DriversTrucks { get; set;} = new HashSet<DriverTruck>();
    }
}
