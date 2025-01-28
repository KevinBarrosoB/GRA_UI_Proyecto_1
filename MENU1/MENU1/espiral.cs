using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU1
{
    internal class espiral
    {
        static ArrayList puntos = new ArrayList();

        public void coor(int hor, int ver, int ancho, int largo)
        {
            imprimir im = new imprimir();
            puntos.Add(new Coordenada(hor, ver));
            horizontaliz(ver, hor, ancho, largo);
            imprimir.colores(puntos, 1);
        }
        public static void horizontaliz(int hor, int ver, int ancho, int largo)
        {
            int v = ver;
            for (int i = ver - 1; i >= ver - largo; i--)
            {
                puntos.Add(new Coordenada(i, hor));
                v--;
            }
            verticalar(hor - 1, v, ancho, largo + 5);
        }
        public static void verticalar(int hor, int ver, int ancho, int largo)
        {
            if (hor - ancho >= 8)
            {
                int h = hor;
                for (int i = hor; i > hor - ancho; i--)
                {
                    puntos.Add(new Coordenada(ver, i));
                    h--;
                }
                horizontalde(h + 1, ver, ancho + 2, largo);
            }
            else
            {
                for (int i = hor; i > 7; i--)
                {
                    puntos.Add(new Coordenada(ver, i));
                }
            }
        }

        public static void horizontalde(int hor, int ver, int ancho, int largo)
        {
            int v = ver;
            for (int i = ver + 1; i <= ver + largo; i++)
            {
                puntos.Add(new Coordenada(i, hor));
                v++;
            }
            verticalab(hor, v, ancho, largo + 5);

        }

        public static void verticalab(int hor, int ver, int ancho, int largo)
        {
            int h = hor;
            for (int i = hor + 1; i <= hor + ancho; i++)
            {
                puntos.Add(new Coordenada(ver, i));
                h++;
            }
            horizontaliz(h, ver, ancho + 2, largo);

        }
        public class Coordenada
        {
            public int Horizontal { get; set; }
            public int Vertical { get; set; }

            public Coordenada(int horizontal, int vertical)
            {
                Horizontal = horizontal;
                Vertical = vertical;
            }
        }

    }
}
