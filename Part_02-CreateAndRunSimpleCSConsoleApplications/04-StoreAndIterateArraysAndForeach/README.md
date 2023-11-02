Title: MSLearningCSharp  
Author: Microsoft  
Modified by: Brooke Taylor  
Date: 11/01/2023  
Description: Learning C# using freeCodeCamp and microsoft.com.  

---

## Declare a new array

1. To declare a new array of strings that can hold three elements, enter the following code: 

        string[] fraudulentOrderIDs = new string[3];

2. The `new` operator creates a new instance of an array in the computer's memory that can hold three string values. 

## Assign values to elements of an array

At this point, you've declared an array of strings, but each element of the array is empty. To access an element of an array, you use a numeric zero-based index inside of square brackets. You can assign a value to an array element using the `=` as if it were a regular variable.

1. To assign Order ID values to your fraudulentOrderIDs array, update your code as follows: 

        string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";

2. Notice that you're using the name of the array to access array elements. Each element is accessed individually by specifying zero-based index number inside the square brackets.

    Since your array is declared as a string, the values that you assign must also be strings. In this scenario, you're assigning Order IDs to the elements of the array. 


## Initialize an array

You can initialize an array during declaration just like you would a regular variable. However, to initialize the elements of the array, you use a special syntax featuring curly braces. 

        string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

## Looping through an array using foreach

The `foreach` statement provides a simple, clean way to iterate through the elements of an array. The `foreach` statement processes array elements in increasing index order, starting with index 0 and ending with index Length -1. It uses a temporary variable to hold the value of the array element associated with the current iteration. Each iteration will run the code block that's located below the `foreach` declaration.

        string[] names = { "Rowena", "Robin", "Bao" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

Below the `foreach` keyword, the code block that contains the Console.WriteLine(name); will execute once for each element of the `names` array. As the .NET runtime loops through each element of the array, the value stored in the current element of the `names` array is assigned to the temporary variable `name` for easy access inside of the code block.

## Create and initialize an array of int

1. To create an array of type `int` that stores the number of finished products in each bin, enter the following code: 

        int[] inventory = { 200, 450, 700, 175, 250 };

## Add a foreach statement to iterate through the array

1. To create a `foreach` statement that iterates through each element of the `inventory` array, enter the following code: 

        foreach (int items in inventory)
        {

        }