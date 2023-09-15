﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Tienda;

namespace WebApplication2.Pages.Tienda.Ventas
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2Context _context;

        public IndexModel(WebApplication2.Data.WebApplication2Context context)
        {
            _context = context;
        }

        public IList<Venta> Venta { get;set; }

        public async Task OnGetAsync()
        {
            Venta = await _context.Venta
                .Include(v => v.Cliente).ToListAsync();
        }
    }
}
