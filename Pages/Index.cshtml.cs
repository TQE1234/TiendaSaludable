using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Tienda;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public List<Producto> Productos { get; set; }

        public void OnGet()
        {
            // Inicializa la lista de productos con datos de ejemplo (ajusta según tus datos reales).
            Productos = new List<Producto>
            {
                new Producto
                {
                    ProductoId = 1,
                    Nombre = "Producto 1",
                    Precio = 19.99M
                },
                new Producto
                {
                    ProductoId = 2,
                    Nombre = "Producto 2",
                    Precio = 24.99M
                },
                new Producto
                {
                    ProductoId = 3,
                    Nombre = "Producto 3",
                    Precio = 14.99M
                }
                // Agrega más productos según sea necesario.
            };
        }
    }
}
