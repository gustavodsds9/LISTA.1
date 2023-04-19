using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {//Declaração de variáveis
            double milha;
            double km;
            Console.Write("Digite o valor da distância em milhas marítimas: ");
            milha = Double.Parse(Console.ReadLine());
            km = (milha * 1852) / 1000;
            Console.WriteLine("O valor em quilômetros é: {0}", km);

        }
    }
}
