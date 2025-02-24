using System;
using MENU1;
using static MENU1.espiral;

class Program
{

    static void Main(string[] args)
    {
        
        menu_principal();

    }
    public static void menu_principal()
    {
        bool salir = false;

        while (!salir)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(68, 5);
            Console.WriteLine("Menu Principal");
            Console.SetCursorPosition(69, 10);
            Console.WriteLine("Elaborado por:");
            Console.SetCursorPosition(65, 12);
            Console.WriteLine("Kevin Barroso Briones");
            Console.SetCursorPosition(65, 16);
            Console.WriteLine("Seleciona un opcion:");
            Console.SetCursorPosition(49, 20);
            Console.WriteLine("1) Primer menu");
            Console.SetCursorPosition(66, 20);
            Console.WriteLine("2) Segundo menu");
            Console.SetCursorPosition(83, 20);
            Console.WriteLine("3) Salir del menu");
            Console.SetCursorPosition(66, 24);
            Console.WriteLine("Digita tu eleccion");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(74, 26);
            int opcion = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Menu.menu_1();
                        salir = true;
                        break;
                    case 2:
                        Console.Clear();
                        Menu.menu_2();
                        salir = true;
                        break;
                    case 3:
                        salir = true;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(61, 28);
                        Console.WriteLine("Elige una opcion entre 1 y 3");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(61, 30);
                Console.WriteLine("Parametro invalido");
            }
            Console.ReadKey();
        }
    }
}