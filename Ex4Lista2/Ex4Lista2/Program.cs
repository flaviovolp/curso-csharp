Console.WriteLine("Entre com a hora inicial e a hora final: ");
string[] vet = Console.ReadLine().Split(' ');
int hora1 = int.Parse(vet[0]);
int hora2 = int.Parse(vet[1]);
int tempo;

if (hora1 < hora2)
{
    tempo = hora2 - hora1;

}
else if (hora1>hora2)
{
    tempo = 24 - hora1 + hora2;
}
else
{
    tempo = 24;
}

Console.WriteLine("O JOGO DUROU {0} HORAS(S)",tempo);