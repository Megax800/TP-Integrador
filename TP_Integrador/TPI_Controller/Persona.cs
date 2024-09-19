using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
   public struct TipoPersonas { 
        public int id;
        public string nombre;
   }
    public class Persona
    {
        private string _apellido;
        private string _direccion;
        private string _mail;
        private string _nombre;
        private string _telefono;
        private int _idPlan;
        private int _legajo;
        private System.DateTime _fechanac;
        private TipoPersonas _tipopersona;

        public Persona(string ape, string nom, TipoPersonas tp, DateTime fechanac)
        {
            Apellido = ape;
            Nombre = nom;
            TipoPersona = tp;
            _fechanac = fechanac;
        }

        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }

        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public string Email
        {
            get => _mail;
            set => _mail = value;
        }

        public int Legajo
        {
            get => _legajo;
            set => _legajo = value;
        }

        public int IdPlan
        {
            get => _idPlan;
            set => _idPlan = value;
        }

        public string Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }

        public System.DateTime FechaNacimiento
        {
            get => _fechanac;
            set => _fechanac= value;
        }

        public TipoPersonas TipoPersona
        {
            get => _tipopersona;
            set => _tipopersona = value;
        }
    }
}