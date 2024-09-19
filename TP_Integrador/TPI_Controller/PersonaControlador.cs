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
            listaTipos[0].id = 1;
            listaTipos[0].nombre = "Alumno";
            listaTipos[1].id = 2;
            listaTipos[1].nombre = "Profesor";
            listaTipos[2].id = 3;
            listaTipos[2].nombre = "Sysadmin";
        }

        public string AddPersona(Persona per)
        {
            try
            {
                DAOPersona DAO= new DAOPersona();

                DAO.AddPersona(per.Apellido,per.Nombre,per.TipoPersona.id,per.FechaNacimiento,per.Direccion, per.IdPlan, per.Telefono, per.Email);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "ok";
        }

        public Persona GetPersona(int id)
        {
            DAOPersona DAO= new DAOPersona();
            DAO.GetPersonaById(id);
            Persona per = new Persona(DAO.Apellido, DAO.Nombre, listaTipos[DAO.TipoPersona - 1], DAO.FechaNacimiento, DAO.Direccion, DAO.IdPlan, DAO.Telefono, DAO.Email);

            return per;
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