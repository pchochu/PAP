﻿namespace Projekt
{
    partial class vlastnyFilm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Uloz = new System.Windows.Forms.Button();
            this.HladajObrazok = new System.Windows.Forms.Button();
            this.MenoFilmu = new System.Windows.Forms.Label();
            this.PopisFilmu = new System.Windows.Forms.Label();
            this.ObrazokFilmu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 129);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 38);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(432, 253);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 202);
            this.textBox2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(336, 541);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Uloz
            // 
            this.Uloz.Location = new System.Drawing.Point(517, 959);
            this.Uloz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Uloz.Name = "Uloz";
            this.Uloz.Size = new System.Drawing.Size(200, 55);
            this.Uloz.TabIndex = 3;
            this.Uloz.Text = "Uloz";
            this.Uloz.UseVisualStyleBackColor = true;
            this.Uloz.Click += new System.EventHandler(this.Uloz_Click);
            // 
            // HladajObrazok
            // 
            this.HladajObrazok.Location = new System.Drawing.Point(91, 649);
            this.HladajObrazok.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.HladajObrazok.Name = "HladajObrazok";
            this.HladajObrazok.Size = new System.Drawing.Size(200, 95);
            this.HladajObrazok.TabIndex = 4;
            this.HladajObrazok.Text = "Hladaj obrazok";
            this.HladajObrazok.UseVisualStyleBackColor = true;
            this.HladajObrazok.Click += new System.EventHandler(this.HladajObrazok_Click);
            // 
            // MenoFilmu
            // 
            this.MenoFilmu.AutoSize = true;
            this.MenoFilmu.Location = new System.Drawing.Point(128, 129);
            this.MenoFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MenoFilmu.Name = "MenoFilmu";
            this.MenoFilmu.Size = new System.Drawing.Size(86, 32);
            this.MenoFilmu.TabIndex = 5;
            this.MenoFilmu.Text = "Meno";
            // 
            // PopisFilmu
            // 
            this.PopisFilmu.AutoSize = true;
            this.PopisFilmu.Location = new System.Drawing.Point(128, 253);
            this.PopisFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PopisFilmu.Name = "PopisFilmu";
            this.PopisFilmu.Size = new System.Drawing.Size(87, 32);
            this.PopisFilmu.TabIndex = 6;
            this.PopisFilmu.Text = "Popis";
            // 
            // ObrazokFilmu
            // 
            this.ObrazokFilmu.AutoSize = true;
            this.ObrazokFilmu.Location = new System.Drawing.Point(128, 541);
            this.ObrazokFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ObrazokFilmu.Name = "ObrazokFilmu";
            this.ObrazokFilmu.Size = new System.Drawing.Size(122, 32);
            this.ObrazokFilmu.TabIndex = 7;
            this.ObrazokFilmu.Text = "Obrazok";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(336, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pridaj vlastny film";
            // 
            // vlastnyFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 1042);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObrazokFilmu);
            this.Controls.Add(this.PopisFilmu);
            this.Controls.Add(this.MenoFilmu);
            this.Controls.Add(this.HladajObrazok);
            this.Controls.Add(this.Uloz);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "vlastnyFilm";
            this.Text = "vlastnyFilm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Uloz;
        private System.Windows.Forms.Button HladajObrazok;
        private System.Windows.Forms.Label MenoFilmu;
        private System.Windows.Forms.Label PopisFilmu;
        private System.Windows.Forms.Label ObrazokFilmu;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}