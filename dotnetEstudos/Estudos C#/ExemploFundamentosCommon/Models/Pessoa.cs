using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estudos_C_.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; } 
        public string? NomeRepresentanteLegalPessoaFisica { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é \n{Nome}, e tenho {Idade}");
        }
    }
}

//PascalCase em Classes, propriedades e métodos
//Não abreviar nomes de propriedades
//Nome do arquivo deve ser o nome da classe
