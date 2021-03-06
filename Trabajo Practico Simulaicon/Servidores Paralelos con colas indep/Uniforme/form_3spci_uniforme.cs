﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Trabajo_Practico_Simulaicon;

namespace Trabajo_Practico_Simulacion.Servidores_Paralelos_con_colas_indep
{
    public partial class form_3spci_uniforme : Form
    {
        string nom_graf = "Uniforme";
        public form_3spci_uniforme()
        {
            InitializeComponent();
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            int msj = Validar(this.Controls);
            if (msj == 0)
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
                    Servidores_paralelos_con_colas_indep servidores = new Servidores_paralelos_con_colas_indep('u', 0.1, 0.4, 0.1, 0.4, int.Parse(txtNroMax.Text), i);

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
                        mensaje = "Las probabilidades deben ser números decimales menores a 1.";
                        break;
                    case (4):
                        mensaje = "La probabilidad mínima debe ser menor a la probabilidad máxima.";
                        break;
                    case (5):
                        mensaje = "Las probabilidades no deben ser mayores a 1.";
                        break;
                    case (6):
                        mensaje = "El número máximo de clientes en cola debe ser un número entero positivo.";
                        break;
                    default: break;

                }
                MessageBox.Show(mensaje, "¡ Atención !", MessageBoxButtons.OK);
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
            double res;
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
                if (txtPmin.Text.Contains("."))
                {
                    txtPmin.Text = txtPmin.Text.Replace('.', ',');
                }
                if (txtPmax.Text.Contains("."))
                {
                    txtPmax.Text = txtPmax.Text.Replace('.', ',');
                }
                if (!(Double.TryParse(txtPmin.Text, out res)) || !(Double.TryParse(txtPmax.Text, out res)))
                {
                    msj = 3; // Las probabilidades deben ser números decimales menores a 1.
                }
                else if ((Convert.ToDouble(txtPmin.Text) > Convert.ToDouble(txtPmax.Text)))
                {
                    msj = 4; // La probabilidad mínima debe ser menor a la probabilidad máxima.
                }
                else if ((Convert.ToDouble(txtPmin.Text) > 1 || Convert.ToDouble(txtPmax.Text) > 1))
                {
                    msj = 5; // Las probabilidades no deben ser mayores a 1.
                }
                if (!(Int32.TryParse(txtNroMax.Text, out result)))
                {
                    msj = 6; // El número máximo de clientes en cola debe ser un número entero positivo.
                }
            }

            return msj;
        }
    }
}
