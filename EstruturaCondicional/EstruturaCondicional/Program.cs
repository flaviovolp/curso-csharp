﻿

Console.WriteLine("Qual a hora atual: ");
int x = int.Parse(Console.ReadLine());

if(x <12 )
{
    Console.WriteLine("Bom dia!");
}
else if(x < 18)
{
    Console.WriteLine("Boa tarde");
}
else
{
    Console.WriteLine("Boa noite!");
}