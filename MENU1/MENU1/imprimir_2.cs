using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MENU1.rectangulos;
using System.Linq;

namespace MENU1
{
    internal class imprimir_2
    {
        public static void colores(ArrayList list)
        {
            foreach (Coordenada punto in list)
            {
                System.Threading.Thread.Sleep(100);
                switch (punto.C)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;

                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        break;
                }
                Console.SetCursorPosition(punto.Horizontal, punto.Vertical);
                Console.WriteLine("*");
            }
            menu_emergente();
        }
        private static void menu_emergente()
        {
            Program program = new Program();
            rectangulos rec = new rectangulos();    
            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(40, 29);
            Console.WriteLine("Ingresa una opcion: 1)Regresar al menu principal 2)volver a ejecutar 3) salir ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        program.menuprin();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        rec.coor(75, 10, 2, 4);
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        Environment.Exit(0);

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
        }

    }
}
