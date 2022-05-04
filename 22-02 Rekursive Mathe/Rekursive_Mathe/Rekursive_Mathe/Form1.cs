using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rekursive_Mathe
{
    public partial class Form1 : Form
    {
        private int _selected_option = 0;
        private int _x_valid = 0;
        private int _y_valid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Index-order independent processor of selected math operations from the dropdown menu of the app */
            string math_choice = comboBox_math_operations.SelectedItem.ToString();

            if (math_choice == "Addieren")
            {
                _selected_option = 1;
            }
            else if (math_choice == "Substrahieren")
            {
                _selected_option = 2;
            }
            else if (math_choice == "Multiplizieren")
            {
                _selected_option = 3;
            }
            else if (math_choice == "Dividieren")
            {
                _selected_option = 4;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
            /* Manages inputs of X and Y fields
             * updates the state of the app according to the entered values of X or of Y */
        {
            try
            {
                if (sender == x_input)
                // Operations with an input of X value
                {
                    int x_temp = Convert.ToInt32(x_input.Text);
                    if (x_temp >= 0)
                    {
                        _x_valid = x_temp;
                        label5_x_message.Visible = false;
                        button1.Enabled = true;
                    }
                    else
                    {
                        label5_x_message.Visible = true;
                        label5_x_message.Text = "Nur positive gerade Zahlen!";
                        label5_x_message.ForeColor = Color.Red;
                        button1.Enabled = false;
                    }
                }
                else if (sender == y_input)
                // Operations with an input of Y value
                {
                    int y_temp = Convert.ToInt32(y_input.Text);
                    if (y_temp >= 0)
                    {
                        _y_valid = y_temp;
                        label6_y_message.Visible = false;
                        button1.Enabled = true;
                    }
                    else
                    {
                        label6_y_message.Visible = true;
                        label6_y_message.Text = "Nur positive gerade Zahlen!";
                        label6_y_message.ForeColor = Color.Red;
                        button1.Enabled = false;
                    }
                }
                
            }
            catch
            // if X or Y values are not convertable into a whole number (int)
            {
                button1.Enabled = false;
                if (sender == x_input)
                {
                    _x_valid = 0;
                    label5_x_message.Visible = true;
                    label5_x_message.Text = "Nur positive gerade Zahlen!";
                    label5_x_message.ForeColor = Color.Red;
                }
                else if (sender == y_input)
                {
                    _y_valid = 0;
                    label6_y_message.Visible = true;
                    label6_y_message.Text = "Nur positive gerade Zahlen!";
                    label6_y_message.ForeColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_selected_option)
            {
                case 1:
                    result_field.Text = ADD(_x_valid, _y_valid).ToString();
                    break;
                case 2:
                    result_field.Text = SUB(_x_valid, _y_valid).ToString();
                    break;
                case 3:
                    result_field.Text = MUL(_x_valid, _y_valid).ToString();
                    break;
                case 4:
                    result_field.Text = DIV(_x_valid, _y_valid).ToString();
                    break;
                default:
                    result_field.Text = "Wählen Sie die Operation!";
                    break;
            }
        }

        /* Area of the logical functions of the program */

        private int ADD(int x, int y)
        {
            /* Recursive Addition of 2 positive whole numbers 
             params: x, y: pre-validated positive integer numbers
             return: a result of addition */
            if (x == 0 && y == 0)
            {
                return 0;
            }
            else if (x == 0)
            {
                return 1 + ADD(x, y - 1);
            }
            else if (y == 0)
            {
                return 1 + ADD(x - 1, y);
            }
            else
            {
                return 1 + 1 + ADD(x - 1, y - 1);
            }
        }

        private int SUB(int x, int y)
            /* Recursive Substraction of 2 positive whole numbers 
            params: x, y: pre-validated positive integer numbers
            return: a result of substraction */
        {
            if (y == 0)
            {
                return ADD(x, 0);
            }
            else
            {
                return SUB(x, y - 1) - 1;
            }
        }

        private int MUL(int x, int y)
        {
            /* Recursive Multiplication of 2 positive whole numbers 
            params: x, y: pre-validated positive integer numbers
            return: a result of multiplication */
            if (y == 1)
            {
                return ADD(x, 0);
            }
            else if (y == 0)
            {
                return 0;
            } 
            else
            {
                return ADD(ADD(x, 0), MUL(x, y - 1));
            }
        }

        private int DIV(int x, int y)
            /* Recursive Division of 2 positive whole numbers 
            params: x, y: pre-validated positive integer numbers
            return: a result of division */
        {
            if (SUB(x, y) < 0)
            {
                return 0;
            }
            else
            {
                return 1 + DIV(SUB(x, y), y);
            } 
        }
    }
}
