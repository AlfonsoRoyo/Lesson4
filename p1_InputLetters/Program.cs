using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1_InputLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escriba un programa C # Sharp que tome tres letras como entrada 
            //y visualícelas en orden inverso

            char letter, letter1, letter2;

            Console.WriteLine("Input letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
            Console.ReadKey();


        }
    }
}
