var singIn = @"Account
              Sing In
";
Console.WriteLine(singIn);

Console.WriteLine("Enter your name and age");

Console.Write("Name: ");
string userName = Console.ReadLine();

Console.Write("Age: ");
string userAge = Console.ReadLine();

Console.WriteLine("\nPass the robot test");
Console.WriteLine("2 + 2 * 2 = ?");

Console.Write("Answer: ");
byte userAnswer = byte.Parse(Console.ReadLine());

if (userAnswer == 6)
{
    var successfully = @$"
   Name: {userName}
   Age: {userAge}
   The test was successful

            Entrance allowed!
    
";
    Console.WriteLine(successfully);
}
else
    Console.WriteLine(@"
            Entry denied, you have not passed the robot check!
"
); 

