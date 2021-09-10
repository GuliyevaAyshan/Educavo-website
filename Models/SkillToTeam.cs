using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class SkillToTeam
    {
        public int Id { get; set; }

        public int TeamId { get; set; }
        [ForeignKey("TeamId")]
        public Team Team { get; set; }

        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        public Skill Skill { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Persentage { get; set; }
    }
}
