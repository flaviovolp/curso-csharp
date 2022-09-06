using System.Globalization;

Console.WriteLine("Entre com o codigo das peças 1 e 2, o número de peças 1 e 2 e o valor unitário \n das peças 1 e2: ");
string[] vet1 = Console.ReadLine().Split(' ');
string[] vet2 = Console.ReadLine().Split(' ');

double valor = 
 (double.Parse(vet1[1]) * double.Parse(vet1[2],CultureInfo.InvariantCulture)) + (double.Parse(vet2[1]) * double.Parse(vet2[2],CultureInfo.InvariantCulture));

Console.WriteLine("VALOR A PAGAR: R$ "+valor.ToString("F2", CultureInfo.InvariantCulture));