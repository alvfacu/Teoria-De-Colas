using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Trabajo_Practico_Simulaicon;

namespace Trabajo_Practico_Simulacion.Servidores_en_Serie.Uniforme
{
    public partial class form_2ss_uniforme : Form
    {
        int c;
        double[] tiempos = { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };
        string nom_graf = "Uniforme";
        List<double> TEA;
        List<double> TDS;

        List<double> cli_cola1;
        List<double> dem_prom1;
        List<double> utilizacion1;

        List<double> cli_cola2;
        List<double> dem_prom2;
        List<double> utilizacion2;

        public form_2ss_uniforme()
        {
            InitializeComponent();

        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            //int msj = Validar(this.Controls);
            int msj = 0;
            if (msj == 0)
            {
                c = form_cantidadservidores.nro + 1;

                cli_en_cola_s1.Series.Clear();
                cli_en_cola_s2.Series.Clear();

                dem_prom_cli_s1.Series.Clear();
                dem_prom_cli_s2.Series.Clear();

                utilizacion_serv1.Series.Clear();
                utilizacion_serv2.Series.Clear();

                cli_cola1 = new List<double>();
                dem_prom1 = new List<double>();
                utilizacion1 = new List<double>();

                cli_cola2 = new List<double>();
                dem_prom2 = new List<double>();
                utilizacion2 = new List<double>();

                cli_en_cola_s1.Series.Add(nom_graf);
                cli_en_cola_s1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola_s1.Series[nom_graf].Color = Color.Green;
                cli_en_cola_s1.Series[nom_graf].BorderWidth = 3;

                cli_en_cola_s2.Series.Add(nom_graf);
                cli_en_cola_s2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola_s2.Series[nom_graf].Color = Color.Green;
                cli_en_cola_s2.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli_s1.Series.Add(nom_graf);
                dem_prom_cli_s1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli_s1.Series[nom_graf].Color = Color.Red;
                dem_prom_cli_s1.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli_s2.Series.Add(nom_graf);
                dem_prom_cli_s2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli_s2.Series[nom_graf].Color = Color.Red;
                dem_prom_cli_s2.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv1.Series.Add(nom_graf);
                utilizacion_serv1.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv1.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv1.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv2.Series.Add(nom_graf);
                utilizacion_serv2.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv2.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv2.Series[nom_graf].BorderWidth = 3;

                NrosAleatorios.GenerarNros(Convert.ToInt32(txtHs.Text));

                for (int i = 0; i < tiempos.Length; i++)
                {
                    ServidoresSerie MultiplesServidores;
                    TEA = new List<double>();
                    TDS = new List<double>();

                    if (chkArribo.Checked == true)
                    {
                        if (txtTEA_a.Text.Contains("."))
                        {
                            txtTEA_a.Text = txtTEA_a.Text.Replace('.', ',');
                        }
                        if (txtTEA_b.Text.Contains("."))
                        {
                            txtTEA_b.Text = txtTEA_b.Text.Replace('.', ',');
                        }

                        TEA.Add(Convert.ToDouble(txtTEA_a.Text));
                        TEA.Add(Convert.ToDouble(txtTEA_b.Text));
                        if (cbxDTDS.SelectedItem.ToString() == "Exponencial")
                        {
                            TDS.Add(tiempos[i]);
                            TDS.Add(tiempos[i]);
                            MultiplesServidores = new ServidoresSerie(c, 'u', TEA, 'e', TDS);
                        }
                        else
                        {
                            TDS.Add(tiempos[i]);
                            TDS.Add(tiempos[i]);
                            TDS.Add(tiempos[i]);
                            TDS.Add(tiempos[i]);
                            MultiplesServidores = new ServidoresSerie(c, 'u', TEA, 'w', TDS);
                        }
                    }
                    else
                    {
                        if (txtTDS1_a.Text.Contains("."))
                        {
                            txtTDS1_a.Text = txtTDS1_a.Text.Replace('.', ',');
                        }
                        if (txtTDS1_b.Text.Contains("."))
                        {
                            txtTDS1_b.Text = txtTDS1_b.Text.Replace('.', ',');
                        }
                        if (txtTDS2_a.Text.Contains("."))
                        {
                            txtTDS2_a.Text = txtTDS2_a.Text.Replace('.', ',');
                        }
                        if (txtTDS2_b.Text.Contains("."))
                        {
                            txtTDS2_b.Text = txtTDS2_b.Text.Replace('.', ',');
                        }

                        TDS.Add(Convert.ToDouble(txtTDS1_a.Text));
                        TDS.Add(Convert.ToDouble(txtTDS1_b.Text));
                        TDS.Add(Convert.ToDouble(txtTDS2_a.Text));
                        TDS.Add(Convert.ToDouble(txtTDS2_b.Text));
                        if (cbxDTEA.SelectedItem.ToString() == "Exponencial")
                        {
                            TEA.Add(tiempos[i]);
                            MultiplesServidores = new ServidoresSerie(c, 'e', TEA, 'u', TDS);
                        }
                        else
                        {
                            TEA.Add(tiempos[i]);
                            TEA.Add(tiempos[i]);
                            MultiplesServidores = new ServidoresSerie(c, 'w', TEA, 'u', TDS);
                        }
                    }

                    while (MultiplesServidores.reloj < Convert.ToDouble(txtHs.Text))
                    {
                        char proximo_evento = MultiplesServidores.rutinadetiempo();
                        if (proximo_evento == 'a')
                        {
                            MultiplesServidores.arribo();
                        }
                        else if (proximo_evento == 'b')
                        {
                            MultiplesServidores.partida_arribo(proximo_evento);
                        }
                        else if (proximo_evento == 'c')
                        {
                            MultiplesServidores.partida_arribo(proximo_evento);
                        }
                        else if (proximo_evento == 'd')
                        {
                            MultiplesServidores.partida_arribo(proximo_evento);
                        }
                        else
                        {
                            MultiplesServidores.partida();
                        }
                    }

                    cli_en_cola_s1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.CantPromClientesColaS(0)));
                    cli_en_cola_s2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.CantPromClientesColaS(1)));
                    cli_cola1.Add(MultiplesServidores.CantPromClientesColaS(0));
                    cli_cola2.Add(MultiplesServidores.CantPromClientesColaS(1));

