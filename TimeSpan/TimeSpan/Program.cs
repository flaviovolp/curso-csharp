TimeSpan t1 = new TimeSpan(0, 1, 30); // construtor utilizando horas ,minutos e segundos

Console.WriteLine(t1);
Console.WriteLine(t1.Ticks);

TimeSpan t2 = new TimeSpan(); // cria vazio

Console.WriteLine(t2);

TimeSpan t3 = new TimeSpan(900000000L); //cria a partir de nanossegundos
Console.WriteLine(t3);

TimeSpan t4 = new TimeSpan(2, 11, 21);
Console.WriteLine(t4);

TimeSpan t5 = new TimeSpan(1, 2, 11, 21); // cria utilizando dia, horas, minutos e segundos
Console.WriteLine(t5);

TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321); // cria utilizando dias, horas, minutos ,segundos e milissegundos
Console.WriteLine(t6);

Console.WriteLine("---------------------------------------");

TimeSpan t7 = TimeSpan.FromDays(1.5); // cria duração em horas informando dias
Console.WriteLine(t7);

TimeSpan t8 = TimeSpan.FromHours(1.5);
Console.WriteLine(t8);

TimeSpan t9 = TimeSpan.FromMinutes(1.5);
Console.WriteLine(t9);

TimeSpan t10 = TimeSpan.FromSeconds(1.5);
Console.WriteLine(t10);

TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
Console.WriteLine(t11);

TimeSpan t12 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t12);
