using System;
using MENU1;
using static MENU1.espiral;

class Program
{
    static void Main(string[] args)
    {
        int ver = 19;
        int hor = 75;
        int ancho = 2;
        int largo = 4;
        int opcion;
        espiral co = new espiral();
        rectangulos re = new rectangulos();
        do
        {   
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(60, 15);
            Console.WriteLine("==== MENÚ DE OPCIONES ====");
            Console.SetCursorPosition(60, 17);
            Console.WriteLine("1. Opción 1");
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("2. Espiral de estasteriscos");
            Console.SetCursorPosition(60, 21);
            Console.WriteLine("0. Salir");
            Console.SetCursorPosition(60, 23);
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        re.coor(hor, ver, ancho, largo);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        co.coor(hor, ver, ancho, largo);
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            if (opcion != 0)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

}
