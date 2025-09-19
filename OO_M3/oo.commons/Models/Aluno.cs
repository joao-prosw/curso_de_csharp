using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Models
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            
        }
        public Aluno(string nome) : base(nome)
        {

        }
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} e sou um aluno de nota {Nota}.");
        }
    }
}