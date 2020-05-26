namespace Vozovy_Park_V2
{
    partial class PridaniAuta
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
            this.pridej = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Znacka = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Typ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Spotreba = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Udrzba = new System.Windows.Forms.TextBox();
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
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(140, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 73);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vytvoření auta ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pridej
            // 
            this.pridej.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridej.Location = new System.Drawing.Point(194, 612);
            this.pridej.Name = "pridej";
            this.pridej.Size = new System.Drawing.Size(237, 56);
            this.pridej.TabIndex = 24;
            this.pridej.Text = "Přidat auto";
            this.pridej.UseVisualStyleBackColor = true;
            this.pridej.Click += new System.EventHandler(this.Pridej_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(19, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Značka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(19, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(377, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Typ:";
            // 
            // textBox_Znacka
            // 
            this.textBox_Znacka.Location = new System.Drawing.Point(24, 454);
            this.textBox_Znacka.Multiline = true;
            this.textBox_Znacka.Name = "textBox_Znacka";
            this.textBox_Znacka.Size = new System.Drawing.Size(223, 40);
            this.textBox_Znacka.TabIndex = 30;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(24, 538);
            this.textBox_Model.Multiline = true;
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(223, 40);
            this.textBox_Model.TabIndex = 31;
            // 
            // textBox_Typ
            // 
            this.textBox_Typ.Location = new System.Drawing.Point(382, 355);
            this.textBox_Typ.Multiline = true;
            this.textBox_Typ.Name = "textBox_Typ";
            this.textBox_Typ.Size = new System.Drawing.Size(223, 40);
            this.textBox_Typ.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(377, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Spotřeba na 100 km:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(24, 355);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(223, 40);
            this.textBox_ID.TabIndex = 34;
            // 
            // textBox_Spotreba
            // 
            this.textBox_Spotreba.Location = new System.Drawing.Point(382, 454);
            this.textBox_Spotreba.Multiline = true;
            this.textBox_Spotreba.Name = "textBox_Spotreba";
            this.textBox_Spotreba.Size = new System.Drawing.Size(223, 40);
            this.textBox_Spotreba.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(377, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Náklady na údržbu:";
            // 
            // textBox_Udrzba
            // 
            this.textBox_Udrzba.Location = new System.Drawing.Point(382, 538);
            this.textBox_Udrzba.Multiline = true;
            this.textBox_Udrzba.Name = "textBox_Udrzba";
            this.textBox_Udrzba.Size = new System.Drawing.Size(223, 40);
            this.textBox_Udrzba.TabIndex = 37;
            // 
            // PridaniAuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(623, 719);
            this.Controls.Add(this.textBox_Udrzba);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Spotreba);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Typ);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.textBox_Znacka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pridej);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PridaniAuta";
            this.Text = "PridaniAuta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pridej;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Znacka;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Typ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Spotreba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Udrzba;
    }
}