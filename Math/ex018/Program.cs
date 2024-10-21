using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            double num1, num2;
            Console.WriteLine("Calculadora Simples - TI 46");
            Console.WriteLine("Operação com dois números");
            Console.WriteLine("Digite o 1º número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2º número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Menu de opções");
            Console.WriteLine("-------------------");
            Console.WriteLine("\n[ + ] Somar\n[ - ] Subtrair\n[ * ] Multiplicar\n[ / ] Dividir");
            Console.WriteLine("-------------------");
            Console.WriteLine("Digite a operação que deseja efetuar: ");
            op = Console.ReadLine();
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case "/":
                    if(num2 != 0)
                    {
                        Console.WriteLine(num1 + " / " + num2 + " = " + num1 / num2);

                    }
                    else
                    {
                        Console.WriteLine("ERRO!\nNão existe divisão por zero!");
                    }
                    break;
            }
            Console.ReadKey();

        }
    }
}
