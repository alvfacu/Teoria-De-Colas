using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabajo_Practico_Simulaicon
{
    class Servidores_paralelos_con_colas_indep
    {
        // Variables globales
        public double reloj, tiempo_prox_arribo, tiempo_ult_evento, TDS, TEA, tea_a, tea_b, tds_a, tds_b;
        public char tipo;
        char tipotea, tipotds;
        public int ind;

        //Variables servidor 1 
        List<double> area_bajo_b = new List<double>();
        List<double> area_bajo_q = new List<double>();
        List<double> tiempo_prox_partida = new List<double>();
        List<double> demora_total = new List<double>();
        List<int>nro_cli_en_cola = new List<int>();
        List<int> nro_cli_comp_dem = new List<int>();
        List<int> estado_serv = new List<int>();
        List<double> arribos_s1 = new List<double> { 0 };
        List<double> arribos_s2 = new List<double> { 0 };
        List<double> arribos_s3 = new List<double> { 0 };
        List<double> TIOS = new List<double>();




        public Servidores_paralelos_con_colas_indep(double tea, double tds)
        {
            tipo = 'e';
            TEA = tea;
            reloj = tiempo_prox_arribo = 0;
            for (int i = 1; i < 4; i++)
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

            tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
            //tiempo_prox_arribo = Exponential.Sample(TEA);
        }

        public char rutinadetiempo()
        {
            //Con el siguiente for e if determino si el proximo evento es una partida y de que servidor es
            double part_min=1000000000;
            bool partida = false;
            for (int i = 1; i <= 4; i++)
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
                for (int i = 1; i <= 4; i++)
                {
                    if (nro_cli_en_cola[i] < cola_min)
                    {
                        ind = i;
                        cola_min = nro_cli_en_cola[i];
                    }
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
                nro_cli_en_cola[ind] = nro_cli_en_cola[ind] + 1;
                switch (ind)
                {

                    case 1:
                        {
                            arribos_s1.Add(reloj);
                            break;
                        }
                    case 2:
                        {
                            arribos_s2.Add(reloj);
                            break;
                        }
                    case 3:
                        {
                            arribos_s3.Add(reloj);
                            break;
                        }
                    default :
                        {
                            break;
                        }

                }
                
            
            }
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




    }
}




