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

namespace Trabajo_Practico_Simulaicon
{
    public partial class form_ss_exponencial : Form
    {
        bool arribo;
        double[] tiempos = { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };
        double[] cli_q = new double[18];
        List<double> cli_cola;
        List<double> dem_prom;
        List<double> utilizacion;

        public form_ss_exponencial()
        {
            InitializeComponent();
            txtTEA.Enabled = false;
            txtTEA.Text = "0,1 ... 0,5 ... 0,9";
            txtTDS.Enabled = false;
            txtTDS.Text = "0,1 ... 0,5 ... 0,9";
        }

        private void btn_simular_Click(object sender, EventArgs e)
        {
            int msj = Validar(this.Controls);
            if (msj == 0)
            {
                String nom_graf = "Exponencial";
                cli_cola = new List<double>();
                dem_prom = new List<double>();
                utilizacion = new List<double>();

                cli_en_cola.Series.Clear();
                dem_prom_cli.Series.Clear();
                utilizacion_serv.Series.Clear();                          

                cli_en_cola.Series.Add(nom_graf);
                cli_en_cola.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                cli_en_cola.Series[nom_graf].Color = Color.Green;
                //cli_en_cola.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli.Series.Add(nom_graf);
                dem_prom_cli.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                dem_prom_cli.Series[nom_graf].Color = Color.Red;
                //dem_prom_cli.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv.Series.Add(nom_graf);
                utilizacion_serv.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
                utilizacion_serv.Series[nom_graf].Color = Color.Blue;
                //utilizacion_serv.Series[nom_graf].BorderWidth = 3;
                
                NrosAleatorios.GenerarNros(Convert.ToInt32(txtHs.Text));

                for (int i = 0; i < tiempos.Length; i++)
                {
                    ServidorSimple ServidorSimple_Exp;

                    if (arribo)
                    {
                        ServidorSimple_Exp = new ServidorSimple(Convert.ToDouble(txtTEA.Text), tiempos[i]);
                    }
                    else
                    {
                        ServidorSimple_Exp = new ServidorSimple(tiempos[i], Convert.ToDouble(txtTDS.Text));
                    }

                    while (ServidorSimple_Exp.reloj < Convert.ToDouble(txtHs.Text))
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

                    //DataPoint punto = new DataPoint(tiempos[i], ServidorSimple_Exp.CantPromClientesCola);
                    //cli_en_cola.Series[nom_graf].Points.Add(punto);
                    cli_cola.Add(ServidorSimple_Exp.CantPromClientesCola);

                    //punto = new DataPoint(tiempos[i], ServidorSimple_Exp.DemPromedio);
                    //dem_prom_cli.Series[nom_graf].Points.Add(punto);
                    dem_prom.Add(ServidorSimple_Exp.DemPromedio);

                    //punto = new DataPoint(tiempos[i], ServidorSimple_Exp.UtilServidor);
                    //utilizacion_serv.Series[nom_graf].Points.Add(punto);
                    utilizacion.Add(ServidorSimple_Exp.UtilServidor);

                    NrosAleatorios.ReiniciarR();
                }

                for (int j = 0; j < cli_cola.Count; j++)
                {
                    cli_q[j] = cli_cola[j];
                }

                cli_en_cola.Series[nom_graf].Points.AddXY(1, cli_q.Length);
                cli_en_cola.Series[nom_graf].Points[0].YValues = cli_q;
                
                dem_prom_cli.Series[nom_graf].Points.DataBindY(dem_prom);
                dem_prom_cli.Series[nom_graf]["BoxPlotShowAverage"] = "true";
                dem_prom_cli.Series[nom_graf]["BoxPlotShowMedian"] = "true";
                dem_prom_cli.Series[nom_graf]["BoxPlotShowUnusualValues"] = "true";

                utilizacion_serv.Series[nom_graf].Points.DataBindY(utilizacion);
                utilizacion_serv.Series[nom_graf]["BoxPlotShowAverage"] = "true";
                utilizacion_serv.Series[nom_graf]["BoxPlotShowMedian"] = "true";
                utilizacion_serv.Series[nom_graf]["BoxPlotShowUnusualValues"] = "true";

                //cli_en_cola.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola) * 1.2;
                //dem_prom_cli.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom) * 1.2;
                //utilizacion_serv.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion) * 1.2;

                NrosAleatorios.ReiniciarN();
            }
            else
            {
                string mensaje = null; 
                switch(msj)
                {
                    case (1): mensaje = "Existen campos vacíos.";
                            break;
                    case (2): mensaje = "Verifique el formato las horas: deben ser enteras.";
                        break;
                    case (3): mensaje = "El TDS tiene que ser un decimal entre 0,1 y 1.";
                            break;
                    case (4): mensaje = "El TEA tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (5): mensaje = "El TDS tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (6): mensaje = "El TEA tiene que ser un decimal entre 0,1 y 1.";
                        break;
                    case (7): mensaje = "Debe ingresar un TEA o un TDS";
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
            if(!est)
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
                    if (txtTDS.Text.Contains("."))
                    {
                        txtTDS.Text = txtTDS.Text.Replace('.', ',');
                    }
                    if (!(Double.TryParse(txtTDS.Text, out res)))
                    {
                        msj = 3;
                    }
                    else if ((Convert.ToDouble(txtTDS.Text) < 0.1 || Convert.ToDouble(txtTDS.Text) > 1))
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
                txtTDS.Visible = true;
                txtTDS.Enabled = true;
                txtTDS.Clear();
            }
            else
            {
                txtTDS.Enabled = false;
                txtTDS.Text = "0,1 ... 0,5 ... 0,9";
            }
        }
        
    }
}
