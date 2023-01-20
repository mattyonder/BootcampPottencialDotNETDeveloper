using Estudos_C_.Common.Models;


// --------------------------------------------------------------------------------

// Instancia da classe pessoa
Pessoa p = new Pessoa();

/*
    Atribui o nome e idade para pessoa
    Passando o nome Mateus
    E passando a idade 18
*/
p.Nome = "Mateus";
p.Idade = 18;

// Faz a pessoa se apresentar
p.Apresentar();




Calculadora c = new Calculadora();
c.Somar(3, 4);
c.Subtrair(4, 8);

// --------------------------------------------------------------------------------

// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Item na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// --------------------------------------------------------------------------------

// Console.WriteLine("Percorrendo a lista com o FOR");
// for (int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Posição n° {contadorForeach} - {listaString[contadorForeach]}");
//     contadorForeach++;
// }

// --------------------------------------------------------------------------------

// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 32;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 50;

// // int tamanho = 9;

// // Array.Resize(ref arrayInteiros, tamanho);

// Console.WriteLine("Percorrendo o Arry co m FOREACH");
// for (int i = 0; i < arrayInteiros.Length ; i++)
// {
//     Console.WriteLine($"{i}° Posição: {arrayInteiros[i]}");
// }

// Console.WriteLine("Percorrendo o Arry com FOREACH");

// --------------------------------------------------------------------------------

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {valor}");
//     contadorForeach++;
// }

// --------------------------------------------------------------------------------

// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Mateus";
// pessoa1.Idade = 17;
// pessoa1.Apresentar();

// --------------------------------------------------------------------------------

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("\n1 . Cadastrar cliente " 
//                     + "\n2 . Buscar cliente "
//                     + "\n3 . Apagar cliente "
//                     + "\n4 . Encerrar ");
//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção Invalida");
//             break;
//     }
// }


// Console.WriteLine("O programa se encerrou");

// --------------------------------------------------------------------------------

// int soma = 0,numero = 0;

// do
// {
//     Console.WriteLine("Digite um número: (0 para parar)");


//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// --------------------------------------------------------------------------------

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }

// --------------------------------------------------------------------------------

// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// --------------------------------------------------------------------------------

// Calculadora calc = new Calculadora();

// calc.RaizQuadrada(25);

// --------------------------------------------------------------------------------

// Numero Incremento
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// //Numero Decremento
// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);

// --------------------------------------------------------------------------------

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// --------------------------------------------------------------------------------

// calc.Potencia(4, 2);

// --------------------------------------------------------------------------------

// calc.Somar(10, 30);
// calc.Subtrair(30, 10);
// calc.Multiplicar(4, 3);
// calc.Dividir(10, 5);

// --------------------------------------------------------------------------------

// bool choveu = false;

// bool estaTarde = false;

// if ( !choveu && !estaTarde )
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia");
// }

// --------------------------------------------------------------------------------

// bool presencaMinina = true;
// double media = 6.9;

// if ( presencaMinina && media >= 7 )
// {
//     Console.WriteLine("Está aprovado");
// }
// else
// {
//     Console.WriteLine("Está Reprovado");
// }

// --------------------------------------------------------------------------------

// bool maior18Anos = true;

// bool altorizacaoResponsavel = false;

// if ( maior18Anos || altorizacaoResponsavel )
// {
//     Console.WriteLine("Está liberado a entrada");
// }
// else
// {
//     Console.WriteLine("Entrada barrada");
// }

// --------------------------------------------------------------------------------

// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }

// --------------------------------------------------------------------------------

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u" )
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma Vogal");
// }

// --------------------------------------------------------------------------------

// if (letra == "a")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }

// else
// {
//     Console.WriteLine("Não é vogal");
// }

// --------------------------------------------------------------------------------

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada. ");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque. ");
// }

// --------------------------------------------------------------------------------

// string a = "15 -";

// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");

// --------------------------------------------------------------------------------

// double a = 4 / (2 + 2);

// Console.WriteLine(a);

// --------------------------------------------------------------------------------

// Eu posso adicionar valores de um tipo em outro tipo que
// abriga valores maiores que ele ( tipo caixa pequena em uma grande )

// Mas não posso fazer um "caixa grande dentro de caixa pequena"

// int a = 5;
// double b = a; //Aqui teve um casting implicito

// int a = 5;
// long b = a;

// long a = long.MaxValue; // Não é possivel passar de long para int
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);

// --------------------------------------------------------------------------------

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);
// //Todos herdam por herança métodos da classe Object

// --------------------------------------------------------------------------------

// int a = 30;
// int b = 0;

// int c = a + b;
// c = c + 5; // 30 + 5
// c += 5; // É a mesma coisa de um c = c + 5
// c -= 5; // Mesma cisa que c = c - 5
// c *= 5; // Mesma coisa se aplica a outros sinais

// --------------------------------------------------------------------------------

// Cast - Casting
// int a = Convert.ToInt32("null");
// O Convert consegue lidar com valores nulos, retornando o 
// o valor 0

// Já o parse não consegue
// int a = int.Parse("A");
// Console.WriteLine(a);

// --------------------------------------------------------------------------------

// //Pega a data atual
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// --------------------------------------------------------------------------------

// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;
// double altura = 1.70;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condicao: " + condicao);

//ToString no altura para fazer o valor double ser mostrado com aquela formatação escrita

// --------------------------------------------------------------------------------

/*Pessoa pessoa = new Pessoa();

pessoa.Nome = "Mateus";
pessoa.Idade = 17;
pessoa.Apresentar();

Pessoa pessoaFisica = new Pessoa();

pessoaFisica.Nome = "Teteu";
pessoaFisica.Idade = 17;
pessoaFisica.Apresentar();
*/

//Nome de variavel em camelCase 
//Sem caracter especial em classe, variavel ou propriedade
//Underline é uma exceção

// --------------------------------------------------------------------------------
