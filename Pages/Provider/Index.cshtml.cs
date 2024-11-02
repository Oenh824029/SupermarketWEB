using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Provider
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Providers> Provider { get; set; } = default!;

        public async Task OnGetAsync()
        {
            // condición para las categorias
            if (_context.Providers != null)
            {
                Provider = await _context.Providers.ToListAsync();
            }
        }
    }
}
