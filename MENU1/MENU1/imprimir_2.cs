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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(63, 3);
            Console.WriteLine("Rectangulos de colores");
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
            tabla.menu_adicional(7,1);
        }
    }
}
