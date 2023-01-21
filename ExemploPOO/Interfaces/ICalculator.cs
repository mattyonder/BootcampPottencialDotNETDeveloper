using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculator
    {
        int Sum(int num1, int num2);
        int Subtract(int num1, int num2);
        int Multiply(int num1, int num2);

        // Quando eum implemento o método dentro da interface, eu não preciso implementar ele nas classes que tem essa interface implementada
        int Divison(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}