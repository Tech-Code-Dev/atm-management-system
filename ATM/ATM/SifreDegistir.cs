using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void degistir_Click(object sender, EventArgs e)
        {
            if (pintbx.Text == "" || pinonaytbx.Text == "")
            {
                MessageBox.Show("Yeni şifrenizi girin ve onaylayın!");
            }
            else if (pintbx.Text != pinonaytbx.Text)
            {
                MessageBox.Show("Pin girişi eşleşmiyor!");
            }
            else
            {
                try {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set pin= " + pintbx.Text + " where Accnum= '" + Acc + "'",bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN güncellendi!");
                    bag.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
