using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SWD_Formular_Registrierung_NIKOLAENKO
{
    public partial class Registrierungsformular : Form
    {
        private string user_firstname = "";
        private string user_lastname = "";
        private string username = "";

        private string eye_symbol = "\u2182";

        // More to RegEx @ https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference?redirectedfrom=MSDN
        Regex names_regex = new Regex(@"^[a-zA-Z]+$");  // ^ == Anfang, $ == Ende eines Strings, + == vorh.Zeichen darf 1 und mehr widerholt w
        Regex address_regex = new Regex(@"[a-zA-Z-\W]+, \d+[a-zA-Z]?");  // \W == beliebiege nicht-Alphanumerische Symbole, \d == Zahlen, 
        // ? == vorh.Zeichen darf 0 und mehrmals widerholt werden
        Regex cityname_regex = new Regex(@"^[a-zA-Z]+[-a-zA-Z]+$");  // [^abc] == alles außer a, b oder c
        Regex password_regex = new Regex(@"[a-zA-Z]+[\d]+[\W-_]+");

        public Registrierungsformular()
        {
            InitializeComponent();
            button2_show_password.Text = eye_symbol;
        }

        /* 
        Validierung der Vornamenseingabe + Erstellung des Benutzernamens
        */
        private void input1_name_TextChanged(object sender, EventArgs e)
        {
            if (Check_text_input(ref input1_name, ref error_label1_name, names_regex))
            {
                user_firstname = input2_lastname.Text;
            }
            else
            {
                user_firstname = "";
            }

            if (user_firstname != "" & user_lastname != "")
            {
                username = user_firstname + user_lastname.ToLower();
            }
            else
            {
                username = "";
            }
            input6_username.Text = username;
        }

        /* 
        Validierung der Nachnamenseingabe + Erstellung des Benutzernamens
        */
        private void input2_lastname_TextChanged(object sender, EventArgs e)
        {
            if (Check_text_input(ref input2_lastname, ref error_label2_lastname, names_regex))
            {
                user_lastname = input2_lastname.Text;
            }
            else
            {
                user_lastname = "";
            }

            if (user_firstname != "" & user_lastname != "")
            {
                username = user_firstname + user_lastname.ToLower();
            }
            else
            {
                username = "";
            }
            input6_username.Text = username;
        }

        /* 
        Validierung der Adresseneingabe
        */
        private void input3_address_TextChanged(object sender, EventArgs e)
        {
            bool result = Check_text_input(ref input3_address, ref error_label3_address, address_regex);
        }

        /* 
        Validierung der Ortseingabe
        */
        private void input4_city_TextChanged(object sender, EventArgs e)
        {
            bool result = Check_text_input(ref input4_city, ref error_label4_cityname, cityname_regex);
        }

        /* 
        Validierung des Passworts
        */
        private void input7_password_TextChanged(object sender, EventArgs e)
        {
            if (password_regex.IsMatch(input7_password.Text) && input7_password.Text.Length >= 7 || input7_password.Text == "")
            {
                input7_password.ForeColor = Color.Black;
                error_label5_password.Visible = false;
            }
            else
            {
                input7_password.ForeColor = Color.Red;
                error_label5_password.Visible = true;
            }
        }

        /* 
        Validierung der Akzeptierung von AGBs für die Freischaltung der Anmeldung
        */
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_register.Enabled = checkBox1.Checked;
        }

        private void button2_show_password_Click(object sender, EventArgs e)
        {
            input7_password.UseSystemPasswordChar = !input7_password.UseSystemPasswordChar;
        }

        /* 
        Eine universelle Funktion für Eingabevalidierung 
        */
        private bool Check_text_input(ref TextBox input_obj, ref Label label_obj, Regex regex_str)
        {
            if (regex_str.IsMatch(input_obj.Text) || input_obj.Text == "")
            {
                input_obj.ForeColor = Color.Black;
                label_obj.Visible = false;
                return true;
            }
            else
            {
                input_obj.ForeColor = Color.Red;
                label_obj.Visible = true;
                return false;
            }
        }
    }
}
