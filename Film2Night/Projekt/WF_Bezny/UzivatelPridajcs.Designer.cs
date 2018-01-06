namespace Projekt
{
    partial class UzivatelPridajcs
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
            this.meno = new System.Windows.Forms.Label();
            this.obrazok = new System.Windows.Forms.PictureBox();
            this.popis = new System.Windows.Forms.Label();
            this.ukonci = new System.Windows.Forms.Button();
            this.dalsi = new System.Windows.Forms.Button();
            this.pridaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazok)).BeginInit();
            this.SuspendLayout();
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(488, 49);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(93, 32);
            this.meno.TabIndex = 0;
            this.meno.Text = "label1";
            // 
            // obrazok
            // 
            this.obrazok.Location = new System.Drawing.Point(163, 247);
            this.obrazok.Name = "obrazok";
            this.obrazok.Size = new System.Drawing.Size(796, 663);
            this.obrazok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obrazok.TabIndex = 1;
            this.obrazok.TabStop = false;
            // 
            // popis
            // 
            this.popis.AutoSize = true;
            this.popis.Location = new System.Drawing.Point(488, 160);
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(93, 32);
            this.popis.TabIndex = 2;
            this.popis.Text = "label2";
            // 
            // ukonci
            // 
            this.ukonci.Location = new System.Drawing.Point(94, 995);
            this.ukonci.Name = "ukonci";
            this.ukonci.Size = new System.Drawing.Size(163, 90);
            this.ukonci.TabIndex = 3;
            this.ukonci.Text = "Ukonči";
            this.ukonci.UseVisualStyleBackColor = true;
            this.ukonci.Click += new System.EventHandler(this.ukonci_Click);
            // 
            // dalsi
            // 
            this.dalsi.Location = new System.Drawing.Point(862, 1001);
            this.dalsi.Name = "dalsi";
            this.dalsi.Size = new System.Drawing.Size(179, 84);
            this.dalsi.TabIndex = 4;
            this.dalsi.Text = "Ďalší";
            this.dalsi.UseVisualStyleBackColor = true;
            this.dalsi.Click += new System.EventHandler(this.dalsi_Click);
            // 
            // pridaj
            // 
            this.pridaj.Location = new System.Drawing.Point(410, 952);
            this.pridaj.Name = "pridaj";
            this.pridaj.Size = new System.Drawing.Size(312, 133);
            this.pridaj.TabIndex = 5;
            this.pridaj.Text = "Pridaj";
            this.pridaj.UseVisualStyleBackColor = true;
            this.pridaj.Click += new System.EventHandler(this.pridaj_Click);
            // 
            // UzivatelPridajcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1358, 1244);
            this.Controls.Add(this.pridaj);
            this.Controls.Add(this.dalsi);
            this.Controls.Add(this.ukonci);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.obrazok);
            this.Controls.Add(this.meno);
            this.Name = "UzivatelPridajcs";
            this.Text = "UzivatelPridajcs";
            this.Load += new System.EventHandler(this.UzivatelPridajcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obrazok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.PictureBox obrazok;
        private System.Windows.Forms.Label popis;
        private System.Windows.Forms.Button ukonci;
        private System.Windows.Forms.Button dalsi;
        private System.Windows.Forms.Button pridaj;
    }
}