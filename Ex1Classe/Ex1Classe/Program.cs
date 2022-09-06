using Ex1Classe;

Pessoa p1, p2;

p1 = new Pessoa();
p2 = new Pessoa();

Console.WriteLine("Entre com os dados da primeira Pessoa: \n Nome: ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
p1.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com os dados da segunda Pessoa: \n Nome: ");
p2.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
p2.Idade = int.Parse(Console.ReadLine());

if(p1.Idade>p2.Idade)
{
    Console.WriteLine("Pessoa mais velha: "+ p1.Nome);
    
}
else
{
    Console.WriteLine("Pessoa mais velha: "+p2.Nome);
}
