namespace Vozovy_Park_V2
{
    partial class OdebratUzivatele
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ujmeno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_heslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_uzivatelOD = new System.Windows.Forms.TextBox();
            this.potvrdi_smazat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(84, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 73);
            this.label1.TabIndex = 23;
            this.label1.Text = "Odebrání uživatele";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ujmeno
            // 
            this.textBox_ujmeno.Location = new System.Drawing.Point(51, 432);
            this.textBox_ujmeno.Multiline = true;
            this.textBox_ujmeno.Name = "textBox_ujmeno";
            this.textBox_ujmeno.Size = new System.Drawing.Size(228, 37);
            this.textBox_ujmeno.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(45, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "Uživ. jméno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_heslo
            // 
            this.textBox_heslo.Location = new System.Drawing.Point(319, 432);
            this.textBox_heslo.Multiline = true;
            this.textBox_heslo.Name = "textBox_heslo";
            this.textBox_heslo.PasswordChar = '*';
            this.textBox_heslo.Size = new System.Drawing.Size(228, 37);
            this.textBox_heslo.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(313, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 27;
            this.label5.Text = "Heslo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(6, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 36);
            this.label2.TabIndex = 28;
            this.label2.Text = "Jméno uživatele k odstranění:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_uzivatelOD
            // 
            this.textBox_uzivatelOD.Location = new System.Drawing.Point(49, 328);
            this.textBox_uzivatelOD.Multiline = true;
            this.textBox_uzivatelOD.Name = "textBox_uzivatelOD";
            this.textBox_uzivatelOD.Size = new System.Drawing.Size(228, 37);
            this.textBox_uzivatelOD.TabIndex = 29;
            // 
            // potvrdi_smazat
            // 
            this.potvrdi_smazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potvrdi_smazat.Location = new System.Drawing.Point(152, 488);
            this.potvrdi_smazat.Name = "potvrdi_smazat";
            this.potvrdi_smazat.Size = new System.Drawing.Size(336, 41);
            this.potvrdi_smazat.TabIndex = 30;
            this.potvrdi_smazat.Text = "Potvrdit a smazat";
            this.potvrdi_smazat.UseVisualStyleBackColor = true;
            this.potvrdi_smazat.Click += new System.EventHandler(this.Potvrdi_smazat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(370, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Uživatel neexistuje";
            this.label3.Visible = false;
            // 
            // OdebratUzivatele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.potvrdi_smazat);
            this.Controls.Add(this.textBox_uzivatelOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_heslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ujmeno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OdebratUzivatele";
            this.Text = "OdebratUzivatele";
            this.Load += new System.EventHandler(this.OdebratUzivatele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ujmeno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_heslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_uzivatelOD;
        private System.Windows.Forms.Button potvrdi_smazat;
        private System.Windows.Forms.Label label3;
    }
}