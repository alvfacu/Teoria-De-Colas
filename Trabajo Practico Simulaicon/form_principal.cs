using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabajo_Practico_Simulaicon
{
    public partial class form_principal : Form
    {
        public form_principal()
        {
            InitializeComponent();
            ToolTip MyToolTip = new ToolTip();
            MyToolTip.SetToolTip(this.btn_servidor_simple, "Servidor Simple");
            MyToolTip.SetToolTip(this.btn_dos_serv_serie, "Servidores En Serie");
            MyToolTip.SetToolTip(this.btn_multiples, "Servidores Paralelos");
            MyToolTip.SetToolTip(this.btn_jocking, "Servidores Paralelos con Jocking");
        }

        private void btn_servidor_simple_Click(object sender, EventArgs e)
        {
            form_seleccion_distribucion form = new form_seleccion_distribucion('a');
            form.ShowDialog();
        }

        private void btn_dos_serv_serie_Click(object sender, EventArgs e)
        {
            form_cantidadservidores form = new form_cantidadservidores('b');
            form.ShowDialog();
        }
        
        private void btn_multiples_Click(object sender, EventArgs e)
        {
            form_cantidadservidores form = new form_cantidadservidores('c');
            form.ShowDialog();
        }

        private void btn_jocking_Click(object sender, EventArgs e)
        {
            form_seleccion_distribucion form = new form_seleccion_distribucion('d');
            form.ShowDialog();
        }
    }
}
