using System;
namespace Clases1
{
    public class A
    {
        string nombreInstancia;

        public string NombreInstancia
        {
            get
            {
                return nombreInstancia;
            }
            set
            {
                nombreInstancia = value;
            }
        }

        public A()
        {
            this.nombreInstancia = "Instancia sin nombre";
        }

        public A(string nombreInstancia)
        {
            NombreInstancia = nombreInstancia;
        }

        public void MostrarNombre(string nombreInstancia)
        {
            Console.WriteLine(nombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("Se invoca el metodo M1");
        }

        public void M2()
        {
            Console.WriteLine("Se invoca el metodo M2");
        }

        public void M3()
        {
            Console.WriteLine("Se invoca el metodo M3");
        }
    }
}
