using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        }

    }
}
