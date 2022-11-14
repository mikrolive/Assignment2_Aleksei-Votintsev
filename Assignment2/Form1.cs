using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const float class_seat_A = 15, class_seat_B = 12, class_seat_C = 9;

            double seats_count_A, seats_count_B, seats_count_C;

            seats_count_A = double.Parse(textBox1.Text);
            seats_count_B = double.Parse(textBox2.Text);
            seats_count_C = double.Parse(textBox3.Text);

            double seats_total_A, seats_total_B, seats_total_C, total_all;

            seats_total_A = seats_count_A * class_seat_A;
            seats_total_B = seats_count_B * class_seat_B;
            seats_total_C = seats_count_C * class_seat_C;
            total_all = seats_total_A + seats_total_B + seats_total_C;

            textBox4.Text = seats_total_A.ToString() + "$";
            textBox5.Text = seats_total_B.ToString() + "$";
            textBox6.Text = seats_total_C.ToString() + "$";
            textBox7.Text = total_all.ToString() + "$";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
