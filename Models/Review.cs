using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(500), Required]
        public string Text { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Courses")]
        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team Team { get; set; }
        [Column(TypeName = "tinyint"), Required]
        public byte Rating { get; set; }
  
        public DateTime AddedDate { get; set; }
 
    }
}
