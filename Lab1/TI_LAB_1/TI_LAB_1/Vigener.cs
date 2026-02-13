using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_LAB_1
{
    internal static class Vigener
    {
        private const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const int LETTER_COUNT = 33;

        public static string GetPlainTextWithSpaces(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (char symbol in str)
            {
                char upperSymbol = char.ToUpper(symbol);
                if (ALPHABET.Contains(upperSymbol.ToString()) || upperSymbol == ' ')
                {
                    sb.Append(upperSymbol);
                }
            }
            return sb.ToString();
        }

        private static int GetLetterIndex(char letter)
        {
            return ALPHABET.IndexOf(letter);
        }

        private static char GetLetterFromIndex(int index)
        {
            return ALPHABET[index % LETTER_COUNT];
        }
        public static string Encipher(string plainText, string key)
        {
            string plainTextWithSpaces = GetPlainTextWithSpaces(plainText);
            string cleanPlainText = Decimation.GetPlainText(plainText);
            if (string.IsNullOrEmpty(cleanPlainText))
                return "";
            string autokey = key + cleanPlainText;

            StringBuilder cipherText = new StringBuilder();

            for (int i = 0; i < cleanPlainText.Length; i++)
            {
                char plainChar = cleanPlainText[i];
                char keyChar = autokey[i];

                int plainIndex = GetLetterIndex(plainChar);
                int keyIndex = GetLetterIndex(keyChar);
                int cipherIndex = (plainIndex + keyIndex) % LETTER_COUNT;
                char cipherChar = GetLetterFromIndex(cipherIndex);

                cipherText.Append(cipherChar);
            }

            StringBuilder resultText = new StringBuilder(plainTextWithSpaces);
            int pos = 0;
            for (int i = 0; i < resultText.Length; i++)
            {
                if (resultText[i] == ' ')
                    continue;
                resultText[i] = cipherText[pos];
                pos++;
            }
            return resultText.ToString();
        }

        public static string Decipher(string cipherText, string key)
        {
            string cipherWithSpaces = GetPlainTextWithSpaces(cipherText);
            string cleanCipherText = Decimation.GetPlainText(cipherText);
            if (string.IsNullOrEmpty(cleanCipherText))
                return "";

            StringBuilder autokey = new StringBuilder(key);
            StringBuilder plainText = new StringBuilder();

            for (int i = 0; i < cleanCipherText.Length; i++)
            {
                char cipherChar = cleanCipherText[i];
                char keyChar = autokey[i];

                int cipherIndex = GetLetterIndex(cipherChar);
                int keyIndex = GetLetterIndex(keyChar);

                int plainIndex = (cipherIndex - keyIndex + LETTER_COUNT) % LETTER_COUNT;
                char plainChar = GetLetterFromIndex(plainIndex);

                plainText.Append(plainChar);
                autokey.Append(plainChar); 
            }

            StringBuilder resultText = new StringBuilder(cipherWithSpaces);
            int pos = 0;
            for (int i = 0; i < resultText.Length; i++)
            {
                if (resultText[i] == ' ')
                    continue;
                resultText[i] = plainText[pos];
                pos++;
            }

            return resultText.ToString();
        }
    }
}