using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(Title), nameof(DiplomaYearId), nameof(AcademicYearId), IsUnique = true)]
   public class DiplomaYearSection
   {
      public int Id {get; set;}

       [Required]
      [RegularExpression(@"^Section\s[1-9]{1}$", ErrorMessage = "Incorrect Formatting")]
      public string Title {get; set;} = string.Empty;

      [Required]
      public int DiplomaYearId {get; set;} //fk

      [Required]
      public int AcademicYearId {get; set;} //fk

      public DiplomaYear? DiplomaYear {get; set;}
      public ICollection<CourseOffering>? CourseOfferings {get; set;}
      public AcademicYear? AcademicYear {get; set;}
      public AdvisingAssignment? AdvisingAssignment {get; set;}
   }
}