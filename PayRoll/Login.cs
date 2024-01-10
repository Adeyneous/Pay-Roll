using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-H6VRQ8P3\SQLEXPRESS;Initial Catalog=Emp_Info;Integrated Security=True");


        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Step 1: Establish the connection
            string connectionString = "Server=LAPTOP-H6VRQ8P3\\SQLEXPRESS;;Database=Emp_Info;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Step 2: Retrieve necessary data
                    string userName = txtUsername.Text; // Assuming txtUserName is the TextBox for capturing the user's name
                    string password = txtPassword.Text; // Assuming txtPassword is the TextBox for capturing the password

                    // Step 3: Check if the user input matches the data in the Employee_cred table
                    string selectQuery = "SELECT COUNT(*) FROM Employee_cred WHERE employee_Username = @employee_Username AND employe_Password = @employe_Password";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@employee_Username", userName);
                        command.Parameters.AddWithValue("@employe_Password", password);

                        // Step 4: Execute the SELECT statement and retrieve the count
                        int count = (int)command.ExecuteScalar();

                        // Step 5: Check if the count is greater than 0 (indicating a match)
                        if (count > 0)
                        {
                            // Access granted, proceed with the desired action
                            // For example, show the form or perform additional actions
                            FrmNailShop FrmNailShop = new FrmNailShop();
                            FrmNailShop.UserName = txtUsername.Text; // Pass the value from the txtUsername TextBox
                            FrmNailShop.Password = txtPassword.Text; // Pass the value from the txtPassword TextBox
                            FrmNailShop.ShowDialog();
                        }
                        else
                        {
                            // Access denied, display an error message
                            MessageBox.Show("Access denied. You do not have permission to access this form.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., display the actual exception message for debugging)
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Step 1: Establish the connection
            string connectionString = "Server=LAPTOP-H6VRQ8P3\\SQLEXPRESS;;Database=Emp_Info;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Step 2: Retrieve necessary data
                    string userName = txtUsername.Text; // Assuming txtUserName is the TextBox for capturing the user's name
                    string password = txtPassword.Text; // Assuming txtPassword is the TextBox for capturing the password

                    // Step 3: Create and execute the SQL SELECT statement
                    string selectQuery = "SELECT employee_dept FROM Employee_cred WHERE employee_Username = @employee_Username AND employe_Password = @employe_Password";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@employee_Username", userName);
                        command.Parameters.AddWithValue("@employe_Password", password);

                        // Step 4: Execute the SELECT statement and retrieve the department value
                        string department = command.ExecuteScalar()?.ToString();

                        // Step 5: Check if the department is "administrator"
                        if (department == "administrator")
                        {
                            // Access granted, proceed with the desired action
                            // For example, show the form or perform additional actions

                         
                            frmAdmin frmAdmin = new frmAdmin();
                            frmAdmin.ShowDialog();
                        }
                        else
                        {
                            // Access denied, display an error message
                            MessageBox.Show("Access denied. You do not have permission to access this form.");
                        }
                    }
                }
                catch (Exception)
                {
                    // Handle the exception (e.g., display an error message)
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // Iterate through all controls on the form
            foreach (Control control in Controls)
            {
                // Check if the control is a TextBox
                if (control is TextBox textBox)
                {
                    // Clear the TextBox
                    textBox.Text = string.Empty;
                }
            }
        }

        private void chbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowpassword.Checked == false)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

