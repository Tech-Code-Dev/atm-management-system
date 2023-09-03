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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class Mevduat : Form
    {
        public Mevduat()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void addtransaction()
        {
            string TrType = "Bakiye";
            try
            {
                bag.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl values ('"+Acc+"', '"+TrType+"', '"+mevduattxb.Text+"', '"+DateTime.Today.Date.ToString()+"')", bag);
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (mevduattxb.Text == "" || Convert.ToUInt32(mevduattxb.Text) <=0)
            {
                MessageBox.Show("Yatırılacak tutarı girin!");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(mevduattxb.Text);
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("update AccTbl set Balance='" + newbalance + "' where AccNum='" + Acc+ "'", bag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Yatırım başarılı!");
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
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int oldbalance, newbalance;
        private void getbalance()
        {
            bag.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccTbl where AccNum= '" +Acc+ "' ", bag);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            bag.Close();
        }
        private void Mevduat_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
