using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPI_Controller
{
    public class UsuarioControlador
    {
        List<Usuario> usuarios = [];
        TipoPersonas[] listaTipos = new TipoPersonas[3];
        public UsuarioControlador()
        {
            listaTipos[0].id = 1;
            listaTipos[0].nombre = "sysAdmin";
            listaTipos[1].id = 2;
            listaTipos[1].nombre = "Alumno";
            listaTipos[2].id = 3;
            listaTipos[2].nombre = "Docente";

            usuarios.Add(new Usuario("Russmann", "Octavio", listaTipos[0], DateTime.Parse("13/06/2002"), 49639));
            usuarios.Add(new Usuario("Perez", "Sergio", listaTipos[1], DateTime.Parse("29/03/2005"), 52333));
            usuarios.ElementAt(0).Clave = "1234";
            Console.WriteLine(usuarios.ElementAt(0));
        }

        public int ValidaUser(string username, string pass)
        {
            Usuario buffer;
            try
            {
                var query = from u in usuarios where u.NombreUsuario.Equals(username) select u;
                buffer = query.ElementAt(0);
            }
            catch (Exception ex)
            {
                return 0;
            }


            if (buffer.Clave == pass)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public bool AddUsuario(Usuario User)
        {
            try
            {
                usuarios.Add(User);
            }
            catch (Exception ex)
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
            }
            catch (Exception ex)
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

        public string GetUsuarioPass(string userName)
        {
            var query = from u in usuarios where u.NombreUsuario.Equals(userName) select u;
            return query.ElementAt(0).Clave;
        }
    }
}