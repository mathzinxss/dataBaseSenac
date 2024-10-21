/*
    Escreva um algoritmo para ler as dimensões de um retângulo (base e altura), calcular e escrevera área do retângulo.
*/

byte bas, altura;

Console.Write("Digite o valor da base: ");
bas = Convert.ToByte(Console.ReadLine());
Console.Write("Digite o valor da altura: ");
altura = Convert.ToByte(Console.ReadLine());

Console.WriteLine("A area do retângulo é: " + (bas * altura));

Console.WriteLine("\n\n");
Console.ReadKey();


