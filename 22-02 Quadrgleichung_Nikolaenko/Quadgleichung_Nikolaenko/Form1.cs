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

        private void textBox_TextChanged(object sender, EventArgs e)
         /* Diese Funktion verwaltet Zuweisung von Eingabenwerten in Textfeldern P und Q;
         * Konvertiert einen str-Wert eines Textfelds Text-Parameter in ein Double;
         * Weist den Souble-Wert dem entstpechenden Attribut der Klasse 
         */
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
         /* Diese Funktion fordert mögliche X1 und X2-Lösungen für aktuelle Werte von Klassenattribute P und Q an;
         * Rechnet die Anzahl von möglichen Lösungen bei den aktuellen P und Q;
         * Je nach Anzahl von Lösungen passt die Bedieneroberfläche der Anwendung entsprechend an, indem die ins str konvertierten Werte von X1 und X2 sowie eine entsprechende Nachricht mit dem D-Wert angezeigt werden
         */
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

                    solution_label.Text = $"D={d}, keine Lösung möglich!";
                    solution_label.ForeColor = Color.Red;
                    solution_label.Visible = true;
                    break;
            }

            Console.WriteLine("D is " + d);

        }

        private void BerechnungVonD(double p, double q, ref double d)
         /* Diese Funktion rechnet einen absoluten Wert von D der quadratischen Gleichung aus
         * args: p, q - Double-Werte von Klassenattributen mit aktuellen Werten von P und Q
         *       d - Double für aktuellen D-Wert (Nicht absoluten!)
         */
        {
            d = Math.Pow((p / 2), 2) - q;
        }

        private int BerechnungVonX(double p, double q, ref double x1, ref double x2)
        /* Fordert einen absoluten D-Wert an
         * Rechnet X1- bzw X1- und X2-Werte je nach aktuellen D-Wert aus
         * Gibt einen int-Wert für die Anzahl von möglichen Lösungen der quadratischen Gleichung zurück
         * args: p, q - Double-Werte von Klassenattributen mit aktuellen Werten von P und Q
         *       x1, x2 - Double-Werte für die Lösungen der quadratischen Gleichung
         *       d - Double-formattierte Klassenattribut für aktuellen D-Wert (Nicht absoluten!)
         * return: int-Wert für die Anzahl von möglichen Lösungen
         */
        {
            BerechnungVonD(p, q, ref d);

            if (d > 0)
            {
                x1 = Math.Round(((-p / 2) + Math.Sqrt(d)), 2);
                x2 = Math.Round(((-p / 2) - Math.Sqrt(d)), 2);
                Console.WriteLine("2 solutions found: x1=" + x1 + " x2=" + x2);
                return 2;
            }
            else if (d == 0)
            {
                x1 = (-p / 2) + Math.Sqrt(d);
                Console.WriteLine("1 solution found: x1=" + x1);
                return 1;
            }
            else
            {
                Console.WriteLine("No solution for current values of p and q");
                return 0;
            }

        }
    }
}
