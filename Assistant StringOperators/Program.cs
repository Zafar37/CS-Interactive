// Concatanation - операция склеивания объектов линейной структуры, обычно строк.
var firstName = "Zafar";
var lastName = "Urakov";
var fullName = firstName + " " + lastName;

Console.WriteLine($"Fullname: {fullName}");
Console.WriteLine();


//Escape Characters — замена в тексте управляющих символов на соответствующие текстовые подстановки.
//Один из видов управляющих последовательностей

var complexString = "\"Asp.Net Core in Action\" by Andtrew Trowlson";
Console.WriteLine(complexString);
Console.WriteLine();

//Interpolation anf Formatting

//Interpolation(Osonroq textlaga islatiladi - способ соединения строк через вставку значений переменных в строку-шаблон с помощью фигурных скобок.
var age = 10;
Console.WriteLine($"Age: {age}");//interppolation

//Formating(kiyinroq textlaga ishlatiladi:
var ageText = "Hello, {0} {1}, {0} how are you?";
var greeting = string.Format(ageText, "Zafar", "Welcome");

Console.WriteLine("Formating: ");
Console.WriteLine("Formating greeting text : {0}", greeting);


// Verabtim String:

var longText = $@"
Hello, i'm Zafar.

I
Love
C#
{greeting}

";//verbatim string - qop string chikarish uchun.

var filePth = @"E:\DotnetExs\CS.Interactive\Practice - N1\bin";

//Length
var simpleText = "Console";
Console.WriteLine($"Length of word \" {simpleText}\" - {simpleText.Length}");


var symbol = simpleText[0];
Console.WriteLine($"Symbol at index 0 : {symbol}");

var substring = simpleText.Substring(0, 3);
Console.WriteLine($"Substring of word \"{simpleText}\" from index 0 with length 3: {substring}");

//Splitting and Joinig

var loremText = "Prepared by experienced English teachers, the texts, articles and conversations are brief and appropriate to your level of proficiency." +
    " Take the multiple-choice quiz following each text, and you'll get the results immediately. You will feel both challenged and accomplished! " +
    "You can even download (as PDF) and print the texts and exercises. It's enjoyable, fun and free. Good luck!";

var words = loremText.Split(' ');
var sentences = loremText.Split('.');
var duplicateTextSplit = loremText.Split("immediately");

Console.WriteLine("Word: ");
foreach (var word in words)
    Console.WriteLine(word + "\n");
Console.WriteLine();

Console.WriteLine("Sentences: ");
foreach (var word in sentences)
    Console.WriteLine(word + "\n");
Console.WriteLine();

Console.WriteLine("Duplicate word text: : ");
foreach (var word in duplicateTextSplit)
    Console.WriteLine(word + "\n");
Console.WriteLine();

// probel bilan Console.ReadLine kilish

var input = Console.ReadLine();
var splitInput = input.Split(' ');
var numberA = int.Parse(splitInput[0]);
var numberB = int.Parse(splitInput[1]);

Console.WriteLine ($"Number A: {numberA}");
Console.WriteLine ($"Number B: {numberB}");

Console.WriteLine();


//cases, case operators

var john = "John";
var firstNameA = john.ToLower();//john
var firstNameB = john.ToUpper();//JOHN
var firstNameC = john.ToLowerInvariant();//john
var firstNameD = john.ToUpperInvariant();//JOHN


Console.WriteLine($"ToLower {firstNameA}");
Console.WriteLine($"ToUpper {firstNameB}");
Console.WriteLine($"ToLowerInvariant {firstNameC}");
Console.WriteLine($"ToUpperInvariant {firstNameD}");

//char toUpper ToLower - only in string
var test = "A".ToLower()[0];

//Comprison and Equality - solishtirish va tten bolishi

var textComapreA = "John";
var textComapreB = "John";

//Console.



// "abc" and "bcd" = -1
// "abc" and "abc" = 0
// "Abc" and "abc" = 1//po alfovitu (ketmaketligi).


//solishtirish:
//var textComapreA = "John";
//var textComapreB = "John";

Console.WriteLine($"Compare result:{textComapreA} {textComapreB} : {textComapreA.CompareTo(textComapreB)}");// 0
Console.WriteLine($"Equals result of: {textComapreA} {textComapreB} : {textComapreA.Equals(textComapreB)}");// true
Console.WriteLine($"EqualseSequence of result: {textComapreA} {textComapreB} : {textComapreA.SequenceEqual(textComapreB )}");// true
Console.WriteLine($"= result of: {textComapreA} {textComapreB} : {textComapreA == textComapreB}");// True

var objectA = new object();//pustoy
var objectB = new object();// pustoy 

Console.WriteLine($" objectA = objectB : {objectA == objectB}");
Console.WriteLine($" objectA Equals objectB : {objectA.Equals(objectB)}");//reference buyicha tikshiradi
Console.WriteLine($" objectA object.Equals objectB : {object.Equals(objectA, objectB)}");//reference buyicha tikshiradi
Console.WriteLine($" objectA object.ReferenceEquals objectB : {object.ReferenceEquals(objectA, objectB)}");

//Searching

//startingWith
Console.WriteLine($" startingWith char: {textComapreA.StartsWith('J')}");
Console.WriteLine($" startingWith string : {textComapreA.StartsWith("Jo")}");
Console.WriteLine($" startingWith string with ignore case : {textComapreA.StartsWith("Jo" , StringComparison.OrdinalIgnoreCase)}");


//EndWith
Console.WriteLine($"End with string with ignore case -{textComapreA.EndsWith("Hn", StringComparison.OrdinalIgnoreCase)}");

//Containts

Console.WriteLine($"Contains with igore case - {loremText.Contains("folLowing", StringComparison.OrdinalIgnoreCase)}");
Console.WriteLine();

//Replasing

var passwordChangeEmail = "Dear {{User}}! You new password id {{Password}}";
var userToken = "{{User}}";
var passwordToken = "{{Password}}";

var email = passwordChangeEmail.Replace(userToken, "Zafar").Replace(passwordToken, "12345");
Console.WriteLine($"Senfing email: {email}");
Console.WriteLine();

//trim and padding
var untrimmedText = "                      text value                  ";
var trimmedText = untrimmedText.Trim();// probellarni uchirvoradi
Console.WriteLine($"trimmedText: {trimmedText}");

Console.WriteLine("Example with replace, trim");
var securityMessage = "This is credential! {{Password}}";

var messageForUser = securityMessage.Replace(passwordToken, "23456789");//zamena
var messageForModerator = securityMessage.Replace(passwordToken, "********");
var messageForAssistant = messageForModerator.Trim('*');

Console.WriteLine();
Console.WriteLine($"Message for user {messageForUser}");
Console.WriteLine($"Message for moderator {messageForModerator}");
Console.WriteLine($"Message for assistant {messageForAssistant}");
Console.WriteLine();


Console.WriteLine($"Text : {untrimmedText}, after trim start : {untrimmedText.TrimStart()}");
Console.WriteLine($"Text : {untrimmedText}, after trim end : {untrimmedText.TrimEnd()}");

untrimmedText.TrimEnd();
untrimmedText.TrimStart();
untrimmedText.Trim();

Console.WriteLine($"Does strim get affected ? - {untrimmedText}");

Console.WriteLine();
var questionSample = "I go to";
var question = questionSample.PadRight(20, '*');
Console.WriteLine($"Question : {question}");
