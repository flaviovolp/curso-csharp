using System.Globalization;
using ExEstatico;

Console.WriteLine("Qual é a cotação do dólar: ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantos dólares você vai comprar: ");
double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Valor a ser pago em reais: "+ConversorDeMoeda.Conversao(cotacao,quantidade).ToString("F2",CultureInfo.InvariantCulture));
