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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.nevidenéFilmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videnéFilmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.všetkyFilmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 48);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nevidenéFilmyToolStripMenuItem,
            this.videnéFilmyToolStripMenuItem,
            this.všetkyFilmyToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(109, 45);
            this.toolStripDropDownButton1.Text = "Filter";
            // 
            // nevidenéFilmyToolStripMenuItem
            // 
            this.nevidenéFilmyToolStripMenuItem.Name = "nevidenéFilmyToolStripMenuItem";
            this.nevidenéFilmyToolStripMenuItem.Size = new System.Drawing.Size(330, 46);
            this.nevidenéFilmyToolStripMenuItem.Text = "Nevidené filmy";
            this.nevidenéFilmyToolStripMenuItem.Click += new System.EventHandler(this.nevidenéFilmyToolStripMenuItem_Click);
            // 
            // videnéFilmyToolStripMenuItem
            // 
            this.videnéFilmyToolStripMenuItem.Name = "videnéFilmyToolStripMenuItem";
            this.videnéFilmyToolStripMenuItem.Size = new System.Drawing.Size(330, 46);
            this.videnéFilmyToolStripMenuItem.Text = "Videné filmy";
            this.videnéFilmyToolStripMenuItem.Click += new System.EventHandler(this.videnéFilmyToolStripMenuItem_Click);
            // 
            // všetkyFilmyToolStripMenuItem
            // 
            this.všetkyFilmyToolStripMenuItem.Name = "všetkyFilmyToolStripMenuItem";
            this.všetkyFilmyToolStripMenuItem.Size = new System.Drawing.Size(330, 46);
            this.všetkyFilmyToolStripMenuItem.Text = "Všetky filmy";
            this.všetkyFilmyToolStripMenuItem.Click += new System.EventHandler(this.všetkyFilmyToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Location = new System.Drawing.Point(0, 48);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1120, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // MojeFilmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 879);
            this.Controls.Add(this.Koniec);
            this.Controls.Add(this.Videl);
            this.Controls.Add(this.Dalsi);
            this.Controls.Add(this.popis);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MojeFilmy";
            this.Text = "MojeFilmy";
            this.Load += new System.EventHandler(this.MojeFilmy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem nevidenéFilmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videnéFilmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem všetkyFilmyToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}