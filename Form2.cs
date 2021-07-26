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
    public partial class ADD : Form
    {
        public ADD()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUITIONDataSet.ST_RECORD' table. You can move, or remove it, as needed.
            

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int sid = Convert.ToInt32(s_id.Text);


            var select = "SELECT * FROM ST_RECORD WHERE STUDENT_ID="+sid+"";
            var c = new SqlConnection(conSTRING); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];







        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSTRING);
            con.Open();
            if(con.State == System.Data.ConnectionState.Open)
            {

                string output = "";
                string q = "insert into ST_RECORD (NAME,CLASS,COURSE_ID,MOBILE,F_NAME,EMAIL_ID) values('" + name.Text.ToString()+ "','" + clss.Text.ToString() + "','" + course.Text.ToString() + "','" + mobile.Text.ToString() + "','" + fname.Text.ToString() + "','" + email.Text.ToString() + "');";
                SqlCommand cmd = new SqlCommand(q,con);
                cmd.ExecuteNonQuery();
                
                string qq = "select max(STUDENT_ID) from ST_RECORD;";
                SqlDataReader dr;
                SqlCommand cmde = new SqlCommand(qq, con);
                dr = cmde.ExecuteReader();
                while(dr.Read())
                {
                     output = output + dr.GetValue(0);
                }
                MessageBox.Show("Sucessfully entered");
                MessageBox.Show("Student_Id is: " + output);
                string q1 = "insert into PAY1 (STUDENT_ID,NAME,MONTH,CLASS,COURSE_ID) values(" + output + ",'" + name.Text.ToString() + "','JUL','"+clss.Text.ToString()+"','"+course.Text.ToString()+"');";
                SqlCommand CNO = new SqlCommand(q1, con);
                CNO.ExecuteNonQuery();


            }
            this.Hide();
            ADD a2 = new ADD();
            a2.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(conSTRING);
            cone.Open();
            if (cone.State == System.Data.ConnectionState.Open)
            {

                
                int sid = Convert.ToInt32(s_id.Text);
                

                string r = "delete from ST_RECORD where STUDENT_ID= " + sid + ";";
                SqlCommand cmd1 = new SqlCommand(r, cone);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Record has been removed sucessfully");


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(conSTRING);
            cone.Open();
            if (cone.State == System.Data.ConnectionState.Open)
            {   
                    if (textBox4.Text != "")
                    {
                        string output = "";
                        string outputn = "";
                        int sid = Convert.ToInt32(textBox4.Text);
                        SqlDataReader dr;
                        SqlDataReader ar;
                        string qq = "select * from ST_RECORD where STUDENT_ID= " + sid + ";";
                        SqlCommand cmde = new SqlCommand(qq, cone);
                        dr = cmde.ExecuteReader();
                        while (dr.Read())
                        {
                            output = output + "STUDENT ID: " + dr.GetValue(0) + "\n NAME: " + dr.GetValue(1) + "\n CLASS: " + dr.GetValue(2) + "\n COURSE_ID: " + dr.GetValue(3) + "\n MOBILE: " + dr.GetValue(4) + "\n FATHER'S NAME: " + dr.GetValue(5) + "\n EMAIL-ID: " + dr.GetValue(6) + "\nDATE of BIRTH: " + dr.GetValue(7);

                        }




                        MessageBox.Show("Previous Records\n" + output);

                        string rr = "update ST_RECORD set NAME='" + textBox9.Text.ToString() + "',CLASS='" + comboBox3.Text.ToString() + "',COURSE_ID='" + comboBox4.Text.ToString() + "',MOBILE= " + textBox7.Text.ToString() + ",F_NAME='" + textBox6.Text.ToString() + "',EMAIL_ID='" + textBox5.Text.ToString() + "',DOB='" + dobu.Text.ToString() + "' where STUDENT_ID= " + sid + ";";
                        SqlCommand cmd1 = new SqlCommand(rr, cone);

                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Record has been updated sucessfully");
                        string qr = "select * from ST_RECORD where STUDENT_ID= " + sid + ";";
                        SqlCommand cmd2 = new SqlCommand(qr, cone);
                        ar = cmd2.ExecuteReader();
                        while (ar.Read())
                        {
                            outputn = outputn + "STUDENT ID: " + ar.GetValue(0) + "\n NAME: " + ar.GetValue(1) + "\n CLASS: " + ar.GetValue(2) + "\n COURSE_ID: " + ar.GetValue(3) + "\n MOBILE: " + ar.GetValue(4) + "\n FATHER'S NAME: " + ar.GetValue(5) + "\n EMAIL-ID: " + ar.GetValue(6);
                        }

                        MessageBox.Show("Updated Records\n" + outputn);
                        
                    }
                    else
                    {
                        
                    }
                    
                
            }
            this.Hide();
            ADD a2 = new ADD();
            a2.ShowDialog();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cone = new SqlConnection(conSTRING);
            cone.Open();
            if (cone.State == System.Data.ConnectionState.Open)
            {

                
                if (textBox4.Text != "")
                {
                    errorSt.Text = "*";
                    int sid = Convert.ToInt32(textBox4.Text);
                    SqlDataReader dr;

                    string qq = "select * from ST_RECORD where STUDENT_ID= " + sid + ";";
                    SqlCommand cmde = new SqlCommand(qq, cone);
                    dr = cmde.ExecuteReader();
                    while (dr.Read())
                    {
                        textBox9.Text = dr.GetValue(1).ToString();
                        textBox7.Text = dr.GetValue(4).ToString();
                        comboBox3.Text = dr.GetValue(3).ToString();
                        comboBox4.Text = dr.GetValue(2).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox5.Text = dr.GetValue(6).ToString();
                        dobu.Text = dr.GetValue(7).ToString();
                        
                    }
                    button5.Visible = true;
                }
                else
                {
                    errorSt.Text = "enter STUDENT ID";
                    button5.Visible = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD a2 = new ADD();
            a2.ShowDialog();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD a2 = new ADD();
            a2.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DEL_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NEW_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
