using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Oi, meu nome é {Nome} e sou um Diretor ganhando {Salario} de salário.");
        }
        
    }
}