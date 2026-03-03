using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Diksha_CU_CG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ELLK6DL\\SQLEXPRESS;Initial Catalog = EmployeeDB;" + "TrustServerCertificate=True;Integrated Security=True;";
            try
            {
                using var connection = new SqlConnection(connectionString);
                connection.Open();

                MessageBox.Show("Connection Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed" + ex.Message);

            }

        }
    }
}
