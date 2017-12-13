namespace Projekt
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.upraviťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uživateľovToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zobraziťToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uživateľovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.meno = new System.Windows.Forms.Label();
            this.Vlastny = new System.Windows.Forms.Button();
            this.Nove = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upraviťToolStripMenuItem,
            this.zobraziťToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(452, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // upraviťToolStripMenuItem
            // 
            this.upraviťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmyToolStripMenuItem1,
            this.uživateľovToolStripMenuItem1});
            this.upraviťToolStripMenuItem.Name = "upraviťToolStripMenuItem";
            this.upraviťToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.upraviťToolStripMenuItem.Text = "Upraviť";
            // 
            // filmyToolStripMenuItem1
            // 
            this.filmyToolStripMenuItem1.Name = "filmyToolStripMenuItem1";
            this.filmyToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.filmyToolStripMenuItem1.Text = "Filmy";
            // 
            // uživateľovToolStripMenuItem1
            // 
            this.uživateľovToolStripMenuItem1.Name = "uživateľovToolStripMenuItem1";
            this.uživateľovToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.uživateľovToolStripMenuItem1.Text = "Uživateľov";
            // 
            // zobraziťToolStripMenuItem
            // 
            this.zobraziťToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmyToolStripMenuItem,
            this.uživateľovToolStripMenuItem});
            this.zobraziťToolStripMenuItem.Name = "zobraziťToolStripMenuItem";
            this.zobraziťToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.zobraziťToolStripMenuItem.Text = "Zobraziť";
            // 
            // filmyToolStripMenuItem
            // 
            this.filmyToolStripMenuItem.Name = "filmyToolStripMenuItem";
            this.filmyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.filmyToolStripMenuItem.Text = "Filmy";
            // 
            // uživateľovToolStripMenuItem
            // 
            this.uživateľovToolStripMenuItem.Name = "uživateľovToolStripMenuItem";
            this.uživateľovToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.uživateľovToolStripMenuItem.Text = "Uživateľov";
            this.uživateľovToolStripMenuItem.Click += new System.EventHandler(this.uživateľovToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vitaj";
            // 
            // meno
            // 
            this.meno.AutoSize = true;
            this.meno.Location = new System.Drawing.Point(22, 63);
            this.meno.Name = "meno";
            this.meno.Size = new System.Drawing.Size(33, 13);
            this.meno.TabIndex = 3;
            this.meno.Text = "meno";
            // 
            // Vlastny
            // 
            this.Vlastny.Location = new System.Drawing.Point(77, 178);
            this.Vlastny.Name = "Vlastny";
            this.Vlastny.Size = new System.Drawing.Size(139, 39);
            this.Vlastny.TabIndex = 4;
            this.Vlastny.Text = "Vlastny film";
            this.Vlastny.UseVisualStyleBackColor = true;
            this.Vlastny.Click += new System.EventHandler(this.Vlastny_Click);
            // 
            // Nove
            // 
            this.Nove.Location = new System.Drawing.Point(244, 178);
            this.Nove.Name = "Nove";
            this.Nove.Size = new System.Drawing.Size(139, 40);
            this.Nove.TabIndex = 5;
            this.Nove.Text = "Nove filmy";
            this.Nove.UseVisualStyleBackColor = true;
            this.Nove.Click += new System.EventHandler(this.Nove_Click);
            // 
            // hlavneA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 280);
            this.Controls.Add(this.Nove);
            this.Controls.Add(this.Vlastny);
            this.Controls.Add(this.meno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "hlavneA";
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.hlavneA_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem upraviťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uživateľovToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zobraziťToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uživateľovToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label meno;
        private System.Windows.Forms.Button Vlastny;
        private System.Windows.Forms.Button Nove;
    }
}