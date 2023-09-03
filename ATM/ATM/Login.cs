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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.Show();
            this.Hide();
        }
        public static String AccNumber;

        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string AccNum = hesnotbx.Text;
            string pin = pintbx.Text;
            SqlCommand cmd = new SqlCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "SELECT * FROM AccTbl where AccNum='" + hesnotbx.Text + "' AND pin='" + pintbx.Text + "'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                AccNumber = hesnotbx.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                bag.Close();
            }
            else
            {
                MessageBox.Show("Yanlış hesap numarası veya PIN kodu!");
            }
            
            bag.Close();
        }
    }
}
