using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Contact_Tracing_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FORM2 = new Form2();
            FORM2.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Add ScrollBars
            textBox1.ScrollBars = ScrollBars.Both;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            StreamReader inputFile = new StreamReader(@"D:\Download\Code\ASSIGNMENT #3\Covid-19 Contact Tracing Form\DATABASE RECORD.txt");
            textBox1.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }
    }
}
