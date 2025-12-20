using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // READ – Load Orders
        private void LoadOrders()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Orders", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // CREATE – Insert Order
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtOrderId.Text == "" || txtCustomerId.Text == "" ||
                txtProductId.Text == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Orders (OrderID, CustomerID, ProductID, Quantity) VALUES (@oid, @cid, @pid, @qty)", con))
                {
                    cmd.Parameters.AddWithValue("@oid", txtOrderId.Text);
                    cmd.Parameters.AddWithValue("@cid", txtCustomerId.Text);
                    cmd.Parameters.AddWithValue("@pid", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order Added Successfully");
            LoadOrders();
        }

        // UPDATE – Update Order
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Orders SET CustomerID=@cid, ProductID=@pid, Quantity=@qty WHERE OrderID=@oid", con))
                {
                    cmd.Parameters.AddWithValue("@oid", txtOrderId.Text);
                    cmd.Parameters.AddWithValue("@cid", txtCustomerId.Text);
                    cmd.Parameters.AddWithValue("@pid", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order Updated Successfully");
            LoadOrders();
        }

        // DELETE – Delete Order
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Orders WHERE OrderID=@oid", con))
                {
                    cmd.Parameters.AddWithValue("@oid", txtOrderId.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order Deleted Successfully");
            LoadOrders();
        }

        private void ProductId_Click(object sender, EventArgs e)
        {

        }
    }
}
