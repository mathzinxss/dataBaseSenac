using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converte_Temperatura___Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Um tipo de variável real é double
            double tc, tf;
            Console.WriteLine("Conversão de Temperaturas ºF a ºC");
            Console.Write("Digite uma temperatura em ºF: ");
            // Leitura da variável tf

            // tf = Convert.ToDouble(Console.ReadLine()); 
            tf = double.Parse(Console.ReadLine());
            tc = 5 * (tf - 32) / 9;

            Console.WriteLine("\n" + tf + "ºF = " + Math.Round(tc,1) + "ºC");

            Console.ReadKey();
        }
    }
}
