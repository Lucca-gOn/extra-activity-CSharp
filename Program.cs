// Programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos e semanas.
// Entrada: Receber o ano de nascimento.
// Processamento: Ano atual, subtraido pelo ano de nascimento = idade em anos (pesquisar variável para colocar data). Para calcular semanas, multiplicar a idade pela quantidade de semanas no ano.

Console.WriteLine($"Seja bem vindo, iremos calcular a sua idade em anos e semanas, vamos começar? :)");

Console.Write($"Digite o ano do seu nascimento:");
int ano = int.Parse(Console.ReadLine());

int idade = DateTime.Now.Year - ano;
int semanas = idade * 52;

Console.WriteLine($"Sua idade é: {idade} anos e {semanas} semanas. Obrigado!");




