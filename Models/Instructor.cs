using System.ComponentModel.DataAnnotations;

namespace NSCCCourseMap.Models
{
   public class Instructor
   {
      public int Id {get; set;}

      [Required]
      public string FirstName {get; set;} = string.Empty;

      [Required]
      public string LastName {get; set;} = string.Empty;

      public ICollection<CourseOffering>? CourseOfferings {get; set;}
      public ICollection<AdvisingAssignment>? AdvisingAssignments {get; set;}
   }
}