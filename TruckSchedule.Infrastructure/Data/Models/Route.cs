using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckSchedule.Infrastructure.Constants.DataConstants.Route;
namespace TruckSchedule.Infrastructure.Data.Models
{
    public class Route
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DeparturePlaceMaxLength)]
        [Comment("Truck`s point of departure")]
        public string DeparturePlace{ get; set; } = string.Empty;

        [Required]
        [MaxLength(ArrivalPlaceMaxLength)]
        [Comment("Trruck`s point of arrival")]
        public string ArrivalPlace { get; set; } = string.Empty;

        [Required]
        [Comment("Date and time of departure")]
        public DateTime DepartureTime { get; set; }

        [Required]
        [Comment("Estimated date and time of arrival")]
        public DateTime ArrivalTime { get; set; }

        [Required]
        [Comment("Route`s total distance")]
        [MaxLength(DistanceMaxLength)]
        public int Distance { get; set; }

        [Required]
        [Comment("Point if the route is compleated")]
        public bool IsCompleated { get; set; }

        [Required]
        public int DriverId { get; set; }

        [ForeignKey(nameof(DriverId))]
        public Driver Driver { get; set; } = null!;

    }
}
