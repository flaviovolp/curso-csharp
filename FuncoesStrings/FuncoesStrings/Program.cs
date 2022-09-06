string original = "abcde FGHI ABC abc DEFG     ";

string s1 = original.ToUpper(); //ToUpper() converte para maiuscula
Console.WriteLine("Original: -"+original+"-");
Console.WriteLine("TuUpper: -"+s1+"-");

string s2 = original.ToLower();//ToLower() converte tudo para minúscula
Console.WriteLine("ToLower: -"+s2+"-");

string s3 = original.Trim();//Elimina espaços vazios no começo ou no final
Console.WriteLine("Trim: -"+s3+"-");

int n1 = original.IndexOf("bc");
Console.WriteLine("IndexOf('bc'): "+n1); //pesquisa primeira ocorrência de um termo

int n2 = original.LastIndexOf("bc");
Console.WriteLine("LastIndexOf('bc'): "+n2); //retorna primeira posicao de tras para frente do termo

string s4 = original.Substring(3); // recorta a string original a partir da posicao 3
Console.WriteLine("Substring(3): -"+s4+"-");

string s5 = original.Substring(3, 5);// recorta a string original a partir da posicao 3 5 casas
Console.WriteLine("Substring(3,5): -" + s5+"-");

string s6 = original.Replace('a', 'x');
Console.WriteLine("Replace('a','x'): -"+s6+"-");//troca onde tem a por x


string s7 = original.Replace("abc", "xy");
Console.WriteLine("Replace('abc','xy'): -" + s7 + "-");//troca onde tem abc por xy


bool b1 = String.IsNullOrEmpty(original); //testa se a variavel original é null ou vazio
Console.WriteLine("IsNullOrEmpty: - "+b1);

bool b2 = String.IsNullOrWhiteSpace(original);
Console.WriteLine("IsNullOrWhiteSpace: "+b2);

