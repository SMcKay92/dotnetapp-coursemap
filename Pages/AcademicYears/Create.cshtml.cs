#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NSCCCourseMap.Models;

namespace nscccoursemap_SMcKay92.Pages_AcademicYears
{
    public class CreateModel : PageModel
    {
        private readonly NSCCCourseMapContext _context;

        public CreateModel(NSCCCourseMapContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AcademicYear AcademicYear { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AcademicYears.Add(AcademicYear);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}