using System.Globalization;

Console.WriteLine("Entre com o codigo do item e a quantidade deste item");
string[] vet = Console.ReadLine().Split(' ');
int codigo = int.Parse(vet[0]);
int qtde = int.Parse(vet[1]);
double valor;

if(codigo==1)
{
    valor = qtde * 4.00;

}
else if(codigo==2)
{
    valor = qtde * 4.50;
}
else if (codigo == 3)
{
    valor = qtde * 5.00;
}
else if (codigo == 4)
{
    valor = qtde * 2.00;
}
else 
{
    valor = qtde * 1.50;
}

Console.WriteLine("TOTAL: "+valor.ToString("F2",CultureInfo.InvariantCulture));