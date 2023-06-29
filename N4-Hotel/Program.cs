int index = 0;
var NowHotelRooms = new bool[][]
{
    new bool[]{false,true},
    new bool[]{true,true,false,false}
   
};

Console.WriteLine("Rooms:")

Console.WriteLine($"Xona: {index+1} Bandmi? {NowHotelRooms[0][index++]} ");
Console.WriteLine($"Xona: {index+1} Bandmi? {NowHotelRooms[0][index++]} ");
index= 0;
Console.WriteLine($"Xona: {index+3} Bandmi? {NowHotelRooms[1][index++]} ");
Console.WriteLine($"Xona: {index+3} Bandmi? {NowHotelRooms[1][index++]} ");
Console.WriteLine($"Xona: {index+3} Bandmi? {NowHotelRooms[1][index++]} ");
Console.WriteLine($"Xona: {index+3} Bandmi? {NowHotelRooms[1][index++]} ");

