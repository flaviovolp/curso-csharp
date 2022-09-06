using Ex2ListaClasse;
using System.Globalization;

Funcionario f = new Funcionario();


Console.WriteLine("Nome: ");
f.Nome = Console.ReadLine();
Console.WriteLine("Salário Bruto: ");
f.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Imposto: ");
f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Funcionário: " + f);
Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
f.AumentarSalario(porcentagem);
Console.WriteLine("Dados atualizados: "+f);



