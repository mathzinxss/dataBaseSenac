using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bass, altura, volume;
            
            Console.Write("Digite a base da pirâmide: ");
            bass = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da pirâmide: ");
            altura = double.Parse(Console.ReadLine());

            volume = (bass * altura) / 3;

            Console.WriteLine("O volume da pirâmide é: " + Math.Round(volume, 1));

            Console.ReadKey();
        }
    }
}
