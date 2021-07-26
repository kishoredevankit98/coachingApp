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
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }
        public string conSTRING = "Data Source=ANKIT;Initial Catalog=TUITION;Integrated Security=True;MultipleActiveResultSets=True";
        private void Forgot_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(conSTRING);
            cone.Open();
            if (cone.State == System.Data.ConnectionState.Open)
            {


                if (textBox4.Text != "")
                {
                    errorSt.Text = "*";
                    string sid = textBox1.Text.ToString();
                    string nm = textBox2.Text.ToString();
                    SqlDataReader dr;
                    SqlDataReader ar;
                    string nam = "";
                    string Pass = "";

                    string qq = "select name from login where login_id = '" + sid + "';";
                    SqlCommand cmde = new SqlCommand(qq, cone);
                    dr = cmde.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        nam = nam + dr.GetValue(0);
                    }
                    if (string.Compare(nm,nam)==0)
                    {
                        string qqe = "select [password] from login where login_id = '" + sid + "';";
                        SqlCommand cmd2 = new SqlCommand(qqe, cone);
                        ar = cmd2.ExecuteReader();
                        while (ar.Read())
                        {
                            Pass = Pass + ar.GetValue(0);
                        }
                        textBox3.Text = Pass.ToString();
                        
                    }
                    button1.Visible = true;
                }
                else
                {
                    errorSt.Text = "enter STUDENT ID";
                    button1.Visible = false;
                }
            }

        }
    }
}
