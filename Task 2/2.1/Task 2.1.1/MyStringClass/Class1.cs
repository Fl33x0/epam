using System;
using System.Text;

namespace MyStringClass
{
    public class MyString
    {
        private char[] charMass;

        public char[] CharMass { get; set; }

        public MyString()
        {
            charMass = new char[16];
        }

        public MyString(string text)
        {
            charMass = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                charMass[i] = text[i];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in charMass)
            {
                sb.Append(ch);
            }
            return sb.ToString();
        }

        public bool Equals(char[] a, char[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
           
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
