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

namespace Trabajo_Practico_Simulacion
{
    public partial class form_3ss_exponencial : Form
    {
        int c;
        bool arribo;
        double[] tiempos = { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };
        List<double> TDS;

        List<double> cli_cola1;
        List<double> dem_prom1;
        List<double> utilizacion1;

        List<double> cli_cola2;
        List<double> dem_prom2;
        List<double> utilizacion2;

        List<double> cli_cola3;
        List<double> dem_prom3;
        List<double> utilizacion3;

        public form_3ss_exponencial()
        {
            InitializeComponent();
            txtTEA.Enabled = false;
            txtTEA.Text = "0,1 ... 0,5 ... 0,9";
            txtTDS1.Enabled = false;
            txtTDS1.Text = "0,1 ... 0,5 ... 0,9";
            txtTDS2.Enabled = false;
            txtTDS2.Text = "0,1 ... 0,5 ... 0,9";
            txtTDS3.Enabled = false;
            txtTDS3.Text = "0,1 ... 0,5 ... 0,9";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            int msj = Validar(this.Controls);
            if (msj == 0)
            {
                String nom_graf = "Exponencial";

                c = form_cantidadservidores.nro + 1;

                cli_en_cola_s1.Series.Clear();
                cli_en_cola_s2.Series.Clear();
                cli_en_cola_s3.Series.Clear();

                dem_prom_cli_s1.Series.Clear();
                dem_prom_cli_s2.Series.Clear();
                dem_prom_cli_s3.Series.Clear();

                utilizacion_serv1.Series.Clear();
                utilizacion_serv2.Series.Clear();
                utilizacion_serv3.Series.Clear();

                cli_cola1 = new List<double>();
                dem_prom1 = new List<double>();
                utilizacion1 = new List<double>();

                cli_cola2 = new List<double>();
                dem_prom2 = new List<double>();
                utilizacion2 = new List<double>();

                cli_cola3 = new List<double>();
                dem_prom3 = new List<double>();
                utilizacion3 = new List<double>();

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

                for (int i = 0; i < tiempos.Length; i++)
                {
                    ServidoresSerie ServidoresSerie_Exp;
                    TDS = new List<double>();

                    if (arribo)
                    {
                        TDS.Add(tiempos[i]);
                        TDS.Add(tiempos[i]);
                        TDS.Add(tiempos[i]);
                        ServidoresSerie_Exp = new ServidoresSerie(c, Convert.ToDouble(txtTEA.Text), TDS);
                    }
                    else
                    {
                        TDS.Add(Convert.ToDouble(this.txtTDS1.Text));
                        TDS.Add(Convert.ToDouble(this.txtTDS2.Text));
                        TDS.Add(Convert.ToDouble(this.txtTDS3.Text));
                        ServidoresSerie_Exp = new ServidoresSerie(c, tiempos[i], TDS);
                    }

                    while (ServidoresSerie_Exp.reloj < Convert.ToDouble(txtHs.Text))
                    {
                        char proximo_evento = ServidoresSerie_Exp.rutinadetiempo();
                        if (proximo_evento == 'a')
                        {
                            ServidoresSerie_Exp.arribo();
                        }
                        else if (proximo_evento == 'b')
                        {
                            ServidoresSerie_Exp.partida_arribo(proximo_evento);
                        }
                        else if (proximo_evento == 'c')
                        {
                            ServidoresSerie_Exp.partida_arribo(proximo_evento);
                        }
                        else if (proximo_evento == 'd')
                        {
                            ServidoresSerie_Exp.partida_arribo(proximo_evento);
                        }
                        else
                        {
                            ServidoresSerie_Exp.partida();
                        }
                    }

                    cli_en_cola_s1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.CantPromClientesColaS(0)));
                    cli_en_cola_s2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.CantPromClientesColaS(1)));
                    cli_en_cola_s3.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.CantPromClientesColaS(2)));
                    cli_cola1.Add(ServidoresSerie_Exp.CantPromClientesColaS(0));
                    cli_cola2.Add(ServidoresSerie_Exp.CantPromClientesColaS(1));
                    cli_cola3.Add(ServidoresSerie_Exp.CantPromClientesColaS(2));
                    
                    dem_prom_cli_s1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.DemPromedioS(0)));
                    dem_prom_cli_s2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.DemPromedioS(1)));
                    dem_prom_cli_s3.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.DemPromedioS(2)));
                    dem_prom1.Add(ServidoresSerie_Exp.DemPromedioS(0));
                    dem_prom2.Add(ServidoresSerie_Exp.DemPromedioS(1));
                    dem_prom3.Add(ServidoresSerie_Exp.DemPromedioS(2));
                    
                    utilizacion_serv1.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.UtilServidor(0)));
                    utilizacion_serv2.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.UtilServidor(1)));
                    utilizacion_serv3.Series[nom_graf].Points.Add(new DataPoint(tiempos[i], ServidoresSerie_Exp.UtilServidor(2)));
                    utilizacion1.Add(ServidoresSerie_Exp.UtilServidor(0));
                    utilizacion2.Add(ServidoresSerie_Exp.UtilServidor(1));
                    utilizacion3.Add(ServidoresSerie_Exp.UtilServidor(2));

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
                    if (txtTEA.Text.Contains("."))
                    {
                        txtTEA.Text = txtTEA.Text.Replace('.', ',');
                    }
                    if (!(Double.TryParse(txtTEA.Text, out res)))
                    {
                        msj = 4;
                    }
                    else if (Convert.ToDouble(txtTEA.Text) < 0.1 || Convert.ToDouble(txtTEA.Text) > 1)
                    {
                        msj = 6;
                    }
                }
                else if (this.chkServicio.Checked)
                {
                    if (txtTDS1.Text.Contains("."))
                    {
                        txtTDS1.Text = txtTDS1.Text.Replace('.', ',');
                    }
                    if (txtTDS2.Text.Contains("."))
                    {
                        txtTDS2.Text = txtTDS2.Text.Replace('.', ',');
                    }
                    if (txtTDS3.Text.Contains("."))
                    {
                        txtTDS3.Text = txtTDS3.Text.Replace('.', ',');
                    }
                    if (!(Double.TryParse(txtTDS1.Text, out res)) || !(Double.TryParse(txtTDS2.Text, out res)) || !(Double.TryParse(txtTDS3.Text, out res)))
                    {
                        msj = 3;
                    }
                    else if ((Convert.ToDouble(txtTDS1.Text) < 0.1 || Convert.ToDouble(txtTDS1.Text) > 1) || (Convert.ToDouble(txtTDS2.Text) < 0.1 || Convert.ToDouble(txtTDS2.Text) > 1) || (Convert.ToDouble(txtTDS3.Text) < 0.1 || Convert.ToDouble(txtTDS3.Text) > 1))
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
                txtTEA.Enabled = true;
                txtTEA.Clear();
            }
            else
            {
                txtTEA.Enabled = false;
                txtTEA.Text = "0,1 ... 0,5 ... 0,9";
            }
        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServicio.Checked == true)
            {
                arribo = false;
                chkArribo.Checked = false;
                txtTDS1.Visible = true;
                txtTDS1.Enabled = true;
                txtTDS1.Clear();
                txtTDS2.Visible = true;
                txtTDS2.Enabled = true;
                txtTDS2.Clear();
                txtTDS3.Enabled = true;
                txtTDS3.Clear();
            }
            else
            {
                txtTDS1.Enabled = false;
                txtTDS1.Text = "0,1 ... 0,5 ... 0,9";
                txtTDS2.Enabled = false;
                txtTDS2.Text = "0,1 ... 0,5 ... 0,9";
                txtTDS3.Enabled = false;
                txtTDS3.Text = "0,1 ... 0,5 ... 0,9";
            }
        }
        
    }
}
