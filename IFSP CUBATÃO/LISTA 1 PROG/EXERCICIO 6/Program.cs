using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Descrição das variáveis
            double v1;
            double v2;
            double media;
            Console.Write("Digite o valor 1: ");
            v1 = Double.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            v2 = Double.Parse(Console.ReadLine());
            media = v1 * v2;
            double mediageo = Math.Sqrt(media);
            Console.WriteLine("O média geométrica entre os valores é: {0}", mediageo);
            
        }
    }
}
