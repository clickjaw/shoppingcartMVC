using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoppingCartMVC.Infrastructure;
using ShoppingCartMVC.Models;

namespace ShoppingCartMVC.Areas.Admin
{
    public class IndexModel : PageModel
    {
        private readonly ShoppingCartMVC.Infrastructure.DataContext _context;

        public IndexModel(ShoppingCartMVC.Infrastructure.DataContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products
                .Include(p => p.Category).ToListAsync();
            }
        }
    }
}
