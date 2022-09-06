string[] vet;

int x = 1;
int y = 1;

while(x!=0 && y!=0)
{
    Console.WriteLine("Digite as Coordenadas: ");
    vet = Console.ReadLine().Split(' ');
    x = int.Parse(vet[0]);
    y = int.Parse(vet[1]);
    if(x>0 && y>0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x>0 && y<0)
    {
        Console.WriteLine("quarto");

    }
    else if(x<0 && y>0)
    {
        Console.WriteLine("Segundo");
    }
    else if (x<0 && y<0)
    {
        Console.WriteLine("Terceiro");
    }
    else
    {
        Console.WriteLine(" ");
    }
}
