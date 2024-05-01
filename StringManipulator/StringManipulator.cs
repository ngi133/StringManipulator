using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulator
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CountWords(string input)
        {
            // Dividir la cadena en palabras utilizando espacios en blanco como delimitador
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public int CountLines(string input, int charsByLine)
        {
            if (charsByLine <= 0)
            {
                throw new ArgumentException("Characters per line must be greater than zero.");
            }
            return this.CountCharsWithoutSpace(input) / charsByLine;
        }

        private int CountCharsWithoutSpace(string input)
        {
            return input.Replace(" ", "").Length;
        }
    }
}
