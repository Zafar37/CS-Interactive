Console.WriteLine(@" 
                              Vote");
Console.Write("Enter your age:");
var userAge = int.Parse(Console.ReadLine());

if (userAge >= 18)
    Console.WriteLine("You can vote in elections!");
else
    Console.WriteLine("You can not vote in elections!");