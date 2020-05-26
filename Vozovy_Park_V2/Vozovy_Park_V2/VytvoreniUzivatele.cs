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
using System.Security.Cryptography;

namespace Vozovy_Park_V2
{
    public partial class VytvoreniUzivatele : Form
    {
        UvodniAd a;
        public VytvoreniUzivatele(UvodniAd ad)
        {
            InitializeComponent();
            a = ad;
        }

        private void Zaregistrovat_Click(object sender, EventArgs e)
        {
            string cesta = Environment.CurrentDirectory + @"\Users\";
            byte[] ujmeno = Encoding.GetEncoding("UTF-8").GetBytes(textBox_ujmeno.Text);
            byte[] heslo = Encoding.GetEncoding("UTF-8").GetBytes(textBox_heslo.Text);

            SHA256 sha256 = SHA256.Create();
            byte[] ujmenoHash = sha256.ComputeHash(ujmeno);
            byte[] hesloHash = sha256.ComputeHash(heslo);

            string h = Convert.ToString(ByteArrayToString(hesloHash));
            string un = Convert.ToString(ByteArrayToString(ujmenoHash));
            using (StreamWriter sw = new StreamWriter(Path.Combine(cesta, un + ".txt"), true))
            {
                sw.WriteLine("Jméno:" + textBox_jmeno.Text);
                sw.WriteLine("Příjmení:" + textBox_prijmeni.Text);
                sw.WriteLine("Uživatelské jméno:" + un);
                sw.WriteLine("Heslo:" + h);
            }

            a.Show();
            this.Hide();
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
