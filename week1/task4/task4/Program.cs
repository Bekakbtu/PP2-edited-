using System;

namespace TASK2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //vvedenie razmera massiva
            int[,] r = new int[n, n]; 
            for (int i = 0; i < n; i++) //Parametery dlya strok
            {
                for (int j = 0; j < i + 1; j++) //Parametery dlya stolbcov
                {
                    Console.Write("[*]"); //Output symvola
                }
                Console.WriteLine(); 
            }
        }
    }
}