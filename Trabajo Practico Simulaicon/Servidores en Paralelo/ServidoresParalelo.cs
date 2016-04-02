using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Distributions;

namespace Trabajo_Practico_Simulaicon
{
    class ServidoresParalelo
    {
        public double reloj, tiempo_prox_arribo, tiempo_ult_evento, TEA, TEA_a, TEA_b;
        public int cantidad, ind;
        char tipo;
        char tipotea, tipotds;
        List<double> TDS_a = new List<double>();
        List<double> TDS_b = new List<double>();
        
        List<bool> paso = new List<bool> { false, false, false, false, false };
        List<double> area_bajo_b = new List<double>();
        List<double> area_bajo_q = new List<double>();
        List<double> tiempo_prox_partida = new List<double>();
        List<double> demora_total = new List<double>();
        List<double> TDS = new List<double>();
        int nro_cli_en_cola;
        List<int> nro_cli_comp_dem = new List<int>();
        List<int> estado_serv = new List<int>();
        List<double> TIOS = new List<double>();
        List<double> arribos = new List<double> { 0 };

        public ServidoresParalelo(int c, double tea, List<double> tds)
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
                nro_cli_en_cola = 0;
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }
            
            tiempo_prox_arribo = - TEA * Math.Log(NrosAleatorios.DameNro());
            //tiempo_prox_arribo = Exponential.Sample(TEA);
        }

        public ServidoresParalelo()
        {
            // TODO: Complete member initialization
        }

        public ServidoresParalelo(char t, int c, List<double> tea, List<double> tds_a, List<double> tds_b)
        {
            tipo = t;
            cantidad = c + 1;
            reloj = tiempo_prox_arribo = 0;
            TEA_a = tea[0];
            TEA_b = tea[1];

            for (int i = 0; i < cantidad; i++)
            {
                TDS_a.Add(tds_a[i]);
                TDS_b.Add(tds_b[i]);

                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                nro_cli_en_cola = 0;
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }
            tiempo_prox_arribo = DameValor(TEA_a, TEA_b);
            //tiempo_prox_arribo = Exponential.Sample(TEA);
        }

        public ServidoresParalelo(int cant, char ttea, List<double> tea, char ttds, List<double> tds)
        {
            cantidad = cant + 1;
            tipotea = ttea;
            tipotds = ttds;

            if (tipotea == 'u')
            {
                TEA_a = tea[0];
                TEA_b = tea[1];
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
                    if(i==0)
                    {
                        TDS_a.Add(tds[i]);
                    }
                    else
                    {
                        if(i % 2 == 0)
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
                    TEA_a = tea[0];
                    TEA_b = tea[1];
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                nro_cli_en_cola = 0;
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }     
            
            if (tipotea != 'e')
            {
                tiempo_prox_arribo = DameValor(TEA_a, TEA_b);
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
            char tipo = ' ';
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (estado_serv[j] == 0)
                    {
                        tiempo_ult_evento = reloj;
                        reloj = reloj + tiempo_prox_arribo;
                        ind = j;
                        tipo = 'a';
                        break;
                    }
                }

                //Asignamos al primer menor que encuentre
                if (tipo != 'a' && tiempo_prox_arribo < tiempo_prox_partida[i])
                {
                    tiempo_ult_evento = reloj;
                    reloj = reloj + tiempo_prox_arribo;
                    ind = i;
                    tipo = 'a';
                    break;
                }
                
            }
            if (tipo != 'a')
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (tiempo_prox_arribo >= tiempo_prox_partida[i] && !(paso[i]))
                    {
                        paso[i] = true;
                        tiempo_ult_evento = reloj;
                        reloj = reloj + tiempo_prox_partida[i];
                        ind = i;
                        tipo = 'p';
                        break;
                    }
                }                
            }
            
            return tipo;
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
                    tiempo_prox_arribo = DameValor(TEA_a, TEA_b);
                }
                else
                {
                    tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
                }
                tipo = 'd';
            }
            else
            {
                tiempo_prox_arribo = DameValor(TEA_a, TEA_b);
                //tiempo_prox_arribo = -tea_a * Math.Log(NrosAleatorios.DameNro());
            }
            
            if (estado_serv[ind]==0)
            {
                TIOS[ind] = reloj;
                nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;
                estado_serv[ind] = 1;

                if (tipo == 'e')
                {
                    tiempo_prox_partida[ind] = -TDS[ind] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[ind] = DameValor(TDS_a[ind], TDS_b[ind]);
                    }
                    else
                    {
                        tiempo_prox_partida[ind] = -TDS[ind] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[ind] = DameValor(TDS_a[ind], TDS_b[ind]);
                }
            }
            else
            {
                nro_cli_en_cola = nro_cli_en_cola + 1;
                arribos.Add(reloj);
            } 
        }

        public void partida()
        {
            if (nro_cli_en_cola == 0)
            {
                estado_serv[ind] = 0;
                area_bajo_b[ind] = area_bajo_b[ind] + (reloj - TIOS[ind]);
                tiempo_prox_partida[ind] = 1000000000;
                paso[ind] = false;
            }
            else
            {
                demora_total[ind] = demora_total[ind] + (reloj - arribos[1]);
                area_bajo_q[ind] = area_bajo_q[ind] + (nro_cli_en_cola * (reloj - tiempo_ult_evento));
                arribos.Remove(arribos[1]);
                nro_cli_en_cola = nro_cli_en_cola - 1;
                nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                if (tipo == 'e')
                {
                    tiempo_prox_partida[ind] = -TDS[ind] * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[ind] = DameValor(TDS_a[ind], TDS_b[ind]);
                    }
                    else
                    {
                        tiempo_prox_partida[ind] = -TDS[ind] * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[ind] = DameValor(TDS_a[ind], TDS_b[ind]);
                }

            }
        }

        public double CantPromClientesColaS(int p)
        {
            return area_bajo_q[p] / reloj;
        }

        public double DemPromedioS(int p)
        {
            return demora_total[p] / nro_cli_comp_dem[p] ;
        }

        public double UtilServidor(int p)
        {
            return ((area_bajo_b[p] / reloj))*100;
        }
    }
}
