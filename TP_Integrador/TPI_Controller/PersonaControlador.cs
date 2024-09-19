using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPI_DAO;

namespace TPI_Controller
{
    public class PersonaControlador
    {
        TipoPersonas[] listaTipos = new TipoPersonas[3];
        List<Persona> personas = [];

        public TipoPersonas devolverListaTipos(int tipo)
        {
            return listaTipos[tipo];
        }

        public PersonaControlador()
        {
            int lastID = 0;
            listaTipos[0].id = 1;
            listaTipos[0].nombre = "sysAdmin";
            listaTipos[1].id = 2;
            listaTipos[1].nombre = "Alumno";
            listaTipos[2].id = 3;
            listaTipos[2].nombre = "Docente";

            personas.Add(new Persona("Russmann", "Octavio", listaTipos[0], DateTime.Parse("13/06/2002")));
            lastID++;
            personas.Add(new Persona("Perez", "Sergio", listaTipos[1], DateTime.Parse("29/03/2005")));
            lastID++;
            personas.Add(new Persona("Son", "Goku", listaTipos[1], DateTime.Parse("14/07/1999")));
            lastID++;
            personas.Add(new Persona("Gonzalez", "Rafael", listaTipos[2], DateTime.Parse("13/06/1972")));
            lastID++;
            personas.Add(new Persona("Verian", "Gabriel", listaTipos[2], DateTime.Parse("29/03/1985")));
            lastID++;
            personas.Add(new Persona("Espinosa", "Maria", listaTipos[2], DateTime.Parse("14/07/1989")));
        }

        public string AddPersona(Persona per)
        {
            try
            {
                DAOPersona DAO= new DAOPersona();

                DAO.AddPersona(per.Apellido,per.Nombre,per.TipoPersona.id,per.FechaNacimiento);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "ok";
        }

        public Persona GetPersona(int id)
        {
            var query = from p in personas where p.Legajo.Equals(id) select p;
            return query.ElementAt(0);
        }

        public bool UpdatePersona(Persona old_al, Persona mod_al)
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

        public bool RemovePersona(Persona al)
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