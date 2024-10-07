// Trabalhando com variáveis de memória
// Tipo <nome da variável> = valor = atribuição

byte idade;
decimal salario;
double impostos;
bool filhos;
string nome;

Console.Write("Nome: ");
nome = Console.ReadLine(); // Dado recebido é do tipo string
Console.Write("Filhos [true] / [false]: ");
filhos = Convert.ToBoolean(Console.ReadLine());

Console.Write("Idade: ");
idade = Convert.ToByte(Console.ReadLine());

Console.Write("Salário: ");
salario = Convert.ToDecimal(Console.ReadLine());

Console.Write("Imposto: ");
impostos = Convert.ToDouble(Console.ReadLine());

// Imprimindo os valores das variáveis
Console.WriteLine("\nNome: " + nome);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Filhos: " + filhos);
Console.WriteLine("Salário: " + salario);
Console.WriteLine("Imposto: " + impostos);


Console.ReadKey();