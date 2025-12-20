using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Products", DatabaseConnection.GetConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Products VALUES(@i,@n,@c,@p)",
                DatabaseConnection.GetConnection());

            cmd.Parameters.AddWithValue("@i", textBox1.Text);
            cmd.Parameters.AddWithValue("@n", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@p", textBox4.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "UPDATE Products SET ProductName=@n,Category=@c,Price=@p WHERE ProductID=@i",
                DatabaseConnection.GetConnection());

            cmd.Parameters.AddWithValue("@i", textBox1.Text);
            cmd.Parameters.AddWithValue("@n", textBox2.Text);
            cmd.Parameters.AddWithValue("@c", textBox3.Text);
            cmd.Parameters.AddWithValue("@p", textBox4.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Products WHERE ProductID=@i",
                DatabaseConnection.GetConnection());

            cmd.Parameters.AddWithValue("@i", textBox1.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            LoadData();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
