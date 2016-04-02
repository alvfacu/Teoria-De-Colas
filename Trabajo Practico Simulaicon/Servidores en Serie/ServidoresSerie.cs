using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;
namespace Trabajo_Practico_Simulaicon
{
    class ServidoresSerie
    {
        public double reloj, tiempo_prox_arribo, tiempo_ult_evento, TEA, tea_a, tea_b;
        public int cantidad;
        char tipo, tipotea, tipotds;
        List<double> area_bajo_b = new List<double>();
        List<double> area_bajo_q = new List<double>();
        List<double> tiempo_prox_partida = new List<double>();
        List<double> demora_total = new List<double>();
        List<double> TDS = new List<double>();
        List<double> TDS_a = new List<double>();
        List<double> TDS_b = new List<double>();
        List<int> nro_cli_en_cola = new List<int>();
        List<int> nro_cli_comp_dem = new List<int>();
        List<int> estado_serv = new List<int>();
        List<double> TIOS = new List<double>();
        List<double> arriboss1 = new List<double> { 0 };
        List<double> arriboss2 = new List<double> { 0 };
        List<double> arriboss3 = new List<double> { 0 };
        List<double> arriboss4 = new List<double> { 0 };

        public ServidoresSerie(int c, double tea, List<double> tds)
        {
            tipo = 'e';
            cantidad = c+1;
            TEA = tea;
            reloj = tiempo_prox_arribo = 0;
            for (int i = 0; i < cantidad; i++)
            {
                TDS.Add(tds[i]);

                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                nro_cli_en_cola.Add(0);
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }
            if (cantidad != 4)
            {
                for (int i = 0; i < 4 - cantidad; i++)
                {
                    tiempo_prox_partida.Add(0);
                }
            }

            tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
            //tiempo_prox_arribo = Exponential.Sample(TEA);
        }

        public ServidoresSerie(char t, int c, List<double> tea, List<double> tds_a, List<double> tds_b)
        {
            tipo = t;
            cantidad = c + 1;
            tea_a = tea[0];
            tea_b = tea[1];
            reloj = tiempo_prox_arribo = 0;
            for (int i = 0; i < cantidad; i++)
            {
                TDS_a.Add(tds_a[i]);
                TDS_b.Add(tds_b[i]);

                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                nro_cli_en_cola.Add(0);
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }
            if (cantidad != 4)
            {
                for (int i = 0; i < 4 - cantidad; i++)
                {
                    tiempo_prox_partida.Add(0);
                }
            }
            if(tipo == 'e')
            { 
                tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
                //tiempo_prox_arribo = Exponential.Sample(TEA);
            }
            else
            {
                tiempo_prox_arribo = DameValor(tea_a,tea_b);
            }

        }

        public ServidoresSerie(int cant, char ttea, List<double> tea, char ttds, List<double> tds)
        {
            cantidad = cant + 1;
            tipotea = ttea;
            tipotds = ttds;

            if (tipotea == 'u')
            {
                tea_a = tea[0];
                tea_b = tea[1];
                tipo = tipotea;
                for (int i = 0; i < cantidad; i++)
                {
                    if (tipotds == 'e')
                    {
                        TDS.Add(tds[0]);
                    }
                    else
                    {
                        TDS_a.Add(tds[0]);
                        TDS_b.Add(tds[1]);
                    }
                }
            }
            else if (tipotds == 'u')
            {
                int h = cantidad * 2;
                for (int i = 0; i < h; i++)
                {
                    if (i == 0)
                    {
                        TDS_a.Add(tds[i]);
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            TDS_a.Add(tds[i]);
                        }
                        else
                        {
                            TDS_b.Add(tds[i]);
                        }
                    }
                }
                tipo = tipotea;
                if (tipotea == 'e')
                {
                    TEA = tea[0];
                }
                else
                {
                    tea_a = tea[0];
                    tea_b = tea[1];
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                nro_cli_en_cola.Add(0);
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }
            if (cantidad != 4)
            {
                for (int i = 0; i < 4 - cantidad; i++)
                {
                    tiempo_prox_partida.Add(0);
                }
            }

            if (tipotea != 'e')
            {
                tiempo_prox_arribo = DameValor(tea_a, tea_b);
            }
            else
            {
                tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
            }
            tipo = 'd';
        }

