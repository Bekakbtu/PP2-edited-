using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static void kopirovanie(string[] s, int n) // dublirovat' s dvumya parametrami
        {
            string[] ss = new string[n * 2]; // udvaivaem razmer massiva
            for (int i = 0, j = 0; i < n; ++i) 
            {   
                ss[j++] = s[i]; // Dublirovanie
                ss[j++] = s[i];
            }
            for (int i = 0; i < 2 * n; ++i)
                Console.Write(ss[i] + " ");
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // cgtenie pervoi stroki i convertcia v int
            string[] reading = Console.ReadLine().Split(); // chtenie massiva i razdelenie ego splitom
            kopirovanie((reading, n); // dublirovanie kazhdogo elementa
        }
    }
}