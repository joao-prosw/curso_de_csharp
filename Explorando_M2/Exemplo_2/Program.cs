using ExemploExplorando.Models;
using System.Globalization;

string dataString = "18/03/2024 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine("Conversão bem sucedida:");
    Console.WriteLine(data.ToShortDateString());
    Console.WriteLine(data.ToShortTimeString());
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}










/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 2550.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("p"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));*/

/*Pessoa p1 = new Pessoa(nome:"João", sobrenome:"Santos");

Pessoa p2 = new Pessoa(nome:"Amelia", sobrenome:"Marini");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/

/*int numero1 = 10;
string numero2 = "20";
string resultado = numero1 + numero2;

Console.WriteLine(resultado);*/