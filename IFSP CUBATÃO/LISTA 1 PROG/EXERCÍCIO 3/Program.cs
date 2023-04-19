using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        { //Declaração de variáveis
            double d;
            double area;
            Console.Write("Informe o valor da Diagonal: ");
            d = Double.Parse(Console.ReadLine());
            area = Math.Pow(d, 2) / 2;
            Console.WriteLine("O valor da área do quadrado é: {0} ",area);

            
            
        }
    }
}
