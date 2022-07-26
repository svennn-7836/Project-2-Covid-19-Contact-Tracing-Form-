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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Transition from Form4 back to Form3
            Form3 FORM4 = new Form3();
            FORM4.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Filter out Records by Date

            StreamReader inputFile = new StreamReader(@"D:\Download\Code\ASSIGNMENT #3\Covid-19 Contact Tracing Form\DATABASE RECORD.txt");
            textBox1.Text = inputFile.ReadToEnd();
            inputFile.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Display Filtered Records

            StreamReader inputFile = new StreamReader(@"D:\Download\Code\ASSIGNMENT #3\Covid-19 Contact Tracing Form\DATABASE RECORD.txt");
            textBox1.Text = inputFile.ReadToEnd();
            inputFile.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
