using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] contactList = new string[5, 2];
            int n = 1;

            for (int i = 0; i < contactList.GetLength(0); i++)    //инициализирую имена
            {
                contactList[i, 0] = $"Name{n}";

                n++;
            }

            n = 1;

            for (int j = 0; j < contactList.GetLength(0); j++)    //инициализирую контакты
            {
                contactList[j, 1] = $"Telephon number{n}/email{n}";

                n++;
            }

            for (int i = 0; i < contactList.GetLength(0); i++)
            {
                for (int j = 0; j < contactList.GetLength(1); j++)
                {
                    Console.Write(contactList[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
