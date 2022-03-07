using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NSCCCourseMap.Models
{
   [Index(nameof(Title), IsUnique = true)]
   
   public class Diploma //parent / one
   {
      public int Id {get; set;}
     
      [Required]
      [MinLength(10)]
      public string Title {get; set;} = string.Empty;


      //children / many
      public ICollection<DiplomaYear>? DiplomaYears {get; set;}
   }
}