                    dem_prom_cli_s1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.DemPromedioS(0)));
                    dem_prom_cli_s2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.DemPromedioS(1)));
                    dem_prom1.Add(MultiplesServidores.DemPromedioS(0));
                    dem_prom2.Add(MultiplesServidores.DemPromedioS(1));

                    utilizacion_serv1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.UtilServidor(0)));
                    utilizacion_serv2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], MultiplesServidores.UtilServidor(1)));
                    utilizacion1.Add(MultiplesServidores.UtilServidor(0));
                    utilizacion2.Add(MultiplesServidores.UtilServidor(1));

                    NrosAleatorios.ReiniciarR();
                }

                cli_en_cola_s1.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola1) * 1.2;
                dem_prom_cli_s1.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom1) * 1.2;
                utilizacion_serv1.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion1) * 1.2;

                cli_en_cola_s2.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola2) * 1.2;
                dem_prom_cli_s2.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom2) * 1.2;
                utilizacion_serv2.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion2) * 1.2;

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
                    case (8):
                        mensaje = "El valor de a no puede ser mayor que el de b";
                        break;
                    default: break;

                }
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK);
            }
        }

        private double DameMaximo(List<double> valores)
        {
            valores.Sort();
            return valores[17];
            //return valores[0];
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
                //else if (this.chkArribo.Checked)
                //{
                if (txtTEA_a.Text.Contains("."))
                {
                    txtTEA_a.Text = txtTEA_a.Text.Replace('.', ',');
                }
                if (!(Double.TryParse(txtTEA_a.Text, out res)))
                {
                    msj = 4;
                }
                else if (Convert.ToDouble(txtTEA_a.Text) < 0.1 || Convert.ToDouble(txtTEA_a.Text) > 1)
                {
                    msj = 6;
                }
                if (txtTEA_b.Text.Contains("."))
                {
                    txtTEA_b.Text = txtTEA_b.Text.Replace('.', ',');
                }
                if (!(Double.TryParse(txtTEA_b.Text, out res)))
                {
                    msj = 4;
                }
                else if (Convert.ToDouble(txtTEA_b.Text) < 0.1 || Convert.ToDouble(txtTEA_b.Text) > 1)
                {
                    msj = 6;
                }
                if (Convert.ToDouble(txtTEA_a.Text) > Convert.ToDouble(txtTEA_b.Text))
                {
                    msj = 8;
                }
                //}
                //else if (this.chkServicio.Checked)
                //{
                if (txtTDS1_a.Text.Contains("."))
                {
                    txtTDS1_a.Text = txtTDS1_a.Text.Replace('.', ',');
                }
                if (txtTDS1_b.Text.Contains("."))
                {
                    txtTDS1_b.Text = txtTDS1_b.Text.Replace('.', ',');
                }
                if (!(Double.TryParse(txtTDS1_a.Text, out res)) || !(Double.TryParse(txtTDS1_b.Text, out res)))
                {
                    msj = 3;
                }
                else if ((Convert.ToDouble(txtTDS1_a.Text) < 0.1 || Convert.ToDouble(txtTDS1_a.Text) > 1) || (Convert.ToDouble(txtTDS1_b.Text) < 0.1 || Convert.ToDouble(txtTDS1_b.Text) > 1))
                {
                    msj = 5;
                }
                if (Convert.ToDouble(txtTDS1_a.Text) > Convert.ToDouble(txtTDS1_b.Text))
                {
                    msj = 8;
                }

                if (txtTDS2_a.Text.Contains("."))
                {
                    txtTDS2_a.Text = txtTDS2_a.Text.Replace('.', ',');
                }
                if (txtTDS2_b.Text.Contains("."))
                {
                    txtTDS2_b.Text = txtTDS2_b.Text.Replace('.', ',');
                }
                if (!(Double.TryParse(txtTDS2_a.Text, out res)) || !(Double.TryParse(txtTDS2_b.Text, out res)))
                {
                    msj = 3;
                }
                else if ((Convert.ToDouble(txtTDS2_a.Text) < 0.1 || Convert.ToDouble(txtTDS2_a.Text) > 1) || (Convert.ToDouble(txtTDS2_b.Text) < 0.1 || Convert.ToDouble(txtTDS2_b.Text) > 1))
                {
                    msj = 5;
                }
                if (Convert.ToDouble(txtTDS2_a.Text) > Convert.ToDouble(txtTDS2_b.Text))
                {
                    msj = 8;
                }
            }
            else
            {
                msj = 7;
            }

            return msj;
        }             

        private void chkArribo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArribo.Checked == true)
            {
                lblTDS_S2.Visible = false;
                txtTDS2_a.Visible = false;
                txtTDS2_b.Visible = false;
                lblTDS_S1.Text = "Distribucion de los tiempo entre servicios";
                txtTDS1_a.Visible = false;
                txtTDS1_b.Visible = false;
                cbxDTDS.Visible = true;
                cbxDTDS.SelectedItem = cbxDTDS.Items[0];
                lblS1TDS_a.Visible = false;
                lblS1TDS_b.Visible = false;
                lblS2TDS_a.Visible = false;
                lblS2TDS_b.Visible = false;
                chkServicio.Visible = false;
            }
            else
            {
                lblTDS_S2.Visible = true;
                txtTDS2_a.Visible = true;
                txtTDS2_b.Visible = true;
                lblTDS_S1.Text = "Tiempo entre servicios S1:";
                txtTDS1_a.Visible = true;
                txtTDS1_b.Visible = true;
                cbxDTDS.Visible = false;
                lblS1TDS_a.Visible = true;
                lblS1TDS_b.Visible = true;
                lblS2TDS_a.Visible = true;
                lblS2TDS_b.Visible = true;
                chkServicio.Visible = true;
            }
        }

        private void chkServicio_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkServicio.Checked == true)
            {
                chkArribo.Visible = false;
                lblTEA_a.Visible = false;
                lblTEA_b.Visible = false;
                txtTEA_a.Visible = false;
                txtTEA_b.Visible = false;
                cbxDTEA.Visible = true;
                cbxDTEA.SelectedItem = cbxDTEA.Items[0];

            }
            else
            {
                chkArribo.Visible = true;
                lblTEA_a.Visible = true;
                lblTEA_b.Visible = true;
                txtTEA_a.Visible = true;
                txtTEA_b.Visible = true;
                cbxDTEA.Visible = false;

            }
        }
    }


}
