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

namespace Trabajo_Practico_Simulacion.Servidores_Paralelos_con_colas_indep.Exponencial
{
    public partial class form_3spci_exponencial : Form
    {
        string nom_graf = "Exponencial";
        public form_3spci_exponencial()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //int msj = Validar(this.Controls);


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

                for (double i = Convert.ToDouble(txtPmin.Text); i <= max; i = i + 0.1)
                {
                    Servidores_paralelos_con_colas_indep servidores = new Servidores_paralelos_con_colas_indep(0.3, 0.6, int.Parse(txtNroMax.Text), i);


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

                subirBD(cli_cola1, dem_prom1, utilizacion1, cli_cola2, dem_prom2, utilizacion2, cli_cola3, dem_prom3, utilizacion3);

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

        private void subirBD(List<double> cli_cola1, List<double> dem_prom1, List<double> utilizacion1, List<double> cli_cola2, List<double> dem_prom2, List<double> utilizacion2, List<double> cli_cola3, List<double> dem_prom3, List<double> utilizacion3)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=root;persistsecurityinfo=True;database=bd_simulacion");

            try
            {
                conn.Open();

                MySqlCommand cmdTruncate = new MySqlCommand("TRUNCATE 3s_corridas", conn);
                cmdTruncate.ExecuteNonQuery();

                double max = Convert.ToDouble(txtPmax.Text);
                int j = 0;
                for (double i = Convert.ToDouble(txtPmin.Text); i <= max; i = i + 0.1)
                {
                    MySqlCommand cmdSave = new MySqlCommand("INSERT INTO 3s_corridas(corrida,tiempo,CantPromClientesCola_S1,DemPromedio_S1,UtilServidor1,CantPromClientesCola_S2,DemPromedio_S2,UtilServidor2,CantPromClientesCola_S3,DemPromedio_S3,UtilServidor3) " +
                        "VALUES(@corr,@ti,@cli1,@dem1,@uti1,@cli2,@dem2,@uti2,@cli3,@dem3,@uti3)", conn);
                    cmdSave.Parameters.Add("@corr", MySqlDbType.Int32).Value = j + 1;
                    cmdSave.Parameters.Add("@ti", MySqlDbType.Double).Value = i;
                    cmdSave.Parameters.Add("@cli1", MySqlDbType.Double).Value = cli_cola1[j];
                    cmdSave.Parameters.Add("@dem1", MySqlDbType.Double).Value = dem_prom1[j];
                    cmdSave.Parameters.Add("@uti1", MySqlDbType.Double).Value = utilizacion1[j];
                    cmdSave.Parameters.Add("@cli2", MySqlDbType.Double).Value = cli_cola2[j];
                    cmdSave.Parameters.Add("@dem2", MySqlDbType.Double).Value = dem_prom2[j];
                    cmdSave.Parameters.Add("@uti2", MySqlDbType.Double).Value = utilizacion3[j];
                    cmdSave.Parameters.Add("@cli3", MySqlDbType.Double).Value = cli_cola3[j];
                    cmdSave.Parameters.Add("@dem3", MySqlDbType.Double).Value = dem_prom2[j];
                    cmdSave.Parameters.Add("@uti3", MySqlDbType.Double).Value = utilizacion3[j];
                    cmdSave.ExecuteNonQuery();
                    j++;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                conn.Close();
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
