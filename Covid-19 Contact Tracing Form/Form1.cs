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
    public partial class Form1 : Form
    {
        private Control pictureBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //Create a txt file for gathered Information

            //Change from WriteText to AppendText to record all inputted informations

            StreamWriter outputFile;
            outputFile = File.AppendText(@"D:\Download\Code\ASSIGNMENT #3\Covid-19 Contact Tracing Form\DATABASE.txt");

            outputFile.WriteLine(label8.Text + " " + dateTimePicker1.Text);
            outputFile.WriteLine(label3.Text + " " + textBox1.Text);
            outputFile.WriteLine(label4.Text + " " + textBox2.Text);

            //Classification of sex with radiobutton
            outputFile.Write(label5.Text + " ");

            // Show selected Radio head button using if-else-if statements

            if (radioButton1.Checked)
                outputFile.WriteLine(radioButton1.Text);

            else if (radioButton2.Checked)
                outputFile.WriteLine(radioButton2.Text);

            else if (radioButton3.Checked)
                outputFile.WriteLine(radioButton3.Text);

            outputFile.WriteLine(label6.Text + " " + textBox3.Text);
            outputFile.WriteLine(label7.Text + " " + textBox4.Text);
            outputFile.WriteLine(label9.Text + " " + textBox5.Text);

            //provide 1-line space for new Record
      
            outputFile.WriteLine();          

            outputFile.Close();


            //Transition from Form1 to Form2

            Form2 FORM2 = new Form2();
            FORM2.Show();
            this.Close();
            





            //Transition to DATABASE for filtering and displaying of records

            




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
