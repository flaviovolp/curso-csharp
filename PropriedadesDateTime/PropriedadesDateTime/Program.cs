DateTime d = DateTime.Now;
Console.WriteLine(d);
Console.WriteLine("1) Date: "+d.Date);
Console.WriteLine("2)Day: "+d.Day);
Console.WriteLine("3 - DayOfWeek: "+d.DayOfWeek);
Console.WriteLine("4 - DayofYear: "+d.DayOfYear);
Console.WriteLine("5 - Hour: " + d.Hour);
Console.WriteLine("6 - Kind: "+d.Kind);
Console.WriteLine("7 - Millisecond: "+d.Millisecond);
Console.WriteLine("8 - Minute: "+d.Minute);
Console.WriteLine("9 - Month: "+d.Month);
Console.WriteLine("10 - Second: "+d.Second);
Console.WriteLine("11 - Ticks: "+d.Ticks);
Console.WriteLine("12 - TimeOfDay: "+d.TimeOfDay);
Console.WriteLine("13 - Year: "+d.Year);

Console.WriteLine("--------------------------------");

Console.WriteLine(d.ToLongDateString()); // converte para uma string, pode ser guardada em variavel

Console.WriteLine(d.ToLongTimeString());

Console.WriteLine(d.ToShortDateString());

Console.WriteLine(d.ToShortTimeString());

Console.WriteLine(d.ToString());

string s = d.ToString("yyyy-MM-dd HH:mm:ss");
Console.WriteLine(s);
Console.WriteLine("-----------------------------------------");
DateTime d2 = d.AddDays(5);

Console.WriteLine(d);
Console.WriteLine(d2);

DateTime d3 = d.AddMinutes(3);
Console.WriteLine(d3);

DateTime x1 = new DateTime(2000, 10, 15);
DateTime x2 = new DateTime(2000, 10, 20);

TimeSpan t = x2.Subtract(x1);
Console.WriteLine(t);

