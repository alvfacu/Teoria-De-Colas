using MySql.Data.MySqlClient;
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

namespace Trabajo_Practico_Simulacion.Servidores_en_Paralelo.Weibull
{
    public partial class form_2sp_weibull : Form
    {
        bool arribo;
        int c;
        double[] tiempos = { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };

        List<double> TEA;
        List<double> TDS_a;
        List<double> TDS_b;

        List<double> cli_cola1;
        List<double> dem_prom1;
        List<double> utilizacion1;

        List<double> cli_cola2;
        List<double> dem_prom2;
        List<double> utilizacion2;

        public form_2sp_weibull()
        {
            InitializeComponent();

            txtTEA_a.Enabled = false;
            txtTEA_a.Text = "[0,1;0,9]";

            txtTEA_b.Enabled = false;
            txtTEA_b.Text = "[0,1;0,9]";

            txtTDS1_a.Enabled = false;
            txtTDS1_a.Text = "[0,1;0,9]";

            txtTDS1_b.Enabled = false;
            txtTDS1_b.Text = "[0,1;0,9]";

            txtTDS2_a.Enabled = false;
            txtTDS2_a.Text = "[0,1;0,9]";

            txtTDS2_b.Enabled = false;
            txtTDS2_b.Text = "[0,1;0,9]";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            int msj = Validar(this.Controls);
            if (msj == 0)
            {
                c = form_cantidadservidores.nro + 1;

                String nom_graf = "Weibull";

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
                    ServidoresParalelo MultiplesServidores;
                    TEA = new List<double>();
                    TDS_a = new List<double>();
                    TDS_b = new List<double>();

                    if (arribo)
                    {
                        TEA.Add(Convert.ToDouble(txtTEA_a.Text));
                        TEA.Add(Convert.ToDouble(txtTEA_b.Text));
                        TDS_a.Add(tiempos[i]);
                        TDS_a.Add(tiempos[i]);
                        TDS_b.Add(tiempos[i]);
                        TDS_b.Add(tiempos[i]);
                        MultiplesServidores = new ServidoresParalelo('w',c, TEA, TDS_a, TDS_b);
                    }
                    else
                    {
                        TEA.Add(tiempos[i]);
                        TEA.Add(tiempos[i]);
                        TDS_a.Add(Convert.ToDouble(this.txtTDS1_a.Text));
                        TDS_a.Add(Convert.ToDouble(this.txtTDS2_a.Text));
                        TDS_b.Add(Convert.ToDouble(this.txtTDS1_b.Text));
                        TDS_b.Add(Convert.ToDouble(this.txtTDS2_b.Text));
                        MultiplesServidores = new ServidoresParalelo('w', c, TEA, TDS_a, TDS_b);
                    }
                    
                    while (MultiplesServidores.reloj < Convert.ToDouble(txtHs.Text))
                    {
                        char proximo_evento = MultiplesServidores.rutinadetiempo();
                        if (proximo_evento == 'a')
                        {
                            MultiplesServidores.arribo();
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
                    default: break;

                }
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK);
            }
        }
                
        private double DameMaximo(List<double> valores)
        {
            valores.Sort();
            return valores[17];
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
                else if (this.chkArribo.Checked)
                {
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
                }
                else if (this.chkServicio.Checked)
                {
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
                }
                else
                {
                    msj = 7;
                }
            }
            return msj;
        }

        private void chkArribo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArribo.Checked == true)
            {
                arribo = true;
                chkServicio.Checked = false;
                txtTEA_a.Enabled = true;
                txtTEA_a.Clear();
                txtTEA_b.Enabled = true;
                txtTEA_b.Clear();
            }
            else
            {
                txtTEA_a.Enabled = false;
                txtTEA_a.Text = "[0,1;0,9]";
                txtTEA_b.Enabled = false;
                txtTEA_b.Text = "[0,1;0,9]";
            }
        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServicio.Checked == true)
            {
                arribo = false;
                chkArribo.Checked = false;
                txtTDS1_a.Enabled = true;
                txtTDS1_a.Clear();
                txtTDS1_b.Enabled = true;
                txtTDS1_b.Clear();
                txtTDS2_a.Enabled = true;
                txtTDS2_a.Clear();
                txtTDS2_b.Enabled = true;
                txtTDS2_b.Clear();

            }
            else
            {
                txtTDS1_a.Enabled = false;
                txtTDS1_a.Text = "[0,1;0,9]";
                txtTDS1_b.Enabled = false;
                txtTDS1_b.Text = "[0,1;0,9]";
                txtTDS2_a.Enabled = false;
                txtTDS2_a.Text = "[0,1;0,9]";
                txtTDS2_b.Enabled = false;
                txtTDS2_b.Text = "[0,1;0,9]";
            }
        }
    }
}
