using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace CarsAPI.Models
{
    public class Car
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName="varchar(20)")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; set; }
    }
}
