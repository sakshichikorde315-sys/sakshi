using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Customers", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "" || txtCustomerName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Customers VALUES(@id,@name,@phone)", con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCustomerId.Text));
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer Added Successfully");
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Customers SET CustomerName=@name, Phone=@phone WHERE CustomerID=@id", con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCustomerId.Text));
                cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer Updated Successfully");
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Customers WHERE CustomerID=@id", con);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtCustomerId.Text));

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Customer Deleted Successfully");
            LoadCustomers();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
