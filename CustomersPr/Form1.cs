using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL ile çalışmak için SqlClient eklenir

namespace CustomersPr
{
    public partial class Form1 : Form
    {
        string baglanti = @"Data Source=(localdb)\Projects;Initial Catalog=Northwind;Integrated Security=true;";
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(baglanti);
            cmd = new SqlCommand("Insert INTO Products(ProductName,UnitPrice,UnitsInStock,UnitsOnOrder) Values(@pn,@up,@uis,@uoo)", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@pn", tb_productname.Text);
            cmd.Parameters.AddWithValue("@up", Convert.ToDouble(tb_unitprice.Text));
            cmd.Parameters.AddWithValue("@uis", Convert.ToInt32(tb_stock.Text));
            cmd.Parameters.AddWithValue("@uoo", Convert.ToInt32(tb_order.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün başarıyla Eklendi");
            DispayData();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(baglanti);
            cmd = new SqlCommand("DELETE FROM Products WHERE ProductId = @id", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Ürün başarıyla Silindi");
            DispayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DispayData();
        }

        private void DispayData()
        {
            conn = new SqlConnection(baglanti);
            conn.Open();
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * FROM Products", conn);
            da.Fill(dt);
            dg_product.DataSource = dt;
            conn.Close();
        }

        private void dg_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("CEll Double_Click event calls");
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dg_product.Rows[rowIndex];
             textBox1.Text = row.Cells[0].Value.ToString();
            tb_productname.Text = row.Cells[1].Value.ToString();
            tb_unitprice.Text = row.Cells[5].Value.ToString();
            tb_stock.Text = row.Cells[6].Value.ToString();
            tb_order.Text = row.Cells[7].Value.ToString();
        }

        private void dg_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
