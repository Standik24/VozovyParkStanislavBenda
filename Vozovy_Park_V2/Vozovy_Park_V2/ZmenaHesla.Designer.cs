namespace Vozovy_Park_V2
{
    partial class ZmenaHesla
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
            this.potvrdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stareHeslo = new System.Windows.Forms.TextBox();
            this.noveHeslo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Vozovy_Park_V2.Properties.Resources.logo_PVA;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // potvrdit
            // 
            this.potvrdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.potvrdit.Location = new System.Drawing.Point(164, 524);
            this.potvrdit.Name = "potvrdit";
            this.potvrdit.Size = new System.Drawing.Size(225, 58);
            this.potvrdit.TabIndex = 13;
            this.potvrdit.Text = "Potvrdit";
            this.potvrdit.UseVisualStyleBackColor = true;
            this.potvrdit.Click += new System.EventHandler(this.Potvrdit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Změna hesla";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "Staré heslo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stareHeslo
            // 
            this.stareHeslo.Location = new System.Drawing.Point(12, 346);
            this.stareHeslo.Multiline = true;
            this.stareHeslo.Name = "stareHeslo";
            this.stareHeslo.Size = new System.Drawing.Size(218, 43);
            this.stareHeslo.TabIndex = 16;
            // 
            // noveHeslo
            // 
            this.noveHeslo.Location = new System.Drawing.Point(12, 457);
            this.noveHeslo.Multiline = true;
            this.noveHeslo.Name = "noveHeslo";
            this.noveHeslo.Size = new System.Drawing.Size(218, 43);
            this.noveHeslo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nové heslo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZmenaHesla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noveHeslo);
            this.Controls.Add(this.stareHeslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.potvrdit);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ZmenaHesla";
            this.Text = "ZmenaHesla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button potvrdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stareHeslo;
        private System.Windows.Forms.TextBox noveHeslo;
        private System.Windows.Forms.Label label2;
    }
}