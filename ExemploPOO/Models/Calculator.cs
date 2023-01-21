using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculator : ICalculator
    {
        //Como eu já implementei o método Division no ICalculator, eu não preciso implementar ele aqui.
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;        
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;        
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

       public int Sum(int num1, int num2,int num3)
        {
            return num1 + num2 + num3;
        }

    }

        
}