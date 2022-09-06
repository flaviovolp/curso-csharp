using Banco;
using System.Globalization;

double deposito = 0;
char dep = 'z';

Console.Write("Entre com o número da conta: ");
int conta = int.Parse(Console.ReadLine());
Console.Write("Entre com o nome do titular da conta: ");
string titular = Console.ReadLine();
while (dep != 's' && dep!= 'S' && dep != 'n' && dep!='N')
{
    Console.Write("Haverá depósito inicial(s/n): ");
    dep = char.Parse(Console.ReadLine());
    if (dep == 's' || dep=='S')
    {
        Console.Write("Entre com o valor do depósito inicial: ");
        deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
    else if (dep == 'n' || dep=='N')
    {

    }
    else
    {
        Console.WriteLine("Opção Inválida!");
    }
}
Conta n = new Conta(conta, titular, deposito);
Console.WriteLine(n);

Console.Write("Entre com um valor para depósito: ");
deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
n.Depositar(deposito);
Console.WriteLine(n);
Console.Write("Entre com um valor para Saque: ");
deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
n.Sacar(deposito);
Console.WriteLine(n);
Console.Write("Digite o novo nome da conta: ");
titular = Console.ReadLine();
n.AlterarNomeConta(titular);
Console.WriteLine(n);
