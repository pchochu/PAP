namespace Projekt
{
    partial class hlavne
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
            this.label1 = new System.Windows.Forms.Label();
            this.pridaj = new System.Windows.Forms.Button();
            this.moje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(52, 106);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(86, 32);
            this.meno.TabIndex = 0;
            this.meno.Text = "meno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vitaj";
            // 
            // pridaj
            // 
            this.pridaj.Location = new System.Drawing.Point(239, 506);
            this.pridaj.Name = "pridaj";
            this.pridaj.Size = new System.Drawing.Size(191, 128);
            this.pridaj.TabIndex = 2;
            this.pridaj.Text = "Pridaj Film";
            this.pridaj.UseVisualStyleBackColor = true;
            this.pridaj.Click += new System.EventHandler(this.pridaj_Click);
            // 
            // moje
            // 
            this.moje.Location = new System.Drawing.Point(681, 506);
            this.moje.Name = "moje";
            this.moje.Size = new System.Drawing.Size(184, 128);
            this.moje.TabIndex = 3;
            this.moje.Text = "Moje Filmy";
            this.moje.UseVisualStyleBackColor = true;
            // 
            // hlavne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1163, 782);
            this.Controls.Add(this.moje);
            this.Controls.Add(this.pridaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meno);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "hlavne";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.hlavne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pridaj;
        private System.Windows.Forms.Button moje;
    }
}