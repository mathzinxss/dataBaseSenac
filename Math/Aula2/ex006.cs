// Declaração das variáveis
double salarioAtual, percentualReajuste, novoSalario;

// Leitura do salário atual
Console.WriteLine("Digite o salário mensal atual:");
salarioAtual = Convert.ToDouble(Console.ReadLine());

// Leitura do percentual de reajuste
Console.WriteLine("Digite o percentual de reajuste:");
percentualReajuste = Convert.ToDouble(Console.ReadLine());

// Cálculo do novo salário
novoSalario = salarioAtual * (1 + (percentualReajuste / 100));

// Exibição do resultado
Console.WriteLine("O novo salário é: R$ " + novoSalario.ToString("F2"));
