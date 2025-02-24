using System;
using MENU1;

public class Menu
{
    
    public static void menu_1()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(55, 10);
        Console.WriteLine("Menú 1. Programas de introducción");
        Console.SetCursorPosition(55, 12);
        Console.WriteLine("1) Rectagulos");
        Console.SetCursorPosition(55, 14);
        Console.WriteLine("2) Espiral");
        Console.SetCursorPosition(55, 16);
        Console.WriteLine("3) Zig zag");
        Console.SetCursorPosition(55, 18);
        Console.WriteLine("4) Regresar a menu principal");
        Console.SetCursorPosition(55, 20);
        Console.WriteLine("5) Salir");
        Console.SetCursorPosition(55, 22);
        Console.WriteLine("Digita tu eleccion:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(80, 22);
        int opcion = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    rectangulos.coor(75, 19, 2, 4);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    espiral.coor(70, 19, 2, 4);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    zig.zigzag();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Program.menu_principal();
                    Console.ReadKey();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(61, 28);
                    Console.WriteLine("Elige una opcion entre 1 y 5");
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
    public static void menu_2()
    {
        Program program = new Program();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(55, 10);
        Console.WriteLine("Menú 2. Programas de localización");
        Console.SetCursorPosition(55, 12);
        Console.WriteLine("1) Tabla de senos");
        Console.SetCursorPosition(55, 14);
        Console.WriteLine("2) Tabla de cosenos");
        Console.SetCursorPosition(55, 16);
        Console.WriteLine("3) Calculo de la hipotenusa");
        Console.SetCursorPosition(55, 18);
        Console.WriteLine("4) Calculo de la distancia");
        Console.SetCursorPosition(55, 20);
        Console.WriteLine("5) Calculo de un lanzamiento parabólico ");
        Console.SetCursorPosition(55, 22);
        Console.WriteLine("6) Regresar a menu principal");
        Console.SetCursorPosition(55, 24);
        Console.WriteLine("7) Salir");
        Console.SetCursorPosition(55, 26);
        Console.WriteLine("Digita tu eleccion:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(80, 26);
        int opcio = Convert.ToInt32(Console.ReadLine());

        try
        {
            switch (opcio)
            {
                case 1:
                    Console.Clear();
                    tabla.tabla_seno();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    tabla.tabla_coseno();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    distancia.hipotenuza();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    puntos.distancia();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    tiro_p.parabolico();
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Clear();
                    Program.menu_principal();
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Clear();
                    Program.menu_principal();
                    Console.ReadKey();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(61, 28);
                    Console.WriteLine("Elige una opcion entre 1 y 7");
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