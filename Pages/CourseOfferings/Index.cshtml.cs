#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NSCCCourseMap.Models;

namespace nscccoursemap_SMcKay92.Pages_CourseOfferings
{
    public class IndexModel : PageModel
    {
        private readonly NSCCCourseMapContext _context;

        public IndexModel(NSCCCourseMapContext context)
        {
            _context = context;
        }

        public IList<CourseOffering> CourseOffering { get;set; }

        public async Task OnGetAsync()
        {
            CourseOffering = await _context.CourseOfferings
                .Include(c => c.Course)
                .Include(c => c.DiplomaYearSection)
                .Include(c => c.Instructor)
                .Include(c => c.Semester)
                .OrderByDescending(c => c.Semester)
                .ThenBy(c => c.DiplomaYearSection.DiplomaYear.Diploma)
                .ThenBy(c => c.DiplomaYearSection.DiplomaYear)
                .ThenBy(c => c.Course.CourseCode)
                .ToListAsync();
        }
    }
}
