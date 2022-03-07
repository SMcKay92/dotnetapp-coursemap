using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(InstructorId), nameof(DiplomaYearSectionId), IsUnique = true)]
   public class AdvisingAssignment
   {
      public int Id {get; set;}
      [Required]
      public int? InstructorId {get; set;} //fk
      [Required]
      public int DiplomaYearSectionId {get; set;} //fk

      public Instructor? Instructor {get; set;}
      public DiplomaYearSection? DiplomaYearSection {get; set;}
   }
}