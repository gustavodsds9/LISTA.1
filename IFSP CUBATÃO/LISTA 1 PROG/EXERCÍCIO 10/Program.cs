using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double real;
            Double dolar;
            Double ct;
            Double conversao;
            Console.Write("Cotação do Dólar em reais: ");
            real=Double.Parse(Console.ReadLine());
            Console.Write("Informe o Dólar: ");
            dolar=Double.Parse(Console.ReadLine());
            conversao= dolar * real;
            Console.WriteLine("O valor em Reais é: {0}", conversao);

        }
    }
}
