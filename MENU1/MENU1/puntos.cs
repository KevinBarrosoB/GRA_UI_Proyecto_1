using System;

public class puntos
{

    public static void distancia()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(55, 3);
        Console.WriteLine("Calculo de la distancia entre dos puntos ");

        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(50, 9);

        Console.WriteLine("Ingrese las coordenadas del primer punto (x1, y1):");
        Console.SetCursorPosition(70, 11);
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(80, 11);
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.SetCursorPosition(50, 13);
        Console.WriteLine("Ingrese las coordenadas del segundo punto (x2, y2):");
        Console.SetCursorPosition(70, 15);
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(80, 15);
        double y2 = Convert.ToDouble(Console.ReadLine());

        double pendiente = (y2 - y1) / (x2 - x1);

        double angulo = Math.Atan(pendiente);

        angulo = angulo * 180 / Math.PI;

        double puntoMedioX = (x1 + x2) / 2;
        double puntoMedioY = (y1 + y2) / 2;

        pendiente = Math.Round(pendiente, 2);
        angulo = Math.Round(angulo, 2);
        puntoMedioX = Math.Round(puntoMedioX, 2);
        puntoMedioY = Math.Round(puntoMedioY, 2);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(55, 20);
        Console.WriteLine("La pendiente de la recta es: " + pendiente);
        Console.SetCursorPosition(55, 22);
        Console.WriteLine("El ángulo de inclinación es: " + angulo + " grados");
        Console.SetCursorPosition(55, 24);
        Console.WriteLine("Las coordenadas del punto medio son: (" + puntoMedioX + ", " + puntoMedioY + ")");
        tabla.menu_adicional(4,2);
    }
}