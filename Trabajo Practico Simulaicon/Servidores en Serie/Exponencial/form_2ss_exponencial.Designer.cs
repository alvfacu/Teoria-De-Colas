namespace Trabajo_Practico_Simulaicon
{
    partial class form_2ss_exponencial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_2ss_exponencial));
            this.chkServicio = new System.Windows.Forms.CheckBox();
            this.chkArribo = new System.Windows.Forms.CheckBox();
            this.txtTDS1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTEA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTDS2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_simular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.utilizacion_serv1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.dem_prom_cli_s1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.cli_en_cola_s1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.cli_en_cola_s2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label9 = new System.Windows.Forms.Label();
            this.dem_prom_cli_s2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.utilizacion_serv2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli_s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola_s1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola_s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli_s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv2)).BeginInit();
            this.SuspendLayout();
            // 
            // chkServicio
            // 
            this.chkServicio.AutoSize = true;
            this.chkServicio.Location = new System.Drawing.Point(290, 27);
            this.chkServicio.Name = "chkServicio";
            this.chkServicio.Size = new System.Drawing.Size(15, 14);
            this.chkServicio.TabIndex = 4;
            this.chkServicio.UseVisualStyleBackColor = true;
            this.chkServicio.CheckedChanged += new System.EventHandler(this.chkServicio_CheckedChanged);
            // 
            // chkArribo
            // 
            this.chkArribo.AutoSize = true;
            this.chkArribo.Location = new System.Drawing.Point(152, 25);
            this.chkArribo.Name = "chkArribo";
            this.chkArribo.Size = new System.Drawing.Size(15, 14);
            this.chkArribo.TabIndex = 2;
            this.chkArribo.UseVisualStyleBackColor = true;
            this.chkArribo.CheckedChanged += new System.EventHandler(this.chkArribo_CheckedChanged);
            // 
            // txtTDS1
            // 
            this.txtTDS1.Location = new System.Drawing.Point(311, 25);
            this.txtTDS1.Name = "txtTDS1";
            this.txtTDS1.Size = new System.Drawing.Size(100, 20);
            this.txtTDS1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tiempo de servicio S1:";
            // 
            // txtTEA
            // 
            this.txtTEA.Location = new System.Drawing.Point(173, 25);
            this.txtTEA.Name = "txtTEA";
            this.txtTEA.Size = new System.Drawing.Size(100, 20);
            this.txtTEA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tiempo entre arribos:";
            // 
            // txtHs
            // 
            this.txtHs.Location = new System.Drawing.Point(24, 25);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(100, 20);
            this.txtHs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantida de Hs. a simular:";
            // 
            // txtTDS2
            // 
            this.txtTDS2.Location = new System.Drawing.Point(429, 25);
            this.txtTDS2.Name = "txtTDS2";
            this.txtTDS2.Size = new System.Drawing.Size(100, 20);
            this.txtTDS2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tiempo de servicio S2:";
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(604, 22);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 7;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Utilización del Servidor 1";
            // 
            // utilizacion_serv1
            // 
            chartArea1.Name = "ChartArea1";
            this.utilizacion_serv1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.utilizacion_serv1.Legends.Add(legend1);
            this.utilizacion_serv1.Location = new System.Drawing.Point(15, 485);
            this.utilizacion_serv1.Name = "utilizacion_serv1";
            this.utilizacion_serv1.Size = new System.Drawing.Size(403, 178);
            this.utilizacion_serv1.TabIndex = 27;
            this.utilizacion_serv1.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Demora Promedio de Clientes S1";
            // 
            // dem_prom_cli_s1
            // 
            chartArea2.Name = "ChartArea1";
            this.dem_prom_cli_s1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dem_prom_cli_s1.Legends.Add(legend2);
            this.dem_prom_cli_s1.Location = new System.Drawing.Point(15, 281);
            this.dem_prom_cli_s1.Name = "dem_prom_cli_s1";
            this.dem_prom_cli_s1.Size = new System.Drawing.Size(403, 178);
            this.dem_prom_cli_s1.TabIndex = 25;
            this.dem_prom_cli_s1.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cant de Clientes en Cola S1";
            // 
            // cli_en_cola_s1
            // 
            chartArea3.Name = "ChartArea1";
            this.cli_en_cola_s1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cli_en_cola_s1.Legends.Add(legend3);
            this.cli_en_cola_s1.Location = new System.Drawing.Point(15, 73);
            this.cli_en_cola_s1.Name = "cli_en_cola_s1";
            this.cli_en_cola_s1.Size = new System.Drawing.Size(403, 178);
            this.cli_en_cola_s1.TabIndex = 23;
            this.cli_en_cola_s1.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cant de Clientes en Cola S2";
            // 
            // cli_en_cola_s2
            // 
            chartArea4.Name = "ChartArea1";
            this.cli_en_cola_s2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.cli_en_cola_s2.Legends.Add(legend4);
            this.cli_en_cola_s2.Location = new System.Drawing.Point(442, 73);
            this.cli_en_cola_s2.Name = "cli_en_cola_s2";
            this.cli_en_cola_s2.Size = new System.Drawing.Size(403, 178);
            this.cli_en_cola_s2.TabIndex = 29;
            this.cli_en_cola_s2.Text = "chart1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Demora Promedio de Clientes S2";
            // 
            // dem_prom_cli_s2
            // 
            chartArea5.Name = "ChartArea1";
            this.dem_prom_cli_s2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.dem_prom_cli_s2.Legends.Add(legend5);
            this.dem_prom_cli_s2.Location = new System.Drawing.Point(442, 281);
            this.dem_prom_cli_s2.Name = "dem_prom_cli_s2";
            this.dem_prom_cli_s2.Size = new System.Drawing.Size(403, 178);
            this.dem_prom_cli_s2.TabIndex = 31;
            this.dem_prom_cli_s2.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Utilización del Servidor 2";
            // 
            // utilizacion_serv2
            // 
            chartArea6.Name = "ChartArea1";
            this.utilizacion_serv2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.utilizacion_serv2.Legends.Add(legend6);
            this.utilizacion_serv2.Location = new System.Drawing.Point(442, 485);
            this.utilizacion_serv2.Name = "utilizacion_serv2";
            this.utilizacion_serv2.Size = new System.Drawing.Size(403, 178);
            this.utilizacion_serv2.TabIndex = 33;
            this.utilizacion_serv2.Text = "chart1";
            // 
            // form_2ss_exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 677);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.utilizacion_serv2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dem_prom_cli_s2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cli_en_cola_s2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.utilizacion_serv1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dem_prom_cli_s1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cli_en_cola_s1);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txtTDS2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkServicio);
            this.Controls.Add(this.chkArribo);
            this.Controls.Add(this.txtTDS1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_2ss_exponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidores en Serie - Distribución Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli_s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola_s1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola_s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli_s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.CheckBox chkArribo;
        private System.Windows.Forms.TextBox txtTDS1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTEA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTDS2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion_serv1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom_cli_s1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart cli_en_cola_s1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart cli_en_cola_s2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom_cli_s2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion_serv2;
    }
}