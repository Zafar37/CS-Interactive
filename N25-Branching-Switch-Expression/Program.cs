Console.Write("Enter the number of the day:");

var numberOfTheDay = int.Parse(Console.ReadLine());
Console.WriteLine();

var expression = numberOfTheDay switch
{
 1 => "Dushanba" + " | " +"Monday",   
 2 => "Seshanba" + " | " +"Tuesday",   
 3 => "Chorshanba" + " | " +"Wednesday",   
 4 => "Payshanba" + " | " +"Thursday",   
 5 => "Juma" + " | " +"Friday",   
 6 => "Shanba" + " | " +"Saturday",   
 7 => "Yakshanba" + " | " +"Sunday",   
} ;
Console.WriteLine($"Today is: {expression}");