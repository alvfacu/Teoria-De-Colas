using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico_Simulacion.Servidor_Simple;
using Trabajo_Practico_Simulaicon;

namespace Trabajo_Practico_Simulacion
{
    public partial class form_seleccion_distribucion_ss : Form
    {
        public form_seleccion_distribucion_ss()
        {
            InitializeComponent();
        }

        private void btn_dist_exp_Click(object sender, EventArgs e)
        {
            form_ss_exponencial form = new form_ss_exponencial();
            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btn_dist_uni_Click(object sender, EventArgs e)
        {
            form_ss_uniforme form = new form_ss_uniforme();
            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btn_dist_weibull_Click(object sender, EventArgs e)
        {
            form_ss_weibull form = new form_ss_weibull();
            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btn_comparativa_Click(object sender, EventArgs e)
        {
            form_ss_comparativa form = new form_ss_comparativa();
            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }
    }
}
