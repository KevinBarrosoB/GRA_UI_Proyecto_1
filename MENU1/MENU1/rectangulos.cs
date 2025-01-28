using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MENU1
{
    internal class rectangulos
    {
        static ArrayList puntos = new ArrayList();

        public void coor(int hor, int ver, int ancho, int largo)
        {
            imprimir_2 im = new imprimir_2();
            puntos.Add(new Coordenada(hor, ver));
            horizontalizprincipal(ver, hor, ancho, largo);
            imprimir_2.colores(puntos, 1);
        }
        public static void horizontalizprincipal(int hor, int ver, int ancho, int largo)
        {
            int v = ver;
            for (int i = ver - 1; i >= ver - largo; i--)
            {
                puntos.Add(new Coordenada(i, hor));
                v--;
            }
            horizontalde(hor - 2, v - 6, ancho, largo + 12);
        }
        public static void horizontaliz(int hor, int ver, int ancho, int largo)
        {
            int v = ver;
            for (int i = ver - 1; i >= ver - largo; i--)
            {
                puntos.Add(new Coordenada(i, hor));
                v--;
            }
            verticalar(hor - 1, v, ancho+2, largo);
        }
        public static void verticalar(int hor, int ver, int ancho, int largo)
        {
            if (hor - ancho >= 8)
            {
                int h = hor;
                for (int i = hor; i > hor - ancho+2; i--)
                {
                    puntos.Add(new Coordenada(ver, i));
                    h--;
                }
                horizontalde(h + 1, ver-5, ancho+2 , largo+10);
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
            for (int i = ver + 1; i <= ver + (largo+1); i++)
            {
                puntos.Add(new Coordenada(i, hor));
                v++;
            }
            verticalab(hor, v, ancho+2, largo);

        }

        public static void verticalab(int hor, int ver, int ancho, int largo)
        {
            int h = hor;
            for (int i = hor + 1; i <= hor + ancho; i++)
            {
                puntos.Add(new Coordenada(ver, i));
                h++;
            }
            horizontaliz(h, ver, ancho , largo);

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

