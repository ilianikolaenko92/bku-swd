using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormenRechner
{
    public partial class Form1 : Form
    {
        int option_nr = 0;

        private double input1 = 0;

        private double input2 = 0;

        private double result1 = 0;

        private double result2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShapesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFormFields();  // Bei Änderung der Wahl der Figur im Dropdown-Menu löscht den Inhalt von Ergebnisfelder

            string selectedOption = shapesComboBox.SelectedItem.ToString();
            MessageBox.Show("Sie haben Option: " + selectedOption + " gewählt.");

            if (shapesComboBox.SelectedIndex == 0 || shapesComboBox.SelectedIndex == 2) {
                this.outputField1.Text = "";
                this.outputField1.Text = "";

                this.inputField1.Visible = true;
                this.inputLabel1.Visible = true;
                this.inputField2.Visible = false;
                this.inputLabel2.Visible = false;
                if (shapesComboBox.SelectedIndex == 0)
                {
                    this.inputLabel1.Text = "Seitenlänge";
                    option_nr = 0;
                } else if (shapesComboBox.SelectedIndex == 2)
                {
                    this.inputLabel1.Text = "Radius";
                    option_nr = 2;
                }
            } else if (shapesComboBox.SelectedIndex == 1)
            {
                this.inputField1.Visible = true;
                this.inputLabel1.Visible = true;
                this.inputField2.Visible = true;
                this.inputLabel2.Visible = true;
                this.inputLabel1.Text = "Seitenlänge A";
                this.inputLabel2.Text = "Seitenlänge B";
                option_nr = 1;
            }
                
        }

        private void InputField1_TextChanged(object sender, EventArgs e)
        // Try Catch vs If + TryParse: https://metanit.com/sharp/tutorial/2.14.php
        {
            string input_str = inputField1.Text;

            if (Double.TryParse(input_str, out input1)) {
                // TryParse ist in diesem Fall effizienter als Try + Catch! 
            } else
            {
                input1 = 0;
                inputField1.Text = "NUR ZAHLEN";
                inputField1.ForeColor = Color.Red;
            }

        }

        private void InputField2_TextChanged(object sender, EventArgs e)
        // Try Catch vs If + TryParse: https://metanit.com/sharp/tutorial/2.14.php
        {
            try
            {
                input2 = Double.Parse(inputField2.Text);
            }
            catch
            {
                input2 = 0;
                inputField2.Text = "NUR ZAHLEN";
                inputField2.ForeColor = Color.Red;
            }

        }

        private void InputField1_Enter(object sender, EventArgs e)

        // funktioniert nicht
        {
            string input_str = inputField1.Text;

            if (Double.TryParse(input_str, out input1) && Double.TryParse(inputField2.Text, out input2))
            {
                
            }
            else
            {

            }
        }

        private void InputField2_Enter(object sender, EventArgs e)
        // funktioniert nicht
        {
            string input_str = inputField2.Text;

            if (Double.TryParse(input_str, out input2) && Double.TryParse(inputField1.Text, out input1))
            {

            }
            else
            {
                input2 = 0;
            }
        }

        private void CalculateBttn_Click(object sender, EventArgs e)
        {
            switch (option_nr)
            {
                case 0:
                    Calculate_Square_Data(input1, out result1, out result2);
                    this.outputField1.Text = result1.ToString();
                    this.outputField2.Text = result2.ToString();
                    break;

                case 1:
                    Calculate_Rectangle_Data(input1, input2, out result1, out result2);
                    this.outputField1.Text = result1.ToString();
                    this.outputField2.Text = result2.ToString();
                    break;

                case 2:
                    Calculate_Circle_Data(input1, out result1, out result2);
                    this.outputField1.Text = result1.ToString();
                    this.outputField2.Text = result2.ToString();
                    break;

                default:
                    MessageBox.Show("Etwas ist falsch gelaufen. Bitte überprüfen Sie Ihre Eingaben!");
                    break;
            }

        }

        private void Calculate_Square_Data(double sides_length, out double perimeter, out double area)  
        // https://metanit.com/sharp/tutorial/2.27.php
        {
            perimeter = 4 * sides_length;

            area = Math.Pow(sides_length, 2);


        }

        private void Calculate_Rectangle_Data(double side_a_length, double side_b_length, out double perimeter, out double area)  
        // https://metanit.com/sharp/tutorial/2.27.php
        {
            perimeter = 2 * (side_a_length + side_b_length);

            area = side_a_length * side_b_length;

        }

        private void Calculate_Circle_Data(double radius, out double perimeter, out double area)
        // https://metanit.com/sharp/tutorial/2.27.php
        {
            perimeter = 2 * Math.PI * radius;

            area = Math.PI * Math.Pow(radius, 2);

        }

        private void ClearFormFields()
        {
            this.inputField1.Text = "";
            this.inputField2.Text = "";
            this.outputField1.Text = "";
            this.outputField2.Text = "";
        }

    }
}
