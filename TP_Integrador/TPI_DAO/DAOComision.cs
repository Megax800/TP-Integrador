using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
    public class DAOComision
    {
        [Key]
        public int ComisionId {  get; set; }
        public string ComisionName { get; set; }
        public int PlanId {  get; set; }
    }
}