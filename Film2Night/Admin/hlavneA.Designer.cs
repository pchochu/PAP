namespace Admin
{
    partial class hlavneA
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
            this.Nove = new System.Windows.Forms.Button();
            this.Vlastny = new System.Windows.Forms.Button();
            this.meno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uživateľovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nove
            // 
            this.Nove.Location = new System.Drawing.Point(651, 595);
            this.Nove.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Nove.Name = "Nove";
            this.Nove.Size = new System.Drawing.Size(371, 95);
            this.Nove.TabIndex = 10;
            this.Nove.Text = "Nove filmy";
            this.Nove.UseVisualStyleBackColor = true;
            this.Nove.Click += new System.EventHandler(this.Nove_Click);
            // 
            // Vlastny
            // 
            this.Vlastny.Location = new System.Drawing.Point(205, 595);
            this.Vlastny.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Vlastny.Name = "Vlastny";
            this.Vlastny.Size = new System.Drawing.Size(371, 93);
            this.Vlastny.TabIndex = 9;
            this.Vlastny.Text = "Vlastny film";
            this.Vlastny.UseVisualStyleBackColor = true;
            this.Vlastny.Click += new System.EventHandler(this.Vlastny_Click);
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(59, 321);
            this.meno.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(86, 32);
            this.meno.TabIndex = 8;
            this.meno.Text = "meno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vitaj";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobraziťToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip2.Size = new System.Drawing.Size(1257, 58);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // zobraziťToolStripMenuItem
            // 
            this.zobraziťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmyToolStripMenuItem,
            this.uživateľovToolStripMenuItem});
            this.zobraziťToolStripMenuItem.Name = "zobraziťToolStripMenuItem";
            this.zobraziťToolStripMenuItem.Size = new System.Drawing.Size(142, 48);
            this.zobraziťToolStripMenuItem.Text = "Zobraziť";
            // 
            // filmyToolStripMenuItem
            // 
            this.filmyToolStripMenuItem.Name = "filmyToolStripMenuItem";
            this.filmyToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.filmyToolStripMenuItem.Text = "Filmy";
            this.filmyToolStripMenuItem.Click += new System.EventHandler(this.filmyToolStripMenuItem_Click);
            // 
            // uživateľovToolStripMenuItem
            // 
            this.uživateľovToolStripMenuItem.Name = "uživateľovToolStripMenuItem";
            this.uživateľovToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.uživateľovToolStripMenuItem.Text = "Uživateľov";
            this.uživateľovToolStripMenuItem.Click += new System.EventHandler(this.uživateľovToolStripMenuItem_Click);
            // 
            // hlavneA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1257, 861);
            this.Controls.Add(this.Nove);
            this.Controls.Add(this.Vlastny);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "hlavneA";
            this.Text = "hlavneA";
            this.Load += new System.EventHandler(this.hlavneA_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nove;
        private System.Windows.Forms.Button Vlastny;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem zobraziťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uživateľovToolStripMenuItem;
    }
}