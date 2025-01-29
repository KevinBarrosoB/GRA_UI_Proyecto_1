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
            int c = 1;
            imprimir_2 im = new imprimir_2();
            puntos.Add(new Coordenada(hor, ver, c));
            horizontalizprincipal(ver, hor, ancho, largo, c);
            imprimir_2.colores(puntos);
        }
        public static void horizontalizprincipal(int hor, int ver, int ancho, int largo, int c)
        {
            int v = ver;
            for (int i = ver+2 ; i >= ver - largo; i-=2)
            {
                puntos.Add(new Coordenada(i, hor, c));
                v--;
            }
            horizontalde(hor - 2, v - 6, ancho, largo + 10,c+1);
        }
        public static void horizontaliz(int hor, int ver, int ancho, int largo,int c)
        {
            
            int v = ver;
            for (int i = ver - 1; i >= ver - largo; i--)
            {
                puntos.Add(new Coordenada(i, hor, c));
                v--;
            }
            verticalar(hor - 1, v, ancho+2, largo,c);
        }
        public static void verticalar(int hor, int ver, int ancho, int largo, int c)
        {
            
                int h = hor;
                for (int i = hor; i > hor - ancho+3; i--)
                {
                    puntos.Add(new Coordenada(ver, i, c));
                    h--;
                }
                horizontalde(h -1, ver-6, ancho-2 , largo+10,c+1);
            
            
        }

        public static void horizontalde(int hor, int ver, int ancho, int largo, int c)
        {
            if (c <= 5)
            {
                int v = ver;
                for (int i = ver + 1; i <= ver + (largo + 1); i++)
                {
                    puntos.Add(new Coordenada(i, hor, c));
                    v++;
                }
                verticalab(hor, v, ancho +3, largo, c);
            }

        }

        public static void verticalab(int hor, int ver, int ancho, int largo, int c)
        {
            int h = hor;
            for (int i = hor + 1; i <= hor + ancho; i++)
            {
                puntos.Add(new Coordenada(ver, i,c));
                h++;
            }
            horizontaliz(h, ver, ancho+1,largo,c);

        }
        public class Coordenada
        {
            public int Horizontal { get; set; }
            public int Vertical { get; set; }
            public int C { get; set; }

            public Coordenada(int horizontal, int vertical, int c)
            {
                Horizontal = horizontal;
                Vertical = vertical;
                C = c;
            }
        }


    }
}

