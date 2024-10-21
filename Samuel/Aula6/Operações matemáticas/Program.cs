using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_matemáticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op;
            double num1, num2, result;

            Console.WriteLine("DIGITE A OPERAÇÃO QUE DESEJA EFETUAR\n");
            Console.WriteLine("MENU DE OPÇÕES: \n + para SOMA\n - para SUBTRAÇÃO \n x para MULTI´PLICAÇÃO \n / para DIVISÃO");
            op = Console.ReadLine();
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
