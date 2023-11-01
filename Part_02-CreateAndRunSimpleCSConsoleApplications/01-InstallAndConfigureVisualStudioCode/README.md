Title: MSLearningCSharp  
Author: Microsoft  
Modified by: Brooke Taylor  
Date: 10/31/2023  
Description: Learning C# using freeCodeCamp and microsoft.com.  

---

1. Download Visual Studio Code

    https://code.visualstudio.com/



2. Check to see if .NET is already installed

    Open **Command Prompt** or **Powershell** and enter the command: 

        dotnet --version



3. Install the .NET 7 Software Development Kit

    https://dotnet.microsoft.com/en-us/download


4. Verify your installation

            dotnet --version


5. Configure Visual Studio Code Extensions - 

    > In the filtered list of available extensions, select the extension labeled "**C# Dev Kit** - Official C# extension from Microsoft" that's published by Microsoft.

    Notice that installing the C# Dev Kit installs the following extensions: 

    * C# Dev Kit - Official C# extension from Microsoft.
    * C# - Base language support for C#.
    * IntelliCode for C# - AI-assisted development for C# Dev Kit.
    * .NEt Install Tool for Extension Authors.


6. Create, build, and run your application

The .NET software development kit (SDK) includes a command-line interface (CLI) that can be accessed from Visual Studio Code's integrated Terminal.

        dotnet new console -o ./CsharpProjects/TestProject

        dotnet build

        dotnet run

        

