﻿using Ex1ListaClasse;
using System.Globalization;

Retangulo retangulo = new Retangulo();
Console.WriteLine("Entre com a largura e altura do retângulo: ");
retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA ="+ retangulo.Area().ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO =" + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL =" + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();
Console.WriteLine(retangulo);
