using ExemploPOO.Models;
using ExemploPOO.Interfaces;

ICalculator calculator = new Calculator();
Console.WriteLine(calculator.Multiply(3, 9));

//----------------------------------------------------------------

// Instanciando o objeto computer e usando os métodos da classe Object

// Computer computer = new Computer();
// Console.WriteLine(computer.ToString());

//----------------------------------------------------------------

// Instanciando objetos das classes Aluno e Pessoa, usando contrutores.

// Pessoa person1 = new Pessoa("Mateus");
// person1.Introduce();
// Aluno studant1 = new Aluno("Matias");
// studant1.Introduce();

//----------------------------------------------------------------

// Instanciando o objeto account1 do tipo Checking, que herda da classe abstrata Account

// Checking account1 = new Checking();
// account1.Credit(500);
// account1.DisplayBalance();

//----------------------------------------------------------------

// Instanciando objetos studant1 e teacher1, que herdam da classe Pessoa

// Aluno studant1 = new Aluno();

// studant1.Nome = "Mateus";
// studant1.Idade = 17;
// studant1.Email = "teste@teste.com";
// studant1.Grade = 10;
// studant1.Apresentar();

// Teacher teacher1 = new Teacher();
// teacher1.Nome = "Matias";
// teacher1.Idade = 30;
// teacher1.Salary = 1000;
// teacher1.Apresentar();

//----------------------------------------------------------------

// Instanciando o objeto c1 da classe Conta corrente

// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();

//----------------------------------------------------------------

// Instanciando um objeto person1 do tipo Pessoa

// Pessoa person1 = new Pessoa();
// person1.Nome = "Mateus";
// person1.Idade = 17;

// person1.Apresentar();