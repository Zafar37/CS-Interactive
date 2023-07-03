Console.WriteLine(@"                             HI!
             I'm a robot Dany, and i will help you
                calculate the length of a word.
");
Console.Write("Enter a word: ");
var word = Console.ReadLine();

var wordLenght = word.Length;
var wordSymbol = word[0];

Console.WriteLine($"\nAnd so , your word \"{word}\".\n\nWord length: \"{wordLenght}\"\n\nFirst character: \"{wordSymbol}\"");
Console.WriteLine("See you!");

//task 2
var text = "Foydalanuvchidan kerakli tekstni ajratib olish uchun shu tekst joylashgan indeks va uni uzulini so'rang, o'sha tekstni kiritlgan tekstdan ajratib olib, konsolga chiqaring";

Console.WriteLine($"Text: {text}");

Console.WriteLine($"Text Length: {text.Length},Enter index and length to get substring.");
var indexText = int.Parse( Console.ReadLine() );
var lengthText1 = int.Parse(Console.ReadLine());

var substring = text.Substring(indexText, lengthText1);
Console.WriteLine($"Substring: {substring}");