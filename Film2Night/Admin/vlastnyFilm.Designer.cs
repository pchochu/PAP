namespace Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.ObrazokFilmu = new System.Windows.Forms.Label();
            this.PopisFilmu = new System.Windows.Forms.Label();
            this.MenoFilmu = new System.Windows.Forms.Label();
            this.HladajObrazok = new System.Windows.Forms.Button();
            this.Uloz = new System.Windows.Forms.Button();
            this.obraz = new System.Windows.Forms.PictureBox();
            this.popis = new System.Windows.Forms.TextBox();
            this.meno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(344, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 52);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pridaj vlastny film";
            // 
            // ObrazokFilmu
            // 
            this.ObrazokFilmu.AutoSize = true;
            this.ObrazokFilmu.Location = new System.Drawing.Point(136, 558);
            this.ObrazokFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ObrazokFilmu.Name = "ObrazokFilmu";
            this.ObrazokFilmu.Size = new System.Drawing.Size(122, 32);
            this.ObrazokFilmu.TabIndex = 16;
            this.ObrazokFilmu.Text = "Obrazok";
            // 
            // PopisFilmu
            // 
            this.PopisFilmu.AutoSize = true;
            this.PopisFilmu.Location = new System.Drawing.Point(136, 270);
            this.PopisFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PopisFilmu.Name = "PopisFilmu";
            this.PopisFilmu.Size = new System.Drawing.Size(87, 32);
            this.PopisFilmu.TabIndex = 15;
            this.PopisFilmu.Text = "Popis";
            // 
            // MenoFilmu
            // 
            this.MenoFilmu.AutoSize = true;
            this.MenoFilmu.Location = new System.Drawing.Point(136, 146);
            this.MenoFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.MenoFilmu.Name = "MenoFilmu";
            this.MenoFilmu.Size = new System.Drawing.Size(86, 32);
            this.MenoFilmu.TabIndex = 14;
            this.MenoFilmu.Text = "Meno";
            // 
            // HladajObrazok
            // 
            this.HladajObrazok.Location = new System.Drawing.Point(99, 666);
            this.HladajObrazok.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.HladajObrazok.Name = "HladajObrazok";
            this.HladajObrazok.Size = new System.Drawing.Size(200, 95);
            this.HladajObrazok.TabIndex = 13;
            this.HladajObrazok.Text = "Hladaj obrazok";
            this.HladajObrazok.UseVisualStyleBackColor = true;
            this.HladajObrazok.Click += new System.EventHandler(this.HladajObrazok_Click);
            // 
            // Uloz
            // 
            this.Uloz.Location = new System.Drawing.Point(525, 976);
            this.Uloz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Uloz.Name = "Uloz";
            this.Uloz.Size = new System.Drawing.Size(200, 55);
            this.Uloz.TabIndex = 12;
            this.Uloz.Text = "Uloz";
            this.Uloz.UseVisualStyleBackColor = true;
            this.Uloz.Click += new System.EventHandler(this.Uloz_Click);
            // 
            // obraz
            // 
            this.obraz.Location = new System.Drawing.Point(344, 558);
            this.obraz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.obraz.Name = "obraz";
            this.obraz.Size = new System.Drawing.Size(611, 391);
            this.obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obraz.TabIndex = 11;
            this.obraz.TabStop = false;
            // 
            // popis
            // 
            this.popis.Location = new System.Drawing.Point(440, 270);
            this.popis.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.popis.Multiline = true;
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(399, 202);
            this.popis.TabIndex = 10;
            // 
            // meno
            // 
            this.meno.Location = new System.Drawing.Point(440, 146);
            this.meno.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(399, 38);
            this.meno.TabIndex = 9;
            // 
            // vlastnyFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 1089);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObrazokFilmu);
            this.Controls.Add(this.PopisFilmu);
            this.Controls.Add(this.MenoFilmu);
            this.Controls.Add(this.HladajObrazok);
            this.Controls.Add(this.Uloz);
            this.Controls.Add(this.obraz);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.meno);
            this.Name = "vlastnyFilm";
            this.Text = "vlastnyFilm";
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ObrazokFilmu;
        private System.Windows.Forms.Label PopisFilmu;
        private System.Windows.Forms.Label MenoFilmu;
        private System.Windows.Forms.Button HladajObrazok;
        private System.Windows.Forms.Button Uloz;
        private System.Windows.Forms.PictureBox obraz;
        private System.Windows.Forms.TextBox popis;
        private System.Windows.Forms.TextBox meno;
    }
}