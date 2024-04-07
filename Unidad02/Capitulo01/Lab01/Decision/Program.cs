using System;

string InputTexto;
Console.WriteLine("Ingrese un Texto:");
InputTexto= Console.ReadLine();

while(InputTexto == ""){
    Console.WriteLine("Ingrese un Texto:");
    InputTexto = Console.ReadLine();
}

bool salir = false;

Console.WriteLine("Texto OK");
while (salir == false)
{
    Console.WriteLine("Menu:\n 1. Texto en Mayusculas\n 2. Texto en Minusculas\n 3.Cantidad de Caracteres\n 0. Salir\n");
    
    ConsoleKeyInfo opcion = Console.ReadKey();

    if (opcion.Key == ConsoleKey.D1)
    {
        Console.WriteLine(InputTexto.ToUpper());
    }
    else if (opcion.Key == ConsoleKey.D2)
    {
        Console.WriteLine(InputTexto.ToLower());
    }
    else if (opcion.Key == ConsoleKey.D3)
    {
        Console.WriteLine(InputTexto.Length);
    }
    else if (opcion.Key == ConsoleKey.D0)
    {
        salir = true;
    }
    else
    {
        Console.WriteLine("Valor no Valido");
    }
}