using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Principal : Teacher
    {
        public override void Introduce()
        {
             Console.WriteLine("Diretor");
        }
    }
}