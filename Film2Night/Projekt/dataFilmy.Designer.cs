﻿namespace Projekt
{
    partial class dataFilmy
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
            this.filmy = new System.Windows.Forms.ListView();
            this.Meno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Popis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // filmy
            // 
            this.filmy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Meno,
            this.Popis});
            this.filmy.Location = new System.Drawing.Point(23, 12);
            this.filmy.Name = "filmy";
            this.filmy.Size = new System.Drawing.Size(640, 300);
            this.filmy.TabIndex = 0;
            this.filmy.UseCompatibleStateImageBehavior = false;
            this.filmy.View = System.Windows.Forms.View.Details;
            // 
            // Meno
            // 
            this.Meno.Text = "Meno";
            this.Meno.Width = 90;
            // 
            // Popis
            // 
            this.Popis.Text = "Popis";
            this.Popis.Width = 480;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // dataFilmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 345);
            this.Controls.Add(this.filmy);
            this.Name = "dataFilmy";
            this.Text = "dataFilmy";
            this.Load += new System.EventHandler(this.dataFilmy_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView filmy;
        private System.Windows.Forms.ColumnHeader Meno;
        private System.Windows.Forms.ColumnHeader Popis;
        private System.Windows.Forms.ColumnHeader ID;
    }
}