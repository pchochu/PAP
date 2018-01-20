namespace Admin
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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nahladFilmy)).BeginInit();
            this.SuspendLayout();
            // 
            // nahladFilmy
            // 
            this.nahladFilmy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nahladFilmy.Location = new System.Drawing.Point(87, 216);
            this.nahladFilmy.Name = "nahladFilmy";
            this.nahladFilmy.RowTemplate.Height = 40;
            this.nahladFilmy.Size = new System.Drawing.Size(1248, 710);
            this.nahladFilmy.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(529, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Databáza filmov";
            // 
            // ZobrazFilmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1448, 1020);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nahladFilmy);
            this.Name = "ZobrazFilmy";
            this.Text = "ZobrazFilmy";
            this.Load += new System.EventHandler(this.ZobrazFilmy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nahladFilmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nahladFilmy;
        private System.Windows.Forms.Label label3;
    }
}