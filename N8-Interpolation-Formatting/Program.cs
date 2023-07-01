Console.WriteLine(value: @"       Support ABC-Team

 Enter your email if you want to change your password

");
Console.Write("Email:");

string yourEmail = Console.ReadLine();

var emailMassage = "\n\"Email massage:\n{0}";
var greetingEmail = string.Format(emailMassage, $"{yourEmail}");
Console.WriteLine(greetingEmail);

var passworUser = "\nWe would like to inform you, that your password was changed.\nYour new password is {0}";
var greetingPassworUser = string.Format(passworUser, "w#34qj9@");
Console.WriteLine(greetingPassworUser);

Console.WriteLine("\nSincerely\nABC-Team\"");
