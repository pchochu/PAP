namespace Admin
{
    partial class hladajObrazok
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
            this.Pridaj = new System.Windows.Forms.Button();
            this.ObrazokFilmu = new System.Windows.Forms.Label();
            this.Hladaj = new System.Windows.Forms.Button();
            this.obraz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).BeginInit();
            this.SuspendLayout();
            // 
            // Pridaj
            // 
            this.Pridaj.Location = new System.Drawing.Point(496, 542);
            this.Pridaj.Name = "Pridaj";
            this.Pridaj.Size = new System.Drawing.Size(175, 101);
            this.Pridaj.TabIndex = 15;
            this.Pridaj.Text = "Pridaj";
            this.Pridaj.UseVisualStyleBackColor = true;
            this.Pridaj.Click += new System.EventHandler(this.Pridaj_Click);
            // 
            // ObrazokFilmu
            // 
            this.ObrazokFilmu.AutoSize = true;
            this.ObrazokFilmu.Location = new System.Drawing.Point(91, 160);
            this.ObrazokFilmu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ObrazokFilmu.Name = "ObrazokFilmu";
            this.ObrazokFilmu.Size = new System.Drawing.Size(122, 32);
            this.ObrazokFilmu.TabIndex = 14;
            this.ObrazokFilmu.Text = "Obrazok";
            // 
            // Hladaj
            // 
            this.Hladaj.Location = new System.Drawing.Point(54, 268);
            this.Hladaj.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Hladaj.Name = "Hladaj";
            this.Hladaj.Size = new System.Drawing.Size(200, 95);
            this.Hladaj.TabIndex = 13;
            this.Hladaj.Text = "Zmeň obrázok";
            this.Hladaj.UseVisualStyleBackColor = true;
            this.Hladaj.Click += new System.EventHandler(this.Hladaj_Click);
            // 
            // obraz
            // 
            this.obraz.Location = new System.Drawing.Point(294, 115);
            this.obraz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.obraz.Name = "obraz";
            this.obraz.Size = new System.Drawing.Size(611, 391);
            this.obraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obraz.TabIndex = 12;
            this.obraz.TabStop = false;
            // 
            // hladajObrazok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 785);
            this.Controls.Add(this.Pridaj);
            this.Controls.Add(this.ObrazokFilmu);
            this.Controls.Add(this.Hladaj);
            this.Controls.Add(this.obraz);
            this.Name = "hladajObrazok";
            this.Text = "hladajObrazok";
            this.Load += new System.EventHandler(this.hladajObrazok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pridaj;
        private System.Windows.Forms.Label ObrazokFilmu;
        private System.Windows.Forms.Button Hladaj;
        private System.Windows.Forms.PictureBox obraz;
    }
}