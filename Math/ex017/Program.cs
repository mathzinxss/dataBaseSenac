using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura Case

            string mes;

            Console.WriteLine("Quantidade de dias do mês... ");
            Console.WriteLine("Digite o nº de um mês (entre 1 e 12): ");
            mes = Console.ReadLine();

            switch (mes)
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine(mes + " tem 31 dias!");
                    break;

                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    Console.WriteLine(mes + " tem 30 dias!");
                    break;

                case "fevereiro":
                    Console.WriteLine(mes + " tem 28 ou 29 dias!");
                    break;
                default: // É similar ao OUTROCASO de Algoritmos
                    Console.WriteLine("Mês não existe");
                    Console.WriteLine("Programa encerrado!");
                    Console.WriteLine("Digite em qualquer tecla para sair!");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
    }
}
