using System;

namespace Task_1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Параметры надписи: None");
            Console.WriteLine("Введите число");
            bool[] Params = new bool[3] { false, false, false };

            while (true)
            {


                int inputnum = InputTool();
                
                switch (inputnum)
                {
                    case 1:
                        Params[0] = !Params[0];
                        break;

                    case 2:
                        Params[1] = !Params[1];
                        break;

                    case 3:
                        Params[2] = !Params[2];
                        break;
                }

                string TrueParameters = "";
                for (int i = 0; i < Params.Length; i++)
                {
                    
                    if (Params[i] == true)
                    {
                        TrueParameters += Enum.GetName(typeof(TitleParameters), i) + ", ";
                    }
                }

                if (TrueParameters == "")
                {
                    Console.WriteLine("None");
                }

                Console.WriteLine(TrueParameters);
            }
        }

        public static int InputTool()
        {
            for (; ; )
            {
                int input;
                bool a = Int32.TryParse(Console.ReadLine(), out input);
                if (a == true)
                {
                    if ((input <= 0) | (input > 3)) Console.WriteLine("Ошибка: введите значение от 1 до 3");
                    else return input;
                }
                else
                {
                    continue;
                }
            }
        }

        enum TitleParameters
        {
            Bold = 0,
            Italic = 1,
            Underline = 2,
        }
    }
}
