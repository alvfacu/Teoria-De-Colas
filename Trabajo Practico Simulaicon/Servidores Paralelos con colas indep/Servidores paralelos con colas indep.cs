using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_Practico_Simulaicon
{
    class Servidores_paralelos_con_colas_indep
    {
        // Variables globales
        public double reloj, tiempo_prox_arribo, tiempo_ult_evento, TDS, TEA, tea_a, tea_b, tds_a, tds_b, prob_cambio;
        public char tipo;
        char tipotea, tipotds;
        public int ind, nro_cli_max;

        //Variables servidores 
        List<double> area_bajo_b = new List<double>();
        List<double> area_bajo_q = new List<double>();
        List<double> tiempo_prox_partida = new List<double>();
        List<double> demora_total = new List<double>();
        //List<int>nro_cli_en_cola = new List<int>();
        List<int> nro_cli_comp_dem = new List<int>();
        List<int> estado_serv = new List<int>();
        List<double> arribos_s1 = new List<double>();
        List<double> arribos_s2 = new List<double>();
        List<double> arribos_s3 = new List<double>();
        List<double> TIOS = new List<double>();

        public Servidores_paralelos_con_colas_indep(double tea, double tds, int nro_max, double prob)
        {
            tipo = 'e';
            prob_cambio = prob;
            nro_cli_max = nro_max;
            TDS = tds;
            TEA = tea;
            reloj = tiempo_prox_arribo = 0;
            for (int i = 0; i < 3; i++)
            {
                area_bajo_b.Add(0);
                area_bajo_q.Add(0);
                tiempo_prox_partida.Add(10000000000);
                demora_total.Add(0);
                //nro_cli_en_cola.Add(0);
                nro_cli_comp_dem.Add(0);
                estado_serv.Add(0);
                TIOS.Add(0);
            }

            tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
            //tiempo_prox_arribo = Exponential.Sample(TEA);
        }

        public char rutinadetiempo()
        {
            //Con el siguiente for e if determino si el proximo evento es una partida y de que servidor es
            double part_min = 1000000000;
            bool partida = false;
            for (int i = 0; i < 3; i++)
            {
                if (tiempo_prox_arribo > tiempo_prox_partida[i])
                {
                    if (tiempo_prox_partida[i] < part_min)
                    {

                        ind = i;
                        part_min = tiempo_prox_partida[i];
                    }
                    partida = true;
                }
            }
            if (partida)
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida[ind];
                return ('p');
            }
            else
            {
                //con el siguiente for e if determino a que servidor le corresponde el siguiente arribo 
                int cola_min = 10000;
                /*for (int i = 0; i < 3; i++)
                {
                    if ((estado_serv[i]==0) && nro_cli_en_cola[i] < cola_min)
                    {
                        ind = i;
                        cola_min = nro_cli_en_cola[i];
                    }
                }*/

                if ((estado_serv[0] == 0) && arribos_s1.Count() < cola_min)
                {
                    ind = 0;
                    cola_min = arribos_s1.Count();
                }
                else if ((estado_serv[1] == 0) && arribos_s2.Count() < cola_min)
                {
                    ind = 1;
                    cola_min = arribos_s2.Count();
                }
                else
                {
                    ind = 2;
                    cola_min = arribos_s3.Count();
                }


                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_arribo;
                return ('a');
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

            if (estado_serv[ind] == 0)
            {
                TIOS[ind] = reloj;
                nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;
                estado_serv[ind] = 1;

                if (tipo == 'e')
                {
                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                    }
                    else
                    {
                        tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                }
            }
            else
            {
                //nro_cli_en_cola[ind] = nro_cli_en_cola[ind] + 1;
                switch (ind)
                {

                    case 0:
                        {
                            arribos_s1.Add(reloj);
                            break;
                        }
                    case 1:
                        {
                            arribos_s2.Add(reloj);
                            break;
                        }
                    case 2:
                        {
                            arribos_s3.Add(reloj);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }
        }

        public void partida()
        {
            switch (ind)
            {
                case 0:
                    {
                        if (arribos_s1.Count() == 0)
                        {
                            estado_serv[ind] = 0;
                            area_bajo_b[ind] = area_bajo_b[ind] + (reloj - TIOS[ind]);
                            tiempo_prox_partida[ind] = 1000000000;
                        }
                        else
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s1[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (/*nro_cli_en_cola[ind]*/arribos_s1.Count() * (reloj - tiempo_ult_evento));
                            arribos_s1.Remove(arribos_s1[0]);
                            //nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                        }
                        break;
                    }
                case 1:
                    {
                        if (arribos_s2.Count() == 0)
                        {
                            estado_serv[ind] = 0;
                            area_bajo_b[ind] = area_bajo_b[ind] + (reloj - TIOS[ind]);
                            tiempo_prox_partida[ind] = 1000000000;
                        }
                        else
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s2[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (/*nro_cli_en_cola[ind]*/arribos_s2.Count() * (reloj - tiempo_ult_evento));
                            arribos_s2.Remove(arribos_s2[0]);
                            //nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (arribos_s3.Count() == 0)
                        {
                            estado_serv[ind] = 0;
                            area_bajo_b[ind] = area_bajo_b[ind] + (reloj - TIOS[ind]);
                            tiempo_prox_partida[ind] = 1000000000;
                        }
                        else
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s3[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (/*nro_cli_en_cola[ind]*/arribos_s3.Count() * (reloj - tiempo_ult_evento));
                            arribos_s3.Remove(arribos_s3[0]);
                            //nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                        }
                        break;
                    }
            }
            /*
            if (nro_cli_en_cola[ind] == 0)
            {
                estado_serv[ind] = 0;
                area_bajo_b[ind] = area_bajo_b[ind] + (reloj - TIOS[ind]);
                tiempo_prox_partida[ind] = 1000000000;
                //paso[ind] = false;
            }
            else
            {
                switch (ind)
                {
                    case 0:
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s1[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (nro_cli_en_cola[ind] * (reloj - tiempo_ult_evento));
                            arribos_s1.Remove(arribos_s1[0]);
                            nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                            break;
                        }
                    case 1:
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s2[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (nro_cli_en_cola[ind] * (reloj - tiempo_ult_evento));
                            arribos_s2.Remove(arribos_s2[0]);
                            nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                            break;
                        }
                    case 2:
                        {
                            demora_total[ind] = demora_total[ind] + (reloj - arribos_s3[0]);
                            area_bajo_q[ind] = area_bajo_q[ind] + (nro_cli_en_cola[ind] * (reloj - tiempo_ult_evento));
                            arribos_s3.Remove(arribos_s3[0]);
                            nro_cli_en_cola[ind] = nro_cli_en_cola[ind] - 1;
                            nro_cli_comp_dem[ind] = nro_cli_comp_dem[ind] + 1;

                            if (tipo == 'e')
                            {
                                tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                //tiempo_prox_partida[ind] = Exponential.Sample(TDS[ind]);
                            }
                            else if (tipo == 'd')
                            {
                                tipo = tipotds;
                                if (tipo != 'e')
                                {
                                    tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                                }
                                else
                                {
                                    tiempo_prox_partida[ind] = -TDS * Math.Log(NrosAleatorios.DameNro());
                                }
                                tipo = 'd';
                            }
                            else
                            {
                                tiempo_prox_partida[ind] = DameValor(tds_a, tds_b);
                            }
                            break;
                        }
                }
            }*/
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
            return ((area_bajo_b[p] / reloj)) * 100;
        }

        public void cambio()
        {
            int nro_cli_en_cola_max = 0;
            int cola_min = 1000;
            int indsal = 0;
            /*for (int i = 0; i < 3; i++)
            {
                if(nro_cli_en_cola[i]>nro_cli_max)
                {
                    if(nro_cli_en_cola[i]>nro_cli_en_cola_max)
                    {
                        nro_cli_en_cola_max = nro_cli_en_cola[i];
                        indsal = i;
                    }
                } 
            }*/

            if (arribos_s1.Count() > nro_cli_max)
            {
                if (arribos_s1.Count() > nro_cli_en_cola_max)
                {
                    nro_cli_en_cola_max = arribos_s1.Count();
                    indsal = 0;
                }
            }
            else if (arribos_s2.Count() > nro_cli_max)
            {
                if (arribos_s2.Count() > nro_cli_en_cola_max)
                {
                    nro_cli_en_cola_max = arribos_s2.Count();
                    indsal = 1;
                }
            }
            else /*(arribos_s3.Count() > nro_cli_max)*/
            {
                if (arribos_s3.Count() > nro_cli_en_cola_max)
                {
                    nro_cli_en_cola_max = arribos_s3.Count();
                    indsal = 2;
                }
            }

            if (nro_cli_en_cola_max != 0)
            {
                double nro = NrosAleatorios.DameNro();
                if (nro <= prob_cambio)
                {
                    /*for (int i = 0; i < 3; i++)
                    {
                        if (nro_cli_en_cola[i] < cola_min)
                        {
                            cola_min = nro_cli_en_cola[i];
                            ind = i;
                        }
                    }*/

                    if (arribos_s1.Count() < cola_min)
                    {
                        cola_min = arribos_s1.Count();
                        ind = 0;
                    }
                    else if (arribos_s2.Count() < cola_min)
                    {
                        cola_min = arribos_s2.Count();
                        ind = 1;
                    }
                    else
                    {
                        cola_min = arribos_s3.Count();
                        ind = 2;
                    }
                }
                switch (indsal)
                {
                    case 0:
                        {
                            arribo();
                            arribos_s1.Remove(arribos_s1[arribos_s1.Count - 1]);
                            break;
                        }
                    case 1:
                        {
                            arribo();
                            arribos_s2.Remove(arribos_s2[arribos_s2.Count - 1]);
                            break;
                        }
                    case 2:
                        {
                            arribo();
                            arribos_s3.Remove(arribos_s3[arribos_s3.Count - 1]);
                            break;
                        }
                }
            }
        }

    }
}




