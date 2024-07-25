using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Especialidad
    {
        private string _desc;

        public Especialidad(string desc)
        {
            _desc = Descripcion;
        }

        public string Descripcion
        {
            get => _desc;
            set
            {
                _desc = value;
            }
        }
    }
}