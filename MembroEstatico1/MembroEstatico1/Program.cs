using System.Globalization;
using MembroEstatico1;


Console.WriteLine("Digite o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Calculadora.Circunferencia(raio);
Console.WriteLine("Circunferncia: " + circ.ToString("F2", CultureInfo.InvariantCulture));

double volume = Calculadora.Volume(raio);
Console.WriteLine("Volume: "+volume.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: "+Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));





