using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Teacher : Pessoa
    {
        public Teacher()
        {
            
        }

        public Teacher(string name) : base(name)
        {
            
        }
        public decimal Salary { get; set; }
        public override void Introduce()
        {
             Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos, sou um professor e ganho R${Salary}.");
        }
    }
}