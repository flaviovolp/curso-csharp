﻿using System.Globalization;

double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
Console.WriteLine(desconto);