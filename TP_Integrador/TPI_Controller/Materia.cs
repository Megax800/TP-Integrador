using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Materia
    {
        private int _materiaId;
        private int _materiaHsSem;
        private int _materiaHsTot;
        private int _planId;

        public Materia(int materiaId, int materiaHsSemana, int materiaHsTotal, int planId)
        {
            MateriaId = materiaId;
            MateriaHsSemanales = materiaHsSemana;
            MateriaHsTotales = materiaHsTotal;
            PlanId = planId;
        }

        public int MateriaId
        {
            get => _materiaId;
            set
            {
                _materiaId = value;
            }
        }

        public int MateriaHsTotales
        {
            get => _materiaHsTot;
            set
            {
                _materiaHsTot = value;
            }
        }

        public int MateriaHsSemanales
        {
            get => _materiaHsSem;
            set
            {
                _materiaHsSem = value;
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