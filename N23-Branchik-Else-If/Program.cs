Console.Write("Enter a number:");

var number = int.Parse(Console.ReadLine());

if(number == 0)
{
    Console.WriteLine("This number is 0");
}
else if(number < 0)
{
    Console.WriteLine("This nimber is negative");
}
else
{
    Console.WriteLine("This number is positive");
}