Recommended video https://www.youtube.com/watch?v=r5dtl9Uq9V0
https://learn.microsoft.com/en-us/dotnet/core/tools/


1. install latest version of Microsoft .Net Core SDK from dotnet.microsoft.com/download
2. verify installation by writing in cmd   
    dotnet --version
3. install extension C# for Visual Studio Code (powered by OmniSharp) by Microsoft

Below description how to create basic console app project

4. in your repo folder create subfolder where your new program code will reside
5. open cmd shell (or powershell console in vs code) and go to newly created folder
    e.g. Cd C:\MyWorkspace\my_playground\c#_test\firstCodeInVSCode
6. write
    dotnet new console
7. if you are in CMD write "code ." to open created console project
8. create/or modify code according your needs
9. to run code write in terminal
    dotnet run



If you wanted to create solution as you used to do in VS do following instead of steps 5 -9

20. in CMD or terminal write
    dotnet new sln -n "myVSCodeSolution"
    dotnet new console -n "myConsoleApp"
20.c
    dotnet new classlib -n "myLibrary"   (if you need separate library file)

21. write dir to see created folders and files. Till now project IS NOT a part of solution. We have to bind it.
    dotnet sln myVSCodeSolution.sln add ./myConsoleApp/myConsoleApp.csproj
    dotnet sln myVSCodeSolution.sln add ./myLibrary/myLibrary.csproj

    If we wanted to extend our library with more classes we can add more cs files in library directory (here \firstCodeInVSCode\myLibrary) e.g. Class2.cs.
    There is no need add library file using dotnet CLI (as shown in 20.c) or recreate reference (as shown in 22).
    It's up to you as well whether you stick to the same namespace in new file or set new one.
    
        namespace myLibrary;
        public class Class2
            {
            }

22. make reference between project console and the library
    dotnet add ./myConsoleApp/myConsoleApp.csproj reference   ./myLibrary/myLibrary.csproj

    This will add new item in myConsoleApp.csproj



Debuger setup
Once you open/reopen vs code and click on c# project (here e.g. .../myConsoleApp/myConsoleApp.csproj) you'll be prompted to install "required assets to build and debug".
Click yes to confirm setup.
If you clicked "no" by chance or you delayed with clicking you can either reopen vs code or better in command pallet (Ctrl+shift+P) choose omnisharp:select project.
Alternatively select Run>Add Configuration from menu and then select .Net5+ and .NET Core at the select environment prompt.
This will; 
    a/ create new subfolder bin\Debug\...
    b/ add two new files in .vscode folder with run and debug configuration

30.


more help on CLI
.net core command-line interface (CLI) tools

Other:
If wanted install nuget package write dotnet add package packageName
    e.g. dotnet add package log4net

You'll see new entry csproj file
here e.g. 
        <ItemGroup>
            <PackageReference Include="log4net" Version="2.0.15" />
        </ItemGroup>
... and when you run app you'll notice log4net.dll in myConsoleApp/bin/debug


40. create release
    dotnet run --version Release

50 gitignore    
    To configure git ignore go to you main app folder and run
    dotnet new gitignore



60. usefull switch --dry-run
e.g.  dotnet new classlib --dry-run -n newClass