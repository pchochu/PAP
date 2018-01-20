namespace Admin
{
    partial class RegistraciaAdmin
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
            this.TlacitkoRegistracia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.heslo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.heslo = new System.Windows.Forms.TextBox();
            this.userMeno = new System.Windows.Forms.TextBox();
            this.menoPriezvisko = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TlacitkoRegistracia
            // 
            this.TlacitkoRegistracia.Location = new System.Drawing.Point(416, 444);
            this.TlacitkoRegistracia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TlacitkoRegistracia.Name = "TlacitkoRegistracia";
            this.TlacitkoRegistracia.Size = new System.Drawing.Size(200, 55);
            this.TlacitkoRegistracia.TabIndex = 26;
            this.TlacitkoRegistracia.Text = "Registrácia";
            this.TlacitkoRegistracia.UseVisualStyleBackColor = true;
            this.TlacitkoRegistracia.Click += new System.EventHandler(this.TlacitkoRegistracia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 368);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Zopakuj heslo";
            // 
            // heslo2
            // 
            this.heslo2.Location = new System.Drawing.Point(386, 368);
            this.heslo2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.heslo2.Name = "heslo2";
            this.heslo2.Size = new System.Drawing.Size(260, 38);
            this.heslo2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Heslo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Uživateľské meno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Meno a Priezvisko";
            // 
            // heslo
            // 
            this.heslo.Location = new System.Drawing.Point(386, 306);
            this.heslo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.heslo.Name = "heslo";
            this.heslo.Size = new System.Drawing.Size(260, 38);
            this.heslo.TabIndex = 20;
            // 
            // userMeno
            // 
            this.userMeno.Location = new System.Drawing.Point(386, 239);
            this.userMeno.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.userMeno.Name = "userMeno";
            this.userMeno.Size = new System.Drawing.Size(260, 38);
            this.userMeno.TabIndex = 19;
            // 
            // menoPriezvisko
            // 
            this.menoPriezvisko.Location = new System.Drawing.Point(386, 177);
            this.menoPriezvisko.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.menoPriezvisko.Name = "menoPriezvisko";
            this.menoPriezvisko.Size = new System.Drawing.Size(260, 38);
            this.menoPriezvisko.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(120, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(577, 46);
            this.label5.TabIndex = 27;
            this.label5.Text = "Pridaj ďalšieho administrátora";
            // 
            // RegistraciaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 570);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TlacitkoRegistracia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heslo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heslo);
            this.Controls.Add(this.userMeno);
            this.Controls.Add(this.menoPriezvisko);
            this.Name = "RegistraciaAdmin";
            this.Text = "RegistraciaAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TlacitkoRegistracia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox heslo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heslo;
        private System.Windows.Forms.TextBox userMeno;
        private System.Windows.Forms.TextBox menoPriezvisko;
        private System.Windows.Forms.Label label5;
    }
}