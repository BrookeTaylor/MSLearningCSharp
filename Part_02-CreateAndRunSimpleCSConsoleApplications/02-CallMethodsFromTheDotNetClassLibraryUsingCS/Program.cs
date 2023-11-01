/// <summary>
/// Title: MSLearningCSharp
/// Author: Microsoft
/// Modified by: Brooke Taylor
/// Date: 10/31/2023
/// Description: Learning C# using freeCodeCamp and microsoft.com
/// </summary>


Console.WriteLine("\nCall different kinds of methods in the .NET Class Library\n\n");


Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine("System.Random Class");
Console.WriteLine(roll);


int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"\n\nFirst roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}\n\n");

int firstValue = 500;
int secondValue = 600;
// int largerValue;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);