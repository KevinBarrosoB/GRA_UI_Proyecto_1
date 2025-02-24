using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

    public class zig
    {
        public static void zigzag()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(67, 3);
            Console.WriteLine("Zig zag azules");
            int ver = 40;
            int hor = 20;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(39, hor);
            Console.WriteLine("*");
            horizontal(ver, hor);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(105, hor);
            Console.WriteLine("*");
            tabla.menu_adicional(8,1);

    }
        public static void horizontal(int ver, int hor)
        {
            for (int i = ver; i <ver+5;i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(i,hor);
                Console.WriteLine("*");
            }
            if (hor < 20 && ver <100 ) { 
                vertical2(ver+5, hor);
            }
            else if (ver < 100)
            {
                vertical1(ver + 5, hor);
            }
        }
        public static void vertical1(int ver, int hor)
        {
            for (int i = hor; i > hor - 14; i--)
            {
                System.Threading.Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(ver, i);
                Console.WriteLine("*");
            }
            if (ver + 1 < 140) { 
                horizontal(ver+1, hor-13); 
            }           
        }
        public static void vertical2(int ver, int hor)
        {
            for (int i = hor; i < hor + 14; i++)
            {
                System.Threading.Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(ver, i);
                Console.WriteLine("*");
            }
            if (ver + 1 < 140)
            {
                horizontal(ver+1, hor+ 13);
            }
            
        }
    }

