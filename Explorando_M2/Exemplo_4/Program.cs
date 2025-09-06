using ExemploExplorando.Models;
using System.Globalization;

//Tuplas, operador ternário e desconstrução de um objeto

int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

/*Pessoa p1 = new Pessoa("Leonardo", "Buta");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");*/

/*LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("../Exemplo_3/Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas: " + quantidadeDeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}

/*(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "João Paulo", "Menezes Santos", 1.90M);

Console.WriteLine($"Id: {tupla.Id}");
Console.WriteLine($"Nome: {tupla.Nome}");
Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
Console.WriteLine($"Altura: {tupla.Altura}");

Console.WriteLine($"\n");

ValueTuple<int, string, string, decimal> tuplaDois = (2, "Amelia", "Marini Santos", 1.83M);

Console.WriteLine($"Id: {tuplaDois.Item1}");
Console.WriteLine($"Nome: {tuplaDois.Item2}");
Console.WriteLine($"Sobrenome: {tuplaDois.Item3}");
Console.WriteLine($"Altura: {tuplaDois.Item4}");

var tuplaTres = Tuple.Create(3, "Murilo", "dos Santos Costa", 1.85M);

Console.WriteLine($"\n");

Console.WriteLine($"Id: {tuplaTres.Item1}");
Console.WriteLine($"Nome: {tuplaTres.Item2}");
Console.WriteLine($"Sobrenome: {tuplaTres.Item3}");
Console.WriteLine($"Altura: {tuplaTres.Item4}");*/