using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Trabajo_Practico_Simulacion;
using Trabajo_Practico_Simulaicon;

namespace Trabajo_Practico_Simulacion.Servidor_Simple
{
    public partial class form_ss_comparativa : Form
    {
        List<double> tds;
        List<double> tea;

        public form_ss_comparativa()
        {
            InitializeComponent();
        }

        private void form_ss_comparativa_Load(object sender, EventArgs e)
        {
            Simular();
        }

        private void Simular()
        {
            for(int i=0;i<3;i++)
            {
                cant_cli_cola.Series[i].Points.Clear();
                dem_prom.Series[i].Points.Clear();
                utilizacion.Series[i].Points.Clear();
            }                      

            NrosAleatorios.GenerarNros(100);
    
            #region Exponencial 0.3

            ServidorSimple ServidorSimple_Exp = new ServidorSimple(0.3, 0.3);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            DataPoint punto = new DataPoint(0.3, ServidorSimple_Exp.CantPromClientesCola);
            cant_cli_cola.Series[0].Points.Add(punto);
            dem_prom.Series[0].Points.Add(new DataPoint(0.3, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[0].Points.Add(new DataPoint(0.3, ServidorSimple_Exp.UtilServidor));

            #endregion 

            NrosAleatorios.ReiniciarR();

            #region Uniforme 0.3
            
            #endregion
            
            NrosAleatorios.ReiniciarR();

            #region Weibull 0.3
            tea = new List<double>() { 0.3, 0.3 };
            tds = new List<double>() { 0.3, 0.3 };
            ServidorSimple_Exp = new ServidorSimple('w', tea, tds);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            cant_cli_cola.Series[2].Points.Add(new DataPoint(0.3, ServidorSimple_Exp.CantPromClientesCola));
            dem_prom.Series[2].Points.Add(new DataPoint(0.3, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[2].Points.Add(new DataPoint(0.3, ServidorSimple_Exp.UtilServidor));
            #endregion

            NrosAleatorios.ReiniciarR();
            
            #region Exponencial 0.5
            ServidorSimple_Exp = new ServidorSimple(0.5, 0.5);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            punto = new DataPoint(0.5, ServidorSimple_Exp.CantPromClientesCola);
            cant_cli_cola.Series[0].Points.Add(punto);
            dem_prom.Series[0].Points.Add(new DataPoint(0.5, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[0].Points.Add(new DataPoint(0.5, ServidorSimple_Exp.UtilServidor));

            #endregion

            NrosAleatorios.ReiniciarR();

            #region Uniforme 0.5

            #endregion

            NrosAleatorios.ReiniciarR();

            #region Weibull 0.5
            tea = new List<double>() { 0.5, 0.5 };
            tds = new List<double>() { 0.5, 0.5 };
            ServidorSimple_Exp = new ServidorSimple('w', tea, tds);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            cant_cli_cola.Series[2].Points.Add(new DataPoint(0.5, ServidorSimple_Exp.CantPromClientesCola));
            dem_prom.Series[2].Points.Add(new DataPoint(0.5, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[2].Points.Add(new DataPoint(0.5, ServidorSimple_Exp.UtilServidor));
            #endregion

            NrosAleatorios.ReiniciarR();

            #region Exponencial 0.7
            ServidorSimple_Exp = new ServidorSimple(0.7, 0.7);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            punto = new DataPoint(0.7, ServidorSimple_Exp.CantPromClientesCola);
            cant_cli_cola.Series[0].Points.Add(punto);
            dem_prom.Series[0].Points.Add(new DataPoint(0.7, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[0].Points.Add(new DataPoint(0.7, ServidorSimple_Exp.UtilServidor));
            #endregion

            NrosAleatorios.ReiniciarR();
            
            #region Uniforme 0.7

            #endregion

            NrosAleatorios.ReiniciarR();

            #region Weibull 0.7
            tea = new List<double>() { 0.7, 0.7 };
            tds = new List<double>() { 0.7, 0.7 };
            ServidorSimple_Exp = new ServidorSimple('w', tea, tds);
            while (ServidorSimple_Exp.reloj < Convert.ToDouble(100))
            {
                char proximo_evento = ServidorSimple_Exp.rutinadetiempo();
                if (proximo_evento == 'a')
                {
                    ServidorSimple_Exp.arribo();
                }
                else
                {
                    ServidorSimple_Exp.partida();
                }
            }
            cant_cli_cola.Series[2].Points.Add(new DataPoint(0.7, ServidorSimple_Exp.CantPromClientesCola));
            dem_prom.Series[2].Points.Add(new DataPoint(0.7, ServidorSimple_Exp.DemPromedio));
            utilizacion.Series[2].Points.Add(new DataPoint(0.7, ServidorSimple_Exp.UtilServidor));
            #endregion                     

            NrosAleatorios.ReiniciarN();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simular();
        }
    }
}
