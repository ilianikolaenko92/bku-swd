using System;
using System.Collections.Generic;

namespace Verschlüsselungsverfahren
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zeichensatz = new List<string>();
            foreach (char buchstabe in "abcdefghijklmnopqrstuvwxyz") {
                zeichensatz.Add(buchstabe.ToString());
            }

            int cäsar_schlüssel = 3;

            string vigenere_schlüsselwort = "sicher";

            string klartext = "einen guten start";

            Console.WriteLine($"Ergebnis der Verschlüsselung mit dem Cäsar-Verfahrens und dem Schlüssel {cäsar_schlüssel}:");
            CalculateCäsar(zeichensatz, cäsar_schlüssel, klartext, "encode");

            Console.WriteLine($"Ergebnis der Entschlüsselung mit dem Cäsar-Verfahrens und dem Schlüssel {cäsar_schlüssel}:");
            CalculateCäsar(zeichensatz, cäsar_schlüssel, klartext, "decode");

            Console.WriteLine($"Ergebnis der Verschlüsselung mit dem Vigenère-Verfahrens und dem Schlüsselwort -{vigenere_schlüsselwort}-:");
            CalculateVigenere(zeichensatz, vigenere_schlüsselwort, klartext, "encode");

            Console.WriteLine($"Ergebnis der Entschlüsselung mit dem Vigenère-Verfahrens und dem Schlüsselwort -{vigenere_schlüsselwort}-:");
            CalculateVigenere(zeichensatz, vigenere_schlüsselwort, klartext, "decode");

            Console.ReadLine();
        }

        static void CalculateCäsar(List<string> alphabet, int key, string message, string operation)
        {

            string result_text = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (!alphabet.Contains(message[i].ToString()))
                {
                    result_text += message[i].ToString();
                }
                else if (operation == "encode")
                {
                    int encrypted_idx = (alphabet.IndexOf(message[i].ToString()) + key) % 26;
                    result_text += alphabet[encrypted_idx];
                }
                else if (operation == "decode")
                {
                    int encrypted_idx = (Math.Abs(alphabet.IndexOf(message[i].ToString()) - key)) % 26;
                    result_text += alphabet[encrypted_idx];
                }

            };

            Console.WriteLine(result_text);

        }

        static void CalculateVigenere(List<string> alphabet, string codeword, string message, string operation)
        {
            int codeword_len = codeword.Length;
            string result_text = "";
            int skips_counter = 0;  // is used to address a correct index in a codeword when iterating using -i- through a message string with symbols that are not in the list of letters (" " etc.): their indexes should be skipped since the algorythm only applies to letters in the message

            for (int i = 0; i < message.Length; i++)
            {
                if (!alphabet.Contains(message[i].ToString()))
                {
                    result_text += message[i].ToString();
                    skips_counter += 1;
                }
                else
                {
                    int temp_idx_mssg = alphabet.IndexOf(message[i].ToString());
                    int temp_idx_codeword = (i >= codeword.Length) ? alphabet.IndexOf(codeword[(i - skips_counter) % codeword.Length].ToString()) : alphabet.IndexOf(codeword[i].ToString());

                    if (operation == "encode")
                    {
                        result_text += alphabet[(temp_idx_mssg + temp_idx_codeword) % 26];
                    }
                    else if (operation == "decode")
                    {
                        result_text += alphabet[Math.Abs(temp_idx_mssg - temp_idx_codeword) % 26];
                    }
                }
            }

            Console.WriteLine(result_text);
        }
    }
}
