using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(CourseId), nameof(DiplomaYearSectionId), nameof(SemesterId), IsUnique = true)]
   public class CourseOffering
   {
      public int Id {get; set;}
      [Required]
      public int CourseId {get; set;} //fk
      //[Required]
      public int? InstructorId {get; set;} = null; //fk
      [Required]
      public int DiplomaYearSectionId {get; set;} //fk
      [Required]
      public int SemesterId {get; set;} //fk
      public bool IsDirectedElective {get; set;}

      public DiplomaYearSection? DiplomaYearSection {get; set;}
      public Semester? Semester {get; set;}
      public Course? Course {get; set;}
      public Instructor? Instructor {get; set;}
   }
}