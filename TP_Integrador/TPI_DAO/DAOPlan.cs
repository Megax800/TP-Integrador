using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOPlan
    {
        [Key]
        public int PlanId { get; set; }
        public int PlanAño { get; set; }
        public int EspecId { get; set; }
    }
}