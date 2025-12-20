using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new Order().Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new Customer().Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new Product().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
