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
            string verschlüsselt_cäsar = "lfk elq hlq vlfkhuhu vdwc";
            string verschlüsselt_vigenere = "ctcbwlj dqy avapphgylmp";

            Console.WriteLine($"Ergebnis der Verschlüsselung mit dem Cäsar-Verfahrens und dem Schlüssel {cäsar_schlüssel}:");
            CalculateCäsar(zeichensatz, cäsar_schlüssel, klartext, "encode");

            Console.WriteLine($"Ergebnis der Entschlüsselung mit dem Cäsar-Verfahrens und dem Schlüssel {cäsar_schlüssel}:");
            CalculateCäsar(zeichensatz, cäsar_schlüssel, verschlüsselt_cäsar, "decode");

            Console.WriteLine($"Ergebnis der Verschlüsselung mit dem Vigenère-Verfahrens und dem Schlüsselwort -{vigenere_schlüsselwort}-:");
            CalculateVigenere(zeichensatz, vigenere_schlüsselwort, klartext, "encode");

            Console.WriteLine($"Ergebnis der Entschlüsselung mit dem Vigenère-Verfahrens und dem Schlüsselwort -{vigenere_schlüsselwort}-:");
            CalculateVigenere(zeichensatz, vigenere_schlüsselwort, verschlüsselt_vigenere, "decode");

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
                    int encrypted_idx = (alphabet.IndexOf(message[i].ToString()) - key) % 26;
                    result_text += (encrypted_idx < 0) ? alphabet[26 + encrypted_idx] : alphabet[encrypted_idx];  // in case of a negative index ADDS it to the length of the list of letters (i.e. reduces 26 by the negative index) to reach a correct letter backwards
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
                        int decoding_idx = temp_idx_mssg - temp_idx_codeword;
                        result_text += (decoding_idx < 0) ? alphabet[26 + decoding_idx] : alphabet[(decoding_idx) % 26];  // in case of a negative index ADDS it to the length of the list of letters (i.e. reduces 26 by the negative index) to reach a correct letter backwards
                    }
                }
            }

            Console.WriteLine(result_text);
        }
    }
}
