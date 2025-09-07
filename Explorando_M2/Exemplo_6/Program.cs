using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

//Tipos especiais no C#:

int numero = 19;
bool par = false;

par = numero.EhPar();

Console.WriteLine($"O número {numero} é " + (par ? "par" : "ímpar"));

/*MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("teste");

Console.WriteLine(arrayString[0]);

/*dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "teste";

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

/*string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}



/*var tipoAnonimo = new { Nome = "João", Sobrenome = "Paulo", Altura = 1.90 };

Console.WriteLine($"Nome: {tipoAnonimo.Nome}\nSobrenome: {tipoAnonimo.Sobrenome}\nAltura: {tipoAnonimo.Altura}");

/*string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}\nPreço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy")}\n" + (venda.Desconto.HasValue ? $"Desconto de {venda.Desconto}" : ""));
}*/

/*bool? desejaEmail = true;

if (desejaEmail.HasValue && desejaEmail.Value)
{
    Console.WriteLine("O usuário quer receber emails");
}
else
{
    Console.WriteLine("O não quer receber emails ou não respondeus");
}*/