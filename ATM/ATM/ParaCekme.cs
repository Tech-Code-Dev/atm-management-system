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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        int oldbalance, newbalance;
        private void getbalance()
        {
            bag.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccTbl where AccNum= '" +Acc+ "' ", bag);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            kalan.Text = "Kalan Bak. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            bag.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     

        private void ParaCekme_Load(object sender, EventArgs e)
        {
            getbalance();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void addtransaction()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + paramiktar.Text + "', '" + DateTime.Today.Date.ToString() + "')", bag);
                cmd.ExecuteNonQuery();
                bag.Close();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void paracek_Click(object sender, EventArgs e)
        {
            if (paramiktar.Text == "")
            {
                MessageBox.Show("Eksik Bilgi!");
            }
            else if(Convert.ToInt32(paramiktar.Text) <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin!");
            }
            else if(Convert.ToInt32(paramiktar.Text) > bal)
            {
                MessageBox.Show("Geçerli bir miktar girin!");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(paramiktar.Text);
                    try
                    {
                        bag.Open();
                        SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" +Acc+ "'", bag);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Para çekme işlemi başarılı!");
                        bag.Close();
                        addtransaction();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
