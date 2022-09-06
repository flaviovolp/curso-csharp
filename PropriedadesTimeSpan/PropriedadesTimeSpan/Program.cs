
TimeSpan t1 = TimeSpan.MaxValue;
TimeSpan t2 = TimeSpan.MinValue;

TimeSpan t3 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

Console.WriteLine("------------------------------------");

TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
Console.WriteLine("Days: "+t4.Days);
Console.WriteLine("Hours: "+t4.Hours);
Console.WriteLine("Minutes: "+t4.Minutes);
Console.WriteLine("Milliseconds: "+t4.Milliseconds);
Console.WriteLine("Seconds: "+t4.Seconds);
Console.WriteLine("ticks: "+t4.Ticks);

Console.WriteLine("TotalDays: "+t4.TotalDays);
Console.WriteLine("TotalHours: "+t4.TotalHours);
Console.WriteLine("TotalMinutes: "+t4.TotalMinutes);
Console.WriteLine("TotalSeconds: "+t4.TotalSeconds);
Console.WriteLine("TotalMilisseconds: "+t4.TotalMilliseconds);


Console.WriteLine("--------------------------------------");

TimeSpan d1 = new TimeSpan(1, 30, 10);
TimeSpan d2 = new TimeSpan(0, 10, 5);

TimeSpan sum = d1.Add(d2);
Console.WriteLine(sum);

TimeSpan dif = d1.Subtract(d2);
Console.WriteLine(dif);

TimeSpan mult = d2.Multiply(2.0);
Console.WriteLine(mult);

TimeSpan div = d2.Divide(2.0);
Console.WriteLine(div);




