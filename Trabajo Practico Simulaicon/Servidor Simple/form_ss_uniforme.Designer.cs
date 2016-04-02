namespace Trabajo_Practico_Simulacion.Servidor_Simple
{
    partial class form_ss_uniforme
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ss_uniforme));
            this.label6 = new System.Windows.Forms.Label();
            this.utilizacion_serv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.dem_prom_cli = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkArribo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cli_en_cola = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_simular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTEA_a = new System.Windows.Forms.TextBox();
            this.txtTEA_b = new System.Windows.Forms.TextBox();
            this.lblTEA_a = new System.Windows.Forms.Label();
            this.lblTEA_b = new System.Windows.Forms.Label();
            this.lblTDS_b = new System.Windows.Forms.Label();
            this.lblTDS_a = new System.Windows.Forms.Label();
            this.txtTDS_b = new System.Windows.Forms.TextBox();
            this.txtTDS_a = new System.Windows.Forms.TextBox();
            this.chkServicio = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDTEA = new System.Windows.Forms.ComboBox();
            this.cbxDTDS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Utilización del Servidor";
            // 
            // utilizacion_serv
            // 
            chartArea1.Name = "ChartArea1";
            this.utilizacion_serv.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.utilizacion_serv.Legends.Add(legend1);
            this.utilizacion_serv.Location = new System.Drawing.Point(28, 486);
            this.utilizacion_serv.Name = "utilizacion_serv";
            this.utilizacion_serv.Size = new System.Drawing.Size(514, 178);
            this.utilizacion_serv.TabIndex = 28;
            this.utilizacion_serv.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Demora Promedio de Clientes";
            // 
            // dem_prom_cli
            // 
            chartArea2.Name = "ChartArea1";
            this.dem_prom_cli.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dem_prom_cli.Legends.Add(legend2);
            this.dem_prom_cli.Location = new System.Drawing.Point(28, 282);
            this.dem_prom_cli.Name = "dem_prom_cli";
            this.dem_prom_cli.Size = new System.Drawing.Size(514, 178);
            this.dem_prom_cli.TabIndex = 26;
            this.dem_prom_cli.Text = "chart1";
            // 
            // chkArribo
            // 
            this.chkArribo.AutoSize = true;
            this.chkArribo.Location = new System.Drawing.Point(167, 28);
            this.chkArribo.Name = "chkArribo";
            this.chkArribo.Size = new System.Drawing.Size(15, 14);
            this.chkArribo.TabIndex = 2;
            this.chkArribo.UseVisualStyleBackColor = true;
            this.chkArribo.CheckedChanged += new System.EventHandler(this.chkArribo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cant de Clientes en Cola";
            // 
            // cli_en_cola
            // 
            chartArea3.Name = "ChartArea1";
            this.cli_en_cola.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cli_en_cola.Legends.Add(legend3);
            this.cli_en_cola.Location = new System.Drawing.Point(28, 74);
            this.cli_en_cola.Name = "cli_en_cola";
            this.cli_en_cola.Size = new System.Drawing.Size(514, 178);
            this.cli_en_cola.TabIndex = 22;
            this.cli_en_cola.Text = "chart1";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(457, 21);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 8;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tiempo entre arribos:";
            // 
            // txtHs
            // 
            this.txtHs.Location = new System.Drawing.Point(28, 26);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(100, 20);
            this.txtHs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantida de Hs. a simular:";
            // 
            // txtTEA_a
            // 
            this.txtTEA_a.Location = new System.Drawing.Point(197, 24);
            this.txtTEA_a.Name = "txtTEA_a";
            this.txtTEA_a.Size = new System.Drawing.Size(34, 20);
            this.txtTEA_a.TabIndex = 3;
            // 
            // txtTEA_b
            // 
            this.txtTEA_b.Location = new System.Drawing.Point(254, 24);
            this.txtTEA_b.Name = "txtTEA_b";
            this.txtTEA_b.Size = new System.Drawing.Size(34, 20);
            this.txtTEA_b.TabIndex = 4;
            // 
            // lblTEA_a
            // 
            this.lblTEA_a.AutoSize = true;
            this.lblTEA_a.Location = new System.Drawing.Point(184, 29);
            this.lblTEA_a.Name = "lblTEA_a";
            this.lblTEA_a.Size = new System.Drawing.Size(13, 13);
            this.lblTEA_a.TabIndex = 32;
            this.lblTEA_a.Text = "a";
            // 
            // lblTEA_b
            // 
            this.lblTEA_b.AutoSize = true;
            this.lblTEA_b.Location = new System.Drawing.Point(237, 29);
            this.lblTEA_b.Name = "lblTEA_b";
            this.lblTEA_b.Size = new System.Drawing.Size(13, 13);
            this.lblTEA_b.TabIndex = 33;
            this.lblTEA_b.Text = "b";
            // 
            // lblTDS_b
            // 
            this.lblTDS_b.AutoSize = true;
            this.lblTDS_b.Location = new System.Drawing.Point(378, 29);
            this.lblTDS_b.Name = "lblTDS_b";
            this.lblTDS_b.Size = new System.Drawing.Size(13, 13);
            this.lblTDS_b.TabIndex = 39;
            this.lblTDS_b.Text = "b";
            // 
            // lblTDS_a
            // 
            this.lblTDS_a.AutoSize = true;
            this.lblTDS_a.Location = new System.Drawing.Point(325, 29);
            this.lblTDS_a.Name = "lblTDS_a";
            this.lblTDS_a.Size = new System.Drawing.Size(13, 13);
            this.lblTDS_a.TabIndex = 38;
            this.lblTDS_a.Text = "a";
            // 
            // txtTDS_b
            // 
            this.txtTDS_b.Location = new System.Drawing.Point(395, 24);
            this.txtTDS_b.Name = "txtTDS_b";
            this.txtTDS_b.Size = new System.Drawing.Size(34, 20);
            this.txtTDS_b.TabIndex = 7;
            // 
            // txtTDS_a
            // 
            this.txtTDS_a.Location = new System.Drawing.Point(338, 24);
            this.txtTDS_a.Name = "txtTDS_a";
            this.txtTDS_a.Size = new System.Drawing.Size(34, 20);
            this.txtTDS_a.TabIndex = 6;
            // 
            // chkServicio
            // 
            this.chkServicio.AutoSize = true;
            this.chkServicio.Location = new System.Drawing.Point(308, 28);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(15, 14);
            this.chkServicio.TabIndex = 5;
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(311, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Tiempo entre servicios:";
            // 
            // cbxDTEA
            // 
            this.cbxDTEA.FormattingEnabled = true;
            this.cbxDTEA.Items.AddRange(new object[] {
            "Exponencial",
            "Weibull"});
            this.cbxDTEA.Location = new System.Drawing.Point(169, 24);
            this.cbxDTEA.Name = "cbxDTEA";
            this.cbxDTEA.Size = new System.Drawing.Size(121, 21);
            this.cbxDTEA.TabIndex = 40;
            this.cbxDTEA.Visible = false;
            // 
            // cbxDTDS
            // 
            this.cbxDTDS.FormattingEnabled = true;
            this.cbxDTDS.Items.AddRange(new object[] {
            "Exponencial",
            "Weibull"});
            this.cbxDTDS.Location = new System.Drawing.Point(311, 25);
            this.cbxDTDS.Name = "cbxDTDS";
            this.cbxDTDS.Size = new System.Drawing.Size(121, 21);
            this.cbxDTDS.TabIndex = 41;
            this.cbxDTDS.Visible = false;
            this.cbxDTDS.SelectedIndexChanged += new System.EventHandler(this.cbxDTDS_SelectedIndexChanged);
            // 
            // form_ss_uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(558, 675);
            this.Controls.Add(this.cbxDTDS);
            this.Controls.Add(this.cbxDTEA);
            this.Controls.Add(this.lblTDS_b);
            this.Controls.Add(this.lblTDS_a);
            this.Controls.Add(this.txtTDS_b);
            this.Controls.Add(this.txtTDS_a);
            this.Controls.Add(this.chkServicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTEA_b);
            this.Controls.Add(this.lblTEA_a);
            this.Controls.Add(this.txtTEA_b);
            this.Controls.Add(this.txtTEA_a);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.utilizacion_serv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dem_prom_cli);
            this.Controls.Add(this.chkArribo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cli_en_cola);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_ss_uniforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor Simple - Distribución Uniforme";
            this.Load += new System.EventHandler(this.form_ss_uniforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion_serv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom_cli;
        private System.Windows.Forms.CheckBox chkArribo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cli_en_cola;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTEA_a;
        private System.Windows.Forms.TextBox txtTEA_b;
        private System.Windows.Forms.Label lblTEA_a;
        private System.Windows.Forms.Label lblTEA_b;
        private System.Windows.Forms.Label lblTDS_b;
        private System.Windows.Forms.Label lblTDS_a;
        private System.Windows.Forms.TextBox txtTDS_b;
        private System.Windows.Forms.TextBox txtTDS_a;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxDTEA;
        private System.Windows.Forms.ComboBox cbxDTDS;
    }
}