using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaBlazor.Shared
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? Nombre { get; set; }
        public int? IdCategoria { get; set; }
        public string? DescripcionCategoria { get; set; }

        [Required(ErrorMessage = "El stock es requerido.")]
        public int? Stock { get; set; }

        [Required(ErrorMessage = "El precio es requerido.")]
        public decimal? Precio { get; set; }
    }
}
