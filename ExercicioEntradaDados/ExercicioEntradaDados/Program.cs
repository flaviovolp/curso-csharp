﻿using System.Globalization;

Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem sua casa: ");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu ultimo nome, idade e altura na (mesma linha): ");
string[] vet = Console.ReadLine().Split(' ');

string unome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(unome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
