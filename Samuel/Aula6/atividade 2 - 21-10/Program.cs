using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade_2___21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decisao;
            double valor, valorAtual;

            Console.WriteLine("Digite o total a ser pago: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("1 - Cliente Comum\n 2 - Funcionário \n 3 - Vip");
            decisao = Convert.ToInt32(Console.ReadLine());

            switch (decisao)
            {
                case 1:
                    valorAtual = valor;
                    Console.WriteLine("Cliente Comum: \n"+ "Total a pagar " + valorAtual.ToString("C")+" sem desconto");
                    break;

                    case 2:
                    valorAtual = valor - (valor * 0.10);
                    Console.WriteLine("Funcionário: \n"+ "Total a pagar "+valorAtual.ToString("C")+" com desconto de 10%");
                    break;

                case 3:
                    valorAtual = valor - (valor * 0.05);
                    Console.WriteLine("Funcionário: \n" + "Total a pagar " + valorAtual.ToString("C") + " com desconto de 5%");
                    break;
            }
            Console.ReadKey();
        }
    }
}
