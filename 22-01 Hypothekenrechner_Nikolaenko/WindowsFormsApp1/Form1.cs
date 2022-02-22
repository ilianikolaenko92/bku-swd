using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypothekenrechner_Nikolaenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal loan_ttl_eur = 0;
        private decimal interest_rate = 0;
        private decimal yearly_payback_eur = 0;
        private int loan_period_yrs = 0;
        private decimal payback_ttl_eur = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();  // Resets the list field upon every click on the bttn
            loan_ttl_eur = Convert.ToDecimal(textBox1.Text);  // Resets the var of ttl loan amount upon every click on the bttn

            int counter = 1;
            while (counter <= loan_period_yrs)
            {
                decimal current_debt = get_current_debt(ref loan_ttl_eur, interest_rate, yearly_payback_eur);
                listView1.Items.Add($"Jahr {counter}: " + String.Format("{0:n}", current_debt));
                counter++;
            }
            textBox4.Text = String.Format("{0:n}", loan_ttl_eur);  // .Format() method with "{0:n}" adds separater for thousands of numbers
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            loan_period_yrs = (int)(numericUpDown1.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loan_ttl_eur = Convert.ToDecimal(textBox1.Text);
                Console.WriteLine("Loan amount was set to" + loan_ttl_eur);

                payback_ttl_eur = loan_ttl_eur;
                textBox4.Text = String.Format("{0:n}", payback_ttl_eur);  // .Format() method with "{0:n}" adds separater for thousands of numbers
            }
            catch
            {
                loan_ttl_eur = 0;
                payback_ttl_eur = 0;
                listView1.Items.Clear();
                textBox1.Text = loan_ttl_eur.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {
                interest_rate = Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                interest_rate = 0;
                textBox2.Text = interest_rate.ToString();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearly_payback_eur = Convert.ToDecimal(textBox3.Text);
                Console.WriteLine("Yearly Payback was set to" + yearly_payback_eur);
            }
            catch
            {
                yearly_payback_eur = 0;
                textBox3.Text = yearly_payback_eur.ToString(); 
            }
        }

        private decimal get_current_debt(ref decimal loan_left_ttl, decimal interest_rate, decimal yearly_payback)
        {
            decimal current_rate_eur = get_rate(loan_left_ttl, interest_rate);

            decimal current_payment = loan_left_ttl + current_rate_eur - yearly_payback;

            Console.WriteLine("Current year debt left: " + current_payment + "with payback of " + yearly_payback + "eur");

            loan_ttl_eur = current_payment;

            return Math.Round(loan_ttl_eur, 2);
        }

        private decimal get_rate(decimal loan_ttl_left, decimal interest_rate)
        {
            decimal rate_sum = loan_ttl_left * (interest_rate / 100);

            Console.WriteLine("Current year debt left to pay: " + rate_sum);

            return Math.Round(rate_sum, 2);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string temp_val = textBox1.Text;

            try
            {
                textBox1.Text = string.Format("{0:#,##0.00}", double.Parse(textBox1.Text));  // Reformats the string of the input upon leaving the field. Found here https://stackoverflow.com/questions/15473216/how-to-format-a-windows-forms-textbox-with-thousand-separator-and-decimal-separt
            }
    
            catch
            {
                textBox1.Text = temp_val;
            }
            
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            string temp_val = textBox3.Text;

            try
            {
                textBox3.Text = string.Format("{0:#,##0.00}", double.Parse(textBox3.Text));  // Reformats the string of the input upon leaving the field. Found here https://stackoverflow.com/questions/15473216/how-to-format-a-windows-forms-textbox-with-thousand-separator-and-decimal-separt
            }

            catch
            {
                textBox3.Text = temp_val;
            }
        }
    }
}
