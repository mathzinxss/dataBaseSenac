/*
    Escreva um algoritmo para ler o salário mensal atual de um funcionário e o percentual de reajuste. Calcule e escreva o valor do novo salário. 
*/

double salarioAtual, percentualReajuste, novoSalario;

Console.Write("Digite o seu salário mensal atual: ");
salarioAtual = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o reajuste percentual: ");
percentualReajuste = Convert.ToDouble(Console.ReadLine());

novoSalario = salarioAtual * (1 + (percentualReajuste / 100));

Console.WriteLine("O novo salário é: R$" + novoSalario.ToString("F2"));

Console.WriteLine("\n\n");
Console.ReadKey();

