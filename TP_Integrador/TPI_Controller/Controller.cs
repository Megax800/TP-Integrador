using System.Security.Cryptography.X509Certificates;

namespace TPI_Controller
{
    
    public class Controlador
    {
        TipoPersonas[] listaTipos = new TipoPersonas[3];
        List<Persona> personas = [];
        List<Usuario> usuarios = [];
        List<Curso> cursos = [];
        List<Especialidad> especialidades = [];
        List<Comision> comisiones = [];
        List<Plan> planes = [];
        List<Materia> materias = [];
        public Controlador()
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
            
            usuarios.Add(new Usuario("Russmann", "Octavio", listaTipos[0], DateTime.Parse("13/06/2002")));
            usuarios.Add(new Usuario("Perez", "Sergio", listaTipos[1], DateTime.Parse("29/03/2005")));
            usuarios.ElementAt(0).Clave = "1234";
            Console.WriteLine(usuarios.ElementAt(0));

            especialidades.Add(new Especialidad("Tecnico Electronico"));
            especialidades.Add(new Especialidad("Mecanico"));
            especialidades.Add(new Especialidad("Electricista"));

            cursos.Add(new Curso(2008, 1, 30, "Termodinamica I", 101));
            cursos.Add(new Curso(2005, 2, 30, "Fisica I", 102));
            cursos.Add(new Curso(2008, 3, 30, "Electricidad II", 201));

            comisiones.Add(new Comision(1, "1K01", 1));
            comisiones.Add(new Comision(2, "1K02", 1));
            comisiones.Add(new Comision(3, "1K03", 1));
            comisiones.Add(new Comision(4, "1C03", 2));
            comisiones.Add(new Comision(5, "1C03", 2));
            comisiones.Add(new Comision(6, "1C03", 3));
            // ID COMISION, NOMBRE COMISION, ID PLAN (puede hacer referencia a plan 2008 sistemas, 2023 sistemas, 2008 civil, etc...)

            planes.Add(new Plan(1, 2008, 1));
            planes.Add(new Plan(2, 2008, 2));
            planes.Add(new Plan(3, 2008, 3));
            planes.Add(new Plan(4, 2008, 4));
            planes.Add(new Plan(5, 2008, 5));
            planes.Add(new Plan(6, 2023, 1));
            planes.Add(new Plan(7, 2023, 2));
            planes.Add(new Plan(8, 2023, 3));
            // especialidad id no incluida en su clase aun

            materias.Add(new Materia(1, 4, 200, 1));
            materias.Add(new Materia(2, 4, 200, 1));
            materias.Add(new Materia(3, 3, 170, 7));
            materias.Add(new Materia(4, 8, 400, 3));
            materias.Add(new Materia(5, 5, 300, 4));
            materias.Add(new Materia(6, 6, 300, 2));
            materias.Add(new Materia(7, 8, 400, 2));
        }
        
        //0: Usuario Incorrecto 1: Validacion Correcta 2: Constraseña incorrecta
        public int ValidaUser(string username, string pass)
        {
            Usuario buffer;
            try
            {
                var query = from u in usuarios where u.NombreUsuario.Equals(username) select u;
                buffer = query.ElementAt(0);
            }
            catch(Exception ex)
            {
                return 0;
            }
            
            
            if(buffer.Clave == pass)
            {
                return 1;
            }else
            {
                return 2;
            }
        }

        public bool AddUsuario(string ape, string nom, TipoPersonas tp, DateTime nac)
        {
            try
            {
                usuarios.Add(new Usuario(ape, nom, tp, nac));
            }catch(Exception ex)
            {
                return false;
            }

            return true;
        }

        public Usuario GetUsuario(string username)
        {
            var query = from u in usuarios where u.NombreUsuario.Equals(username) select u;
            return query.ElementAt(0);
        }

        public bool UpdateUsuario(Usuario oldUser, Usuario modifiedUser)
        {
            try
            {
                usuarios.Remove(oldUser);
                usuarios.Add(modifiedUser);
            }catch(Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool RemoveUsuario(Usuario user)
        {
            try
            {
                usuarios.Remove(user);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
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

        public string GetUsuarioPass(string userName)
        {
            var query = from u in usuarios where u.NombreUsuario.Equals(userName) select u;
            return query.ElementAt(0).Clave;
        }

        public bool AddComision(int comId, string comNombre, int planId)
        {
            try
            {
                comisiones.Add(new Comision(comId, comNombre, planId));
            }
            catch (Exception ex)
            {
                // log ex?
                return false;
            }
            return true;
        }
        static void Main() { }
    }

    
}