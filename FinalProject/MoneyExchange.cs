//Diego Tordoya
// MoneyExchange form
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class MoneyExchange : Form
    {
        private DateTime startTime;
        private DateTime endTime;
        private string newfromValue;

        
        //CAD = 1.00 -> PEN = 2.81
        //CAD = 1.00 -> USD = 0.75
        //CAD = 1.00 -> EUR = 0.68
        //CAD = 1.00 -> GBP = 0.60

        public MoneyExchange()
        {

            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application Money Exchange?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
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

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            // Set the start time to the current time
            startTime = DateTime.Now;
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal cad = 1.00m;
            decimal usd = 0.75m;
            decimal eur = 0.68m;
            decimal gbp = 0.60m;
            decimal pen = 2.81m;
            decimal fromValue = 0;
            decimal toValue = 0;
            decimal convertedValue = 0m;
            string fromCurrency = "";
            string toCurrency = "";

            try
            {

                string valueInserted = textBox1.Text.Trim();
                Regex codeRegex = new Regex(@"^\d{1,3}(,\d{3})*(\.\d+)?$");
                if (textBox1.Text == "")
                {
                    throw new Exception("Please, insert a value to be converted.");
                }
                else if (!codeRegex.IsMatch(valueInserted))
                {
                    throw new Exception("Please enter currency values using the US Standard $ 1,000.00");
                }
                else
                {

                    foreach (RadioButton radioButton1 in groupBox1.Controls.OfType<RadioButton>())
                    {

                        if (radioButton1.Checked)
                        {
                            switch (radioButton1.Text)
                            {
                                case "CAD":
                                     fromValue = cad;
                                    fromCurrency = "CAD";
                                    break;
                                case "USD":
                                     fromValue = usd;
                                    fromCurrency = "USD";
                                    break;
                                case "EUR":
                                    fromValue = eur;
                                    fromCurrency = "EUR";
                                    break;
                                case "GBP":
                                      fromValue = gbp;
                                    fromCurrency = "GBP";
                                    break;
                                case "PEN":
                                     fromValue = pen;
                                    fromCurrency = "PEN";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    foreach (RadioButton radioButton2 in groupBox2.Controls.OfType<RadioButton>())
                    {

                        if (radioButton2.Checked)
                        {
                            switch (radioButton2.Text)
                            {
                                case "CAD":
                                    toValue = cad;
                                    toCurrency = "CAD";
                                    break;
                                case "USD":
                                    toValue = usd;
                                    toCurrency = "USD";
                                    break;
                                case "EUR":
                                    toValue = eur;
                                    toCurrency = "EUR";
                                    break;
                                case "GBP":
                                    toValue = gbp;
                                    toCurrency = "GBP";
                                    break;
                                case "PEN":
                                    toValue = pen;
                                    toCurrency = "PEN";
                                    break;
                                default:
                                    break;
                            }
                        }
                    }

                    convertedValue = Convert.ToDecimal(textBox1.Text) * toValue / fromValue;
                    textBox2.Text = convertedValue.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox1.Focus();
            }

            string path = "moneyConversion.txt";
            FileStream fs1 = null;
            try
            {
                fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs1);
                textOut.WriteLine($"{newfromValue} {fromCurrency}  = {convertedValue.ToString("0.00")} {toCurrency} {DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")}");
                
                textOut.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(path + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs1 != null) fs1.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader f1 = new StreamReader("moneyConversion.txt"))
                {
                    string contents = f1.ReadToEnd();
                    if (contents != null && contents.Trim() != "")
                    {
                        MessageBox.Show(contents, "Money Conversion - Diego", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("The Textfile is empty.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            newfromValue = textBox1.Text;
        }
    }
}
