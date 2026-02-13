using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_LAB_1
{
    public static class Decimation
    {
        private const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const int ALPHABET_POWER = 33;

        public static string GetPlainText(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            StringBuilder sb = new StringBuilder();
            foreach (char symbol in str)
            {
                char upperSymbol = char.ToUpper(symbol);
                if (ALPHABET.Contains(upperSymbol.ToString()))
                    sb.Append(upperSymbol);
            }
            return sb.ToString();
        }

        public static int GetKey(string str)
        {
            string digits = "";
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                    digits += c;
            }

            if (int.TryParse(digits, out int key) && key != 0)
                return Math.Abs(key);

            return -1;
        }

        public static string Encipher(string text, int key)
        {
            string textWithSpaces = Vigener.GetPlainTextWithSpaces(text);
            string cleanText = GetPlainText(text);

            if (string.IsNullOrEmpty(cleanText))
                return textWithSpaces;

            StringBuilder cipherText = new StringBuilder();
            foreach (char symbol in cleanText)
            {
                int index = ALPHABET.IndexOf(symbol);
                if (index >= 0)
                {
                    int newIndex = (index * key) % ALPHABET_POWER;
                    cipherText.Append(ALPHABET[newIndex]);
                }
            }

            StringBuilder resultText = new StringBuilder(textWithSpaces);
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

 
        public static string Decipher(string text, int key)
        {
            int inverseKey = 0;
            for (int i = 1; i < ALPHABET_POWER; i++)
            {
                if ((key * i) % ALPHABET_POWER == 1)
                {
                    inverseKey = i;
                    break;
                }
            }

            string textWithSpaces = Vigener.GetPlainTextWithSpaces(text);
            string cleanText = GetPlainText(text);

            if (string.IsNullOrEmpty(cleanText))
                return textWithSpaces; 

            string plainText = Encipher(cleanText, inverseKey);
            StringBuilder resultText = new StringBuilder(textWithSpaces);
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

        public static bool IsValidKey(int key)
        {
            return GreatestCommonDivisor(key, ALPHABET_POWER) == 1;
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return Math.Abs(a);
        }
    }
}