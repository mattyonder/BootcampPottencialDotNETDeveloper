using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {

        public Aluno()
        {
            
        }

        public Aluno(string name) : base(name)
        {
            
        }
        public double Grade { get; set; }
        public string Email { get; set; }

        public override void Introduce()
        {
            Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos, e sou um aluno nota {Grade}.");
        }
    }
}