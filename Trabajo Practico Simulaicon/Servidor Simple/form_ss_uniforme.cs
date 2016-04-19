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

namespace Trabajo_Practico_Simulacion.Servidor_Simple
{
    public partial class form_ss_uniforme : Form
    {
        double[] tiempos = { 0.1, 0.15, 0.2, 0.25, 0.3, 0.35, 0.4, 0.45, 0.5, 0.55, 0.6, 0.65, 0.7, 0.75, 0.8, 0.85, 0.9, 0.95 };
        List<double> cli_cola;
        List<double> dem_prom;
        List<double> utilizacion;

        List<double> TEA;
        List<double> TDS;

        public form_ss_uniforme()
        {
            InitializeComponent();            
        }

        private void chkArribo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArribo.Checked == true)
            {                
                chkServicio.Visible = false;
                lblTDS_a.Visible = false;
                lblTDS_b.Visible = false;
                txtTDS_a.Visible = false;
                txtTDS_a.Clear();
                txtTDS_b.Visible = false;
                txtTDS_b.Clear();
                cbxDTDS.Visible = true;
                cbxDTDS.SelectedItem = cbxDTDS.Items[0];
            }
            else
            {
                chkServicio.Visible = true;
                lblTDS_a.Visible = true;
                lblTDS_b.Visible = true;
                txtTDS_a.Visible = true;
                txtTDS_b.Visible = true;
                cbxDTDS.Visible = false;
            }
        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServicio.Checked == true)
            {
                chkArribo.Visible = false;
                lblTEA_a.Visible = false;
                lblTEA_b.Visible = false;
                txtTEA_a.Visible = false;
                txtTEA_a.Clear();
                txtTEA_b.Visible = false;
                txtTEA_b.Clear();
                cbxDTEA.Visible = true;
                cbxDTEA.SelectedItem = cbxDTDS.Items[0];
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

        private void btn_simular_Click(object sender, EventArgs e)
        {
            int msj = Validar(this.Controls);
            if (msj == 0)
            {
                String nom_graf = "Uniforme";

                cli_cola = new List<double>();
                dem_prom = new List<double>();
                utilizacion = new List<double>();

                cli_en_cola.Series.Clear();
                dem_prom_cli.Series.Clear();
                utilizacion_serv.Series.Clear();

                cli_en_cola.Series.Add(nom_graf);
                cli_en_cola.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                cli_en_cola.Series[nom_graf].Color = Color.Green;
                cli_en_cola.Series[nom_graf].BorderWidth = 3;

                dem_prom_cli.Series.Add(nom_graf);
                dem_prom_cli.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                dem_prom_cli.Series[nom_graf].Color = Color.Red;
                dem_prom_cli.Series[nom_graf].BorderWidth = 3;

                utilizacion_serv.Series.Add(nom_graf);
                utilizacion_serv.Series[nom_graf].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                utilizacion_serv.Series[nom_graf].Color = Color.Blue;
                utilizacion_serv.Series[nom_graf].BorderWidth = 3;

                NrosAleatorios.GenerarNros(Convert.ToInt32(txtHs.Text));

                for (int i = 0; i < tiempos.Length; i++)
                {
                    ServidorSimple ServidorSimple;
                    TDS = new List<double>();
                    TEA = new List<double>();
                                     
                    if (chkArribo.Checked == true)
                    {
                        TEA.Add(Convert.ToDouble(txtTEA_a.Text));
                        TEA.Add(Convert.ToDouble(txtTEA_b.Text));
                        if (cbxDTDS.SelectedItem.ToString() == "Exponencial")
                        {
                            TDS.Add(tiempos[i]);
                            ServidorSimple = new ServidorSimple('u', TEA, 'e', TDS);
                        }
                        else
                        {
                            TDS.Add(tiempos[i]);
                            TDS.Add(tiempos[i]);
                            ServidorSimple = new ServidorSimple('u', TEA, 'w', TDS);
                        }
                    }
                    else
                    {
                        TDS.Add(Convert.ToDouble(txtTDS_a.Text));
                        TDS.Add(Convert.ToDouble(txtTDS_b.Text));
                        if (cbxDTEA.SelectedItem.ToString()=="Exponencial")
                        {
                            TEA.Add(tiempos[i]);
                            ServidorSimple = new ServidorSimple('e', TEA, 'u', TDS);
                        }
                        else
                        {
                            TEA.Add(tiempos[i]);
                            TEA.Add(tiempos[i]);
                            ServidorSimple = new ServidorSimple('w', TEA, 'u', TDS);
                        }
       
                    }

                    
                    while (ServidorSimple.reloj < Convert.ToDouble(txtHs.Text))
                    {
                        char proximo_evento = ServidorSimple.rutinadetiempo();
                        if (proximo_evento == 'a')
                        {
                            
                            ServidorSimple.arribo();
                        }
                        else
                        {
                            ServidorSimple.partida();
                        }
                    }

                    DataPoint punto = new DataPoint(tiempos[i], ServidorSimple.CantPromClientesCola);
                    cli_en_cola.Series[nom_graf].Points.Add(punto);
                    cli_cola.Add(ServidorSimple.CantPromClientesCola);

                    punto = new DataPoint(tiempos[i], ServidorSimple.DemPromedio);
                    dem_prom_cli.Series[nom_graf].Points.Add(punto);
                    dem_prom.Add(ServidorSimple.DemPromedio);

                    punto = new DataPoint(tiempos[i], ServidorSimple.UtilServidor);
                    utilizacion_serv.Series[nom_graf].Points.Add(punto);
                    utilizacion.Add(ServidorSimple.UtilServidor);

                    NrosAleatorios.ReiniciarR();
                }

                cli_en_cola.ChartAreas[0].AxisY.Maximum = DameMaximo(cli_cola) * 1.2;
                dem_prom_cli.ChartAreas[0].AxisY.Maximum = DameMaximo(dem_prom) * 1.2;
                utilizacion_serv.ChartAreas[0].AxisY.Maximum = DameMaximo(utilizacion) * 1.2;

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
                        mensaje = "Los parámetros del TDS tienen que ser números decimales entre 0,1 y 1.";
                        break;
                    case (4):
                        mensaje = "Los parámetros del TEA tienen que ser números decimales entre 0,1 y 1.";
                        break;
                    case (5):
                        mensaje = "Los parámetros del TDS tienen que ser números decimales entre 0,1 y 1.";
                        break;
                    case (6):
                        mensaje = "Los parámetros del TEA tienen que ser números decimales entre 0,1 y 1.";
                        break;
                    case (7):
                        mensaje = "Debe ingresar los parámetros del TEA o del TDS";
                        break;
                    case (8):
                        mensaje = "El valor de a no puede superar al de b";
                        break;
                    default: break;

                }
                MessageBox.Show(mensaje, "¡ Atención !", MessageBoxButtons.OK);
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
                if (c.Visible==true & c is TextBox & c.Text == String.Empty)
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
                if (txtTEA_a.Visible == true)
                {
                    if (txtTEA_a.Text.Contains("."))
                    {
                        txtTEA_a.Text = txtTEA_a.Text.Replace('.', ',');
                    }
                    if (txtTEA_b.Text.Contains("."))
                    {
                        txtTEA_b.Text = txtTEA_b.Text.Replace('.', ',');
                    }
                    if (!(Double.TryParse(txtTEA_a.Text, out res)) || !(Double.TryParse(txtTEA_b.Text, out res)))
                    {
                        msj = 4;
                    }
                    else if ((Convert.ToDouble(txtTEA_a.Text) < 0.1 || Convert.ToDouble(txtTEA_a.Text) > 1) || (Convert.ToDouble(txtTEA_b.Text) < 0.1 || Convert.ToDouble(txtTEA_b.Text) > 1))
                    {
                        msj = 6;
                    }
                    if (Convert.ToDouble(txtTEA_a.Text) > Convert.ToDouble(txtTEA_b.Text))
                    {
                        msj = 8;
                    }
                }
                //}
                //else if (this.chkServicio.Checked)
                //{
                if (txtTDS_a.Visible == true)
                {
                    if (txtTDS_a.Text.Contains("."))
                    {
                        txtTDS_a.Text = txtTDS_a.Text.Replace('.', ',');
                    }
                    if (txtTDS_b.Text.Contains("."))
                    {
                        txtTDS_b.Text = txtTDS_b.Text.Replace('.', ',');
                    }
                    if (!(Double.TryParse(txtTDS_a.Text, out res)) || !(Double.TryParse(txtTDS_b.Text, out res)))
                    {
                        msj = 3;
                    }
                    else if ((Convert.ToDouble(txtTDS_a.Text) < 0.1 || Convert.ToDouble(txtTDS_a.Text) > 1) || (Convert.ToDouble(txtTDS_b.Text) < 0.1 || Convert.ToDouble(txtTDS_b.Text) > 1))
                    {
                        msj = 5;
                    }

                    if (Convert.ToDouble(txtTDS_a.Text) > Convert.ToDouble(txtTDS_b.Text))
                    {
                        msj = 8;
                    }
                    }
                //}
                /*else
                {
                    msj = 7;
                }*/

            }

            return msj;
        }
        
    }
}
