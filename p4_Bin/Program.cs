using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string result;
            do
            {
                Console.Write("Number to convert (or \"end\")? ");
                answer = Console.ReadLine();
                if (answer != "end")
                {
                    int n = Convert.ToInt32(answer);
                    result = "";
                    while (n > 1)

                    {
                        int remainder = n % 2;
                        result = Convert.ToString(remainder) + result;
                        n /= 2;

                    }
                    result = Convert.ToString(n) + result;
                    Console.WriteLine("Binary: {0}", result);
                }

            }
            while (answer != "end");
        }
    }
}
