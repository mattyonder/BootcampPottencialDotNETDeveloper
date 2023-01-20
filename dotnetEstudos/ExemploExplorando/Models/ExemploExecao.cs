using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Execução tratada. " + ex.Message);
                
                /// Console.WriteLine("Execução tratada. " + ex.StackTrace);
                /// Nesse aqui, é mostrado todo o rastro feito pelo throw exception
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        { 
           Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exeção");
        }
    }
}