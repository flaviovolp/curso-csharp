using Exemplo2Classe;
using System.Globalization;

Produto p = new Produto("TV", 500.00, 10);

Console.WriteLine(p.Nome);

p.Nome= "TV 6k";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);
Console.WriteLine(p.Quantidade);


/*
Console.WriteLine("Entre com os dados do produto: ");
Console.WriteLine("Nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());

Produto p = new Produto(nome, preco);



Console.WriteLine( );
Console.WriteLine("Dados do Produto: " + p);

Console.WriteLine();
Console.Write("Digite a quantidade de produtos a ser adicionada: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: "+p);
Console.WriteLine("Digite a quantidade de produtoas a ser removida: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados Atualizados: "+p); 
*/