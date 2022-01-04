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

namespace MusteriSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlConnection con;
        string constring = @"Data Source=(localdb)\Projects;Initial Catalog=Northwind;Integrated Security=true;";

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DisplayData();

        }

        private void DisplayData()
        {
            con = new SqlConnection(constring);
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            con.Open();
            da = new SqlDataAdapter("Select * FROM Employees", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void ClearData()
        {
            txtLastName.Text = "";
            txtFname.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFname.Text != "" && txtLastName.Text != "")
            {
                cmd = new SqlCommand("insert into Employees(FirstName,LastName) values(@fname,@lname)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLastName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }  
        }
    }
}
