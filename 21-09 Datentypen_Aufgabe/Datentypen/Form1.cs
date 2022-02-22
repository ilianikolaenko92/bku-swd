using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datentypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double a = 30.29; // Gleichzeitige Definition und Initialisierung einer Variable
            double b = 5.8;
            double c;

            c = a + b;

            MessageBox.Show($"Das Ergebnis der Addierung lautet: {c}"); // MessageBox.Show() Methode nimmt nur ein String als Argument ein. Auch einfach c.ToString() / Convert.ToString(c) / (String)(c) / .TryParse() ist möglich.
            MessageBox.Show($"Das Ergebnis der Substaktion lautet: {a - b}"); // eine separate Variable ist für jede Operation in diesem Fall  nicht nötig und nicht Speichereffizient. Ss wäre sinnvoller (wenn überhaupt) einen Delegat einer Funktion mit mehreren Vorgehensweisen für dieselben Argumente zu erstellen
            MessageBox.Show($"Das Ergebnis der Multiplikation lautet: {a * b}");
            MessageBox.Show($"Das Ergebnis der Division lautet: {a / b}");
            MessageBox.Show($"Das Ergebnis des Modulos lautet: {Convert.ToInt32(a % b) }"); // Damit die Modulo immer als ganzzahlige Zahl ausgegeben werden, muss die Ergebnis ins integer konvertiert werden

        }
    }
}
