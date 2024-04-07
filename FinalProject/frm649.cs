//Diego Tordoya
// Lottery 649 form
//2023-04-18

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class frm649 : Form
    {
        public frm649()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit ?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {

                this.Close();
            }
        }

        
            private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            string lotteryName = "";
           
                lotteryName = "649";
               int maxNumber = 49;
            

            while (numbers.Count < (lotteryName == "Max" ? 7 : 8))
            {
                int randomNumber = random.Next(1, maxNumber + 1);
                if (!numbers.Contains(randomNumber))
                {
                    numbers.Add(randomNumber);
                }
            }

               string bonusNumber = ""+random.Next(1, 49);
            

            string filePath = "LottoNbrs.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                string numbersString = string.Join(",", numbers);
                string line = lotteryName + ", " + DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt") + ", " + numbersString +"   Bonus " +bonusNumber;
                sw.WriteLine(line);
            }

            string generatedNumbersString = string.Join(Environment.NewLine, numbers);
            generatedNumbersString += bonusNumber;
            LottoTextbox.Text = generatedNumbersString;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "LottoNbrs.txt";
            string content = "";

            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            content += line + Environment.NewLine;
                        }
                    }
                }
            }
            else
            {
                content = "File does not exist.";
            }

            string title = "Lottery Numbers - " + DateTime.Now.ToString("yyyy/MM/dd h:mm:ss tt") + " - Diego";
            MessageBox.Show(content, title);


        }
    }
}
