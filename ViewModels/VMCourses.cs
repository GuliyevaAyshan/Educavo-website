using EduCavoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.ViewModels
{
    public class VMCourses:VMBase
    {
        public List<Courses> RecentCourses { get; set; }
        public List<Courses> RelatedCourses { get; set; }
        public List<Courses> Courses { get; set; }
        public Courses Course { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Review> Review { get; set; }
        public List<SkillLevel> SkillLevel { get; set; }
        public List<PriceLevel> PriceLevel { get; set; }
        public List<CourseTypes> CourseTypes { get; set; }
        public List<FaqToCourse> FaqToCourse { get; set; }
        public List<Faq> Faqs { get; set; }
        public List<FaqTitles> FaqTitles { get; set; }
        public List<Review> ReviewToCourse { get; set; }
        public List<TeamToCourses> TeamToCourses { get; set; }
       
        public List<DurationTime> DurationTime { get; set; }
        public List<Team> Team { get; set; }
        public Team Instructor { get; set; }
        public int? instructorId { get; set; }
        public int? durationTimeId { get; set; }
        public int? skillLevelId { get; set; }
        public List<int> courseTypesId { get; set; }
        public int? priceLevelId { get; set; }
        public VMCourses Filter { get; set; }
        public int? catId { get; set; }
        public List<Customer> CustomUser { get; set; }
        public bool Assessments { get; set; }   
        public List<CurriculumTitles> CurriculumTitles { get; set; }
        public List<Curriculum> Curriculum { get; set; }
        public string WhatLearn { get; set; }
    }
}
