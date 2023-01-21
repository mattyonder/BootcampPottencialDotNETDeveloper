using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int accountNumber, decimal openingBalance)
        {
            AccountNumber = accountNumber;
            balance = openingBalance;
        }
        public int AccountNumber { get; set; }

        private decimal balance;

        public void Sacar(decimal value)
        {
            if (balance >= value){
                balance -= value;
                Console.WriteLine("Saque realizado com sucesso");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o saldo dispónivel");
            }
            
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo disponível é: " + balance);
        }

        
    }
}