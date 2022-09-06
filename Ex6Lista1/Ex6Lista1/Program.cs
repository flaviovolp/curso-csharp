using System.Globalization;

Console.WriteLine("Entre com os valores A, B e C: ");
string[] vet = Console.ReadLine().Split(' ');

double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

double triangulo = a * c / 2;
double circulo = Math.PI * Math.Pow(c, 2);
double trapezio = ((a + b) * c) / 2;
double quadrado = b * b;
double retangulo = a * b;

Console.WriteLine("TRIANGULO: "+triangulo.ToString("F3",CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
