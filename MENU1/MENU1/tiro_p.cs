using System;

public class tiro_p
{

    public static void parabolico()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(62, 3);
        Console.WriteLine("Calculo del tiro parabolico");
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(57, 5);
        Console.Write("Ingrese la velocidad inicial (m/s): ");
        Console.SetCursorPosition(92, 5);
        double velocidadInicial = Convert.ToDouble(Console.ReadLine());
        Console.SetCursorPosition(54, 7);
        Console.Write("Ingrese el ángulo de lanzamiento (grados): ");
        Console.SetCursorPosition(97, 7);
        double anguloLanzamiento = Convert.ToDouble(Console.ReadLine());

        double anguloRad = anguloLanzamiento * Math.PI / 180;

        const double gravedad = 9.81; 

        double tiempoVuelo = (2 * velocidadInicial * Math.Sin(anguloRad)) / gravedad;
        double alturaMaxima = (Math.Pow(velocidadInicial, 2) * Math.Pow(Math.Sin(anguloRad), 2)) / (2 * gravedad);
        double distanciaMaxima = Math.Pow(velocidadInicial, 2) * Math.Sin(2 * anguloRad) / gravedad;
        double velocidadMaxima = velocidadInicial * Math.Sin(anguloRad);
        double velocidadFinalY = velocidadMaxima * Math.Cos(anguloRad);
        double alturaFinal = 0;

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(70, 10);
        Console.WriteLine("Resultados:");
        Console.SetCursorPosition(53, 12);
        Console.WriteLine("Tiempo de vuelo: " + tiempoVuelo + " segundos");
        Console.SetCursorPosition(53, 14);
        Console.WriteLine("Altura máxima: " + alturaMaxima + " metros");
        Console.SetCursorPosition(53, 16);
        Console.WriteLine("Distancia máxima: " + distanciaMaxima + " metros");
        Console.SetCursorPosition(53, 18);
        Console.WriteLine("Velocidad máxima en Y: " + velocidadMaxima + " m/s");
        Console.SetCursorPosition(53, 20);
        Console.WriteLine("Velocidad final en Y: " + velocidadFinalY + " m/s");

        Console.SetCursorPosition(53, 22);
        Console.WriteLine("Coordenadas (X,Y) en intervalos de 10 fracciones de segundo:");
        for (double t = 0; t <= tiempoVuelo; t += 0.1)
        {
            System.Threading.Thread.Sleep(500);
            Console.SetCursorPosition(53, 24);
            Console.WriteLine("                                                                                                       ");
            double x = velocidadInicial * Math.Cos(anguloRad) * t;
            double y = (velocidadInicial * Math.Sin(anguloRad) * t) - (0.5 * gravedad * Math.Pow(t, 2));
            alturaFinal = y;
            Console.SetCursorPosition(53, 24);
            Console.WriteLine("Tiempo: " + t.ToString("0.0") + "s - Coordenadas: (" + x.ToString("0.00") + "m, " + y.ToString("0.00") + "m)");

        }
        Console.SetCursorPosition(53, 27);
        Console.WriteLine("Altura final: " + alturaFinal.ToString("0.00") + " metros");
        tabla.menu_adicional(5,2);
    }
}