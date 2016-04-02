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
    public partial class form_cantidadservidores : Form
    {
        static public int nro;
        private char tipo;
        

        public form_cantidadservidores(char v)
        {
            InitializeComponent();
            this.tipo = v;
            cmbCantidad.SelectedItem = cmbCantidad.Items[0];
        }
        
        private void btn_listo_Click(object sender, EventArgs e)
        {
            nro = this.cmbCantidad.SelectedIndex;
            form_seleccion_distribucion form = new form_seleccion_distribucion(tipo,nro);
            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void form_cantidadservidores_Load(object sender, EventArgs e)
        {

        }
    }
}
