using System.Globalization;

Console.WriteLine("Entre com o valor do raio do circulo: ");
double raio= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = Math.PI * Math.Pow(raio, 2);


Console.WriteLine("A área do círculo é igual: " + area.ToString("F4",CultureInfo.InvariantCulture));


