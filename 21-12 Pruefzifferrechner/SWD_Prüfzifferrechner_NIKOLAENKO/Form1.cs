using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWD_Prüfzifferrechner_NIKOLAENKO
{
    public partial class Form1 : Form
    {
        /*
        Main variables area
        */

        private string card_nr_str = "";

        private int[] card_nrs_arr = new int[16];

        private int security_nr_received = 0;
        private int security_nr_calculated = 0;

        public Form1()
        {
            InitializeComponent();
            validation_label1.Visible = false;
        }


        /*
        WinForms Events' Logic area
        */

        // Wrong input in the masked field detected
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            update_feedback_label(ref validation_label1, true, "Bitte nur Zahlen (maximal 16) eingeben!", Color.Red);
        }

        // User input in the masked field is changed
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        // https://www.c-sharpcorner.com/uploadfile/mahesh/maskedtextbox-in-C-Sharp/
        {
            // Beliebige Meldungen von vorherigen Vorgängen neusetzen
            update_feedback_label(ref validation_label1, false, "", Color.Black);

            // Hauptvariablen neu setzen
            card_nr_str = "";  // lert die Hauptvariable neu
            Array.Clear(card_nrs_arr, 0, card_nrs_arr.Length);  // leert das Array von vorherigen Ergebnissen ab dem bestimmten Index bis den eingegebenen Inde
            security_nr_calculated = 0;  // setzt die kalkulierte Prüfziffer der letzten Eingabe neu
            security_nr_received = 0;  // setzt die erhaltene Prüfziffer der letzten Eingabe neu

            // Bei vollständiger Eingabe einer Hauptvariable den neuen Wert zuweisen
            if (maskedTextBox1.MaskFull)
            {
                card_nr_str = maskedTextBox1.Text;
            }
        }

        // Button to check the security number clicked
        private void button1_check_cardnr_Click(object sender, EventArgs e)
        {
            if (card_nr_str.Length != 16)
            {
                update_feedback_label(ref validation_label1, true, "Bitte die ganze Kartennummer eingeben!", Color.Red);
            } 
            else
            {
                // Jedes Zeichen des Strings ins int konvertieren
                for (int i = 0; i < card_nr_str.Length; i++)
                {
                    card_nrs_arr[i] = (int)char.GetNumericValue(card_nr_str[i]);
                }

                // Wert der erhaltenen Prüfsziffer der Variable zuweisen
                security_nr_received = card_nrs_arr[card_nrs_arr.Length - 1];  // Greift auf eine letzte Ziffer im Array. Ab C# 8.0 kann man  einfach card_nrs_arr[^1] schreiben
                Console.WriteLine("Last number received:" + security_nr_received);

                // Erstellung und Befüllung von 2 Arrays für Zahlen aus geraden und ungeraden Indexen des Hauptarrays
                int[] odd_nrs = new int[8];
                int[] even_nrs = new int[8];  

                create_odds_and_evens_arrs(card_nrs_arr, ref odd_nrs, ref even_nrs);

                // Kalkulieren von Ergebnissen des Luhn-Algorithmus für die Zahlen auf geraden und ungeraden Stellen

                // Für ungerade Indexen:
                int odd_result = 0;
                odd_result =  get_odds_result(odd_nrs, odd_result);

                // Für gerade Indexen:
                int even_result = 0;
                even_result = get_evens_result(even_nrs, even_result);

                // Ergebnisse und kalkulierte Prüfziffer
                Console.WriteLine("Sum of odd indexes: " + odd_result);
                Console.WriteLine("Sum of even indexes: " + even_result);

                security_nr_calculated = calculate_security_nr(odd_result, even_result);

                Console.WriteLine("Calculated security number: " + security_nr_calculated);


                // Die Meldung entsprechend den Ergebnissen anzeigen
                if (security_nr_calculated == security_nr_received)
                {
                    update_feedback_label(ref validation_label1, true, "Die eingegebene Prüfziffer ist korrekt!", Color.Green);
                }
                else
                {
                    update_feedback_label(ref validation_label1, true, "Die eingegebene Prüfziffer ist falsch!", Color.Red);
                }
            }

        }

        // Button to insert the correct security number clicked
        private void button2_calculate_security_nr_Click(object sender, EventArgs e)
        {
            if (card_nr_str.Length != 16)
            {
                update_feedback_label(ref validation_label1, true, "Bitte die ganze Kartennummer eingeben!", Color.Red);
            }
            else
            {
                // Die eingegebene letzte Ziffer mit einer ausgerechneten ersetzen
                maskedTextBox1.Text = card_nr_str.Insert((card_nr_str.Length - 1), security_nr_calculated.ToString());

                update_feedback_label(ref validation_label1, true, "Die Prüfziffer wurde erfolgreich berechnet!", Color.Blue);

            }
        }


        /*
        Helper functions area
        */

        // Fills 2 arrays with values from the main array either of its odd or even positions
        private void create_odds_and_evens_arrs(int[] main_arr, ref int[] odd_nrs, ref int[] even_nrs)
        {
            int odds_index = 0;
            int evens_index = 0;

            for (int i = 0; i < main_arr.Length - 1; i++)  // The last number (16th) is not used in the algorythm 
            {

                if (i % 2 == 0)  // modulo of 0 have ODD els of arrays! (idx0 is 1, idx2 is 3, idx 4 is 5, ...)
                {
                    odd_nrs[odds_index] = main_arr[i];
                    odds_index++;
                }

                else
                {
                    even_nrs[evens_index] = main_arr[i];
                    evens_index++;
                }
            }
        }

        // Updates attributes of the feedback label according to the result of the input's validation
        private void update_feedback_label(ref Label label_obj, bool is_shown, string feedback_text, Color feedback_color)
        {
            label_obj.Visible = is_shown;
            label_obj.Text = feedback_text;
            label_obj.ForeColor = feedback_color;
        }

        // Gets result of the Lunh-Algorithm for the array of numbers from odd indexes
        private int get_odds_result(int[] odd_nrs_array, int odd_result_int)
        {
            foreach (int odd_element in odd_nrs_array)
            {
                int increased_element = odd_element * 2;

                // Prüfung auf 2-Stelligen Zahlen und Addierung von Zahlen falls 2-stellig
                string temp_str = increased_element.ToString();
                int final_int;

                if (temp_str.Length > 1)  // Für 2-stellige Zahlen
                {
                    int digit1 = (int)char.GetNumericValue(temp_str[0]);
                    int digit2 = (int)char.GetNumericValue(temp_str[1]);

                    final_int = digit1 + digit2;
                    Console.WriteLine("For the number " + temp_str + "the quer sum of " + digit1 + " and " + digit2 + " is " + final_int);
                }

                else  // für 1-stellige Zahlen
                {
                    final_int = Convert.ToInt32(temp_str);
                }

                odd_result_int += final_int;
            }

            return odd_result_int;
        }

        // Gets result of the Lunh-Algorithm for the array of numbers from even indexes
        private int get_evens_result(int[] even_nrs_array, int even_result_int)
        {
            for (int index = 0; index < (even_nrs_array.Length - 1); index++)
            {
                even_result_int += even_nrs_array[index];
            }

            return even_result_int;
        }

        // Calculates a correct security number's value based on the Luhn-Algorithm
        private int calculate_security_nr(int odds_result, int evens_result)
        {
            int raw_result;
            int rounded_result;

            raw_result = odds_result + evens_result;
            Console.WriteLine("Raw result: " + raw_result);

            rounded_result = raw_result;
            while (rounded_result % 10 != 0)
            {
                rounded_result += 1;
            }
            Console.WriteLine("Rounded result: " + rounded_result);

            return rounded_result - raw_result;
        }

    }
}
