Title: MSLearningCSharp  
Author: Microsoft  
Modified by: Brooke Taylor  
Date: 10/31/2023  
Description: Learning C# using freeCodeCamp and microsoft.com.  

---

# Creating an instance of a class

An instance of a class is called an *object*. To create a new instance of a class, you can use the `new` operator. Consider the following line of code that creates the new instance of the `Random` class to create a new object called `dice`:

        Random dice = new Random();

The `new` operator does several important things: 

* It first requests an address in the computer's memory large enough to store a new object based on the `Random` class.
* It creates the new object, and stores it at the memory address.
* It returns the memory address so that it can be saved in the `dice` variable.

From that point on, when the `dice` variable is referenced, the .NET Runtime performs a lookup behind the scenes to give the illusion that you're working directly with the object itself. 

