using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Comision
    {
        private int _comisionId;
        private string _comisionNombre;
        private int _planId;

        public Comision(int comisionId, string comisionNombre, int planId)
        {
            ComisionId = comisionId; // luego autogenerada al commit en sql
            ComisionNombre = comisionNombre;
            PlanId = planId;
        }

        public int ComisionId
        {
            get => _comisionId;
            set
            {
                _comisionId = value;   
            }
        }

        public string ComisionNombre
        {
            get => _comisionNombre;
            set
            {
                _comisionNombre = value;    
            }
        }

        public int PlanId
        {
            get => _planId;
            set
            {
                _planId = value;
            }
        }
    }
}