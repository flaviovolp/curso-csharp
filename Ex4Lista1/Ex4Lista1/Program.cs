using System.Globalization;

Console.WriteLine("Entre com o número do Funcionário, número de horas trabalhadas e o valor que recebe por hora: ");
int number = int.Parse(Console.ReadLine());
int horas = int.Parse(Console.ReadLine());
double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double salario = horas * valor_hora;

Console.WriteLine("NUMBER = " + number);
Console.WriteLine("SALARY = U$ "+salario.ToString("F2",CultureInfo.InvariantCulture));
