using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_Enumerados
{

    /*
     Considere el siguiente código para la enumeración.
     Aquí se crea una enumeración con el nombre del mes
     y sus miembros de datos son el nombre de meses como 
     enero, febrero, marzo, abril y mayo. Ahora intentemos 
     imprimir los valores enteros predeterminados de estas
     enumeraciones. Se requiere una conversión explícita 
     para convertir del tipo enum a un tipo integral
     */

    class Program
    {
        enum month
        {
            // following are the data members 
            jan,
            feb,
            mar,
            apr,
            may
        }

        static void Main(string[] args)
        {
            // getting the integer values of data members.. 
            Console.WriteLine("The value of jan in month " +
                              "enum is " + (int)month.jan);
            Console.WriteLine("The value of feb in month " +
                              "enum is " + (int)month.feb);
            Console.WriteLine("The value of mar in month " +
                              "enum is " + (int)month.mar);
            Console.WriteLine("The value of apr in month " +
                              "enum is " + (int)month.apr);
            Console.WriteLine("The value of may in month " +
                              "enum is " + (int)month.may);
            
            Console.ReadKey();
        }
    }
}
