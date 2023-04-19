using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LISTA1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            Double L1;
            Double L2;
            Double área;
            Console.Write("Inserir valor da aresta: "); 
            L1 = Double.Parse (Console.ReadLine());
            L2 = L1;
            área = L1 * L2;
            Console.WriteLine("O valor da área do quadrado é: {0}", área);

        }
    }
}
