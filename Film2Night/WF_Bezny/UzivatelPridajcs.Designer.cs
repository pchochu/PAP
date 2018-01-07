namespace WF_Bezny
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
            this.pridaj = new System.Windows.Forms.Button();
            this.dalsi = new System.Windows.Forms.Button();
            this.ukonci = new System.Windows.Forms.Button();
            this.popis = new System.Windows.Forms.Label();
            this.obrazok = new System.Windows.Forms.PictureBox();
            this.meno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obrazok)).BeginInit();
            this.SuspendLayout();
            // 
            // pridaj
            // 
            this.pridaj.Location = new System.Drawing.Point(295, 869);
            this.pridaj.Name = "pridaj";
            this.pridaj.Size = new System.Drawing.Size(312, 133);
            this.pridaj.TabIndex = 11;
            this.pridaj.Text = "Pridaj";
            this.pridaj.UseVisualStyleBackColor = true;
            this.pridaj.Click += new System.EventHandler(this.pridaj_Click);
            // 
            // dalsi
            // 
            this.dalsi.Location = new System.Drawing.Point(651, 918);
            this.dalsi.Name = "dalsi";
            this.dalsi.Size = new System.Drawing.Size(179, 84);
            this.dalsi.TabIndex = 10;
            this.dalsi.Text = "Ďalší";
            this.dalsi.UseVisualStyleBackColor = true;
            this.dalsi.Click += new System.EventHandler(this.dalsi_Click);
            // 
            // ukonci
            // 
            this.ukonci.Location = new System.Drawing.Point(98, 902);
            this.ukonci.Name = "ukonci";
            this.ukonci.Size = new System.Drawing.Size(163, 90);
            this.ukonci.TabIndex = 9;
            this.ukonci.Text = "Ukonči";
            this.ukonci.UseVisualStyleBackColor = true;
            this.ukonci.Click += new System.EventHandler(this.ukonci_Click);
            // 
            // popis
            // 
            this.popis.Location = new System.Drawing.Point(792, 219);
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(400, 500);
            this.popis.TabIndex = 8;
            this.popis.Text = "label2";
            // 
            // obrazok
            // 
            this.obrazok.Location = new System.Drawing.Point(195, 197);
            this.obrazok.Name = "obrazok";
            this.obrazok.Size = new System.Drawing.Size(528, 575);
            this.obrazok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obrazok.TabIndex = 7;
            this.obrazok.TabStop = false;
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(524, 76);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(93, 32);
            this.meno.TabIndex = 6;
            this.meno.Text = "label1";
            // 
            // UzivatelPridajcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1471, 1142);
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

        private System.Windows.Forms.Button pridaj;
        private System.Windows.Forms.Button dalsi;
        private System.Windows.Forms.Button ukonci;
        private System.Windows.Forms.Label popis;
        private System.Windows.Forms.PictureBox obrazok;
        private System.Windows.Forms.Label meno;
    }
}