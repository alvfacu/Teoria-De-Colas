﻿namespace Trabajo_Practico_Simulaicon
{
    partial class form_seleccion_distribucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_seleccion_distribucion));
            this.btn_dist_exp = new System.Windows.Forms.Button();
            this.btn_dist_uni = new System.Windows.Forms.Button();
            this.btn_dist_weibull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dist_exp
            // 
            this.btn_dist_exp.Location = new System.Drawing.Point(12, 12);
            this.btn_dist_exp.Name = "btn_dist_exp";
            this.btn_dist_exp.Size = new System.Drawing.Size(217, 39);
            this.btn_dist_exp.TabIndex = 1;
            this.btn_dist_exp.Text = "Distribución Exponencial";
            this.btn_dist_exp.UseVisualStyleBackColor = true;
            this.btn_dist_exp.Click += new System.EventHandler(this.btn_dist_exp_Click);
            // 
            // btn_dist_uni
            // 
            this.btn_dist_uni.Location = new System.Drawing.Point(12, 57);
            this.btn_dist_uni.Name = "btn_dist_uni";
            this.btn_dist_uni.Size = new System.Drawing.Size(217, 39);
            this.btn_dist_uni.TabIndex = 2;
            this.btn_dist_uni.Text = "Distribución Uniforme";
            this.btn_dist_uni.UseVisualStyleBackColor = true;
            this.btn_dist_uni.Click += new System.EventHandler(this.btn_dist_uni_Click);
            // 
            // btn_dist_weibull
            // 
            this.btn_dist_weibull.Location = new System.Drawing.Point(12, 102);
            this.btn_dist_weibull.Name = "btn_dist_weibull";
            this.btn_dist_weibull.Size = new System.Drawing.Size(217, 39);
            this.btn_dist_weibull.TabIndex = 3;
            this.btn_dist_weibull.Text = "Distribución Weibull";
            this.btn_dist_weibull.UseVisualStyleBackColor = true;
            this.btn_dist_weibull.Click += new System.EventHandler(this.btn_dist_weibull_Click);
            // 
            // form_seleccion_distribucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(241, 152);
            this.Controls.Add(this.btn_dist_weibull);
            this.Controls.Add(this.btn_dist_uni);
            this.Controls.Add(this.btn_dist_exp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "form_seleccion_distribucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribución";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_dist_exp;
        private System.Windows.Forms.Button btn_dist_uni;
        private System.Windows.Forms.Button btn_dist_weibull;
    }
}