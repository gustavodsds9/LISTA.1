using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double z;
            Console.Write("Informe o valor de X: ");
            x=Double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de Y: ");
            y=Double.Parse(Console.ReadLine());
            z=Math.Pow(x,y);
            Console.WriteLine("Resultado: {0}", z);

        }
    }
}
