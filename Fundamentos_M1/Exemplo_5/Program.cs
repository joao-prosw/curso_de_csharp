using Curso_de_csharp.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("Volkswagen");
listaString.Add("Ford");
listaString.Add("Peugeot");
listaString.Add("FIAT");

Console.WriteLine($"Itens na miunha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("Honda");

Console.WriteLine($"Itens na miunha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("FIAT");

Console.WriteLine($"Itens na miunha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

/*for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"#{i + 1} - {listaString[i]}");
}


Console.WriteLine("\n\n");

foreach (string valor in listaString)
{
    Console.WriteLine($"Item: {valor}");
}*/