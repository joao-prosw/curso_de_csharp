using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

int a = 10;
int b = a;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

b = 60;

Console.WriteLine($"Valor de A: {a}");
Console.WriteLine($"Valor de B: {b}");

/*Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = p1;

p2.Nome = "Vinícius";

Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");*/

