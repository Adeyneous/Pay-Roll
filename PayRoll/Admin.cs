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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PayRoll
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-H6VRQ8P3\SQLEXPRESS;Initial Catalog=Emp_Info;Integrated Security=True");

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the employee information from the input fields
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int employeeId = int.Parse(txtEmployeeId.Text);
            decimal payRate = decimal.Parse(txtPayRate.Text);
            string department = txtDepartment.Text;
            DateTime hireDate = dateTimeHireDate.Value;
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            // Save all the information to the Login_Info table
            string queryLoginInfo = "INSERT INTO Login_Info (employee_id, employee_fname, employe_lname, employee_dept, employee_payrate, hire_date) " +
                         "VALUES (@employeeId, @firstName, @lastName, @department, @payRate, @hireDate)";


            // Save the information to the Employee_cred table
            string queryEmployeeCred = $"INSERT INTO Employee_cred (employee_id, employee_Username, employe_Password, employee_dept) VALUES ({employeeId}, '{username}', '{password}', '{department}')";


            // Execute the queries to save the data to the database
            // Step 1: Establish the connection
            string connectionString = "Server=LAPTOP-H6VRQ8P3\\SQLEXPRESS;;Database=Emp_Info;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(queryLoginInfo, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@payRate", payRate);
                    command.Parameters.AddWithValue("@hireDate", hireDate);

                    command.ExecuteNonQuery();
                }

                
                using (SqlCommand command = new SqlCommand(queryEmployeeCred, connection))
                {

                    command.Parameters.AddWithValue("@employee_id", employeeId);
                    command.Parameters.AddWithValue("@employee_Username", username);
                    command.Parameters.AddWithValue("@employe_Password", password);
                    command.Parameters.AddWithValue("@employee_dept", department);
                   

                    command.ExecuteNonQuery();
                }
            }

            // Display a success message
            MessageBox.Show("Employee information saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
    }
}