        private double DameValor(double a, double b)
        {
            switch (tipo)
            {
                case ('u'): return (a + (b - a) * NrosAleatorios.DameNro());
                case ('w'):
                    {
                        double valor = -Math.Log(NrosAleatorios.DameNro());
                        valor = Math.Pow(valor, 1 / b);
                        valor = a * valor;
                        return valor;
                    }
                default: return 0;
            }
        }
        public char rutinadetiempo()
        {
            if (tiempo_prox_arribo < tiempo_prox_partida[0])
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_arribo;
                return ('a');
            }
            else if (tiempo_prox_partida[0] < tiempo_prox_partida[1])
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[0];
                return ('b'); // arribo/partida entre 1 y 2
            }
            else if(tiempo_prox_partida[2] == 0)
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[1];
                return ('p');
            }
            else if (tiempo_prox_partida[1] < tiempo_prox_partida[2])
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[1];
                return ('c'); //arribo/partida entre 2 y 3
            }
            else if (tiempo_prox_partida[3] == 0)
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[2];
                return ('p');
            }
            else if (tiempo_prox_partida[2] < tiempo_prox_partida[3])
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[2];
                return ('d'); //arribo/partida entre 3 y 4
            }
            else
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[3];
                return ('p');
            }
        }

        public void arribo()
        {
            if (tipo == 'e')
            {
                tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
                //tiempo_prox_arribo = Exponential.Sample(TEA);
            }
            else if (tipo == 'd')
            {
                tipo = tipotea;
                if (tipo != 'e')
                {
                    tiempo_prox_arribo = DameValor(tea_a, tea_b);
                }
                else
                {
                    tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
                }
                tipo = 'd';
            }
            else
            {
                tiempo_prox_arribo = DameValor(tea_a, tea_b);
                //tiempo_prox_arribo = -tea_a * Math.Log(NrosAleatorios.DameNro());
            }

            if (estado_serv[0] == 0)
            {
                TIOS[0] = reloj;
                nro_cli_comp_dem[0] = nro_cli_comp_dem[0] + 1;
                estado_serv[0] = 1;
                if (tipo == 'e')
                {
                    tiempo_prox_partida[0] = -TDS[0] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[0] = DameValor(TDS_a[0], TDS_b[0]);
                    }
                    else
                    {
                        tiempo_prox_partida[0] = -TDS[0] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[0] = DameValor(TDS_a[0], TDS_b[0]);
                }
            }
            else
            {
                nro_cli_en_cola[0] = nro_cli_en_cola[0] + 1;
                arriboss1.Add(reloj);
            }
        }

        public void partida()
        {
            if (nro_cli_en_cola[cantidad-1] == 0)
            {
                estado_serv[cantidad - 1] = 0;
                area_bajo_b[cantidad - 1] = area_bajo_b[cantidad - 1] + (reloj - TIOS[cantidad - 1]);
                tiempo_prox_partida[cantidad - 1] = 1000000000;
            }
            else
            {
                if (cantidad == 2)
                {
                    demora_total[cantidad - 1] = demora_total[cantidad - 1] + (reloj - arriboss2[1]);
                    arriboss2.Remove(arriboss2[1]);
                }
                else if (cantidad == 3)
                {
                    demora_total[cantidad - 1] = demora_total[cantidad - 1] + (reloj - arriboss3[1]);
                    arriboss3.Remove(arriboss3[1]);
                }
                else if (cantidad == 4)
                {
                    demora_total[cantidad - 1] = demora_total[cantidad - 1] + (reloj - arriboss4[1]);
                    arriboss4.Remove(arriboss4[1]);
                }
                
                area_bajo_q[cantidad - 1] = area_bajo_q[cantidad - 1] + (nro_cli_en_cola[cantidad - 1] * (reloj - tiempo_ult_evento));
                nro_cli_en_cola[cantidad - 1] = nro_cli_en_cola[cantidad - 1] - 1;
                nro_cli_comp_dem[cantidad - 1] = nro_cli_comp_dem[cantidad - 1] + 1;
                if (tipo == 'e')
                {
                    tiempo_prox_partida[cantidad - 1] = -TDS[cantidad - 1] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[cantidad - 1] = DameValor(TDS_a[cantidad - 1], TDS_b[cantidad - 1]);
                    }
                    else
                    {
                        tiempo_prox_partida[cantidad - 1] = -TDS[cantidad - 1] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[cantidad - 1] = DameValor(TDS_a[cantidad - 1], TDS_b[cantidad - 1]);
                }
            }

        }
        
        internal void partida_arribo(char prox)
        {
            int ind1 = 0;
            int ind2 = 0;
            switch (prox)
            {
                case ('b'):
                    {
                        ind1 = 0;
                        ind2 = 1;
                        break;
                    }
                case ('c'):
                    {
                        ind1 = 1;
                        ind2 = 2;
                        break;
                    }
                case ('d'):
                    {
                        ind1 = 2;
                        ind2 = 3;
                        break;
                    }
                default:
                    { break; }
            }

            //Partida servidor ind1
            if (nro_cli_en_cola[ind1] == 0)
            {
                estado_serv[ind1] = 0;
                area_bajo_b[ind1] = area_bajo_b[ind1] + ( reloj - TIOS[ind1] );
                tiempo_prox_partida[ind1] = 1000000000;
            }
            else
            {
                if (prox == 'b')
                {
                    demora_total[ind1] = demora_total[ind1] + (reloj - arriboss1[1]);
                    arriboss1.Remove(arriboss1[1]);
                }
                else if (prox == 'c')
                {
                    demora_total[ind1] = demora_total[ind1] + (reloj - arriboss2[1]);
                    arriboss2.Remove(arriboss2[1]);
                }
                else if (prox == 'd')
                {
                    demora_total[ind1] = demora_total[ind1] + (reloj - arriboss3[1]);
                    arriboss3.Remove(arriboss3[1]);
                }
                area_bajo_q[ind1] = area_bajo_q[ind1] + (nro_cli_en_cola[ind1] * (reloj - tiempo_ult_evento));
                nro_cli_en_cola[ind1] = nro_cli_en_cola[ind1] - 1;
                nro_cli_comp_dem[ind1] = nro_cli_comp_dem[ind1] + 1;
                if (tipo == 'e')
                {
                    tiempo_prox_partida[ind1] = -TDS[ind1] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[ind1] = DameValor(TDS_a[ind1], TDS_b[ind1]);
                    }
                    else
                    {
                        tiempo_prox_partida[ind1] = -TDS[ind1] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[ind1] = DameValor(TDS_a[ind1], TDS_b[ind1]);
                }

            }

            //Arribo servidor ind2
            if (estado_serv[ind2] == 0)
            {
                nro_cli_comp_dem[ind2] = nro_cli_comp_dem[ind2] + 1;
                TIOS[ind2] = reloj;
                estado_serv[ind2] = 1;
                if (tipo == 'e')
                {
                    tiempo_prox_partida[ind2] = -TDS[ind2] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[ind2] = DameValor(TDS_a[ind2], TDS_b[ind2]);
                    }
                    else
                    {
                        tiempo_prox_partida[ind2] = -TDS[ind2] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[ind2] = DameValor(TDS_a[ind2], TDS_b[ind2]);
                }
            }
            else
            {
                nro_cli_en_cola[ind2] = nro_cli_en_cola[ind2] + 1;
                if (prox == 'b')
                {
                    arriboss2.Add(reloj);
                }
                else if (prox == 'c')
                {
                    arriboss3.Add(reloj);
                }
                else if (prox == 'd')
                {
                    arriboss4.Add(reloj);
                }
                
            }
        }

        public double CantPromClientesColaS(int p)
        {
            return area_bajo_q[p] / reloj;
        }
        public double DemPromedioS(int p)
        {
            return demora_total[p] / nro_cli_comp_dem[p];
        }

        public double UtilServidor(int p)
        {
            if(area_bajo_b[p] == 0)
            {
                return 0;
            }
            else
            { 
                return ((area_bajo_b[p] / reloj))*100;
            }
        }


    }
}
