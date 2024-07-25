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
        private bool _habilitado;
        private string _nombre;
        private string _nombreusuario;
        public Usuario(string ape, string nom, TipoPersonas tp, DateTime nac)
        {
            _apellido = ape;
            _nombre = nom;
            _mail = "";
            _nombreusuario = String.Concat(ape.ToLower(), nom.ToLower());
            _clave = nac.ToShortDateString();
            if (tp.id == 1)
            {
                _habilitado = true;
            }
            else
            {
                _habilitado = false;
            }
      
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

        public bool Habilitado
        {
            get => _habilitado;
            set => _habilitado = value;
        }
    }
}