using Ex2Classe;
using System.Globalization;

Funcionario f1, f2;
double salarioMedio;

f1 = new Funcionario();
f2 = new Funcionario();


Console.WriteLine("Dados do primeiro funcionário:\nNome: ");
f1.Nome = Console.ReadLine();
Console.WriteLine("Salário: ");
f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:\nNome: ");
f2.Nome = Console.ReadLine();
Console.WriteLine("Salário: ");
f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salarioMedio = (f1.Salario + f2.Salario) / 2;

Console.WriteLine("Salário Médio: "+salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
