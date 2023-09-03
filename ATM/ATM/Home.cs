using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bakiye bak = new Bakiye();
            this.Hide();
            bak.Show();
        }
        public static String AccNumber;
        private void Home_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Hesap Numarası:" + Login.AccNumber;
            AccNumber = Login.AccNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mevduat mevduat = new Mevduat();
            mevduat.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SifreDegistir sifreDegistir = new SifreDegistir();
            sifreDegistir.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ParaCekme paraCekme = new ParaCekme();
            paraCekme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hizlinakit hizlinakit = new hizlinakit();
            hizlinakit.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MiniOzet miniOzet = new MiniOzet();
            miniOzet.Show();
            this.Hide();
        }
    }
}
