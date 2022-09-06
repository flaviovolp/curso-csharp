using Ex3ListaClasse;
using System.Globalization;

Aluno a = new Aluno();

Console.WriteLine("Nome do Aluno: ");
a.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno: ");
a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL: "+a.CalcularNotaFinal().ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(a.AprovadoReprovado(a.CalcularNotaFinal()));
