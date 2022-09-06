using System.Globalization;
using VetorExemplo2;

Console.WriteLine("Informe quantidade de produtos: ");
int n = int.Parse(Console.ReadLine());

Produto[] vect = new Produto[n];

double soma = 0.0;

for(int i=0; i<n; i++)
{
    string nome = Console.ReadLine();
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Produto { Nome = nome, Preco = preco };
    
    soma += vect[i].Preco;
}

double media = soma / n;
Console.WriteLine("Preco Medio"+media.ToString("F2",CultureInfo.InvariantCulture));