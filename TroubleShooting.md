# "C# Interfaces" Troubleshooting Guide

## Contents
- [Issue 1](#issue-1) - Error message: "No connection could be made because the target machine actively refused it."  

- [Issue 2](#issue-2) - When adding a type from another assembly (such as adding "IPersonReader" to the "ServiceReader" class), it has red squigglies and will not build.  

- [Issue 3](#issue-3) - Error message in Visual Studio: "Process with an Id of XXXX is not running".

***

## Issue 1  
**Error message when running the sample application.**
```
'No connection could be made because the target machine actively refused it. [::ffff:127.0.0.1]:9874 (localhost:9874)'
```

### Cause
The web service is not running.

### Solution
**In Visual Studio**, set the solution to have multiple startup projects.
1. Right-click on the solution in Solution Explorer.
2. Choose "Set Startup Project" ("Properties" will also get you there, but you may need to navigate once the popup has opened).  
![Solution popup menu](/images/Solution_popup.png)  
3. In the dialog, select "Startup Project" (under "Common Properties").
4. Select "Multiple startup projects".  
![Solution properties dialog](/images/Startup_dialog.png)  
5. Set "People.Service" to "Start without debugging".
6. Set "PeopleViewer" to "Start".
7. Click "OK".

Now when you run the application (using "F5" or the "Start" button on the toolbar), both the service and the web application will start.

*If you are using **Visual Studio Code** and/or command line tools, then please follow the instructions under "Running the Application" in the main [README.md](/README.md) file.*

***

## Issue 2
**When adding a type from another assembly (such as adding "IPersonReader" to the "ServiceReader" class), it has red squigglies and will not build.**

### Cause
There is a missing assembly/project reference or "using" statement for the "PersonReader.Interface" project.  

Sometimes "Ctrl+." does not work to add the project reference or "using" statement. I have found that if I mis-spell a reference (or get the capitalization wrong) sometimes Visual Studio can find it, but sometimes it cannot.

### Solution
Manually add the assembly/project reference and "using" statement.

**To add a project reference in Visual Studio:**  
1. In Solution Explorer, expand the project (I'll use "PersonReader.Service" here).  
![Service Reader project](/images/ServiceReader_project.png)  
2. Right-click on "Dependencies" and choose "Add Project Reference..."  
![Dependency popup](/images/Dependency_popup.png)  
3. Check the appropriate project name ("PersonReader.Interface" here).  
![Project reference dialog](/images/ProjectReference_dialog.png)  
4. Click "OK".

**To add a project reference in Visual Studio Code:**  
1. On the command line, navigate to the project folder ("PersonReader.Service").
```
PS C:\source\Interfaces\Module3\Extensibility\PersonReader.Service>
```
2. Type "dotnet add reference" and then the project name
```
PS C:[path]>dotnet add reference ..\PersonReader.Interface\PersonReader.Interface.csproj
```
*Note: Command-line completion helps here.*  

**To add a "using" statement**, add the following to the top of the file:

```c#
using PersonReader.Interface;
```

***
## Issue 3  
**Error message when running the sample application in Visual Studio.**
```
'Process with an Id of XXXX is not running'
```

### Cause
Visual Studio is trying to use IISExpress host the web application.

### Solution
**Visual Studio**: Get the latest version of the sample code from this repository. Both the .NET 5.0 and .NET 6.0 versions have been updated so that this issue should not occur.

**Manual Fix**: If you would like to fix the existing code on your machine, switch the People.Service and PeopleViewer projects to run directly instead of using IISExpress. This is only if you want to fix your existing code. The easier option is to get the latest version of the code samples from this repository.

1. In the Solution Explorer, right-click on the People.Service project and select "Set as Startup Project".  
![Set as Startup Project](/images/Set_as_Startup.png)  

2. On the toolbar, use the down arrow next to "IIS Express", and change the option to "People.Service".  
![Set to the program name](/images/Set_to_program.png)  

3. This should now show the name of the project ("People.Service") on the "Start Debugging" button.  
![Set to the program name](/images/Program_set.png)  

4. Repeat the above instructions for the "PeopleViewer" project.

5. Set the Solution back to using multiple startup projects by following the steps in [Issue 1](#issue-1).

There are quite a few steps here, so I would recommend getting the latest version of the code.
***

