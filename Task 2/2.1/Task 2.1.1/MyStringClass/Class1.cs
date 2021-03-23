using System;
using System.Collections.Generic;
using System.Text;

namespace MyStringClass
{
    public class MyString
    {
        private char[] charMass;

        public char[] CharMass { get => charMass; }

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

        public static bool Equals(MyString a, MyString b)
        {
            char[] aMass = a.CharMass;
            char[] bMass = b.CharMass;
            if (aMass.Length != bMass.Length)
            {
                return false;
            }
           
            for (int i = 0; i < aMass.Length; i++)
            {
                if (aMass[i] != bMass[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int? IndexOf(char a)
        {
            for (int i = 0; i < charMass.Length; i++)
            {
                if (charMass[i] == a)
                {
                    return i;
                }
            }

            return null;
        }

        //get a number of words in our string
        public int GetWordsQuantity()
        {
            List<char> separators = new List<char>();

            for (int i = 0; i < charMass.Length; i++)
            {
                if (Char.IsSeparator(charMass[i]) | Char.IsPunctuation(charMass[i]) == true)
                {
                    separators.Add(charMass[i]);
                }
            }

            string s = new string(charMass);

            char[] seps = new char[separators.Count];
            separators.CopyTo(seps, 0);
            string[] words = s.Split(seps);
            return words.Length;
        }

        // underdeveloped concatenation
        public static MyString Concat(MyString a, MyString b) 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            sb.Append(b);

            MyString ConcatString = new MyString(sb.ToString());
            return ConcatString;
        }
    }
}
