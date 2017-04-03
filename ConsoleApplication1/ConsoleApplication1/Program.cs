using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           

           Console.WriteLine(IsPrime(18));
        }

        public static bool IsPrime(int n)
        {

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0 )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
