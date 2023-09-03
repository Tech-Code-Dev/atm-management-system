using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-FNE5H92;Initial Catalog=ATMDb;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (hesnotbx.Text == "" || isimtbx.Text == "" || sisimtbx.Text == "" || adrestbx.Text == "" || gsmtbx.Text == "" || pintbx.Text == "" || meslektbx.Text == "")
            {
                MessageBox.Show("Eksik Bilgi!");
            }
            else
            {
                try
                {
                    bag.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccTbl (AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, Balance, pin) values (@AccNum, @Name, @FaName, @Dob, @Phone, @Address, @Education, @Occupation, @Balance, @pin)", bag);
                    cmd.Parameters.AddWithValue("@AccNum", hesnotbx.Text);
                    cmd.Parameters.AddWithValue("@Name", isimtbx.Text);
                    cmd.Parameters.AddWithValue("@FaName", sisimtbx.Text);
                    cmd.Parameters.AddWithValue("@Dob", datedob.Text);
                    cmd.Parameters.AddWithValue("@Phone", gsmtbx.Text);
                    cmd.Parameters.AddWithValue("@Address", adrestbx.Text);
                    cmd.Parameters.AddWithValue("@Education", egitimcbx.Text);
                    cmd.Parameters.AddWithValue("@Occupation", meslektbx.Text);
                    cmd.Parameters.AddWithValue("@pin", pintbx.Text);
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap Oluşturma Başarılı!");
                    bag.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
