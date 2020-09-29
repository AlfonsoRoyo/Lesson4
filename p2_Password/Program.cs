using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_Password
{
    class Program

    /*
     Escriba un programa Sharp de C # que tome la 
     identificación de usuario y la contraseña como 
     entrada (tipo cadena). Después de 3 intentos 
     incorrectos, el usuario será rechazado 
     */

    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0, dd = 0;
            Console.Write("\n\nCheck username and password : \n");
            Console.Write("N.B. : Defaul username and password is : username and password\n");
            Console.Write("-------------------------------------------\n");
            do
            {
                Console.Write("Input a username: ");
                username = Console.ReadLine();

                Console.Write("Input a password: ");
                password = Console.ReadLine();
                if (username == "username" && password == "password")
                {
                    dd = 1;
                    ctr = 3;

                }

                else
                {

                    dd = 0;
                    ctr++;
                }

            }
            
            while ((username != "username" || password !="password" ) && (ctr != 3));



            if (dd == 0)
            {
                Console.Write("\nLogin attemp more than three times Try later! \n \n");
            }
            else
            if (dd == 1)
            {
                Console.Write("\nPassword entered successfull!\n\n");
            }

        }
    }
}
