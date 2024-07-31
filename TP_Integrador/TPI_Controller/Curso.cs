using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Curso
    {
        private int _añocal;
        private int _idmat;
        private int _cupo;
        private string _desc;
        private int _idcom;

        public Curso(int año, int mat, int cupo, string desc,int com)
        {
            _añocal = año;
            _idmat = mat;
            _cupo = cupo;
            _desc = desc;
            _idcom = com;

        }

        public int AñoCalendario
        {
            get => _añocal;
            set
            {
                _añocal = value;   
            }
        }

        public int Cupo
        {
            get => _cupo;
            set
            {
                _cupo = value;
            }
        }

        public string Descripcion
        {
            get => _desc;
            set
            {
                _desc = value;
            }
        }

        public int IdComision
        {
            get => _idcom;
            set
            {
                _idcom = value;
            }
        }

        public int IdMateria
        {
            get => _idmat;
            set
            {
                _idmat = value;
            }
        }
    }
}