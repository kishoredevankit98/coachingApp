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
    public partial class PAY : Form
    {
        public PAY()
        {
            InitializeComponent();
        }
        public string conSTRING = "Data Source=ANKIT;Initial Catalog=TUITION;Integrated Security=True;MultipleActiveResultSets=True";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home A = new home();
            A.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(conSTRING);
            cone.Open();
            if (cone.State == System.Data.ConnectionState.Open)
            {


                if (textBox1.Text != "")
                {
                    
                    errorSt.Text = "*";
                    int sid = Convert.ToInt32(textBox1.Text);
                    SqlDataReader dr;

                    string qq = "select * from ST_RECORD where STUDENT_ID= " + sid + ";";
                    SqlCommand cmde = new SqlCommand(qq, cone);
                    dr = cmde.ExecuteReader();
                    while (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(1).ToString();
                        textBox3.Text = dr.GetValue(3).ToString();
                        
                        dobu.Text = dr.GetValue(7).ToString();

                    }
                    Int32 i = 0;

                    string mn = "select MONTH from PAY1 where STUDENT_ID =" + sid + "";
                    SqlCommand qry = new SqlCommand(mn, cone);

                    SqlDataReader pr;
                    pr = qry.ExecuteReader();
                    while (pr.Read())
                    {
                        Lp.Text = pr.GetValue(0).ToString();




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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home A = new home();
            A.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSTRING);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
               
                int sid = Convert.ToInt32(textBox1.Text);
                string q = "update PAY1 set MONTH='AUG' where STUDENT_ID="+sid+";";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                
                
                
                MessageBox.Show("Pyment for Student id: " + textBox1.Text+"");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            STPAYSLIP n = new STPAYSLIP();
            n.ShowDialog();
        }
    }
}
