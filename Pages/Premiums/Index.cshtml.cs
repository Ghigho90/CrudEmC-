using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GhighoTest.Data;
using GhighoTest.Models;

namespace GhighoTest.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly GhighoTest.Data.ApplicationDbContext _context;

        public IndexModel(GhighoTest.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiums
                .Include(p => p.Student).ToListAsync();
        }
    }
}
