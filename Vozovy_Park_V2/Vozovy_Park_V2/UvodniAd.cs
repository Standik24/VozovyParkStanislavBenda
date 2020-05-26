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
using System.Text.RegularExpressions;

namespace Vozovy_Park_V2
{
    public partial class UvodniAd : Form
    {
        string user;
        public UvodniAd(string uzivatel)
        {
            InitializeComponent();
            user += uzivatel;
        }

        private void Odhlaseni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void UvodniAd_Load(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Users\" + user + ".txt";

            using (StreamReader sr = new StreamReader(cesta))
            {
                Regex rg = new Regex(@"(?<=Jméno:)\S+");
                Regex rx = new Regex(@"(?<=Příjmení:)\S+");
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    if (rg.IsMatch(radek))
                    {
                        label2.Text = Convert.ToString(rg.Match(radek));
                    }
                    if (rx.IsMatch(radek))
                    {
                        label5.Text = Convert.ToString(rx.Match(radek));
                    }
                }
            }
        }

        private void VytvoritUzivatele_Click(object sender, EventArgs e)
        {
            this.Hide();
            VytvoreniUzivatele v = new VytvoreniUzivatele(this);
            v.Show();
        }

        private void VsechnyAuta_Click(object sender, EventArgs e)
        {
            this.Hide();
            VsechnaAuta va = new VsechnaAuta();
            va.Show();
        }

        private void ZrusitUzivatele_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdebratUzivatele od = new OdebratUzivatele(this);
            od.Show();
        }

        private void PridatAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            PridaniAuta pa = new PridaniAuta(this);
            pa.Show();
        }

        private void OdebratAuta_Click(object sender, EventArgs e)
        {
            this.Hide();
            OdebraniAuta oa = new OdebraniAuta(this);
            oa.Show();
        }
    }
}
