using System;

public class distancia
{

    public static void hipotenuza()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(63, 3);
        Console.WriteLine("Calculo de la hipotenusa");
        Console.SetCursorPosition(60, 5);
        Console.WriteLine("Ingresa un valores requeridos");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(65, 12);

        int altura = 20;
        int al = 10;

        for (int i = 0; i < altura; i++)
        {
            Console.SetCursorPosition(65, al);
            Console.WriteLine("|" + new string(' ', i) + "\\");
            al++;
        }
        Console.SetCursorPosition(65, al);
        Console.WriteLine("|" + new string('_', altura ) + "\\");

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(52, 20);
        Console.WriteLine("Cateto 1:");
        Console.SetCursorPosition(61, 20);
        double cateto1 = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(70, 31);
        Console.WriteLine("Cateto 2:");
        Console.SetCursorPosition(79, 31);
        double cateto2 = Convert.ToDouble(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(78, 20);
        double hipotenusa = Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);

        Console.WriteLine($"Hipotenusa: {Math.Round(hipotenusa, 2)}");
        MostrarAngulos(cateto1, cateto2, hipotenusa);
        tabla.menu_adicional(3,2);
    }
    static void MostrarAngulos(double cateto1, double cateto2, double hipotenusa)
    {
        double angulo1 = CalcularAngulo(cateto1, hipotenusa);
        double angulo2 = CalcularAngulo(cateto2, hipotenusa);
        double anguloRecto = 90;
        Console.SetCursorPosition(65, 9);
        Console.WriteLine($"A: {Math.Round(angulo1, 2)} °");
        Console.SetCursorPosition(87, 30);
        Console.WriteLine($"C: {Math.Round(angulo2, 2)} °");
        Console.SetCursorPosition(67, 29);
        Console.WriteLine($"B: {anguloRecto} °");
    }

    static double CalcularAngulo(double cateto, double hipotenusa)
    {
        return Math.Asin(cateto / hipotenusa) * (180 / Math.PI);
    }

}