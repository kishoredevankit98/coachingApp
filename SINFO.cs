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
    public partial class SINFO : Form
    {
        public SINFO()
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

        private void SINFO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tUITIONDataSet2.ST_RECORD' table. You can move, or remove it, as needed.
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sid = Convert.ToInt32(textBox1.Text);


                var select = "SELECT * FROM ST_RECORD WHERE STUDENT_ID=" + sid + ";";
                var c = new SqlConnection(conSTRING); // Your Connection String here
                var dataAdapter = new SqlDataAdapter(select, c);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
            }
                      
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = "";
            textBox1.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string cid = textBox3.Text.ToString();


            var select2 = "SELECT * FROM ST_RECORD WHERE COURSE_ID='" + cid + "'";
            var c2 = new SqlConnection(conSTRING); // Your Connection String here
            var dataAdapter2 = new SqlDataAdapter(select2, c2);

            var commandBuilder2 = new SqlCommandBuilder(dataAdapter2);
            var ds2 = new DataSet();
            dataAdapter2.Fill(ds2);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String clss = textBox2.Text.ToString();


            var select1 = "SELECT * FROM ST_RECORD WHERE CLASS='" + clss + "'";
            var d = new SqlConnection(conSTRING); // Your Connection String here
            var dataAdapter1 = new SqlDataAdapter(select1, d);

            var commandBuilder1 = new SqlCommandBuilder(dataAdapter1);
            var ds1 = new DataSet();
            dataAdapter1.Fill(ds1);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SINFO a = new SINFO();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void feeDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            STPAYSLIP n = new STPAYSLIP();
            n.ShowDialog();
        }
    }
}
