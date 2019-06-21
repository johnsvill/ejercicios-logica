using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsParONo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int e;//Si se usa la librería Math.Pow ya no es necesaria esta variable
            double d;//Si se usa la librería Math.Pow ya no es necesaria esta variable
            Console.Write("Ingrese un número: ");
            Console.ReadKey();
            n = Convert.ToInt16(Console.ReadLine());
            e = n / 2;
            d = (double)n / 2;//Para que la división se almacene como número doble "Casting"
            if(d - e == 0) /*(Math.Pow(-1,n)==1) También se puede hacer por residuo "Módulo %" (n % 2 == 0)*/
            {
                /*Console.WriteLine("El número: " + n + "es par");*/
                //Se recomienda hacerlo asi 1.Es mas eficiente y menos pesado para el procesador. 2.Perite editar el número
                Console.WriteLine("El número: {0} es par", n);
            }
            else
            {
                /*Console.WriteLine("El número: " + n + "es impar");*/
                //Se recomienda hacerlo asi 1.Es mas eficiente y menos pesado para el procesador. 2.Perite editar el número
                Console.WriteLine("El número: {0} es impar", n);
            }
            Console.ReadKey();
        }
    }
}
