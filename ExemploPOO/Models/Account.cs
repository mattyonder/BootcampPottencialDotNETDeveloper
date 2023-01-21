using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Account
    {
        protected decimal balance;

        public abstract void Credit(decimal value);
        public void DisplayBalance()
        {
            Console.WriteLine("O seu saldo é: "+balance);
        }
    }
}