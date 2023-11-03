/// <summary>
/// Title: MSLearningCSharp
/// Author: Microsoft
/// Modified by: Brooke Taylor
/// Date: 11/02/2023
/// Description: Learning C# using freeCodeCamp and microsoft.com
/// </summary>


bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

// Console.WriteLine($"Outside of code block: {value}");
// error CS0103: The name 'value' does not exist in the current context




bool flagg = true;
int values = 0;

if (flagg)
{
    values = 10;
    Console.WriteLine("Inside of code block: " + values);
}
Console.WriteLine("Outside of code block: " + values);




int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");