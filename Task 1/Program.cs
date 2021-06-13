using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            int[,] array = new int[3, 3];
            string str = "";

            for (int i = 0; i < array.GetLength(0); i++)         //инициализирую массив
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ran.Next(1, 15);

                    Console.WriteLine(str + array[i, j]);
                    str += " ";
                }
            }
        }
    }
}
