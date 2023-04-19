using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double p1;
            Double p2;
            Double p3;
            Double p4;
            Double p5;
            Double soma;
            Double pg;
            Double t;
            Console.Write("Informe o primeiro produto: ");
            p1=double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo produto: ");
            p2=double.Parse(Console.ReadLine());
            Console.Write("Informe o terceiro produto: ");
            p3=double.Parse(Console.ReadLine());
            Console.Write("Informe o quarto produto: ");
            p4=double.Parse(Console.ReadLine());
            Console.Write("Informe o quinto produto: ");
            p5=double.Parse(Console.ReadLine());
            soma = p1+p2+p3+p4+p5;
            Console.WriteLine("O valor a ser pago é: {0}", soma);
            Console.Write("Pagamento: ");
            pg=double.Parse(Console.ReadLine());
            t = pg-soma;
            Console.WriteLine("Seu troco é: {0}", t);




        }
    }
}
