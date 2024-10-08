/*
    Ler um valor e escrever se é positivo, negativo ou zero. 
*/

int num;

Console.Write("Digite um número: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{ 
    Console.WriteLine("O número " + num + " é positivo!");
}
if (num < 0)
{
    Console.WriteLine("O número " + num + " é negativo!");
}
if (num == 0)
{
    Console.WriteLine("O número " + num + " é igual a zero!");
}