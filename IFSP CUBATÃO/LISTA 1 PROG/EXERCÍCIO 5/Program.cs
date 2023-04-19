using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {//Declaração de váriaveis
            double v1;
            double v2;
            double v3;
            double v4;
            double media;
            Console.Write("Inserir o valor 1: ");
            v1 = Double.Parse(Console.ReadLine());
            Console.Write("Inserir o valor 2: ");
            v2 = Double.Parse(Console.ReadLine());
            Console.Write("Inserir o valor 3: ");
            v3 = Double.Parse(Console.ReadLine());
            Console.Write("Inserir o valor 4: ");
            v4 = Double.Parse(Console.ReadLine());
            media = (v1 + v2 + v3 + v4) / 4;
            Console.WriteLine("O valor da média aritmética é: {0} ", media);
    
        }
    }
}
