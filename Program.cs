using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            string keyy;
            do
            {
                Console.Write("Prime cheker \n input X:");
                int x = Convert.ToInt32(Console.ReadLine());
                int cout = 0;
                for (int i = 2; i <= x; i++)
                    if (x % i == 0)
                        cout++;

                if (cout == 1) Console.WriteLine("Prime");
                else Console.WriteLine("Non Prime");
                cout = 0;
                Console.Write("Continue Press C Exit Press anyother Key:");
                keyy = Console.ReadLine();
            } while (keyy == "c");
            Console.ReadKey();
        }
    }
}
