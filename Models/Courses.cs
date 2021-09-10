using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Models
{
    public class Courses
    {
        [Key]
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Video { get; set; }
        [NotMapped]
        public IFormFile VideoFile { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    
        public int StudentCount { get; set; }
        public bool Assessments { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Fea { get; set; }
        public int Duration { get; set; }
        public int Lectures { get; set; }
        public int Quizzes { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        public List<TeamToCourses> TeamToCourses { get; set; }
        public List<Review> Review { get; set; }
        public List<Curriculum> Curriculum { get; set; }
        public List<FaqToCourse> FaqToCourses { get; set; }
        public int CourseTypesId { get; set; }
        [ForeignKey("CourseTypesId")]
        public CourseTypes CourseTypes { get; set; }
        public int SkillLevelId { get; set; }
        [ForeignKey("SkillLevelId")]
        public SkillLevel SkillLevel { get; set; }
        public int PriceLevelId { get; set; }
        [ForeignKey("PriceLevelId")]
        public PriceLevel PriceLevel { get; set; }
        public int DurationTimeId { get; set; }
        [ForeignKey("DurationTimeId")]
        public DurationTime DurationTime { get; set; }
        public string WhatLearn { get; set; }
      


    }
}
