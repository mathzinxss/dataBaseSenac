using System;

namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, nota5, mediaAritmetica, mediaHarmonica;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());
            Console.Write("Digite a quinta nota: ");
            nota5 = double.Parse(Console.ReadLine());

            mediaAritmetica = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            mediaHarmonica = 5 / (1 / nota1 + 1 / nota2 + 1 / nota3 + 1 / nota4 + 1 / nota5);

            Console.WriteLine("A média aritmética é: " + Math.Round(mediaAritmetica, 1) + "\nE a média harmônica é: " + Math.Round(mediaHarmonica, 1));
        }
    }
}
