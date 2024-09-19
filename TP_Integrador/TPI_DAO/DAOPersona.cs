using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;

namespace TPI_DAO
{
    public class DAOPersona
    {

        public DAOPersona()
        {
            Apellido = "Foo";
            Nombre = "Bar";
            Direccion = "Fake St. 123";
            Email = "-";
            IdPlan = 0;
            Telefono = "-";
            TipoPersona = 0;
            FechaNacimiento = DateTime.Today;
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

        public void AddPersona(string ape, string nom, int tp, DateTime fechanac, string dir, int plan, string tel, string mail)
        {
            using (var context = new AcademiaContext())
            {
                Apellido = ape;
                Nombre = nom;
                TipoPersona = tp;
                FechaNacimiento = fechanac;
                Direccion = dir;
                IdPlan = plan;
                Telefono = tel;
                Email = mail;

                context.Personas.Add(this);
                context.SaveChanges();
            }
        }

        public void ModifyPersona(string ape, string nom, int tp, DateTime fechanac, string dir, int plan, string tel, int leg)
        {
            using (var context = new AcademiaContext())
            {

                if(context.Personas.Find(leg) != null)
                {
                    Apellido = ape;
                    Nombre = nom;
                    TipoPersona = tp;
                    FechaNacimiento = fechanac;
                    Direccion = dir;
                    IdPlan = plan;
                    Telefono = tel;

                    context.SaveChanges();
                }
                
            }
        }

        public void DeletePersona(int leg)
        {
            using (var context = new AcademiaContext())
            {

                if (context.Personas.Find(leg) != null)
                {
                    context.Personas.Remove(this);
                    context.SaveChanges();
                }

            }
        }

        public DAOPersona GetPersonaById(int leg)
        {
            using (var context = new AcademiaContext())
            {
                var query = from p in context.Personas where p.Legajo.Equals(leg) select p;
                return query.ElementAt(0);
            }


        }
    }
}