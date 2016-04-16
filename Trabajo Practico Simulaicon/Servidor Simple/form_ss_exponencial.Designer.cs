namespace Trabajo_Practico_Simulaicon
{
    partial class form_ss_exponencial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ss_exponencial));
            this.label1 = new System.Windows.Forms.Label();
            this.txtHs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTEA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTDS = new System.Windows.Forms.TextBox();
            this.btn_simular = new System.Windows.Forms.Button();
            this.chkArribo = new System.Windows.Forms.CheckBox();
            this.chkServicio = new System.Windows.Forms.CheckBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantida de Hs. a simular:";
            // 
            // txtHs
            // 
            this.txtHs.Location = new System.Drawing.Point(24, 25);
            this.txtHs.Name = "txtHs";
            this.txtHs.Size = new System.Drawing.Size(100, 20);
            this.txtHs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo entre arribos:";
            // 
            // txtTEA
            // 
            this.txtTEA.Location = new System.Drawing.Point(173, 25);
            this.txtTEA.Name = "txtTEA";
            this.txtTEA.Size = new System.Drawing.Size(100, 20);
            this.txtTEA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo de servicio:";
            // 
            // txtTDS
            // 
            this.txtTDS.Location = new System.Drawing.Point(311, 25);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.Size = new System.Drawing.Size(100, 20);
            this.txtTDS.TabIndex = 5;
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(433, 22);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 6;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Utilización del Servidor";
            // 
            // utilizacion_serv
            // 
            chartArea1.Name = "ChartArea1";
            this.utilizacion_serv.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.utilizacion_serv.Legends.Add(legend1);
            this.utilizacion_serv.Location = new System.Drawing.Point(15, 484);
            this.utilizacion_serv.Name = "utilizacion_serv";
            this.utilizacion_serv.Size = new System.Drawing.Size(514, 178);
            this.utilizacion_serv.TabIndex = 19;
            this.utilizacion_serv.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Demora Promedio de Clientes";
            // 
            // dem_prom_cli
            // 
            chartArea2.Name = "ChartArea1";
            this.dem_prom_cli.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dem_prom_cli.Legends.Add(legend2);
            this.dem_prom_cli.Location = new System.Drawing.Point(15, 280);
            this.dem_prom_cli.Name = "dem_prom_cli";
            this.dem_prom_cli.Size = new System.Drawing.Size(514, 178);
            this.dem_prom_cli.TabIndex = 17;
            this.dem_prom_cli.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cant de Clientes en Cola";
            // 
            // cli_en_cola
            // 
            chartArea3.Name = "ChartArea1";
            this.cli_en_cola.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cli_en_cola.Legends.Add(legend3);
            this.cli_en_cola.Location = new System.Drawing.Point(15, 72);
            this.cli_en_cola.Name = "cli_en_cola";
            this.cli_en_cola.Size = new System.Drawing.Size(514, 178);
            this.cli_en_cola.TabIndex = 15;
            this.cli_en_cola.Text = "chart1";
            // 
            // form_ss_exponencial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(547, 675);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.utilizacion_serv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dem_prom_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cli_en_cola);
            this.Controls.Add(this.chkServicio);
            this.Controls.Add(this.chkArribo);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.txtTDS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHs);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_ss_exponencial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor Simple - Distribución Exponencial";
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion_serv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom_cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cli_en_cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTEA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTDS;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.CheckBox chkArribo;
        private System.Windows.Forms.CheckBox chkServicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion_serv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom_cli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cli_en_cola;
    }
}