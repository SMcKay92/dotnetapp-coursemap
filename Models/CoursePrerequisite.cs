using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(CourseId), nameof(PrerequisiteId), IsUnique = true)]
   public class CoursePrerequisite
   {
      public int Id {get; set;}
      [Required]
      public int CourseId {get; set;} //fk
      [Required]
      public int PrerequisiteId {get; set;} //fk

      public Course? Course {get; set;}
      
      public Course? Prerequisite {get; set;}
   }
}