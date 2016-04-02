namespace Trabajo_Practico_Simulaicon
{
    partial class form_cantidadservidores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cantidadservidores));
            this.btn_listo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_listo
            // 
            this.btn_listo.Location = new System.Drawing.Point(133, 44);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Size = new System.Drawing.Size(75, 23);
            this.btn_listo.TabIndex = 0;
            this.btn_listo.Text = "Aceptar";
            this.btn_listo.UseVisualStyleBackColor = true;
            this.btn_listo.Click += new System.EventHandler(this.btn_listo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indique la cantidad de servidores";
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cmbCantidad.Location = new System.Drawing.Point(48, 46);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(66, 21);
            this.cmbCantidad.TabIndex = 2;
            // 
            // form_cantidadservidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(250, 90);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_cantidadservidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cantidad de servidores";
            this.Load += new System.EventHandler(this.form_cantidadservidores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantidad;
    }
}