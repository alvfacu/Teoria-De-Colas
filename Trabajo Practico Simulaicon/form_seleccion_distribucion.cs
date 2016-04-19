using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Trabajo_Practico_Simulacion;
using Trabajo_Practico_Simulacion.Servidor_Simple;
using Trabajo_Practico_Simulacion.Servidores_en_Paralelo.Uniforme;
using Trabajo_Practico_Simulacion.Servidores_en_Paralelo.Weibull;
using Trabajo_Practico_Simulacion.Servidores_en_Serie;
using Trabajo_Practico_Simulacion.Servidores_en_Serie.Uniforme;
using Trabajo_Practico_Simulacion.Servidores_en_Serie.Weibull;
using Trabajo_Practico_Simulacion.Servidores_Paralelos_con_colas_indep.Exponencial;
using Trabajo_Practico_Simulacion.Servidores_Paralelos_con_colas_indep.Uniforme;

namespace Trabajo_Practico_Simulaicon
{
    public partial class form_seleccion_distribucion : Form
    {
        private char tipo;
        private int nro;

        public form_seleccion_distribucion()
        {
            InitializeComponent();
        }

        public form_seleccion_distribucion(char p)
        {
            InitializeComponent();
            tipo = p;
        }

        public form_seleccion_distribucion(char p, int nro) : this(p)
        {
            this.nro = nro;
        }

        private void btn_dist_exp_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case ('a'):
                    {
                        form_ss_exponencial form = new form_ss_exponencial();
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            this.Dispose();
                        }
                        break;
                    }
                case ('b'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2ss_exponencial form = new form_2ss_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3ss_exponencial form = new form_3ss_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4ss_exponencial form = new form_4ss_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case ('c'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2sp_exponencial form = new form_2sp_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3sp_exponencial form = new form_3sp_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4sp_exponencial form = new form_4sp_exponencial();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case 'd':
                    {
                        form_3spci_exponencial form = new form_3spci_exponencial();
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            this.Dispose();
                        }
                        break;

                    }
                default:
                    break;
            }         
            
        }
                
        private void btn_dist_uni_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case ('a'):
                    {
                        form_ss_uniforme form = new form_ss_uniforme();
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            this.Dispose();
                        }
                        break;
                    }
                case ('b'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2ss_uniforme form = new form_2ss_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3ss_uniforme form = new form_3ss_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4ss_uniforme form = new form_4ss_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case ('c'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2sp_uniforme form = new form_2sp_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3sp_uniforme form = new form_3sp_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4sp_uniforme form = new form_4sp_uniforme();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case ('d'):
                    {
                        form_3spci_uniforme form = new form_3spci_uniforme();
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            this.Dispose();
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void btn_dist_weibull_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case ('a'):
                    {
                        form_ss_weibull form = new form_ss_weibull();
                        if (form.ShowDialog() != DialogResult.OK)
                        {
                            this.Dispose();
                        }
                        break;
                    }
                case ('b'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2ss_weibull form = new form_2ss_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3ss_weibull form = new form_3ss_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4ss_weibull form = new form_4ss_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                case ('c'):
                    {
                        switch (nro)
                        {
                            case (0):
                                {
                                    form_2sp_weibull form = new form_2sp_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (1):
                                {
                                    form_3sp_weibull form = new form_3sp_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                            case (2):
                                {
                                    form_4sp_weibull form = new form_4sp_weibull();
                                    if (form.ShowDialog() != DialogResult.OK)
                                    {
                                        this.Dispose();
                                    }
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
