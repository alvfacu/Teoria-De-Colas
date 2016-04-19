using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico_Simulaicon;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Trabajo_Practico_Simulacion.Servidores_Paralelos_con_colas_indep.Uniforme
{
    public partial class form_3spci_weibull : Form
    {
        string nom_graf = "Weibull";
        public form_3spci_weibull()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            if (/*msj == 0*/true)
            {
                cli_en_cola_s1.Series.Clear();
                cli_en_cola_s2.Series.Clear();
                cli_en_cola_s3.Series.Clear();

                dem_prom_cli_s1.Series.Clear();
                dem_prom_cli_s2.Series.Clear();
                dem_prom_cli_s3.Series.Clear();

                utilizacion_serv1.Series.Clear();
                utilizacion_serv2.Series.Clear();
                utilizacion_serv3.Series.Clear();

                List<double> cli_cola1 = new List<double>();
                List<double> dem_prom1 = new List<double>();
                List<double> utilizacion1 = new List<double>();

                List<double> cli_cola2 = new List<double>();
                List<double> dem_prom2 = new List<double>();
                List<double> utilizacion2 = new List<double>();

                List<double> cli_cola3 = new List<double>();
                List<double> dem_prom3 = new List<double>();
                List<double> utilizacion3 = new List<double>();

                cli_en_cola_s1.Series.Add(nom_graf);
                cli_en_cola_s1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola_s1.Series[nom_graf].Color = Color.Green;
                cli_en_cola_s1.Series[nom_graf].BorderWidth = 3;

                cli_en_cola_s2.Series.Add(nom_graf);
                cli_en_cola_s2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola_s2.Series[nom_graf].Color = Color.Green;
                cli_en_cola_s2.Series[nom_graf].BorderWidth = 3;

                cli_en_cola_s3.Series.Add(nom_graf);
                cli_en_cola_s3.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola_s3.Series[nom_graf].Color = Color.Green;
                cli_en_cola_s3.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli_s1.Series.Add(nom_graf);
                dem_prom_cli_s1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli_s1.Series[nom_graf].Color = Color.Red;
                dem_prom_cli_s1.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli_s2.Series.Add(nom_graf);
                dem_prom_cli_s2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli_s2.Series[nom_graf].Color = Color.Red;
                dem_prom_cli_s2.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli_s3.Series.Add(nom_graf);
                dem_prom_cli_s3.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli_s3.Series[nom_graf].Color = Color.Red;
                dem_prom_cli_s3.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv1.Series.Add(nom_graf);
                utilizacion_serv1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv1.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv1.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv2.Series.Add(nom_graf);
                utilizacion_serv2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv2.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv2.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv3.Series.Add(nom_graf);
                utilizacion_serv3.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv3.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv3.Series[nom_graf].BorderWidth = 3;

                NrosAleatorios.GenerarNros(Convert.ToInt32(txtHs.Text));

                double max = Convert.ToDouble(txtPmax.Text);

                for (double i = Convert.ToDouble(txtPmin.Text); i <= max; i = i + 0.05)
                {
                    Servidores_paralelos_con_colas_indep servidores = new Servidores_paralelos_con_colas_indep('w',0.1,0.5,0.6,0.9,int.Parse(txtNroMax.Text),i);

                    while (servidores.reloj < Convert.ToDouble(txtHs.Text))
                    {
                        char proximo_evento = servidores.rutinadetiempo();
                        if (proximo_evento == 'a')
                        {
                            servidores.arribo();
                            servidores.cambio();
                        }
                        else
                        {
                            servidores.partida();
                        }
                    }

                    cli_en_cola_s1.Series[nom_graf].Points.Add(new DataPoint(i, servidores.CantPromClientesColaS(0)));
                    cli_en_cola_s2.Series[nom_graf].Points.Add(new DataPoint(i, servidores.CantPromClientesColaS(1)));
                    cli_en_cola_s3.Series[nom_graf].Points.Add(new DataPoint(i, servidores.CantPromClientesColaS(2)));
                    cli_cola1.Add(servidores.CantPromClientesColaS(0));
                    cli_cola2.Add(servidores.CantPromClientesColaS(1));
                    cli_cola3.Add(servidores.CantPromClientesColaS(2));

                    dem_prom_cli_s1.Series[nom_graf].Points.Add(new DataPoint(i, servidores.DemPromedioS(0)));
                    dem_prom_cli_s2.Series[nom_graf].Points.Add(new DataPoint(i, servidores.DemPromedioS(1)));
                    dem_prom_cli_s3.Series[nom_graf].Points.Add(new DataPoint(i, servidores.DemPromedioS(2)));
                    dem_prom1.Add(servidores.DemPromedioS(0));
                    dem_prom2.Add(servidores.DemPromedioS(1));
                    dem_prom3.Add(servidores.DemPromedioS(2));

                    utilizacion_serv1.Series[nom_graf].Points.Add(new DataPoint(i, servidores.UtilServidor(0)));
                    utilizacion_serv2.Series[nom_graf].Points.Add(new DataPoint(i, servidores.UtilServidor(1)));
                    utilizacion_serv3.Series[nom_graf].Points.Add(new DataPoint(i, servidores.UtilServidor(2)));
                    utilizacion1.Add(servidores.UtilServidor(0));
                    utilizacion2.Add(servidores.UtilServidor(1));
                    utilizacion3.Add(servidores.UtilServidor(2));

                    NrosAleatorios.ReiniciarR();
                }


                cli_en_cola_s1.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola1) * 1.2;
                dem_prom_cli_s1.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom1) * 1.2;
                utilizacion_serv1.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion1) * 1.2;

                cli_en_cola_s2.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola2) * 1.2;
                dem_prom_cli_s2.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom2) * 1.2;
                utilizacion_serv2.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion2) * 1.2;

                cli_en_cola_s3.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola3) * 1.2;
                dem_prom_cli_s3.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom3) * 1.2;
                utilizacion_serv3.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion3) * 1.2;

                NrosAleatorios.ReiniciarN();
            }
            else
            {
                /*
                string mensaje = null;
                switch (msj)
                {
                    case (1):
                        mensaje = "Existen campos vacíos.";
                        break;
                    case (2):
                        mensaje = "Verifique el formato las horas: deben ser enteras.";
                        break;
                    case (3):
                        mensaje = "El TDS tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (4):
                        mensaje = "El TEA tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (5):
                        mensaje = "El TDS tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (6):
                        mensaje = "El TEA tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (7):
                        mensaje = "Debe ingresar un TEA o un TDS";
                        break;
                    default: break;

                }
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK);
                */
            }
        }
        
        private double DameMaximo(List<double> valores)
        {

            valores.Sort();
            return valores[valores.Count() - 1];
        }

        private int Validar(Control.ControlCollection controls)
        {
            int result;
            //double res;
            int msj = 0;
            bool est = false;
            foreach (Control c in controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    msj = 1;
                    est = true;
                    break;
                }
            }
            if (!est)
            {
                if (!(Int32.TryParse(txtHs.Text, out result)))
                {
                    msj = 2;
                }

                else
                {
                    msj = 7;
                }

            }

            return msj;
        }
    }
}
