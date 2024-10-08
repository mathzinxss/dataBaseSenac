/*
    Escreva um algoritmo para ler um valor (do teclado) e escrever (na tela) o seu antecessor. 
*/

byte n1;

Console.Write("Digite o valor de N1: ");
n1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("O número antecessor de " + n1 + " é: " + (n1 - 1));

Console.WriteLine("\n\n");
Console.ReadKey();

