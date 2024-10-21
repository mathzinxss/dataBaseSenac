using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_de_utensílios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int classificacao;
            Console.Write("Digite o código do produto (1 à 15): ");
            classificacao = int.Parse(Console.ReadLine());

            switch (classificacao)
            
            { 
                case 1:
                    Console.WriteLine("\nAlimento não-perecível");
                    if (classificacao == 1)
                    {
                        Console.WriteLine("Produto: Amaciante");
                        Console.WriteLine("\nAperte uma tecla qualquer para sair");
                    }
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Alimento perecível");
                    break;

                case 5:
                case 6:
                    Console.WriteLine("Vestuário");
                    break;

                case 7:
                    Console.WriteLine("Higiene pessoal");
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Limpeza e Utensílios Domésticos");
                    break;

                default:
                    Console.WriteLine("Código inválido!!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}