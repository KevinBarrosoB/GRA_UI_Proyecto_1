using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static MENU1.espiral;

namespace MENU1
{
    internal class imprimir
    {
        public static void colores(ArrayList list, int n)
        {
            foreach (Coordenada punto in list)
            {
                System.Threading.Thread.Sleep(100);
                switch (n)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        n = 2;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        n = 3;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        n = 4;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        n = 5;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        n = 1;
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
            espiral ees= new espiral();
            int opcion;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(60, 30);
            Console.WriteLine("==== MENÚ DE EMERGENTE====");
            Console.SetCursorPosition(60, 31);
            Console.WriteLine("1)Regresar al menu principal 2)volver a ejecutar 3) salir ");
            Console.SetCursorPosition(60, 32);
            Console.Write("Seleccione una opción: ");
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
                        ees.coor(75, 10, 2, 4);
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
