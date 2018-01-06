namespace Projekt
{
    partial class MojeFilmy
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
            this.Dalsi = new System.Windows.Forms.Button();
            this.Videl = new System.Windows.Forms.Button();
            this.Koniec = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Label();
            this.popis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dalsi
            // 
            this.Dalsi.Location = new System.Drawing.Point(738, 678);
            this.Dalsi.Name = "Dalsi";
            this.Dalsi.Size = new System.Drawing.Size(153, 121);
            this.Dalsi.TabIndex = 0;
            this.Dalsi.Text = "Ďalší";
            this.Dalsi.UseVisualStyleBackColor = true;
            this.Dalsi.Click += new System.EventHandler(this.Dalsi_Click);
            // 
            // Videl
            // 
            this.Videl.Location = new System.Drawing.Point(469, 678);
            this.Videl.Name = "Videl";
            this.Videl.Size = new System.Drawing.Size(167, 121);
            this.Videl.TabIndex = 1;
            this.Videl.Text = "Už som videl";
            this.Videl.UseVisualStyleBackColor = true;
            this.Videl.Click += new System.EventHandler(this.Videl_Click);
            // 
            // Koniec
            // 
            this.Koniec.Location = new System.Drawing.Point(201, 683);
            this.Koniec.Name = "Koniec";
            this.Koniec.Size = new System.Drawing.Size(151, 116);
            this.Koniec.TabIndex = 2;
            this.Koniec.Text = "Koniec";
            this.Koniec.UseVisualStyleBackColor = true;
            this.Koniec.Click += new System.EventHandler(this.Koniec_Click);
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(293, 93);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(93, 32);
            this.meno.TabIndex = 3;
            this.meno.Text = "label1";
            // 
            // popis
            // 
            this.popis.AutoSize = true;
            this.popis.Location = new System.Drawing.Point(798, 179);
            this.popis.Name = "popis";
            this.popis.Size = new System.Drawing.Size(93, 32);
            this.popis.TabIndex = 4;
            this.popis.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MojeFilmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 879);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.Videl);
            this.Controls.Add(this.Dalsi);
            this.Name = "MojeFilmy";
            this.Text = "MojeFilmy";
            this.Load += new System.EventHandler(this.MojeFilmy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Dalsi;
        private System.Windows.Forms.Button Videl;
        private System.Windows.Forms.Button Koniec;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label popis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}