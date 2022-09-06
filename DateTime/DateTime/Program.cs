using System.Globalization;

DateTime d1 = DateTime.Parse("2000-08-15");
Console.WriteLine(d1);

DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
Console.WriteLine(d2);


DateTime d3 = DateTime.Parse("15/08/2000");
Console.WriteLine(d3);

DateTime d4 = DateTime.Parse("15/08/2000 13:05:25");
Console.WriteLine(d4);

DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // mascara de formatação
Console.WriteLine(d5);

DateTime d6 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
Console.WriteLine(d6);



/*DateTime d1 = DateTime.Now; //horario atual do sistema
Console.WriteLine(d1);
Console.WriteLine(d1.Ticks);

DateTime d2 = new DateTime(2018, 11, 25); // especifica ano, mes e dia
Console.WriteLine(d2);

DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
Console.WriteLine(d3);

DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
Console.WriteLine(d4);

DateTime d5 = DateTime.Now;
Console.WriteLine(d5);

DateTime d6 = DateTime.Today;
Console.WriteLine(d6);

DateTime d7 = DateTime.UtcNow;
Console.WriteLine(d7); */