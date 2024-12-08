using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Connection string: Update with your MySQL server details
        private const string ConnectionString = "Server=localhost;Database=testdb;User Id=root;Password=yourpassword;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Attempt to connect to the database
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Example: Load data into a DataGridView
                    string query = "SELECT * FROM user"; 
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add your event handling code for the PictureBox click here, if needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Add your event handling code for the Label click here, if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Example: Authenticate user data
            string username = "admin"; // Replace with actual data
            string password = "password123"; // Replace with actual data

            // Get input from text boxes (replace textBoxUsername and textBoxPassword with your actual TextBox controls)
            string inputUsername = textBoxUsername.Text; // Ensure you have a TextBox named 'textBoxUsername'
            string inputPassword = textBoxPassword.Text; // Ensure you have a TextBox named 'textBoxPassword'

            // Authentication logic
            if (inputUsername == username && inputPassword == password)
            {
                MessageBox.Show("Authentication Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate to Form3
                Form3 nextPage = new Form3();
                this.Hide(); // Hide the current form (optional)
                nextPage.Show(); // Show the next form
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

