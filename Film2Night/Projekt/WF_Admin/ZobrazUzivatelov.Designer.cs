namespace Projekt
{
    partial class ZobrazUzivatelov
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
            this.nahladUziv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nahladUziv)).BeginInit();
            this.SuspendLayout();
            // 
            // nahladUziv
            // 
            this.nahladUziv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nahladUziv.Location = new System.Drawing.Point(53, 26);
            this.nahladUziv.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nahladUziv.Name = "nahladUziv";
            this.nahladUziv.Size = new System.Drawing.Size(1672, 835);
            this.nahladUziv.TabIndex = 0;
            // 
            // ZobrazUzivatelov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2073, 995);
            this.Controls.Add(this.nahladUziv);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ZobrazUzivatelov";
            this.Text = "Zobraz Uzivatelov";
            this.Load += new System.EventHandler(this.ZobrazUzivatelov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nahladUziv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nahladUziv;
    }
}