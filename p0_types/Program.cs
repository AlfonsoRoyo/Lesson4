using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p0_types
{
    class Program
    {
        //Programa en c# para demostrar el uso de los tipos de datos
        static void Main(string[] args)
        {
            // declaring character 
            char a = 'g';
            // Integer data type is generally 
            // used for numeric values
            int i = 89;
            short s = 56;
            // this will give error as number 
            // is larger than short range 
            // short s1 = 87878787878;   

            // long uses Integer values which  
            // may signed or unsigned

            long l = 4564;
            // UInt data type is generally 
            // used for unsigned integer values

            uint ui = 95;

            ushort us = 76;
            // this will give error as number is 
            // larger than short range 

            // ulong data type is generally 
            // used for unsigned integer values
            ulong ul = 3624573;

            // by default fraction value 
            // is double in C# 

            double d = 3.354665544;

            float f = 3.7330645f;

            // for float use 'm' as suffix 
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("interger: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsigned integer: " + ui);
            Console.WriteLine("Unsigned short: " + us);
            Console.WriteLine("Unsigned long: " + ul);
            Console.ReadKey();

            //Reference data types
            // declaring string 
          
            string b = "Geeks";

            //append in a 
            b = b + "for";
            b = b + "Geeks";
            Console.WriteLine(b);

            // declare object obj 

            object obj;
            obj = 20;
            Console.WriteLine(obj);
            // to show type of object 
            // using GetType()       

            Console.WriteLine(obj.GetType());
            Console.ReadKey();

        }
    }
}
