using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TruckSchedule.Infrastructure.Data.Models
{
    public class DriverTruck
    {
        [Required]
        public int DriverId { get; set; }

        [ForeignKey(nameof(DriverId))]
        public virtual Driver Driver { get; set; } = null!;

        [Required]
        public int TruckId { get; set; }

        [ForeignKey(nameof(TruckId))]
        public virtual Truck Truck { get; set; } = null!;
    }
}