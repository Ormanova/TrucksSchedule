using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckSchedule.Infrastructure.Constants.DataConstants.Despatcher;

namespace TruckSchedule.Infrastructure.Data.Models
{
    public class Despatcher
    {
        [Key]
        [Comment("Despatcher identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Despatcher`s name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Personal job position number ")]
        [MaxLength(PersonalNumberMaxLength)]
        public string PersonalNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Despatcher`s phone number")]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public ICollection<Truck> Trucks { get; set; } = new List<Truck>();

        public ICollection<Driver> Drivers { get; set; } = new List<Driver>();

        public ICollection<Client> Clients { get; set; } = new List<Client>();

    }
}
