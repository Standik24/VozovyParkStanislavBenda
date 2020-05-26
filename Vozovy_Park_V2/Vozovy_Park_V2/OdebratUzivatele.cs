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
    public partial class OdebratUzivatele : Form
    {
        UvodniAd a;
        public OdebratUzivatele(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void OdebratUzivatele_Load(object sender, EventArgs e)
        {

        }

        private void Potvrdi_smazat_Click(object sender, EventArgs e)
        {
            byte[] ujmenoA = Encoding.GetEncoding("UTF-8").GetBytes(textBox_ujmeno.Text);
            SHA256 sha256 = SHA256.Create();
            byte[] ujmenoHashA = sha256.ComputeHash(ujmenoA);
            string unA = Convert.ToString(ByteArrayToString(ujmenoHashA));

            byte[] ujmeno = Encoding.GetEncoding("UTF-8").GetBytes(textBox_uzivatelOD.Text);
            byte[] ujmenoHash = sha256.ComputeHash(ujmeno);
            string un = Convert.ToString(ByteArrayToString(ujmenoHash));

            byte[] HesloHash;
            HesloHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBox_heslo.Text));

            string cestaOD = Environment.CurrentDirectory + @"\Users\" + un + ".txt";
            string cesta = Environment.CurrentDirectory + @"\Users\" + unA + ".txt";
            if (File.Exists(cestaOD) == false)
            {
                label3.Visible = true;
            }
            else
            {
                string h = "";
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
                string s = BitConverter.ToString(HesloHash).Replace("-", "").ToLower();
                if (s == h)
                {
                    File.Delete(cestaOD);
                    this.Hide();
                    a.Show();
                }

            }
            
        }
        public static string ByteArrayToString(byte[] arr)
        {
            StringBuilder hex = new StringBuilder(arr.Length * 2);
            foreach (byte b in arr)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
    }
}
