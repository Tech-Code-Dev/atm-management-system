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
    public partial class Bakiye : Form
    {
        public Bakiye()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void getbalance()
        {
            bag.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select Balance from AccTbl where AccNum= '" + hesnolbl2.Text+"' ", bag);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            baklbl2.Text = "Bak. "+dt.Rows[1][0].ToString();
            bag.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void hesnolbl2_Click(object sender, EventArgs e)
        {
            hesnolbl2.Text = Login.AccNumber;
            getbalance();
        }

        private void Bakiye_Load(object sender, EventArgs e)
        {

        }

        private void baklbl2_Click(object sender, EventArgs e)
        {

        }
    }
}
