using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;


// // --------------------------------------------------------------------------------

// Manipulando atribuição de tipo de valor 

// int a = 10;

// int b = a;

// b = 60;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de A: {b}");

// // --------------------------------------------------------------------------------

// Manipulando atribuição de tipo de referencia em memória Stack

// Pessoa p1 = new Pessoa(nome: "Mateus", sobrenome: "Santos");

// Pessoa p2 = new Pessoa(p1.Nome, "Santana");

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");

// // --------------------------------------------------------------------------------

//Método de extensão

// int number = 20;
// bool even  = false;

// even = number.isEven();

// string mensage = "O número " + number + " é "+(even ? "par" : "ímpar");

// Console.WriteLine(mensage);

// // --------------------------------------------------------------------------------

// Classe genêrica

// MyArray<int> integerArray = new MyArray<int>();

// integerArray.AddElementArray(30);

// Console.WriteLine(integerArray[0]);


// MyArray<string> stringArray = new MyArray<string>();

// stringArray.AddElementArray("Texto");

// Console.WriteLine(stringArray[0]);

// // --------------------------------------------------------------------------------

// Tipo dinâmico de variável

// dynamic dynamicVariable = 4;

// Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable})");

// dynamicVariable = "Texto";
// Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable})");

// dynamicVariable = true;
// Console.WriteLine($"Tipo da variável: {dynamicVariable.GetType()}, Valor: {dynamicVariable})");

// // --------------------------------------------------------------------------------

// Tipo anônimo em Coleção

// string fileContent = File.ReadAllText("Arquivos/sales.json");

// List<Sale> saleList = JsonConvert.DeserializeObject<List<Sale>>(fileContent);

// var unnamedList = saleList.Select(x => new { x.Product, x.Price });

// foreach(var sale in unnamedList){
//     Console.WriteLine($"Produto: {sale.Product}, Preço: {sale.Price} ");
// }

// // --------------------------------------------------------------------------------

//  Tipo anonimo em classe genérica

// var unnamedType = new { Name = "Mateus", LastName = "Santos", Height = 1.80 };

// Console.WriteLine("Nome: " + unnamedType.Name);
// Console.WriteLine("Sobrenome: " + unnamedType.LastName);
// Console.WriteLine("Altura: " + unnamedType.Height);

// // --------------------------------------------------------------------------------

// Deserializando o objeto no formato JSON + Colocando propriedade nula

//  string fileContent = File.ReadAllText("Arquivos/sales.json");

//  List<Sale> saleList = JsonConvert.DeserializeObject<List<Sale>>(fileContent);

//  foreach (Sale sale in saleList)
//  {
//      Console.WriteLine($"Id: {sale.Id}, " +
//      $"Produto: {sale.Product}, Preço: {sale.Price}, Data: {sale.SaleData.ToString("dd/MM/yyyy HH:mm")}"
//      +$"{(sale.Discount.HasValue ? $" Desconto de: {sale.Discount}" : "")}");
// }

// // --------------------------------------------------------------------------------

// Tipo nulo

// bool? wantReciveEmail = true;

// if (wantReciveEmail.HasValue && wantReciveEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuário não respondeu ou optou por receber e-mail.");
// }

// // --------------------------------------------------------------------------------

// Deserializando o objeto no formato JSON

// string fileContent = File.ReadAllText("Arquivos/sales.json");

// List<Sale> saleList = JsonConvert.DeserializeObject<List<Sale>>(fileContent);

// foreach (Sale sale in saleList)
// {
//     Console.WriteLine($"Id: {sale.Id}, " +
//     $"Produto: {sale.Product}, Preço: {sale.Price}, Data: {sale.SaleData.ToString("dd/MM/yyyy HH:mm")}");
// }

// // --------------------------------------------------------------------------------

// Criando um arquivo em formato JSON que passa um List contendo vendas

// DateTime currentData = DateTime.Now;

// List<Sale> salesList = new List<Sale>();

// Sale v1 = new Sale(1, "Office supplies", 25.0M, currentData);
// Sale v2 = new Sale(2, "Software License", 110.0M, currentData);

// salesList.Add(v1);
// salesList.Add(v2);

// string serialized = JsonConvert.SerializeObject(salesList, Formatting.Indented);

// File.WriteAllText("Arquivos/sales.json", serialized);

// Console.WriteLine(serialized);

// ISO 8601 - Padroniza o modo como os dados são mostrados no sistema

// // --------------------------------------------------------------------------------

// IF TERNÁRIO

// int number = 15;
// bool isEven = false;

// isEven = number % 2 == 0;
// Console.WriteLine($"O número {number} é " + (isEven ? "par" : "impar"));

// // --------------------------------------------------------------------------------

// IF NÃO TERNARIO
// if (number % 2 == 0)
// {
//     Console.WriteLine($"O número {number} é par");
// }
// else
// {
//     Console.WriteLine($"O número {number} é impar");
// }

// // --------------------------------------------------------------------------------

// Desconstrução de um objeto

// Pessoa p1 = new Pessoa("Mateus", "Santos");

// (string name, string lastname) = p1;

// Console.WriteLine($"{name} {lastname}");

