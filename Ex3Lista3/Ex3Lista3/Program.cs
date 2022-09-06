int conta = 0;
int contg = 0;
int contd = 0;

int codigo = 0;
char stop = 'c';



while(stop=='c')
{
    Console.WriteLine("Entre com um Código ");
    codigo = int.Parse(Console.ReadLine());
    if (codigo==1)
    {
        conta++;
    }
    else if(codigo==2)
    {
        contg++;
    }
    else if(codigo==3)
    {
        contd++;
    }
    else if(codigo==4)
    {
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: "+conta);
        Console.WriteLine("Gasolina: "+ contg);
        Console.WriteLine("Diesel: "+ contd);
        stop = 'p';
    }
    else if(codigo!=4)
    {
        Console.WriteLine("Código Inválido");
       
    }
    
}
