//Diego Tordoya
// Temperature form
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
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TempC;
                decimal TempF;
                Regex codeRegex = new Regex(@"^-?\d*\.?\d*$");
                string temp = textBox1.Text.Trim();

                if (!codeRegex.IsMatch(temp))
                {
                    MessageBox.Show("Please enter a decimal number.");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                else if (codeRegex.IsMatch(temp))
                {
                    decimal input = decimal.Parse(textBox1.Text.Trim());


                    if (radioButton1.Checked) // celcius to farenheit
                    {

                        TempC = input;
                        TempF = (TempC * 9 / 5) + 32;
                        TempF = Decimal.Round(TempF, 1);
                        textBox2.Text = TempF.ToString();

                        switch (textBox2.Text)
                        {
                            case "-40":
                                textBox2.ForeColor = Color.Purple;
                                textBox3.ForeColor = Color.Purple;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Extremely Cold Day\r\n (and the same number!)";
                                break;
                            case "-0.4":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Very Cold Day";
                                break;
                            case "0":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Very Cold Day";
                                break;
                            case "32":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Freezing point of water";
                                break;
                            case "50":
                                textBox2.ForeColor = Color.LightBlue;
                                textBox3.ForeColor = Color.LightBlue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Cool Day";
                                break;
                            case "69.8":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "70":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "86":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Beach weather";
                                break;
                            case "98.6":
                            case "99":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = " Body temperature";
                                break;
                            case "104":
                                textBox2.ForeColor = Color.Red;
                                textBox3.ForeColor = Color.Red;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Hot Bath";
                                break;
                            case "212":
                                textBox2.ForeColor = Color.DarkRed;
                                textBox3.ForeColor = Color.DarkRed;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Water Boils";
                                break;
                            default:
                                textBox3.Clear();
                                break;

                        }

                        string path = "tempConversions.txt";
                        FileStream fs1 = null;
                        try
                        {
                            fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(fs1);
                            textOut.Write(textBox1.Text.Trim() + "°C = ");
                            textOut.Write(textBox2.Text.Trim() + "°F, ");
                            textOut.Write(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt "));
                            textOut.WriteLine(textBox3.Text.Trim() + "  ");
                            textOut.Close();

                            FileStream fs2 = new FileStream("tempConversions.txt", FileMode.Open, FileAccess.Read);
                            StreamReader objR = new StreamReader(fs2);
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

                    else if (radioButton2.Checked) // farenheit to celcius
                    {
                        TempF = decimal.Parse(textBox1.Text);
                        TempC = (TempF - 32) * 5 / 9;
                        TempC = decimal.Round(TempC);
                        textBox2.Text = TempC.ToString();

                        switch (textBox2.Text)
                        {
                            case "-40":
                                textBox2.ForeColor = Color.Purple;
                                textBox3.ForeColor = Color.Purple;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Extremely Cold Day\r\n (and the same number!)";
                                break;
                            case "-18":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Very Cold Day";
                                break;
                            
                            case "0":
                                textBox2.ForeColor = Color.Blue;
                                textBox3.ForeColor = Color.Blue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Freezing point of water";
                                break;
                            case "10":
                                textBox2.ForeColor = Color.LightBlue;
                                textBox3.ForeColor = Color.LightBlue;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Cool Day";
                                break;
                            case "21":
                                textBox2.ForeColor = Color.Green;
                                textBox3.ForeColor = Color.Green;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                                textBox3.Text = "Room temperature";
                                break;
                            case "30":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Beach weather";
                                break;
                            case "37":
                                textBox2.ForeColor = Color.Orange;
                                textBox3.ForeColor = Color.Orange;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = " Body temperature";
                                break;
                            case "40":
                                textBox2.ForeColor = Color.Red;
                                textBox3.ForeColor = Color.Red;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Hot Bath";
                                break;
                            case "100":
                                textBox2.ForeColor = Color.DarkRed;
                                textBox3.ForeColor = Color.DarkRed;
                                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                                textBox3.Text = "Water Boils";
                                break;
                            default:
                                textBox3.Clear();
                                break;

                        }

                        string path = "tempConversions.txt";
                        FileStream fs1 = null;
                        try
                        {
                            fs1 = new FileStream(path, FileMode.Append, FileAccess.Write);
                            StreamWriter textOut = new StreamWriter(fs1);
                            textOut.Write(textBox1.Text.Trim() + "°F = ");
                            textOut.Write(textBox2.Text.Trim() + "°C, ");
                            textOut.Write(DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt "));
                            textOut.WriteLine(textBox3.Text.Trim() + "  ");
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
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid temperature.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader f2 = new StreamReader("tempConversions.txt"))
                {
                    string contents = f2.ReadToEnd();
                    if (contents != null && contents.Trim() != "")
                    {
                        MessageBox.Show(contents, "Temperature Conversion - Diego", MessageBoxButtons.OK);
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Temperature_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            if (radioButton1.Checked)
            {
                label2.Text = "°C";
                label4.Text = "°F";
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "°F";
                label4.Text = "°C";
            }
        }
    }
}
