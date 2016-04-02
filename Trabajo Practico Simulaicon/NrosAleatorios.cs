using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Trabajo_Practico_Simulaicon
{
    class NrosAleatorios
    {
        static public int n = 100000;
        static double[] nros;
        static int r = 0;

        public static double DameNro()
        {
            double nro = nros[r];
            ++r;
            return nro;
        }

        public static void ReiniciarR()
        {
            r = 0;
        }

        public static void ReiniciarN()
        {
            n = 100;
        }

        public static void GenerarNros(int hs)
        {
            n = n * hs;
            nros = new double[n];
            int seed = new Random().Next(0, 100);
            Random generador = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                double nro;
                
                do
                {                    
                    nro = generador.NextDouble();
                }
                while ((nro == 0 || nro == 1));
                nros[i] = nro;
                
            }
        }

    }
}
