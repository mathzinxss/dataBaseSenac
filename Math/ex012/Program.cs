using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_de_Polegadas_a_Milimetros___ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double q_pol, q_milim;
            Console.WriteLine("Conversão de Polegadas a Milímetros");
            Console.Write("Digite uma quantidade de chuva, em pol: ");
            q_pol =  double.Parse(Console.ReadLine());
            q_milim = 25.4 * q_pol;
            Console.WriteLine("\n" + q_pol + "pol. = " + q_milim + " mm.");
            Console.ReadKey();
        }
    }

}
