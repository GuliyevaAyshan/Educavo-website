using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(2000)]
        public string Message { get; set; }
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }
        [ForeignKey("User")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? CommentId { get; set; }
        [ForeignKey("CommentId")]
        public Comment ParentComment { get; set; }

        public DateTime AddedDate { get; set; }
    }
}