// // --------------------------------------------------------------------------------

// Tuplas

// (int, string, string, decimal) tuple = (1, "Mateus", "Santos", 1.80M);

// ValueTuple<int, string, string, decimal> otherTupleExemple = (1, "Mateus", "Santos", 1.80M);

// var otherCreateTupleExemple = Tuple.Create(1, "Mateus", "Buta", 1.80M);


// Console.WriteLine(tuple);

// Console.WriteLine($"Id: {tuple.Item1}");
// Console.WriteLine($"Nome: {tuple.Item2}");
// Console.WriteLine($"Sobrenome: {tuple.Item3}");
// Console.WriteLine($"Altura: {tuple.Item4}");

// // --------------------------------------------------------------------------------

// Diccionary

// O Dictionary armazena dados e uma chave, essa que deve ser unica, lembra muito o conceito de orientação a objeto, de classe e objeto
// Tudo que eu faço no dicionario é por meio de sua chave 

// Dictionary<string, string> states = new Dictionary<string, string>();

// states.Add("SE", "Sergipe");
// states.Add("BA", "Bahia");
// states.Add("MG", "Minas Gerais");

// Console.WriteLine(states["MG"]);

// foreach(KeyValuePair<string, string> item in states) Outra Sintaxe
// foreach(var item in states)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// states.Remove("BA");
// states["SE"] = "Sergipe - valor alterado";

// foreach(var item in states)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string key = "BA2";
// Console.WriteLine($"Verificando o elemento: {key}");

// if (states.ContainsKey(key))
// {
//     Console.WriteLine($"Valor existente: {key}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {key}");
// }

// // --------------------------------------------------------------------------------

// Stack/Pilha

//  O Stack funciona como uma pilha, voce adiciona elementos como uma pilha mesmo, e o ultimo elemento dela que vai ser tratado em vez do primeiro
// LIFO - LAST IN FIRST OUT

// Stack<int> stack = new Stack<int>();

// stack.Push(4);
// stack.Push(6);
// stack.Push(8);
// stack.Push(10);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {stack.Pop()}");

// stack.Push(20);

// foreach(int item in stack)
// {
//     Console.WriteLine(item);
// }

// // --------------------------------------------------------------------------------

// Queue/Fila

// O Queue funciona como uma fila, ele vai tratar o primeiro componente dela como prioridade
// FIFO - FIRST IN FIRST OUT

// Queue<int> queue = new Queue<int>();

// queue.Enqueue(2);
// queue.Enqueue(4);
// queue.Enqueue(6);
// queue.Enqueue(8);

// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {queue.Dequeue()}");
// queue.Enqueue(10);

// foreach(int item in queue)
// {
//     Console.WriteLine(item);
// }

// // --------------------------------------------------------------------------------

// Exeções 

// new ExemploExecao().Metodo1();

// try
// {
//     string[] lines = File.ReadAllLines("Arquivos/fileReading.txt");

//     foreach (string line in lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// // Há uma ordem em que deve ser colocado os exceptions pelo visto
// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado {ex.Message}");
// } 

// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exeção genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou até aqui");
// }

// // --------------------------------------------------------------------------------

// Usando o  DateTime

// string dateString = "2022-12-17 18:00";


// bool sucesso = DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", 
//                     CultureInfo.InvariantCulture,
//                     DateTimeStyles.None, 
//                     out DateTime date);

// if ( sucesso )
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {date}");
// }
// else
// {
//     Console.WriteLine($"{dateString} não é uma data válida");
// }

// Console.WriteLine(data.ToShortDateString());

// // --------------------------------------------------------------------------------

// Usando o Culture info e o ToString

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal monetaryValue = 1582.40M;

// Console.WriteLine(monetaryValue.ToString("C2"));

// double percentage = .3421;

// Console.WriteLine(percentage.ToString("P"));

// int number = 123456;
// int number2 = 19062005;
// Console.WriteLine(number.ToString("##-##-##"));
// Console.WriteLine(number2.ToString("##/##/####"));

// // --------------------------------------------------------------------------------

//Conversão de string para inteiro

// string numero1 = "10";
// string numero2 = "20";

//string resultado = numero1 + numero2;

// int resultado = Convert.ToInt16(numero1) + Convert.ToInt16(numero2);

// Console.WriteLine(resultado);

// --------------------------------------------------------------------------------

// Criando um objeto da classe Pessoa e adicionando a propriedade Alunos, do objeto cursoDeIngles

// Pessoa p1 = new Pessoa(nome: "Mateus", sobrenome: "Santos");
// Pessoa p2 = new Pessoa(nome: "Matias", sobrenome: "Santana");

// Curso cursoDeIngles = new Curso();
//     cursoDeIngles.Nome = "Inglês";
//     cursoDeIngles.Alunos = new List<Pessoa>();

//     cursoDeIngles.AdicionarAluno(p1);
//     cursoDeIngles.AdicionarAluno(p2);
//     cursoDeIngles.ListarAlunos();

// p1.Nome = "Mateus";
// p1.Sobrenome = "Santana";
// p1.Idade = 17;

// p1.Apresentar();