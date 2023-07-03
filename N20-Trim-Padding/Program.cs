//task 1

Console.Write("Enter a name:");

var name = Console.ReadLine();
Console.WriteLine($"Your name: {name}");

var trimmText = name.Trim().Trim('*');
Console.WriteLine($"TrimmerText: {trimmText}");

Console.WriteLine();

//task 2

Console.Write("Enter a text: ");

var text  = Console.ReadLine();
var padText = text.PadLeft(text.Length + 10, '_');
Console.WriteLine($"PadText: {padText}");

