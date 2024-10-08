/*
    Escreva um algoritmo para ler o número total de eleitores de um município, o número de votos brancos, nulos e válidos. Calcular e escrever o percentual de cada um representa em relação ao total de eleitores. 
*/

int totalEleitores, votosBrancos, votosNulos, votosValidos;

Console.Write("Digite o número total de eleitores: ");
totalEleitores = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o número total de votos em branco: ");
votosBrancos = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o número total de votos nulos: ");
votosNulos = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o número total de votos válidos: ");
votosValidos = Convert.ToInt32(Console.ReadLine());


double percentualBrancos = (double) votosBrancos / totalEleitores * 100;
double percentualNulos = (double) votosNulos / totalEleitores * 100;
double percentualValidos = (double) votosValidos / totalEleitores * 100;

Console.WriteLine("\nO percentual de votos em branco é: " + percentualBrancos + "%");
Console.WriteLine("O percentual de votos nulos é: " + percentualNulos + "%");
Console.WriteLine("O percentual de votos válidos é: " + percentualValidos + "%");

Console.WriteLine("\n\n");
Console.ReadKey();