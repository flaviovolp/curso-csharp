﻿using System.Globalization;

Console.WriteLine("Entre com dois valores x e y: ");
string[] vet = Console.ReadLine().Split(' ');

double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

if(x==0 && y==00)
{
    Console.WriteLine("Origem");
}
else if(x==0 && y!=0)
{
    Console.WriteLine("Eixo Y");
}
else if(x!=00 && y==0)
{
    Console.WriteLine("Eixo X");
}
else if(x>0 && y>0)
{
    Console.WriteLine("Q1");
}
else if(x>0 && y<0)
{
    Console.WriteLine("Q4");
}
else if(x<0 && y>0)
{
    Console.WriteLine("Q2");
}
else
{
    Console.WriteLine("Q3");
}