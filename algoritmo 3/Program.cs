using System.Globalization;

Console.Write("informe seu nome completo: ");
// cria a variável nome e recebe seu valor
string nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.Write("quantos quartos existem em sua casa? ");
// converte o texto digitado para um número int
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("informe o preço de sua internet: ");
double precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("informe seu ultimo nome, idade e altura: ");
// Keller 32 1.81
string linha = Console.ReadLine();
// vetor de texto - divisão quando encontrar um espaço
string[] vetor = linha.Split(' ');
string SobreNome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
Console.WriteLine();
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString("F2"));
Console.WriteLine(SobreNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));

