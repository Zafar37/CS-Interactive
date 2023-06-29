Console.WriteLine("#2 - Correct data types \n");

DateTime date = DateTime.Now;
Console.WriteLine($"Todays date: {date}");

DateTime date2 = new DateTime(1970,01,01);
Console.WriteLine($"Unix date: {date2}");

byte age = 75;
Console.WriteLine($"{age} years old");

float money = 35.5F;
Console.WriteLine($"{money}$");

string nickname = "Max Developer";
Console.WriteLine(nickname);