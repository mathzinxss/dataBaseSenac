using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade___3_21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decisao, num1, num2, resp;
            Console.WriteLine("Escolha sua operação:\n1 - Média\n2 - Diferença\n3 - Produto\n4 - Divisão");
            decisao = Convert.ToInt32(Console.ReadLine());

            switch (decisao)
            {
                case 1:
                    Console.WriteLine("\nDigite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    resp = (num1 + num2) / 2;
                        Console.WriteLine("A média entre esses dois números é de: "+resp);
                    break;

                case 2:
                    Console.WriteLine("\nDigite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    resp = num1 - num2;
                    Console.WriteLine("A diferença entre esses dois números é de: " + resp);
                    break;

                case 3:
                    Console.WriteLine("\nDigite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    resp = num1 * num2;
                    Console.WriteLine("O produto entre esses dois números é de: " + resp);
                    break;

                case 4:
                    Console.WriteLine("\nDigite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível fazer a divisão por 0");
                    }
                    else
                    {
                        resp = num1 / num2;
                        Console.WriteLine("A Divisão entre esses dois números é de: " + resp);
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
