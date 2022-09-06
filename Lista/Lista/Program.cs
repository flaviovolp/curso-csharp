using System.Collections.Generic;

List<string> list = new List<string>();
//cria uma lista vazia

list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");

foreach (string obj in list)
{
    Console.WriteLine(obj);
}