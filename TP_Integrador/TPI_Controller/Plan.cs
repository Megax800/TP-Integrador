using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Plan
    {
        private int _planId;
        private int _planAnio;
        private int _especId;

        public Plan(int planId, int planAnio, int especId)
        {
            PlanId = planId;
            PlanAnio = planAnio;
            EspecId = especId;
        }

        public int PlanId
        {
            get => _planId;
            set
            {
                _planId = value;
            }
        }

        public int PlanAnio
        {
            get => _planAnio;
            set
            {
                _planAnio = value;
            }
        }

        public int EspecId
        {
            get => _especId;
            set
            {
                _especId = value;
            }
        }
    }
}