//Diego Tordoya
// IP4Validator form
//2023-04-18


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class IP4Validator : Form
    {
        private DateTime startTime;
        private DateTime endTime;
        public IP4Validator()
        {
            InitializeComponent();
        }

        private void validateip_Click(object sender, EventArgs e)
        {
            string ip = textbox.Text.Trim();
            if (IsValidIP(ip))
            {
                try
                {
                    using (FileStream fileStream = new FileStream("ip_addresses.bin", FileMode.Append))
                    {
                        using (BinaryWriter writer = new BinaryWriter(fileStream))
                        {
                            writer.Write(ip);
                            writer.Write(DateTime.Now.ToLongDateString());
                            writer.Write("");
                            writer.Close();
                            fileStream.Close();

                        }
                    }
                    MessageBox.Show(textbox.Text + "\nThe IP is correct", "Valid IP");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show(textbox.Text + "\nThe IP must have 4 bytes \n Integer number between 0 to 255 \n Separated by a dot (255.255.255.255)", "Error");
            }
        }
        private bool IsValidIP(string ip)
        {
            Regex pattern = new Regex(@"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return pattern.IsMatch(ip);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the App?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                // Set the end time to the current time
                endTime = DateTime.Now;

                // Calculate the time difference in seconds and minutes
                TimeSpan timeDiff = endTime - startTime;
                int seconds = (int)timeDiff.TotalSeconds;
                int minutes = (int)timeDiff.TotalMinutes;

                // Display the time on the form using a MessageBox
                string message = $"Time on form: {seconds} seconds ({minutes} minutes)";
                MessageBox.Show(message);
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void IP4Validator_Load(object sender, EventArgs e)
        {
            DateTime Date = DateTime.Today;
            label2.Text += " " + Date.ToString("dd,-MM-yy");
            startTime = DateTime.Now;
        }
    }
}
