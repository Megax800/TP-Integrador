using System;


namespace Clases1
{
    public class B : A
    {
        public void M4()
        {
            Console.WriteLine("Metodo del hijo Invocado");
        }

        public B()
        {
            A inst = new A("Instancia de B");
        }
    }
}
