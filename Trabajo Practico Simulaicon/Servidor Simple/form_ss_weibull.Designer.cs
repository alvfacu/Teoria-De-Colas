namespace Trabajo_Practico_Simulacion.Servidor_Simple
{
    partial class form_ss_weibull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ss_weibull));
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTDS_b = new System.Windows.Forms.TextBox();
            this.txtTDS_a = new System.Windows.Forms.TextBox();
            this.chkServicio = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTEA_b = new System.Windows.Forms.TextBox();
            this.txtTEA_a = new System.Windows.Forms.TextBox();
            this.chkArribo = new System.Windows.Forms.CheckBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.utilizacion_serv = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.dem_prom_cli = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.cli_en_cola = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "b";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "a";
            // 
            // txtTDS_b
            // 
            this.txtTDS_b.Location = new System.Drawing.Point(392, 26);
            this.txtTDS_b.Name = "txtTDS_b";
            this.txtTDS_b.Size = new System.Drawing.Size(45, 20);
            this.txtTDS_b.TabIndex = 7;
            // 
            // txtTDS_a
            // 
            this.txtTDS_a.Location = new System.Drawing.Point(330, 26);
            this.txtTDS_a.Name = "txtTDS_a";
            this.txtTDS_a.Size = new System.Drawing.Size(45, 20);
            this.txtTDS_a.TabIndex = 6;
            // 
            // chkServicio
            // 
            this.chkServicio.AutoSize = true;
            this.chkServicio.Location = new System.Drawing.Point(302, 30);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(15, 14);
            this.chkServicio.TabIndex = 5;
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Tiempo entre servicios:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "b";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "a";
            // 
            // txtTEA_b
            // 
            this.txtTEA_b.Location = new System.Drawing.Point(244, 27);
            this.txtTEA_b.Name = "txtTEA_b";
            this.txtTEA_b.Size = new System.Drawing.Size(45, 20);
            this.txtTEA_b.TabIndex = 4;
            // 
            // txtTEA_a
            // 
            this.txtTEA_a.Location = new System.Drawing.Point(181, 27);
            this.txtTEA_a.Name = "txtTEA_a";
            this.txtTEA_a.Size = new System.Drawing.Size(45, 20);
            this.txtTEA_a.TabIndex = 3;
            // 
            // chkArribo
            // 
            this.chkArribo.AutoSize = true;
            this.chkArribo.Location = new System.Drawing.Point(153, 30);
            this.chkArribo.Name = "chkArribo";
            this.chkArribo.Size = new System.Drawing.Size(15, 14);
            this.chkArribo.TabIndex = 2;
            this.chkArribo.UseVisualStyleBackColor = true;
            this.chkArribo.CheckedChanged += new System.EventHandler(this.chkArribo_CheckedChanged);
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(461, 25);
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
            this.label2.Location = new System.Drawing.Point(175, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tiempo entre arribos:";
            // 
            // txtHs
            // 
            this.txtHs.Location = new System.Drawing.Point(27, 27);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(100, 20);
            this.txtHs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cantida de Hs. a simular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Utilización del Servidor";
            // 
            // utilizacion_serv
            // 
            chartArea1.Name = "ChartArea1";
            this.utilizacion_serv.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.utilizacion_serv.Legends.Add(legend1);
            this.utilizacion_serv.Location = new System.Drawing.Point(19, 489);
            this.utilizacion_serv.Name = "utilizacion_serv";
            this.utilizacion_serv.Size = new System.Drawing.Size(514, 178);
            this.utilizacion_serv.TabIndex = 65;
            this.utilizacion_serv.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Demora Promedio de Clientes";
            // 
            // dem_prom_cli
            // 
            chartArea2.Name = "ChartArea1";
            this.dem_prom_cli.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dem_prom_cli.Legends.Add(legend2);
            this.dem_prom_cli.Location = new System.Drawing.Point(19, 285);
            this.dem_prom_cli.Name = "dem_prom_cli";
            this.dem_prom_cli.Size = new System.Drawing.Size(514, 178);
            this.dem_prom_cli.TabIndex = 63;
            this.dem_prom_cli.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Cant de Clientes en Cola";
            // 
            // cli_en_cola
            // 
            chartArea3.Name = "ChartArea1";
            this.cli_en_cola.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cli_en_cola.Legends.Add(legend3);
            this.cli_en_cola.Location = new System.Drawing.Point(19, 77);
            this.cli_en_cola.Name = "cli_en_cola";
            this.cli_en_cola.Size = new System.Drawing.Size(514, 178);
            this.cli_en_cola.TabIndex = 61;
            this.cli_en_cola.Text = "chart1";
            // 
            // form_ss_weibull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 683);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.utilizacion_serv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dem_prom_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cli_en_cola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTDS_b);
            this.Controls.Add(this.txtTDS_a);
            this.Controls.Add(this.chkServicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTEA_b);
            this.Controls.Add(this.txtTEA_a);
            this.Controls.Add(this.chkArribo);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ss_weibull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor Simple - Distribución Weibull";
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTDS_b;
        private System.Windows.Forms.TextBox txtTDS_a;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTEA_b;
        private System.Windows.Forms.TextBox txtTEA_a;
        private System.Windows.Forms.CheckBox chkArribo;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion_serv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom_cli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cli_en_cola;
    }
}