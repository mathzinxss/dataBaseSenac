/*
 
*/

byte n1, n2;

Console.Write("N1: ");
n1 = Convert.ToByte(Console.ReadLine());
Console.Write("N2: ");
n2 = Convert.ToByte(Console.ReadLine());
// Calculando...
Console.WriteLine("Produto dobro:" + ((n1 + n2) * (n2 / 2)));
Console.WriteLine("Triplo:" + ((n1 * 3) + n2));
// Console.Write("Cubo: " + (n2 * n2 * n2));
Console.Write("Cubo: " + Math.Pow(n2, 3)); // Utilizando a biblioteca Math.Pow para calcular o cubo de um valor

Console.ReadKey();
Console.WriteLine("\n\n");