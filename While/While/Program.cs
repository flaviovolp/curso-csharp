using System.Globalization;

double numero = 0;
while (numero>=0)
{

    Console.WriteLine("Digite um número: ");
    numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (numero > 0)
    {
        Console.WriteLine(Math.Sqrt(numero).ToString("F3", CultureInfo.InvariantCulture));
    }
    else
    {
        Console.WriteLine("Número Negativo!");
    }
}

