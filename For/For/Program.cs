Console.WriteLine("Quantos números inteiros você vai digitar: ");
int n = int.Parse(Console.ReadLine());

int soma = 0;
for(int i=1; i<=n; i++)
{
    Console.WriteLine("valor #{0}: ",i);
    soma = soma + int.Parse(Console.ReadLine());
    
}
Console.WriteLine("Soma = "+soma);