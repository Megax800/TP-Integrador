using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOMateria
    {
        [Key]
        public int MateriaId { get; set; }
        public int MateriaHsTotales { get; set; }
        public int MateriaHsSemanales { get; set; }
        public int PlanId { get; set; }
    }
}