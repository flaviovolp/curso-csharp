using System.Globalization;

int n = int.Parse(Console.ReadLine());
double[] vect = new double[n];
double soma = 0;

for(int i=0; i<n; i++)
{
    Console.Write("Entre com a posição "+i+": ");
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    soma += vect[i];
}

for (int i = 0; i < n; i++)
{
    Console.Write("Posição {0}: {1} \n", i, vect[i]);
    
}

double media = soma / n;

Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));

