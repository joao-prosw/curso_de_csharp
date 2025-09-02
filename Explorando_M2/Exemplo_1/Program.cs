using ExemploExplorando.Models;

/*Pessoa p1 = new Pessoa();
p1.Nome = "João";
p1.Sobrenome = "Santos";
p1.Idade = 21;

p1.Apresentar();*/

Pessoa p1 = new Pessoa(nome:"João", sobrenome:"Santos");

Pessoa p2 = new Pessoa(nome:"Amelia", sobrenome:"Marini");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

