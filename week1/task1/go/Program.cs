using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Task1
{
    class Program
    {
        public static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int k = 2; k <= Math.Sqrt(x); ++k) // nahozhdenie prostyh chisel
                if (x % k == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine()); // chnenie linii i convertirovanie v int
            int[] a = new int[n]; // sozdanie massiva dlinoyiu n
            int cnt = 0, x;
            string[] numbers = Console.ReadLine().Split(); // chtenie i razdelenie
            for (int i = 0; i < n; ++i)
            {
                x = Convert.ToInt32(numbers[i]);
                if (isPrime(x)) // proverka x na chetnost' cherez funkciyu
                    a[cnt++] = x;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < cnt; ++i)
            {
                Console.Write(a[i].ToString() + " "); // vivesti otvety kak stroku
            }
        }
    }
}