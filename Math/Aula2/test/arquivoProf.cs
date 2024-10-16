float num = 10.356f;
double valor = 12345.6789;
float perc = 0.10f;

// Formato com duas casas decimais
string formatado = String.Format("{0:F3}", valor); // "12345.68"
Console.WriteLine(formatado);
string formatado0 = String.Format("{0:F1}", valor);
Console.WriteLine(formatado0);
string formatado3 = valor.ToString("C"); 
Console.WriteLine(formatado3);
string formatado4 = perc.ToString("P");
Console.WriteLine(formatado4);
string formatado5 = valor.ToString("F");
Console.WriteLine(formatado5);
 formatado5 = valor.ToString("N");
Console.WriteLine(formatado5);
formatado5 = valor.ToString("C");  //c --> currency
Console.WriteLine(formatado5);

//F ou f: Formato fixo.
//N ou n: Formato numérico(inclui separadores de milhar).
//P ou p: Formato percentual.
//C ou c: Formato de moeda.