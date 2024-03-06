using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckSchedule.Infrastructure.Data.Models
{
    [Comment("Truck category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Category name")]
        public string Name { get; set; } =string.Empty;

       
    }
}
