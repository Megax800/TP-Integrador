using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class CursoControlador
    {
        List<Curso> cursos = [];
        public CursoControlador()
        {
            cursos.Add(new Curso(2008, 1, 30, "Termodinamica I", 101));
            cursos.Add(new Curso(2005, 2, 30, "Fisica I", 102));
            cursos.Add(new Curso(2008, 3, 30, "Electricidad II", 201));
        }

        public bool AddCurso(int año, int mat, int cupo, string desc, int com)
        {
            try
            {
                cursos.Add(new Curso(año, mat, cupo, desc, com));
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public Curso GetCurso(int a, int m, int com)
        {
            var query = from c in cursos where c.AñoCalendario.Equals(a) & c.IdMateria.Equals(m) & c.IdComision.Equals(com) select c;
            return query.ElementAt(0);
        }

        public bool UpdateCurso(Curso old_c, Curso mod_c)
        {
            try
            {
                cursos.Remove(old_c);
                cursos.Add(mod_c);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool RemoveCurso(Curso c)
        {
            try
            {
                cursos.Remove(c);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}