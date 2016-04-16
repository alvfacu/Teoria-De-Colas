using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MathNet.Numerics.Distributions;
namespace Trabajo_Practico_Simulaicon
{
    class ServidorSimple
    {
        public double reloj,area_bajo_b,area_bajo_q,tiempo_prox_arribo,tiempo_prox_partida,demora_total,tiempo_ult_evento,TDS,TEA, TIOS;
        public int nro_cli_en_cola, nro_cli_comp_dem ,estado_serv;

        public double tea_a, tea_b, tds_a, tds_b;

        public char tipo;

        char tipotea, tipotds;
        List<double> arribos = new List<double> {0};

        public ServidorSimple(double tea, double tds)
        {
            tipo = 'e';
            TEA = tea;
            TDS = tds;
            reloj = area_bajo_b = area_bajo_q = tiempo_prox_arribo = tiempo_prox_partida = TIOS = 0;
            nro_cli_en_cola = nro_cli_comp_dem = estado_serv = 0;
            tiempo_prox_arribo = - TEA * Math.Log(NrosAleatorios.DameNro());
            //tiempo_prox_arribo = Exponential.Sample(TEA);
            tiempo_prox_partida = 10000000000;
        }

        public ServidorSimple(char ttea, List<double> tea , char ttds , List<double> tds)
        {    
            tipotea = ttea;
            tipotds = ttds;
            
            if (tipotea == 'u')
            {               
                tea_a = tea[0];
                tea_b = tea[1];
                tipo = tipotea;

                if (tipotds == 'e')
                {
                    TDS = tds[0];
                }
                else
                {
                    tds_a = tds[0];
                    tds_b = tds[1];
                }
            }
            else if (tipotds == 'u')
            {
                tds_a = tds[0];
                tds_b = tds[1];
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
            reloj = area_bajo_b = area_bajo_q = tiempo_prox_arribo = tiempo_prox_partida = TIOS = 0;
            nro_cli_en_cola = nro_cli_comp_dem = estado_serv = 0;
            if(tipotea != 'e')
            { 
                tiempo_prox_arribo = DameValor(tea_a, tea_b);
            }
            else
            {
                tiempo_prox_arribo = - TEA * Math.Log(NrosAleatorios.DameNro());
            }
            //tiempo_prox_arribo = - tea_a * Math.Log(NrosAleatorios.DameNro());
            tiempo_prox_partida = 10000000000;
            tipo = 'd';
        }

        public ServidorSimple(char t, List<double> tea, List<double> tds)
        {
            tipo = t;
            tea_a = tea[0];
            tea_b = tea[1];
            tds_a = tds[0];
            tds_b = tds[1];

            reloj = area_bajo_b = area_bajo_q = tiempo_prox_arribo = tiempo_prox_partida = TIOS = 0;
            nro_cli_en_cola = nro_cli_comp_dem = estado_serv = 0;
            tiempo_prox_arribo = DameValor(tea_a,tea_b);
            //tiempo_prox_arribo = - tea_a * Math.Log(NrosAleatorios.DameNro());
            tiempo_prox_partida = 10000000000;
        }
        
        private double DameValor(double a, double b)
        {
            double valor = 0;
            switch (tipo)
            {
                case ('e'):
                    {
                        valor = - a * Math.Log(NrosAleatorios.DameNro());
                        break;
                    }
                case ('u'):
                    {
                        valor = (a + (b - a) * NrosAleatorios.DameNro());
                        break;
                    }
                case ('w'):
                    {
                        valor = - Math.Log(NrosAleatorios.DameNro());
                        valor = Math.Pow(valor, 1 / b);
                        valor = a * valor;
                        break;
                    }
                default:
                    {
                        valor = 0;
                        break;
                    }
            }
            return valor;
        }
        
        public char rutinadetiempo()
        {
            if(tiempo_prox_arribo<tiempo_prox_partida)
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_arribo;
                return ('a');
            }
            else
            {
                tiempo_ult_evento = reloj;
                reloj = reloj + tiempo_prox_partida;
                return ('p');
            }
        }

        public void arribo()
        {
            if(tipo == 'e')
            {
                tiempo_prox_arribo = -TEA * Math.Log(NrosAleatorios.DameNro());
                //tiempo_prox_arribo = Exponential.Sample(TEA);
            }
            else if (tipo=='d')
            {
                tipo = tipotea;
                if(tipo != 'e')
                { 
                    tiempo_prox_arribo = DameValor(tea_a,tea_b);
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
            if (estado_serv==0)
            {
                TIOS = reloj;
                nro_cli_comp_dem = nro_cli_comp_dem + 1;
                estado_serv = 1;
                if(tipo == 'e')
                { 
                    tiempo_prox_partida = - TDS * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida = Exponential.Sample(TDS);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida = DameValor(tds_a, tds_b);
                    }
                    else
                    {
                        tiempo_prox_partida = -TDS * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida = DameValor(tds_a, tds_b);
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
                estado_serv = 0;
                area_bajo_b = area_bajo_b + (reloj - TIOS);
                tiempo_prox_partida = 1000000000;
            }
            else
            {
                demora_total = demora_total + (reloj - arribos[1]);
                area_bajo_q = area_bajo_q + (nro_cli_en_cola * (reloj - tiempo_ult_evento));
                arribos.Remove(arribos[1]);
                nro_cli_en_cola = nro_cli_en_cola - 1;
                nro_cli_comp_dem = nro_cli_comp_dem + 1;
                if (tipo == 'e')
                {
                    tiempo_prox_partida = -TDS * Math.Log(NrosAleatorios.DameNro());
                    //tiempo_prox_partida = Exponential.Sample(TDS);
                }
                else if (tipo == 'd')
                {
                    tipo = tipotds;
                    if (tipo != 'e')
                    {
                        tiempo_prox_partida = DameValor(tds_a, tds_b);
                    }
                    else
                    {
                        tiempo_prox_partida = -TDS * Math.Log(NrosAleatorios.DameNro());
                    }
                    tipo = 'd';
                }
                else
                {
                    tiempo_prox_partida = DameValor(tds_a, tds_b);
                }
            }
        }

        public double CantPromClientesCola
        {
            get { return area_bajo_q / reloj; }
        }

        public double DemPromedio
        {
            get { return demora_total / nro_cli_comp_dem; }
        }

        public double UtilServidor
        {
            get { return ((area_bajo_b / reloj))*100; }
        }

    }
}
