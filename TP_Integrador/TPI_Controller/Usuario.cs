using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class Usuario
    {
        private string _apellido;
        private string _clave;
        private string _mail;
        private int _tipousuario;
        private string _nombre;
        private string _nombreusuario;
        private int _legajo;
        public Usuario(string ape, string nom, TipoPersonas tp, DateTime nac, int legajo)
        {
            _apellido = ape;
            _nombre = nom;
            _mail = "";
            _nombreusuario = String.Concat(ape.ToLower(), nom.ToLower());
            _clave = nac.ToShortDateString();
            _tipousuario = tp.id;
            _legajo = legajo;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Clave
        {
            get => _clave;
            set => _clave = value;
        }

        public string Email
        {
            get => _mail;
            set => _mail = value;
        }

        public string NombreUsuario
        {
            get => _nombreusuario;
            set => _nombreusuario = value;
        }

        public int TipoUsuario
        {
            get => _tipousuario;
            set => _tipousuario = value;
        }

        public int Legajo
        {
            get => _legajo;
            set => _legajo = value;
        }
    }
}