Console.WriteLine("#1-Reseption \n");

Console.WriteLine("Assalamu aleykum,what is your name?");
var HeIsName = Console.ReadLine();

Console.WriteLine($"Good {HeIsName} , my name is Zafar. Nice to meet you! \nAnd how old are you {HeIsName}?");
var HisAge = int.Parse(Console.ReadLine());

Console.WriteLine($"Wow, {HisAge} is a good age! \n{HeIsName} , what is your hobby?");
var Hobby = Console.ReadLine();

Console.WriteLine($"All clear! Check your details.");
Console.WriteLine($"Name: {HeIsName} \nAge: {HisAge} years old \n Hobby: {Hobby}");


