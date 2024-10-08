byte anos, meses, dias;

Console.WriteLine("Digite sua idade em anos: ");
anos = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Digite a quantidade de meses: ");
meses = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Digite a quantidade de dias: ");
dias = Convert.ToByte(Console.ReadLine());

int idadeEmDias = (anos * 365) + (meses * 30) + dias;

Console.WriteLine("Ao todo você tem: " + idadeEmDias + " dias.");
