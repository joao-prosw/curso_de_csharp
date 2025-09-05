using ExemploExplorando.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo só que diferente";
Console.WriteLine("\n");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

if (estados.ContainsKey("BA"))
{
    Console.WriteLine("Bahia ja foi adicionada porra");
}
else
{
    Console.WriteLine("Existe n...");
}

Console.WriteLine(estados["SP"]);

/*Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n");
pilha.Pop();

foreach (int item in pilha)
{
    Console.WriteLine(item);
}*/

/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n");
fila.Dequeue();

foreach (int item in fila)
{
    Console.WriteLine(item);
}*/


/*new ExemploExcecao().Metodo1();

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally
{
    Console.WriteLine($"Cabou a execução aí parsa");
}*/
