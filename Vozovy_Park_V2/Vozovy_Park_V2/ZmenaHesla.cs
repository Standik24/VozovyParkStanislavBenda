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
using System.Security.Cryptography;

namespace Vozovy_Park_V2
{
    public partial class ZmenaHesla : Form
    {
        string user;
        UvodniUz u;
        public ZmenaHesla(UvodniUz uz, string uzivatel)
        {
            InitializeComponent();
            user += uzivatel;
            u = uz;

        }

        private void Potvrdit_Click(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Users\" + user + ".txt";

            string h = "";
            SHA256 sha256 = SHA256.Create();
            byte[] StareHesloHash;
            byte[] NoveHesloHash;
            StareHesloHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(stareHeslo.Text));
            NoveHesloHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(noveHeslo.Text));

            using (StreamReader sr = new StreamReader(cesta))
            {
                Regex rg = new Regex(@"(?<=Heslo:)\S+");
                string radek;
                while ((radek = sr.ReadLine()) != null)
                {
                    if (rg.IsMatch(radek))
                    {
                        h = Convert.ToString(rg.Match(radek));
                    }
                }
            }
            if (BitConverter.ToString(StareHesloHash).Replace("-", "").ToLower() == h)
            {
                this.Hide();
                u.Show();
                string j = "";
                string p = "";
                string uj = "";
                string he = BitConverter.ToString(NoveHesloHash).Replace("-", "").ToLower();
                using (StreamReader sr = new StreamReader(cesta))
                {
                    Regex rg = new Regex(@"(?<=Jméno:)\S+");
                    Regex rx = new Regex(@"(?<=Příjmení:)\S+");
                    Regex ry = new Regex(@"(?<=Uživatelské jméno:)\S+");
                    Regex rz = new Regex(@"(?<=Heslo:)\S+");
                    string radek;

                    while ((radek = sr.ReadLine()) != null)
                    {
                        if (rg.IsMatch(radek))
                        {
                            j = Convert.ToString(rg.Match(radek));
                        }
                        if (rx.IsMatch(radek))
                        {
                            p = Convert.ToString(rx.Match(radek));
                        }
                        if (ry.IsMatch(radek))
                        {
                            uj = Convert.ToString(ry.Match(radek));
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(cesta,false))
                {
                    sw.WriteLine("Jméno:" + j);
                    sw.WriteLine("Příjmení:" + p);
                    sw.WriteLine("Uživatelské jméno:" + uj);
                    sw.WriteLine("Heslo:" + he);
                }

            }
        }
    }
}
