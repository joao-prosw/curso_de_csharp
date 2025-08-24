string teste = "Testando 123";
int numero = 48;
double numeroDecimal = 1.90;
decimal numeroDecimalDois = 1.934M;
bool booleano = true;

Console.WriteLine($"{teste}\n{numero}\n{numeroDecimal.ToString("0.00")}\n{numeroDecimalDois}\n{booleano}\n\n\n\n\n");

// ----------------------------------------------------------------- //

teste = "Resenha Light";
numero = 85;
numeroDecimal = 1.80;
numeroDecimalDois = 1.870M;
booleano = false;

Console.WriteLine($"{teste}\n{numero}\n{numeroDecimal.ToString("0.00")}\n{numeroDecimalDois}\n{booleano}\n\n\n\n\n");

// ----------------------------------------------------------------- //

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
DateTime dataFutura = DateTime.Now.AddDays(5);
Console.WriteLine(dataFutura);
Console.WriteLine(dataAtual.ToString("dd/MM"));