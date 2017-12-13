namespace Projekt
{
    partial class registracia
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
            this.menoPriezvisko = new System.Windows.Forms.TextBox();
            this.userMeno = new System.Windows.Forms.TextBox();
            this.heslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heslo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TlacitkoRegistracia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menoPriezvisko
            // 
            this.menoPriezvisko.Location = new System.Drawing.Point(125, 34);
            this.menoPriezvisko.Name = "menoPriezvisko";
            this.menoPriezvisko.Size = new System.Drawing.Size(100, 20);
            this.menoPriezvisko.TabIndex = 0;
            // 
            // userMeno
            // 
            this.userMeno.Location = new System.Drawing.Point(125, 60);
            this.userMeno.Name = "userMeno";
            this.userMeno.Size = new System.Drawing.Size(100, 20);
            this.userMeno.TabIndex = 1;
            // 
            // heslo
            // 
            this.heslo.Location = new System.Drawing.Point(125, 88);
            this.heslo.Name = "heslo";
            this.heslo.Size = new System.Drawing.Size(100, 20);
            this.heslo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meno a Priezvisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uživateľské meno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Heslo";
            // 
            // heslo2
            // 
            this.heslo2.Location = new System.Drawing.Point(125, 114);
            this.heslo2.Name = "heslo2";
            this.heslo2.Size = new System.Drawing.Size(100, 20);
            this.heslo2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Zopakuj heslo";
            // 
            // TlacitkoRegistracia
            // 
            this.TlacitkoRegistracia.Location = new System.Drawing.Point(136, 146);
            this.TlacitkoRegistracia.Name = "TlacitkoRegistracia";
            this.TlacitkoRegistracia.Size = new System.Drawing.Size(75, 23);
            this.TlacitkoRegistracia.TabIndex = 8;
            this.TlacitkoRegistracia.Text = "Registrácia";
            this.TlacitkoRegistracia.UseVisualStyleBackColor = true;
            this.TlacitkoRegistracia.Click += new System.EventHandler(this.TlacitkoRegistracia_Click);
            // 
            // registracia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 181);
            this.Controls.Add(this.TlacitkoRegistracia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heslo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heslo);
            this.Controls.Add(this.userMeno);
            this.Controls.Add(this.menoPriezvisko);
            this.Name = "registracia";
            this.Text = "registracia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox menoPriezvisko;
        private System.Windows.Forms.TextBox userMeno;
        private System.Windows.Forms.TextBox heslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heslo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TlacitkoRegistracia;
    }
}