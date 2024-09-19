using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TPI_DAO
{
   public struct TipoPersonas { 
        public int id;
        public string nombre;
   }
    public class DAOPersona
    {
        TipoPersonas[] listaTipos = new TipoPersonas[3];

        public DAOPersona()
        {
            listaTipos[0].id = 1;
            listaTipos[0].nombre = "sysAdmin";
            listaTipos[1].id = 2;
            listaTipos[1].nombre = "Alumno";
            listaTipos[2].id = 3;
            listaTipos[2].nombre = "Docente";
        }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }
        [Key]
        public int Legajo { get; set; }

        public int IdPlan { get; set; }

        public string Telefono { get; set; }

        public System.DateTime FechaNacimiento { get; set; }

        public int TipoPersona { get; set; }

        public void AddPersona(string ape, string nom, int tp, DateTime fechanac)
        {
            using (var context = new AcademiaContext())
            {
                DAOPersona per = new DAOPersona();
                per.Nombre = nom;
                per.FechaNacimiento = fechanac;
                per.TipoPersona = tp;
                per.Apellido = ape;

                context.Personas.Add(per);
            }
        }
    }
}