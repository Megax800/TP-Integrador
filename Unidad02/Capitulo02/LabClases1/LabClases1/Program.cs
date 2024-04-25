using Clases1;

A instA= new A();
B instB= new B();

instA.MostrarNombre(instA.NombreInstancia);
instA.M1();
instA.M2();
instA.M3();

Console.WriteLine("Clase B");

instB.M4();
instB.MostrarNombre(instB.NombreInstancia);
instB.M1();
instB.M2();
instB.M3();
