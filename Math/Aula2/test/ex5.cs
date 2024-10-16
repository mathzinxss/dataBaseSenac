float eleitores, brancos, nulos, validos;
float brancoFormatado;
Console.Write("Eleitores: ");
eleitores = Convert.ToSingle(Console.ReadLine());
Console.Write("Brancos: ");
brancos = Convert.ToSingle(Console.ReadLine());
Console.Write("Nulos: ");
nulos = Convert.ToSingle(Console.ReadLine());
Console.Write("Válidos: ");
validos = Convert.ToSingle(Console.ReadLine());

// Mostrando os percentuais

Console.WriteLine("Brancos: " + ((brancos/eleitores) * 100));
