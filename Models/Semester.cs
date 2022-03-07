using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(Name), IsUnique = true)]
   public class Semester
   {
      public int Id {get; set;}
      
      [Required]
       public string Name {get; set;} = string.Empty;
      
      [Required]
      [DataType(DataType.Date)]
      public DateTime StartDate {get; set;}

      [Required]
      [DataType(DataType.Date)]
      public DateTime EndDate {get; set;}

      [Required]
      public int AcademicYearId {get; set;} //fk

      public AcademicYear? AcademicYear {get; set;}
      public ICollection<CourseOffering>? CourseOfferings {get; set;}
   }
}