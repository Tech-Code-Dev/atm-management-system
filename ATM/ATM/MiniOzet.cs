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
    public partial class MiniOzet : Form
    {
        public MiniOzet()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string Acc = Login.AccNumber;
        private void populate()
        {
            bag.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from TransactionTbl where AccNum='"+Acc+"'", bag);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            minidatagw.DataSource = ds.Tables[0];
            bag.Close();
        }
        private void MiniOzet_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
