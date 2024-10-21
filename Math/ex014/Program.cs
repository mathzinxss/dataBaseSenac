using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume, area;

            Console.Write("Digite o raio de um cilíndro: ");
            raio = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura de um cilíndro: ");
            altura = double.Parse(Console.ReadLine());

            area = (2 * Math.PI * raio * (altura + raio));
            // Math.Pow(var, 2) = var²
            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("A área do cilíndro é: " + Math.Round(area, 1) + "\nO volume do cilíndro é: " + Math.Round(volume, 1));
        }
    }
}
