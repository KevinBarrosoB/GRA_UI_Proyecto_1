using System;
using MENU1;
using static MENU1.espiral;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        espiral co = new espiral();
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE OPCIONES ===");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        int ver = 19;
                        int hor = 75;
                        int ancho = 2;
                        int largo = 4;

                        co.coor(hor, ver, ancho, largo);
                        Console.SetCursorPosition(1, 38);
                        Console.WriteLine("fin de la ejecucion");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Has seleccionado la Opción 2.");
                        // Aquí puedes agregar el código para la opción 2
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
