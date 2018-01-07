namespace Projekt
{
    partial class PridajZNetu
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
            this.button1 = new System.Windows.Forms.Button();
            this.Dalsi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Label();
            this.popis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Koniec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dalsi
            // 
            this.Dalsi.Location = new System.Drawing.Point(86, 211);
            this.Dalsi.Name = "Dalsi";
            this.Dalsi.Size = new System.Drawing.Size(147, 79);
            this.Dalsi.TabIndex = 1;
            this.Dalsi.Text = "Ďalší";
            this.Dalsi.UseVisualStyleBackColor = true;
            this.Dalsi.Click += new System.EventHandler(this.Dalsi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 83);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pridaj do DB";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(275, 41);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(93, 32);
            this.meno.TabIndex = 3;
            this.meno.Text = "label1";
            // 
            // popis
            // 
            this.popis.Location = new System.Drawing.Point(426, 96);
            this.popis.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(400, 500);
            this.popis.TabIndex = 4;
            this.popis.Text = "label2";
            // 
            // PridajZNetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(956, 724);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Dalsi);
            this.Controls.Add(this.button1);
            this.Name = "PridajZNetu";
            this.Text = "PridajZNetu";
            this.Load += new System.EventHandler(this.PridajZNetu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dalsi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label popis;
    }
}