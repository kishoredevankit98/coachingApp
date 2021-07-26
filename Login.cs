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

namespace Tuition
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string conSTRING = "Data Source=ANKIT;Initial Catalog=TUITION;Integrated Security=True;MultipleActiveResultSets=True";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cond = new SqlConnection(conSTRING);
            cond.Open();
            if (cond.State == System.Data.ConnectionState.Open)
            {


                string sid = textBox1.Text.ToString();
                SqlDataReader dr;
                string pass = textBox2.Text.ToString();
                string password = "";
                string qq = "select [password] from login where login_id= '" + sid + "';";
                SqlCommand cmde = new SqlCommand(qq, cond);
                dr = cmde.ExecuteReader();
                while (dr.Read())
                {
                    password = password + dr.GetValue(0);
                }

                if (string.Compare(pass, password) == 0)
                {
                    psd.Text = "*";
                    this.Hide();
                    home a = new home();
                    a.ShowDialog();
                }
                else
                {
                    psd.Text = "incorrect password";

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forgot f = new Forgot();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text!= "")
            {
                lgn.Text = "*";
                button1.Visible = true;
            }
            else
            {
                lgn.Text = "Enter login_id first";
                button1.Visible = false;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
