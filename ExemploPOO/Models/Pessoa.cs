using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Introduce()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos!");
        }
    }
}