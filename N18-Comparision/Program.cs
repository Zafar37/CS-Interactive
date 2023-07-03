Console.WriteLine("Enter a word:");
Console.Write("Word 1:");
var textCompareA = Console.ReadLine();
Console.Write("Word 2:");
var textCompareB = Console.ReadLine();


Console.WriteLine($"Compare result:{textCompareA} {textCompareB} : {textCompareA.CompareTo(textCompareB)}");

// "abc" and "bcd" = -1
// "abc" and "abc" = 0
// "Abc" and "abc" = 1//po alfovitu (ketmaketligi).


//solishtirish:


Console.WriteLine($"Equals result of: {textCompareA} {textCompareB} : {textCompareA.Equals(textCompareB)}");
Console.WriteLine($"EqualseSequence of result: {textCompareA} {textCompareB} : {textCompareA.SequenceEqual(textCompareB)}");
Console.WriteLine($"= result of: {textCompareA} {textCompareB} : {textCompareA == textCompareB}");
