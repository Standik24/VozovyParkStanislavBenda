using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vozovy_Park_V2
{
    public partial class PridaniAuta : Form
    {
        UvodniAd a;
        public PridaniAuta(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void Pridej_Click(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Cars\";
            string nazev = textBox_ID.Text + ".txt";
            using (StreamWriter sw = new StreamWriter(Path.Combine(cesta, nazev), true))
            {
                sw.WriteLine("ID:" + textBox_ID.Text);
                sw.WriteLine("Značka:" + textBox_Znacka.Text);
                sw.WriteLine("Model:" + textBox_Model.Text);
                sw.WriteLine("Typ:" + textBox_Typ.Text);
                sw.WriteLine("Spotřeba na 100 km:" + textBox_Spotreba.Text + " litrů.");
                sw.WriteLine("Náklady na celkovou údržbu:" + textBox_Udrzba.Text);
            }
            this.Hide();
            a.Show();
        }
    }
}
