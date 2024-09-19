using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOCurso
    {
        public int AñoCalendario { get; set; }
        public int Cupo { get; set; }
        public string Descripcion { get; set; }
        [Key]
        public int IdComision { get; set; }
        public int IdMateria { get; set; }
    }
}