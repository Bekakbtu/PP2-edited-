using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"/Users/macbook/Projects/w2t1/w2t1/input.txt");
            char[] Asem = text.ToCharArray();
            Array.Reverse(Asem);
            string s = new string(Asem);
            if (s == text)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}