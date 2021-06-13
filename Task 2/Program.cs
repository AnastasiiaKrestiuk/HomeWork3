using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello";

            char[] array = str.ToCharArray();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
        }
    }
}
