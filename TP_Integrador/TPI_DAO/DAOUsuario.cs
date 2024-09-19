using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOUsuario
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int TipoUsuario { get; set; }
        [Key]
        public int Legajo { get; set; }
    }
}