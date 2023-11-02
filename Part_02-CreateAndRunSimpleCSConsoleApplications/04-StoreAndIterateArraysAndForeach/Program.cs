/// <summary>
/// Title: MSLearningCSharp
/// Author: Microsoft
/// Modified by: Brooke Taylor
/// Date: 11/01/2023
/// Description: Learning C# using freeCodeCamp and microsoft.com
/// </summary>


/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"\nFirst: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}\n");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}\n");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n");


string[] names = { "Rowena", "Robin", "Bao\n" };
foreach (string name in names)
{
    Console.WriteLine(name);
}



int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})\n");
}
Console.WriteLine($"We have {sum} items in inventory.\n");






string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}