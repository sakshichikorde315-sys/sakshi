using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SupermarketManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p", con);

                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);

                con.Open();
                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    new MainMenu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
    }
}
