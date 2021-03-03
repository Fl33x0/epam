using System;
using System.Text;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку 1: ");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введите строку 2: ");
            string input2 = Console.ReadLine();

            char[] inputMass = input1.ToCharArray();
            char[] duplicationMass = input2.ToCharArray();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < inputMass.Length; i++)
            {
                sb.Append(inputMass[i]);

                for (int j = 0; j < duplicationMass.Length; j++)
                {                    
                    if (inputMass[i] == duplicationMass[j])
                    {
                        sb.Append(duplicationMass[j]);
                        break;
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
