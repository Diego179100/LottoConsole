using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm649 obj = new frm649();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMax obj = new frmMax();
            obj.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IP4Validator obj= new IP4Validator();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temperature obj = new Temperature();
            obj.Show();
        }
    }
}
