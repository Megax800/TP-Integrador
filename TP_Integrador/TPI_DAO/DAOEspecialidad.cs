using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOEspecialidad
    {
        [Key] 
        public int idEsp { get; set; }
        public string Descripcion { get; set; }
    }
}