using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SWD_Klausur_220505_Nikolaenko
{
    public partial class Form1 : Form
    {
        private Regex str_regex = new Regex(@"[a-zA-Z]");

        private string str_input_1 = "";
        private string str_input_2 = "";
        private string str_input_3 = "";
        private int int_input = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (sender == textBox1)
            {
                validate_str_input(ref textBox1, ref str_input_1);
            }
            else if (sender == textBox2)
            {
                validate_str_input(ref textBox2, ref str_input_2);
            }
            else if (sender == textBox3)
            {
                validate_str_input(ref textBox3, ref str_input_3);
            }
            else if (sender == textBox4)
            {
                validate_int_input(ref textBox4, ref int_input);
            }

            if (!(str_input_1 == "") && !(str_input_2 == "") && !(str_input_3 == "") && !(int_input == 0))
            {
                button1_generate.Enabled = true;
                button2_function.Enabled = true;
            }
            else
            {
                button1_generate.Enabled = false;
                button2_function.Enabled = false;
            }

        }

        private void button1_generate_Click(object sender, EventArgs e)
        {
            generate_code();  // Ohne Parameterangabe wird Standardwert "_" verwebdet
        }

        private void button2_function_Click(object sender, EventArgs e)
        {
            generate_code(separator: int_input.ToString());
        }


        /* AREA of programm logic */

        private void validate_str_input(ref TextBox str_input, ref string str_var)
        {
            if (str_input.Text.Length == 1 && str_regex.IsMatch(str_input.Text))
            {
                str_var = str_input.Text;
                label1.Text = "";
                label1.ForeColor = Color.Black;
                label1.Visible = false;
            }
            else
            {
                str_var = "";
                label1.Text = "Falsche eingabe! Nur 1 Buchstabe bitte.";
                label1.ForeColor = Color.Red;
                label1.Visible = true;
            }
        }

        private void validate_int_input(ref TextBox int_input, ref int int_var)
        {
            try
            {
                int int_value = Convert.ToInt32(int_input.Text);

                if (int_input.Text.Length == 1 && int_value > 0 && int_value <= 9)
                {
                    int_var = int_value;
                    label1.Text = "";
                    label1.ForeColor = Color.Black;
                    label1.Visible = false;
                }
                else
                {
                    int_var = 0;
                    label1.Text = "Falsche eingabe! Nur Zahlen zwichen 1 und 9 bitte.";
                    label1.ForeColor = Color.Red;
                    label1.Visible = true;
                }
            }
            catch
            {
                int_var = 0;
                label1.Text = "Falsche eingabe! Nur Zahlen zwichen 1 und 9 bitte.";
                label1.ForeColor = Color.Red;
                label1.Visible = true;
            }
            
        }

        private void generate_code(string separator = "_")
        {
            string[] string_arr = new string[int_input];

            string label_message = "";

            for (int index = 0; index < string_arr.Length; index++)
            {
                if (int.TryParse(separator, out int res) && res % 2 != 0)
                {
                    string_arr[index] = str_input_3 + str_input_2 + str_input_1;
                }
                else
                {
                    string_arr[index] = str_input_1 + str_input_2 + str_input_3;
                }
                
                Console.WriteLine(string_arr[index]);
            }

            foreach (string segment in string_arr)
            {
                label_message = label_message + segment + separator;
            }

            label_message = label_message.Remove(label_message.Length - 1);

            label1.Text = label_message;
            label1.Visible = true;
            label1.ForeColor = Color.Black;
        }
    }
}
