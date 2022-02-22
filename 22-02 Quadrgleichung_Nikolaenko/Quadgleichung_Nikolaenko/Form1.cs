using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadgleichung_Nikolaenko
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double p = 0;
        private double q = 0;
        private double d = 0;


        private double BerechnungVonD(double p, double q, ref double d)
        {
            d = Math.Pow((p / 2), 2) - q;
            return Math.Abs(d);
        }

        private int BerechnungVonX(double p, double q, ref double x1, ref double x2)
        {
            double d_abs = BerechnungVonD(p, q, ref d);

            if (d > 0)
            {
                x1 = Math.Round(((-p / 2) + Math.Sqrt(d_abs)), 2);
                x2 = Math.Round(((-p / 2) - Math.Sqrt(d_abs)), 2);
                Console.WriteLine("2 solutions found: x1=" + x1 + " x2=" + x2);
                return 2;
            }
            else if (d == 0)
            {
                x1 = (-p / 2) + Math.Sqrt(d_abs);
                Console.WriteLine("1 solution found: x1=" + x1);
                return 1;
            }
            else
            {
                Console.WriteLine("No solution for current values of p and q");
                return 0;
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == p_textbox)
                {
                    p = Convert.ToDouble(p_textbox.Text);
                    Console.WriteLine("p is set to " + p);
                } else if (sender == q_textbox)
                {
                    q = Convert.ToDouble(q_textbox.Text);
                    Console.WriteLine("q is set to " + q);
                }
            }
            catch
            {
                if (sender == p_textbox)
                {
                    p = 0;
                    p_textbox.Text = p.ToString();
                    Console.WriteLine("p value is reset to " + p);
                }
                else if (sender == q_textbox)
                {
                    q = 0;
                    q_textbox.Text = q.ToString();
                    Console.WriteLine("q value is reset to " + q);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = 0;
            double x2 = 0;
            int solutions_avl = BerechnungVonX(p, q, ref x1, ref x2);

            switch (solutions_avl)
            {
                case 2:
                    x1_textbox.Text = x1.ToString();
                    x1_textbox.Visible = true;
                    x1_label.Visible = true;

                    x2_textbox.Text = x2.ToString();
                    x2_textbox.Visible = true;
                    x2_label.Visible = true;

                    solution_label.Text = $"D={d}, 2 Lösungen gefunden!";
                    solution_label.ForeColor = Color.Green;
                    solution_label.Visible = true;

                    break;
                case 1:
                    x1_textbox.Text = x1.ToString();
                    x1_textbox.Visible = true;
                    x1_label.Visible = true;

                    x2_textbox.Visible = false;
                    x2_label.Visible = false;

                    solution_label.Text = $"D={d}, 1 Lösung gefunden!";
                    solution_label.ForeColor = Color.Green;
                    solution_label.Visible = true;

                    break;
                default:
                    x1_textbox.Visible = false;
                    x1_label.Visible = false;

                    x2_textbox.Visible = false;
                    x2_label.Visible = false;

                    solution_label.Text = $"D={d}, keine Lösungen möglich!";
                    solution_label.ForeColor = Color.Red;
                    solution_label.Visible = true;
                    break;
            }

            Console.WriteLine("D is " + d);

        }
    }
}
