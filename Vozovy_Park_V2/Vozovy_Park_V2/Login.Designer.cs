namespace Vozovy_Park_V2
{
    partial class Login
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prihlasit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.heslo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Size = new System.Drawing.Size(594, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // prihlasit
            // 
            this.prihlasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prihlasit.Location = new System.Drawing.Point(12, 431);
            this.prihlasit.Name = "prihlasit";
            this.prihlasit.Size = new System.Drawing.Size(594, 75);
            this.prihlasit.TabIndex = 5;
            this.prihlasit.Text = "Přihlásit se";
            this.prihlasit.UseVisualStyleBackColor = true;
            this.prihlasit.Click += new System.EventHandler(this.Prihlasit_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Uživ. jméno:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(12, 339);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(263, 40);
            this.user.TabIndex = 11;
            // 
            // heslo
            // 
            this.heslo.Location = new System.Drawing.Point(322, 339);
            this.heslo.Multiline = true;
            this.heslo.Name = "heslo";
            this.heslo.Size = new System.Drawing.Size(284, 40);
            this.heslo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(316, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Heslo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Přihlášení";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(318, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 46);
            this.label6.TabIndex = 15;
            this.label6.Text = "Heslo není správné";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 46);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tento uživatel neexistuje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heslo);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prihlasit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Přihlášení";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button prihlasit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox heslo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

