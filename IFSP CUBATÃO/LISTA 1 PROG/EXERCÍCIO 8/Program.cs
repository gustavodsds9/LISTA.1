using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {//Declaração de variáveis
            double c;
            double f;
            Console.Write("Inserir o valor da temperatura em graus Celsius; ");
            c = Double.Parse(Console.ReadLine());
            f = ((c / 5) * 9) + 32;
            Console.WriteLine("O valor da temperatura em Fahrenheit é: {0}", f);
            
        }
    }
}
