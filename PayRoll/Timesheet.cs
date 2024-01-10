using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class FrmNailShop : Form
    {
        Single sngTaxamount = 0.15f;
        Single sngPayrate = 0;


        public FrmNailShop()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToString("dddd,MMMM,d,yyyy h:mm tt");


        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-H6VRQ8P3\SQLEXPRESS;Initial Catalog=Emp_Info;Integrated Security=True");



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Paycheck();
        }

        private void Paycheck()
        {


            if (chkbMailroom.Checked == true)
            {
                sngPayrate = 21.15f;
            }
            else if (chkbAdmid.Checked == true)
            {
                sngPayrate = 50f;
            }
            else if (chkbMangerment.Checked == true)
            {
                sngPayrate = 30.50f;
            }
            else
            {
                MessageBox.Show("Please check a department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the total hours from the text box
            double totalHours;
            bool isValidTotalHours = double.TryParse(txtTotalHoursF.Text.Trim(), out totalHours);

            if (isValidTotalHours)
            {
                // Calculate the gross pay
                double grossPay = totalHours * sngPayrate;

                // Calculate the tax amount
                double sngtaxAmount = grossPay * 0.15;

                // Calculate the total pay after deducting taxes
                double totalPay = grossPay - sngtaxAmount;

                // Display the results to the user
                lblTHoutput.Text = totalHours.ToString("c");
                lblPayrateoutput.Text = sngPayrate.ToString("c");
                lblGrosspoutput.Text = grossPay.ToString("c");
                lblTaxoutput.Text = sngtaxAmount.ToString("c");
                lblNetpayoutput.Text = totalPay.ToString("c");
            }
            else
            {
                // Invalid input for total hours, display an error message or perform appropriate action
                MessageBox.Show("Invalid input for total hours.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtclockinM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinM.Text.Trim();
                string lunchoutInput = txtLunchoutM.Text.Trim();
                string lunchinInput = txtLunchinM.Text.Trim();
                string clockoutInput = txtclockoutM.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm) with optional space
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9]\s?(am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    try
                    {
                        // Valid input in 12-hour clock format
                        // Parse the input strings into DateTime objects
                        DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                        DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                        DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                        DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                        // Calculate the total work duration
                        TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                        // Subtract the lunch break duration (30 minutes)
                        TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                        TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                        // Calculate the total hours as a decimal value
                        double totalHoursDecimal = totalHours.TotalHours;

                        // Display the total hours worked as a decimal value in txtTotalHoursM
                        txtTotalHoursM.Text = totalHoursDecimal.ToString();
                    }
                    catch (FormatException)
                    {
                        // Invalid input, display an error message for incorrect time format
                        MessageBox.Show("Invalid time format. Please enter time in the correct format (hh:mm am/pm).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Invalid input, display an error message for pattern mismatch
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void txtclockinT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinT.Text.Trim();
                string lunchoutInput = txtLunchoutT.Text.Trim();
                string lunchinInput = txtLunchinT.Text.Trim();
                string clockoutInput = txtclockoutT.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursT.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }






        private void txtclockinW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinW.Text.Trim();
                string lunchoutInput = txtLunchoutW.Text.Trim();
                string lunchinInput = txtLunchinW.Text.Trim();
                string clockoutInput = txtclockoutW.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursW.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtclockinTH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinTH.Text.Trim();
                string lunchoutInput = txtLunchoutTH.Text.Trim();
                string lunchinInput = txtLunchinTH.Text.Trim();
                string clockoutInput = txtclockoutTH.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursM.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtclockinF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinF.Text.Trim();
                string lunchoutInput = txtLunchoutF.Text.Trim();
                string lunchinInput = txtLunchinF.Text.Trim();
                string clockoutInput = txtclockoutF.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursM.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtclockinSA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinSA.Text.Trim();
                string lunchoutInput = txtLunchoutSA.Text.Trim();
                string lunchinInput = txtLunchinSA.Text.Trim();
                string clockoutInput = txtclockoutSA.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursM.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtclockinSU_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string clockinInput = txtclockinSU.Text.Trim();
                string lunchoutInput = txtLunchoutSU.Text.Trim();
                string lunchinInput = txtLunchinSU.Text.Trim();
                string clockoutInput = txtclockoutSU.Text.Trim();

                // Regular expression pattern to match 12-hour clock format (hh:mm am/pm)
                string pattern = @"^(0?[1-9]|1[0-2]):[0-5][0-9] (am|pm)$";

                if (System.Text.RegularExpressions.Regex.IsMatch(clockinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchoutInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(lunchinInput, pattern) &&
                    System.Text.RegularExpressions.Regex.IsMatch(clockoutInput, pattern))
                {
                    // Valid input in 12-hour clock format
                    // You can perform further processing or store the valid time values
                    DateTime startTime = DateTime.Today.Add(TimeSpan.Parse(clockinInput));
                    DateTime lunchoutTime = DateTime.Today.Add(TimeSpan.Parse(lunchoutInput));
                    DateTime lunchinTime = DateTime.Today.Add(TimeSpan.Parse(lunchinInput));
                    DateTime endTime = DateTime.Today.Add(TimeSpan.Parse(clockoutInput));

                    TimeSpan totalWorkDuration = (lunchoutTime - startTime) + (endTime - lunchinTime);

                    // Subtract the lunch break duration (30 minutes)
                    TimeSpan lunchBreakDuration = TimeSpan.FromMinutes(30);
                    TimeSpan totalHours = totalWorkDuration - lunchBreakDuration;

                    // Display the total hours worked in txtTotalHoursM
                    txtTotalHoursM.Text = totalHours.TotalHours.ToString();
                }
                else
                {
                    // Invalid input, display an error message or perform appropriate action
                    MessageBox.Show("Invalid Time format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



       


        


        
        private void chkbMailroom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMailroom.Checked == true)
            {
                chkbAdmid.Checked = false;
                chkbMangerment.Checked = false;
            }
        }

        private void chkbAdmid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbAdmid.Checked == true)
            {
                chkbMailroom.Checked = false;
                chkbMangerment.Checked = false;
            }
        }

        private void chkbMangerment_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbMangerment.Checked == true)
            {
                chkbAdmid.Checked = false;
                chkbMailroom.Checked = false;
            }
        }





        public string UserName { get; set; }
        public string Password { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            }
        }
    }




