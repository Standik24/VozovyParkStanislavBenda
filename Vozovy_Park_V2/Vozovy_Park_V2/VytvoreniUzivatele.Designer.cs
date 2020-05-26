namespace Vozovy_Park_V2
{
    partial class VytvoreniUzivatele
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
            this.zaregistrovat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_heslo = new System.Windows.Forms.TextBox();
            this.textBox_ujmeno = new System.Windows.Forms.TextBox();
            this.textBox_prijmeni = new System.Windows.Forms.TextBox();
            this.textBox_jmeno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(129, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zaregistrovat
            // 
            this.zaregistrovat.BackColor = System.Drawing.Color.White;
            this.zaregistrovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaregistrovat.Location = new System.Drawing.Point(183, 549);
            this.zaregistrovat.Name = "zaregistrovat";
            this.zaregistrovat.Size = new System.Drawing.Size(249, 72);
            this.zaregistrovat.TabIndex = 19;
            this.zaregistrovat.Text = "Zaregistrovat";
            this.zaregistrovat.UseVisualStyleBackColor = false;
            this.zaregistrovat.Click += new System.EventHandler(this.Zaregistrovat_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(35, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 18;
            this.label5.Text = "Heslo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "Uživ. jméno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(18, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Příjmení:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Jméno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_heslo
            // 
            this.textBox_heslo.Location = new System.Drawing.Point(139, 481);
            this.textBox_heslo.Multiline = true;
            this.textBox_heslo.Name = "textBox_heslo";
            this.textBox_heslo.PasswordChar = '*';
            this.textBox_heslo.Size = new System.Drawing.Size(228, 37);
            this.textBox_heslo.TabIndex = 14;
            // 
            // textBox_ujmeno
            // 
            this.textBox_ujmeno.Location = new System.Drawing.Point(183, 417);
            this.textBox_ujmeno.Multiline = true;
            this.textBox_ujmeno.Name = "textBox_ujmeno";
            this.textBox_ujmeno.Size = new System.Drawing.Size(228, 37);
            this.textBox_ujmeno.TabIndex = 13;
            // 
            // textBox_prijmeni
            // 
            this.textBox_prijmeni.Location = new System.Drawing.Point(154, 358);
            this.textBox_prijmeni.Multiline = true;
            this.textBox_prijmeni.Name = "textBox_prijmeni";
            this.textBox_prijmeni.Size = new System.Drawing.Size(228, 37);
            this.textBox_prijmeni.TabIndex = 12;
            // 
            // textBox_jmeno
            // 
            this.textBox_jmeno.Location = new System.Drawing.Point(139, 296);
            this.textBox_jmeno.Multiline = true;
            this.textBox_jmeno.Name = "textBox_jmeno";
            this.textBox_jmeno.Size = new System.Drawing.Size(228, 37);
            this.textBox_jmeno.TabIndex = 11;
            // 
            // VytvoreniUzivatele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 630);
            this.Controls.Add(this.zaregistrovat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_heslo);
            this.Controls.Add(this.textBox_ujmeno);
            this.Controls.Add(this.textBox_prijmeni);
            this.Controls.Add(this.textBox_jmeno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VytvoreniUzivatele";
            this.Text = "VytvoreniUzivatele";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zaregistrovat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_heslo;
        private System.Windows.Forms.TextBox textBox_ujmeno;
        private System.Windows.Forms.TextBox textBox_prijmeni;
        private System.Windows.Forms.TextBox textBox_jmeno;
    }
}