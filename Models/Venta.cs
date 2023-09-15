using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Tienda
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }

        // Propiedades de navegación
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        // Lista de productos en la venta
        public List<Producto> Productos { get; set; }
    }
}
