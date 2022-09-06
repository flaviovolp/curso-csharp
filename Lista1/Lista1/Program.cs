using System.Collections.Generic;

List<string> list = new List<string>();

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Flavio");


foreach(string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("List count: "+list.Count);

string s1 = list.Find(x=> x[0] == 'A');
Console.WriteLine("Primeiro 'A': "+s1);


string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Ultimo A: "+s2);

int pos1 = list.FindIndex(x => x[0] == 'A');
Console.WriteLine("Primeira Posição: "+pos1);

int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("ultima posicao: "+pos2);

// criar um filtro na lista
Console.WriteLine("-------------------------------------------");
List<string> list2 = list.FindAll(x => x.Length == 5);
foreach(string obj in list2)
{
    Console.WriteLine(obj);
}

list.RemoveAt(3);
Console.WriteLine("--------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("-----------------------------");
list.RemoveAll(x => x[0] == 'M');
foreach (string obj in list)
{
    Console.WriteLine(obj);
}

list.RemoveRange(0, 2);
Console.WriteLine("----------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}






/*static bool Test(string s)
{
    return s[0] == 'A';
}*/


