using System;
namespace Clases

{
    public class A
    {
        public string NombreInstancia
        {
            get;
            set;
        }
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombreInstancia)
        {
            NombreInstancia = nombreInstancia;
        }
        public string MostrarNombre()
        {
            return this.NombreInstancia;
        }
        void M1()
        {
            Console.WriteLine("M1 fue utilizado");
        }
        void M2()
        {
            Console.WriteLine("M2 fue utilizado");
        }
        void M3()
        {
            Console.WriteLine("M3 fue utilizado");
        }
    }

    A person = new A();
    
}

