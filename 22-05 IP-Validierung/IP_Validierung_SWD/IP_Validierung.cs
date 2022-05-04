using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Validierung_SWD
{
    public partial class IP_Validierung : Form
    {
        private string[] separator_arr = new string[] { "." };
        private int[] subnet_arr = new int[4] { 0, 0, 0, 0 };
        private int[] ip1_arr = new int[4] { 0, 0, 0, 0};
        private int[] ip2_arr = new int[4] { 0, 0, 0, 0 };
        private int bit_wise_sum_ip1 = 0;
        private int bit_wise_sum_ip2 = 0;
        private bool isMatched = false;


        public IP_Validierung()
        {
            InitializeComponent();
        }


        /* Area of standard WinForms event-based methods */

        private void maskedTextBox_Validating(object sender, CancelEventArgs e)
        /* Checks if the received value of an MaskedTextBox matches the requirement for each segment to be between 0 and 255
         Updates message labels and colors according to the result of the validation
         In case of successful validation:
         Cleares a corresponding ListView element of any previous items
         Fills a corresponding class array with segments 
         Adds each segment as an element of a correspong ListView element
         */
            
            // Validating of a MaskedTextBox is fired just before the validation process starts, this is the place to put the actual validation code.
        {

            if (sender == maskedTextBox1_Subnetmask)
            {
                ValidateInputAndFillIntArray(maskedTextBox1_Subnetmask, ref subnet_arr, label2_subnetmask_label, ref e);
            }
            else if (sender == maskedTextBox2_ip1)
            {
                listView1_ip1.Items.Clear();

                ValidateInputAndFillIntArray(maskedTextBox2_ip1, ref ip1_arr, label3_ip1_label, ref e);

                for (int index = 0; index < ip1_arr.Length; index++)
                {
                    DisplayArraySegment(ref maskedTextBox2_ip1, ip1_arr[index], index + 1);
                }
            }
            else if (sender == maskedTextBox3_ip2)
            {
                listView2_ip2.Items.Clear();

                ValidateInputAndFillIntArray(maskedTextBox3_ip2, ref ip2_arr, label4_ip2_label, ref e);

                for (int index = 0; index < ip2_arr.Length; index++)
                {
                    DisplayArraySegment(ref maskedTextBox3_ip2, ip2_arr[index], index + 1);
                }
            }
        }

        private void maskedTextBox_Validated(object sender, EventArgs e)
        /* Checks if all 3 class arrays are not filled with default values (i.e. all three inputs were validated right) and reactivates the button 
         */

            // Validated is fired after the validation process of the MaskedTextBox element has finished and is designed to be the place to something based on the validation result.
        {
            Console.WriteLine("Validation succeeded");
            if (!CheckStandardValues(subnet_arr) && !CheckStandardValues(ip1_arr) && !CheckStandardValues(ip2_arr))
            {
                button1.Enabled = true;
            }
        }

        private void maskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        /* Processes an event of any type mismatch of an input to a numeric Mask of a MaskedTextBox item
         */
        {
            Console.WriteLine("Only numbers are allowed!");
        }

        private void button1_Click(object sender, EventArgs e)
         /* 
         Checks if all 3 class array vars are filled with validated segments
         Performs the bit-wise addition of segments for each of 2 IP-adresses with the subnet mask
         Updates the output text field with a corresponding message at all stages of validation
         */
        {
            if ( !CheckStandardValues(subnet_arr) && !CheckStandardValues(ip1_arr) && !CheckStandardValues(ip2_arr))
            {
                textBox1_result.Text = "Inputs are validated successfully! Ready to validate the IP-adresses";
                textBox1_result.ForeColor = Color.Green;

                bit_wise_sum_ip1 = ValidateNetworkAdress(subnet_arr, ip1_arr);
                bit_wise_sum_ip2 = ValidateNetworkAdress(subnet_arr, ip2_arr);

                isMatched = bit_wise_sum_ip1 == bit_wise_sum_ip2 ? true : false;
            }
            else
            {
                textBox1_result.Text = "The subnet mask or one of IP-adresses are not filled correctly!";
                textBox1_result.ForeColor = Color.Red;

                isMatched = false;
            }

            if (isMatched)
            {
                textBox1_result.Text = $"Network adresses match! {bit_wise_sum_ip1}";
                textBox1_result.ForeColor = Color.Green;
            }
            else
            {
                textBox1_result.Text = $"Network adresses do not match! {bit_wise_sum_ip1} and {bit_wise_sum_ip2}";
                textBox1_result.ForeColor = Color.Red;
            }
        }


        /* Area of custom logic methods */

        private void ValidateInputAndFillIntArray(MaskedTextBox masked_input, ref int[] num_arr, Label info_label, ref CancelEventArgs validation_event)
        /* Splits a string value of the input in a MaskedTextBox into a str-array using a separator from the class array and removes any empty symbols
         * Checks that the str-array contains 4 elements (segments)
         * If all segments are in place, converts all items of the str-array into an int-array
         * For all items of the int-array validates their value and if all segments have a correct value copies them to the corresponding class array of the MaskedTextBox element
         * Updates other related elements (labels, styles) on the run
         * Cancels validation event if anything goes wrong with the validation. See more @ https://docs.microsoft.com/en-us/dotnet/desktop/winforms/user-input-validation-in-windows-forms?view=netframeworkdesktop-4.8&redirectedfrom=MSDN    
        */
        {
            String[] split_str_arr = masked_input.Text.Split(separator_arr, StringSplitOptions.RemoveEmptyEntries);

            if (split_str_arr.Length == 4)
            {
                int[] split_int_arr = Array.ConvertAll(split_str_arr, str_seg => Convert.ToInt32(str_seg));

                if (Array.TrueForAll(split_int_arr, CheckSegments))
                {
                    System.Array.Copy(split_int_arr, num_arr, 4);

                    masked_input.ForeColor = Color.Black;
                    info_label.Text = "All segments are correct!";
                    info_label.ForeColor = Color.Green;
                    info_label.Visible = true;
                }

                else
                {
                    masked_input.ForeColor = Color.Red;
                    info_label.Text = "One of the segments is wrong! Must be between 0 and 255";
                    info_label.ForeColor = Color.Red;
                    info_label.Visible = true;
                    button1.Enabled = false;

                    System.Array.Clear(num_arr, 0, num_arr.Length);
                    textBox1_result.Text = "";
                    validation_event.Cancel = true;
                }

            }
            else
            {
                masked_input.ForeColor = Color.Red;
                info_label.Text = "4 Segments must be present!";
                info_label.ForeColor = Color.Red;
                info_label.Visible = true;

                button1.Enabled = false;
                textBox1_result.Text = "";

                validation_event.Cancel = true;
            }
        }

        private void DisplayArraySegment(ref MaskedTextBox masked_input, int segment, int segment_num)
        /* Adds a new item to the ListView item with a value of an int segment received from a class array
         */
        {
            if (masked_input == maskedTextBox2_ip1)
            {
                listView1_ip1.Items.Add($"Segment {segment_num}: {segment}");
            }
            else if (masked_input == maskedTextBox3_ip2)
            {
                listView2_ip2.Items.Add($"Segment {segment_num}: {segment}");
            }
        }

        private int ValidateNetworkAdress(int[] submask_arr, int[] ip_arr)
        /* Performs a bit-wise addition of each segment with the same index of the class arrays of a subnet mask and of an ip-address
         * returns:
         *  an int of a bit-wise sum of all segments
         
        More about bit-wise operations: https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm
         */
        {
            int bit_wise_sum = 0;

            for (int index = 0; index < submask_arr.Length; index++ )
            {
                bit_wise_sum += submask_arr[index] & ip_arr[index];
            }

            return bit_wise_sum;
        }

        /* Static helper functions */

        private static bool CheckSegments(int segment)
        /* Returns a bool for a check, if a segment value lies between 0 and 255 */
        {
            return 0 <= segment && segment <= 255;
        }

        private static bool CheckStandardValues(int[] int_array)
        /* Returns a bool for a check, if all items of an array contain standard values of their type (0 for integers) */
        {
            return int_array.All(x => x == default(int));
        }
    }
}
