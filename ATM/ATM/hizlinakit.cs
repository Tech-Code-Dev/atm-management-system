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
    public partial class hizlinakit : Form
    {
        public hizlinakit()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            bag.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccTbl where AccNum= '" + Acc + "' ", bag);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            bakiyelbl.Text = "Kalan Bak. " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            bag.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void hizlinakit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addtransaction1()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 100 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void addtransaction2()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 200 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void addtransaction3()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 500 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void addtransaction4()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 1000 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void addtransaction5()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 2000 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void addtransaction6()
        {
            string TrType = "Para Çekme";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('" + Acc + "', '" + TrType + "', '" + 5000 + "', '" + DateTime.Today.Date.ToString() + "')", bag);
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
        private void yüztbx_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 100;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction1();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ikiyüztbx_Click(object sender, EventArgs e)
        {
            if (bal < 200)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 200;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction2();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void besyüztbx_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction3();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bintbx_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction4();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ikibintbx_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction5();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void besbintbx_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Yetersiz bakiye!");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where Accnum='" + Acc + "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Para çekme işlemi başarılı!");
                    bag.Close();
                    addtransaction6();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}