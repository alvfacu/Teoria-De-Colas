namespace Trabajo_Practico_Simulacion.Servidor_Simple
{
    partial class form_ss_comparativa
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ss_comparativa));
            this.cant_cli_cola = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dem_prom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.utilizacion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cant_cli_cola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cant_cli_cola
            // 
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea1.AxisY.Title = "Cant Promedio de Clientes en Cola";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.cant_cli_cola.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Referencias";
            legend1.Title = "Referencias";
            this.cant_cli_cola.Legends.Add(legend1);
            this.cant_cli_cola.Location = new System.Drawing.Point(12, 12);
            this.cant_cli_cola.Name = "cant_cli_cola";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Referencias";
            series1.Name = "Exponencial";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Referencias";
            series2.MarkerSize = 6;
            series2.Name = "Uniforme";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Referencias";
            series3.MarkerSize = 8;
            series3.Name = "Weibull";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cant_cli_cola.Series.Add(series1);
            this.cant_cli_cola.Series.Add(series2);
            this.cant_cli_cola.Series.Add(series3);
            this.cant_cli_cola.Size = new System.Drawing.Size(542, 218);
            this.cant_cli_cola.TabIndex = 0;
            // 
            // dem_prom
            // 
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea2.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea2.AxisY.Title = "Demoria Promedio de Clientes";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.dem_prom.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Name = "Referencias";
            legend2.Title = "Referencias";
            this.dem_prom.Legends.Add(legend2);
            this.dem_prom.Location = new System.Drawing.Point(12, 236);
            this.dem_prom.Name = "dem_prom";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Referencias";
            series4.Name = "Exponencial";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Referencias";
            series5.MarkerSize = 6;
            series5.Name = "Uniforme";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.YValuesPerPoint = 2;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Green;
            series6.Legend = "Referencias";
            series6.MarkerSize = 8;
            series6.Name = "Weibull";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.dem_prom.Series.Add(series4);
            this.dem_prom.Series.Add(series5);
            this.dem_prom.Series.Add(series6);
            this.dem_prom.Size = new System.Drawing.Size(542, 218);
            this.dem_prom.TabIndex = 1;
            // 
            // utilizacion
            // 
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            chartArea3.AxisY.Title = "Utilización del Servidor (%)";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.Name = "ChartArea1";
            this.utilizacion.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Name = "Referencias";
            legend3.Title = "Referencias";
            this.utilizacion.Legends.Add(legend3);
            this.utilizacion.Location = new System.Drawing.Point(12, 460);
            this.utilizacion.Name = "utilizacion";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series7.Legend = "Referencias";
            series7.Name = "Exponencial";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Referencias";
            series8.MarkerSize = 6;
            series8.Name = "Uniforme";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.YValuesPerPoint = 2;
            series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series9.Color = System.Drawing.Color.Green;
            series9.Legend = "Referencias";
            series9.MarkerSize = 8;
            series9.Name = "Weibull";
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.utilizacion.Series.Add(series7);
            this.utilizacion.Series.Add(series8);
            this.utilizacion.Series.Add(series9);
            this.utilizacion.Size = new System.Drawing.Size(542, 218);
            this.utilizacion.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(534, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_ss_comparativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utilizacion);
            this.Controls.Add(this.dem_prom);
            this.Controls.Add(this.cant_cli_cola);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ss_comparativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparativa Servidor Simple";
            this.Load += new System.EventHandler(this.form_ss_comparativa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cant_cli_cola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dem_prom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cant_cli_cola;
        private System.Windows.Forms.DataVisualization.Charting.Chart dem_prom;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilizacion;
        private System.Windows.Forms.Button button1;
    }
}