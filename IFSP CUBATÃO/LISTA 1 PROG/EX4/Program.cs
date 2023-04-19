using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {// Descrição de váriaveis
            double B;
            double h;
            double area;
            Console.Write("Inserir valor da base do triângulo: ");
            B = Double.Parse(Console.ReadLine());
            Console.Write("Inserir valor da altura do triângulo: ");
            h = Double.Parse(Console.ReadLine());
            area = (B * h) / 2;
            Console.WriteLine("O valor da área do triângulo é: {0}", area); 

        }
    }
}
