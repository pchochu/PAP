namespace WF_Bezny
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
            this.moje = new System.Windows.Forms.Button();
            this.pridaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.meno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moje
            // 
            this.moje.Location = new System.Drawing.Point(723, 566);
            this.moje.Name = "moje";
            this.moje.Size = new System.Drawing.Size(184, 128);
            this.moje.TabIndex = 7;
            this.moje.Text = "Moje Filmy";
            this.moje.UseVisualStyleBackColor = true;
            this.moje.Click += new System.EventHandler(this.moje_Click);
            // 
            // pridaj
            // 
            this.pridaj.Location = new System.Drawing.Point(281, 566);
            this.pridaj.Name = "pridaj";
            this.pridaj.Size = new System.Drawing.Size(191, 128);
            this.pridaj.TabIndex = 6;
            this.pridaj.Text = "Pridaj Film";
            this.pridaj.UseVisualStyleBackColor = true;
            this.pridaj.Click += new System.EventHandler(this.pridaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(236, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vitaj";
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(236, 220);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(86, 32);
            this.meno.TabIndex = 4;
            this.meno.Text = "meno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(80, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Uživatelské rozhranie";
            // 
            // hlavne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1152, 847);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moje);
            this.Controls.Add(this.pridaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.meno);
            this.Name = "hlavne";
            this.Text = "hlavne";
            this.Load += new System.EventHandler(this.hlavne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moje;
        private System.Windows.Forms.Button pridaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label label3;
    }
}