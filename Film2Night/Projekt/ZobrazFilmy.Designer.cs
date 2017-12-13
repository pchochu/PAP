namespace Projekt
{
    partial class ZobrazFilmy
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
            this.nahladFilmy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nahladFilmy)).BeginInit();
            this.SuspendLayout();
            // 
            // nahladFilmy
            // 
            this.nahladFilmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nahladFilmy.Location = new System.Drawing.Point(65, 49);
            this.nahladFilmy.Name = "nahladFilmy";
            this.nahladFilmy.RowTemplate.Height = 40;
            this.nahladFilmy.Size = new System.Drawing.Size(915, 609);
            this.nahladFilmy.TabIndex = 0;
            // 
            // ZobrazFilmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 877);
            this.Controls.Add(this.nahladFilmy);
            this.Name = "ZobrazFilmy";
            this.Text = "Zobraz Filmy";
            this.Load += new System.EventHandler(this.ZobrazFilmy_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nahladFilmy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nahladFilmy;
    }
}