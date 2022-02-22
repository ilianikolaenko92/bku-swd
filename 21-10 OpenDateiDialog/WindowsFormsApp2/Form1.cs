using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ab hier in einem PAP oder Struktogramm darstellen
            this.openFileDialog1.InitialDirectory = "C:\\Users\niil02"; //Bitte anpassen - gemacht
            this.openFileDialog1.Filter = "Excel-Dateien|*.csv";
            this.openFileDialog1.FileName = "";

            bool datei_gewaehlt=false;

            while ( ! datei_gewaehlt)
            {
                if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    MessageBox.Show("Gewählte Datei: " + this.openFileDialog1.FileName);
                    datei_gewaehlt = true;
                }
                else
                {
                    MessageBox.Show("Keine Datei gewählt");
                }
            }
            
        }
    }
}
