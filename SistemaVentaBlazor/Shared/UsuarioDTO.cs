using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaBlazor.Shared
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        public string? NombreApellidos { get; set; }

        [Required(ErrorMessage = "El correo es requerido.")]
        public string? Correo { get; set; }
        public int IdRol { get; set; }
        public string? rolDescripcion { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string? Clave { get; set; }
    }
}
