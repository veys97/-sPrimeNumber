using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14102024_asalsayıuygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (IsPrimeNumber(11))
            {
                Console.WriteLine("This is a prime number!");
            }
            else
            {
                Console.WriteLine("This is not a prime number!");
            }
            Console.ReadKey();
        }
        private static bool IsPrimeNumber(int number)
        {
            //Asal sayı; kendinden ve 1'den başka böleni olmayan sayılara denir.
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;   
        }
    }
}
