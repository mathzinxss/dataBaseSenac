using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1___21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            double salario, salarioAtual;
            Console.WriteLine("Qual será o plano de trabalho? \n A, B ou C");
            a = Console.ReadLine();

            Console.WriteLine("Escreva qual é o salário do funcionário: ");
            salario = double.Parse(Console.ReadLine());

            switch (a) {

                case "A":
                    salarioAtual = salario + (salario * 0.10);
                    Console.WriteLine("O novo salário desse camarada é de: "+salarioAtual+" com 10% de aumento");
                    break;

                case "B":
                    salarioAtual = salario + (salario * 0.15);
                    Console.WriteLine("O novo salário desse camarada é de: " + salarioAtual + " com 10% de aumento");
                    break;

                case "C":
                    salarioAtual = salario + (salario * 0.20);
                    Console.WriteLine("O novo salário desse camarada é de: " + salarioAtual + " com 10% de aumento");
                    break;
            }
            Console.ReadKey();
        }
    }
}
