/// <summary>
/// Title: MSLearningCSharp
/// Author: Microsoft
/// Modified by: Brooke Taylor
/// Date: 10/30/2023
/// Description: Learning C# using freeCodeCamp and microsoft.com
/// </summary>



// Character Literals
Console.Write("\nCharacter Literals: ");
// use the single quotation marks '' 
Console.Write('b');



// Integer Literals
Console.Write("\nUsing Integer Literals: ");
Console.Write(123);



Console.WriteLine("\n\nFloat Type\tPrecision\n-------------------------\nfloat\t\t~6-9 digits\ndouble\t\t~15-17 digits\ndecimal\t\t 28-29 digits\n");


// Using floating-point literals
Console.Write("Using floating-point literals ");
Console.Write(0.25F);
Console.Write("\nYou can use either a lower-case f or a upper-case F as the literal suffix for a float.\n\n");

Console.WriteLine(2.625);
Console.WriteLine("To create a double literal, just enter a decimal number. The compiler defaults to a double literal when a decimal number is entered without a literal suffix.\n\n");

Console.WriteLine(12.39816m);
Console.WriteLine("To create a decimal literal, append the letter m after the number. In this context, the m is called a literal suffix.\n\n");

Console.WriteLine("If you wanted to print a value representing either true or false, you could use a bool literal");
Console.WriteLine(true);
Console.WriteLine(false);
