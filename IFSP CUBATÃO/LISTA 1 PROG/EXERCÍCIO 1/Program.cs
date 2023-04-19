using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {//Declaração de variáveis
            int b;
            int h;
            int a;
            Console.Write("Informe a base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura: ");
            h = int.Parse(Console.ReadLine());
            a = b * h;
            Console.WriteLine("O valor da área é: {0}", a);
        }
    }
}
