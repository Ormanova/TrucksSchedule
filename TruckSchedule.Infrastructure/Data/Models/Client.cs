using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TruckSchedule.Infrastructure.Constants.DataConstants.Client;
namespace TruckSchedule.Infrastructure.Data.Models
{
    public class Client
    {
        [Key]
        [Comment("Client Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Client`s name")]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Comment("Client`s phone number")]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public int DespatcherId { get; set; }

        [ForeignKey(nameof(DespatcherId))]
        public Despatcher Despatcher { get; set; } = null!;

       
    }
}
