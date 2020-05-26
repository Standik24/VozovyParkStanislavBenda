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
    public partial class UvodniUz : Form
    {
        string user;
        public UvodniUz(string uzivatel)
        {
            InitializeComponent();
            user += uzivatel;
        }

        private void UvodniUz_Load(object sender, EventArgs e)
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

        private void Odhlaseni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void ZmenaHesla_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZmenaHesla z = new ZmenaHesla(this,user);
            z.Show();
        }

        private void Zarezervovat_Click(object sender, EventArgs e)
        {

        }
    }
}
