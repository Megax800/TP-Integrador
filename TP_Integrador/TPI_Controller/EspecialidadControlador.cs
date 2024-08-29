using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class EspecialidadControlador
    {
        List<Especialidad> especialidades = [];
        public EspecialidadControlador()
        {
            especialidades.Add(new Especialidad("Tecnico Electronico"));
            especialidades.Add(new Especialidad("Mecanico"));
            especialidades.Add(new Especialidad("Electricista"));
        }

        public bool AddEsp(string desc)
        {
            try
            {
                especialidades.Add(new Especialidad(desc));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public Especialidad GetEsp(string d)
        {
            var query = from e in especialidades where e.Descripcion.Equals(d) select e;
            return query.ElementAt(0);
        }

        public bool UpdateEsp(Especialidad old_e, Especialidad mod_e)
        {
            try
            {
                especialidades.Remove(old_e);
                especialidades.Add(mod_e);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool RemoveEsp(Especialidad e)
        {
            try
            {
                especialidades.Remove(e);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}