using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Job:BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(1000)]
        public string? Content { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("CategoryId")]
        [Required]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
