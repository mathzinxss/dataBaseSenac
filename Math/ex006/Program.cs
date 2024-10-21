/*
    Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
    Considerar ano com 365 dias e mês com 30 dias.
*/

byte anos, meses, dias;

Console.Write("Digite sua idade em anos: ");
anos = Convert.ToByte(Console.ReadLine()) ;
Console.Write("Digite a quantidade de meses: ");
meses = Convert.ToByte(Console.ReadLine());
Console.Write("Digite e a quantidade de dias: ");
dias = Convert.ToByte(Console.ReadLine());

int idadeEmDIas = (anos * 365) + (meses * 30) + dias;

Console.WriteLine("Ao todo você tem: " + idadeEmDIas + " dias de vida!");

