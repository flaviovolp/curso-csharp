int senha = 2002;

int senha1=0;
while (senha != senha1)
{
    Console.WriteLine("Digite a Senha: ");
    senha1 = int.Parse(Console.ReadLine());
    if(senha1==senha)
    {
        Console.WriteLine("Acesso Permitido");    
    }
    else
    {
        Console.WriteLine("Senha Inválida");
    }
}