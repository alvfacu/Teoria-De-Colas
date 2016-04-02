namespace Trabajo_Practico_Simulaicon
{
    partial class form_principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_principal));
            this.btn_servidor_simple = new System.Windows.Forms.Button();
            this.btn_dos_serv_serie = new System.Windows.Forms.Button();
            this.btn_multiples = new System.Windows.Forms.Button();
            this.btn_jocking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_servidor_simple
            // 
            this.btn_servidor_simple.Image = ((System.Drawing.Image)(resources.GetObject("btn_servidor_simple.Image")));
            this.btn_servidor_simple.Location = new System.Drawing.Point(12, 12);
            this.btn_servidor_simple.Name = "btn_servidor_simple";
            this.btn_servidor_simple.Size = new System.Drawing.Size(476, 95);
            this.btn_servidor_simple.TabIndex = 1;
            this.btn_servidor_simple.UseVisualStyleBackColor = true;
            this.btn_servidor_simple.Click += new System.EventHandler(this.btn_servidor_simple_Click);
            // 
            // btn_dos_serv_serie
            // 
            this.btn_dos_serv_serie.Image = ((System.Drawing.Image)(resources.GetObject("btn_dos_serv_serie.Image")));
            this.btn_dos_serv_serie.Location = new System.Drawing.Point(12, 113);
            this.btn_dos_serv_serie.Name = "btn_dos_serv_serie";
            this.btn_dos_serv_serie.Size = new System.Drawing.Size(476, 97);
            this.btn_dos_serv_serie.TabIndex = 2;
            this.btn_dos_serv_serie.UseVisualStyleBackColor = true;
            this.btn_dos_serv_serie.Click += new System.EventHandler(this.btn_dos_serv_serie_Click);
            // 
            // btn_multiples
            // 
            this.btn_multiples.Image = ((System.Drawing.Image)(resources.GetObject("btn_multiples.Image")));
            this.btn_multiples.Location = new System.Drawing.Point(12, 216);
            this.btn_multiples.Name = "btn_multiples";
            this.btn_multiples.Size = new System.Drawing.Size(476, 165);
            this.btn_multiples.TabIndex = 3;
            this.btn_multiples.UseVisualStyleBackColor = true;
            this.btn_multiples.Click += new System.EventHandler(this.btn_multiples_Click);
            // 
            // btn_jocking
            // 
            this.btn_jocking.Enabled = false;
            this.btn_jocking.Image = ((System.Drawing.Image)(resources.GetObject("btn_jocking.Image")));
            this.btn_jocking.Location = new System.Drawing.Point(12, 387);
            this.btn_jocking.Name = "btn_jocking";
            this.btn_jocking.Size = new System.Drawing.Size(476, 253);
            this.btn_jocking.TabIndex = 4;
            this.btn_jocking.UseVisualStyleBackColor = true;
            // 
            // form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(505, 656);
            this.Controls.Add(this.btn_jocking);
            this.Controls.Add(this.btn_multiples);
            this.Controls.Add(this.btn_dos_serv_serie);
            this.Controls.Add(this.btn_servidor_simple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione tipo de modelo de cola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_servidor_simple;
        private System.Windows.Forms.Button btn_dos_serv_serie;
        private System.Windows.Forms.Button btn_multiples;
        private System.Windows.Forms.Button btn_jocking;
    }
}

