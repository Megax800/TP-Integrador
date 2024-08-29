using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class PersonaControlador
    {
        TipoPersonas[] listaTipos = new TipoPersonas[3];
        List<Persona> personas = [];

        public PersonaControlador()
        {
            listaTipos[0].id = 1;
            listaTipos[0].nombre = "sysAdmin";
            listaTipos[1].id = 2;
            listaTipos[1].nombre = "Alumno";
            listaTipos[2].id = 3;
            listaTipos[2].nombre = "Docente";

            personas.Add(new Persona("Russmann", "Octavio", listaTipos[0], DateTime.Parse("13/06/2002")));
            personas.Add(new Persona("Perez", "Sergio", listaTipos[1], DateTime.Parse("29/03/2005")));
            personas.Add(new Persona("Son", "Goku", listaTipos[1], DateTime.Parse("14/07/1999")));
            personas.Add(new Persona("Gonzalez", "Rafael", listaTipos[2], DateTime.Parse("13/06/1972")));
            personas.Add(new Persona("Verian", "Gabriel", listaTipos[2], DateTime.Parse("29/03/1985")));
            personas.Add(new Persona("Espinosa", "Maria", listaTipos[2], DateTime.Parse("14/07/1989")));
        }

        public bool AddAlumno(string ape, string nom, DateTime nac)
        {
            try
            {
                personas.Add(new Persona(ape, nom, listaTipos[1], nac));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public Persona GetAlumno(int id)
        {
            var query = from p in personas where p.Legajo.Equals(id) & p.TipoPersona.id.Equals(2) select p;
            return query.ElementAt(0);
        }

        public bool UpdateAlumno(Persona old_al, Persona mod_al)
        {
            try
            {
                personas.Remove(old_al);
                personas.Add(mod_al);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool RemoveAlumno(Persona al)
        {
            try
            {
                personas.Remove(al);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}