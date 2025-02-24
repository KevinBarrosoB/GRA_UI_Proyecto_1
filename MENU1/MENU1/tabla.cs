using System;
using MENU1;

public class tabla
{
    public static void menu_adicional(int n, int m)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(71, 35);
        Console.WriteLine("Opciones");
        Console.SetCursorPosition(49, 36);
        Console.WriteLine("1)Menu principal");
        Console.SetCursorPosition(66, 36);
        Console.WriteLine("2)Menu anterior");
        Console.SetCursorPosition(82, 36);
        Console.WriteLine("3)Continuar");
        Console.SetCursorPosition(94, 36);
        Console.WriteLine("4)Salir");
        Console.SetCursorPosition(65, 37);
        Console.WriteLine("Digite su eleccion:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(85, 37);
        int opcion = Convert.ToInt32(Console.ReadLine());
        try
        {
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Program.menu_principal();
                    break;
                case 2:
                    Console.Clear();
                    if (m == 1)
                    {
                        Menu.menu_1();
                    }
                    else if (m == 2)
                    {
                        Menu.menu_2();
                    }
                    break;
                case 3:
                    Console.Clear();
                    if (n == 1)
                    {
                        tabla_seno();
                    }
                    else if (n == 2)
                    {
                        tabla_coseno();
                    }
                    else if (n == 3)
                    {
                        distancia.hipotenuza();
                    }
                    else if (n == 4)
                    {
                        puntos.distancia();
                    }
                    else if (n == 5)
                    {
                        tiro_p.parabolico();
                    }
                    else if (n == 6)
                    {
                        espiral.coor(70, 19, 2, 4);
                    }
                    else if (n == 7)
                    {
                        rectangulos.coor(75, 19, 2, 4);
                    }
                    else if (n == 8)
                    {
                        zig.zigzag();
                    }
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(61, 38);
                    Console.WriteLine("Elige una opcion entre 1 y 4");
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(61, 39);
            Console.WriteLine("Parametro invalido");
        }
        Console.ReadKey();

    }

    public static void tabla_seno()
    {
        int valor = 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(68, 0);
        Console.WriteLine("Tabla de senos");

        for (int i = 24; i < 95; i += 30)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(i, 3);
            Console.WriteLine("A");
            Console.SetCursorPosition(i+4, 3);
            Console.WriteLine("seno");
            for (int j = 4; j < 34; j++)
            {
                System.Threading.Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(i, j);                
                Console.WriteLine(valor);
                Console.SetCursorPosition(i + 4, j);
                Console.Write(CalcularSeno(valor));
                valor++;
            }
        }
        menu_adicional(1,2);
    }
    static double CalcularSeno(int a)
    {
        double angulo = a * (Math.PI / 180); 
        double resultado = 0.0;
        int precision = 10; 

        for (int n = 0; n < precision; n++)
        {
            double termino = Math.Pow(-1, n) * Math.Pow(angulo, 2 * n + 1) / Factorial(2 * n + 1);
            resultado += termino;
        }
        return resultado;
    }

    static double Factorial(int num)
    {
        double resultado = 1;
        for (int i = 2; i <= num; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    public static void tabla_coseno()
    {
        int valor = 1;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(66, 0);
        Console.WriteLine("Tabla de cosenos");

        for (int i = 24; i < 95; i += 30)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(i, 3);
            Console.WriteLine("A");
            Console.SetCursorPosition(i + 4, 3);
            Console.WriteLine("coseno");
            for (int j = 4; j < 34; j++)
            {
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(i, j);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(valor);
                Console.SetCursorPosition(i + 4, j);
                Console.Write(Cos(valor));
                valor++;
            }
        }
        menu_adicional(2,2);
    }
    static double Cos(int a)
    {
        double angulo = Convert.ToDouble(a);
        double anguloEnRadianes = angulo * (Math.PI / 180);

        double coseno = 1;
        double term = 1;
        int n = 1;

        for (int i = 1; i <= 10; i++)
        {
            term *= -anguloEnRadianes * anguloEnRadianes / (2 * n * (2 * n - 1));
            coseno += term;
            n++;
        }

        return coseno;
    }

}