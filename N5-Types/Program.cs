Console.WriteLine("Primitive type:");

bool Bolean = true;
Console.WriteLine("Bolean = " + Bolean);

char symbol = '*';
Console.WriteLine($"Symbol = {symbol}");    

double PI = Math.PI;
Console.WriteLine($"PI = {PI} \n");

Console.WriteLine("Complex type:");

Guid guid = Guid.NewGuid();
Console.WriteLine("Guid = " + guid);

DateTime Now = DateTime.Now;
Console.WriteLine($"Now: {Now}");
string[,] arrays =
{
    {"Nana","Nina" },
    {"Sana","Sina" },
    {"Gosha","Misha" }
};
Console.WriteLine("Today we are visiting:");
for (int i = 0; i < arrays.GetLength(0); i++)
{
    for (int j = 0; j < arrays.GetLength(1); j++)
    {
        Console.WriteLine(arrays[i, j] + " ");
    }
}


Console.WriteLine("\nValue type:");

int number = 123456789;
Console.WriteLine($"int = {number}");

double PiNumber = Math.PI;
Console.WriteLine($"Double = {PiNumber}");

bool simplysity = false;
Console.WriteLine($"Bool = {simplysity} \n");

Console.WriteLine("Reference type:");

string mood = "Cheerful";
Console.WriteLine($"Srtring = {mood}");
int[] changing = new int[]
{
    1,
    2,
    3,
    4,
    5
};
Console.Write($"Array = ");
for (int i = 0; i < changing.Length; i++)
{
    Console.Write(changing[i] + " ");
}


Console.WriteLine("\n\nStatic:");

var temperature = 36.6F;// temeperaature = "36.6"(string) - Error
Console.WriteLine($"Temperatura: {temperature}");
                        
Console.WriteLine();
Console.WriteLine("Dynamic (dynamic and object):");

// dynamic
dynamic change = 36.6;
change = "Inscription - 36.6";//fashionable to change
change = 110;// fashionable to change
Console.WriteLine($"Dynamic: {change}");
// and 
dynamic a = 10;
dynamic b = 10;
dynamic c = a + b;// work
Console.WriteLine($"Dynamic1: {c}");
//object
object a1 = 10;
object b1 = 10;
// object c1 = a1 + b1  error , does not work

//but can also changes
object changeObj = 36.6;
changeObj = "Inscription - 36.6";//fashionable to change
changeObj = 110;// fashionable to change
Console.WriteLine($"Object: {changeObj}");


