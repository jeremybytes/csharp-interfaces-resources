# "C# Interfaces" Resources
This repository contains sample code and additional resources for the "C# Interfaces" course by Jeremy Clark on Pluralsight. The examples in the course use .NET 5.0. Updated samples using .NET 6.0 are available in this repository.  

## Code Samples
The code samples are in folders starting with the environment (net50), followed by the course module (module1). From there, the "before" and "after" folders contain the code at the beginning of the demo and the code at the end of the demo, respectively.

## Pluralsight Course
* [C# Interfaces](http://www.pluralsight.com/courses/c-sharp-interfaces) by Jeremy Clark (released Jun 2021)  

To see what is new and changed from the previous course, please see [ChangeLog.md](/ChangeLog.md).

## Running the Samples  
The code samples can be followed using Visual Studio (Windows) or Visual Studio Code (Windows, Linux, macOS).

**.NET 5.0 - development tool options**  
* Visual Studio 2022 (Community Edition)
* Visual Studio 2019 (Community Edition)
* Visual Studio Code

**.NET 6.0 - development tool options**  
* Visual Studio 2022 (Community Edition)  
(Visual Studio 2019 does *not* support .NET 6.0)
* Visual Studio Code  

*Note: If you have difficulty running the samples, please see the [Troubleshooting Guide](/TroubleShooting.md) for possible solutions.*

### Visual Studio 2022 and Visual Studio 2019
When using Visual Studio, open the solution file (.sln) that is included in each sample folder. The solution is set up to automatically start the web application as well as the required web service, so no special action should be required.

**Running the Web Service and Application**  
To run a project, click F5 or use "Start debugging" from the toolbar or Debug menu.

Your default browser will automatically open to http://localhost:5000 (the location of the web application). When you are done, close the browser window.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Note: If you get the following error:*

```
'No connection could be made because the target machine actively refused it. [::ffff:127.0.0.1]:9874 (localhost:9874)'
```
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Then the web service is not running. Check the [Troubleshooting Guide](/TroubleShooting.md) for help.*

**Running the Unit Tests**  
For the sample that has unit tests, open the Test Explorer in Visual Studio by selection "Test | Test Explorer" from the menu or "Ctrl+E, T".

In the Test Explorer, click the left-most button (or use "Ctrl+R, V") to run all of the tests.

### Visual Studio Code
When using Visual Studio Code, you will need to start the web service project separately from the web application.

**Starting the Service**  
For the projects that have a "People.Service" folder, use the following steps to start the service:

1. Open a terminal in the "People.Service" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The service should start and show the following info:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:9874
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
```

If you open a browser to http://localhost:9874/people, you will see data from the service.

You can leave this terminal open for all of the samples; each sample uses the same web service.

To stop the service, press "Ctrl+C" in the terminal.

**Running the Web Application**  
To run the web application (PeopleViewer), use the following steps:

1. Open a terminal in the "PeopleViewer" folder.
2. Type "dotnet run". (This will rebuild the project if necessary.)
3. The web application should start and show the following info:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
```
To run the application, open a browser to http://localhost:5000.

When you are done, you can stop the web server by going back to the terminal window and pressing "Ctrl+C".

Alternately, you can run the web application from within Visual Studio Code by using the integrated debugger. For more information, see [Visual Studio Code - Debugging](https://code.visualstudio.com/docs/editor/debugging).

**Running the Unit Tests**  
One of the samples includes unit testing. To run unit tests from the terminal, use the following steps:

1. Open a terminal in the "PeopleViewer.Tests" folder.
2. Type "dotnet test". (This will rebuild the project if necessary.)
3. The tests will run and the result will be similar to the following:
```
Test run for ...\PeopleViewer.Test.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.9.4
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     2, Skipped:     0, Total:     2, Duration: 60 ms - PeopleViewer.Test.dll (net5.0)
```

## Relevant Files  
For a listing of the relevant files in each sample project, please refer to the [RelevantFiles.md](/RelevantFiles.md) file.

## Articles & Links

### 1 - Course Overview

### 2 - Introducing Interfaces
Downloads
* [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (Windows only)  
Community Edition is free to use.  
During installation, choose the "ASP.NET and web development" workload.
* [.NET 6.0](https://dotnet.microsoft.com/download) (Windows, Linux, macOS)  
You will want to use the "Download .NET SDK" to get the developer version of .NET
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet) (Windows, Linux, macOS)  
*.NET 5.0 is available until May 2022. After that, you will want to upgrade to .NET 6.0 if you haven't already.*  
You will want to use the "Download .NET SDK" to get the developer version of .NET
* [Visual Studio Code](https://code.visualstudio.com/download) (Windows, Linux, macOS)  

Article
* [The Secret Code: ASP.NET MVC Conventions](https://jeremybytes.blogspot.com/2020/02/the-secret-code-aspnet-mvc-conventions.html) by Jeremy Clark
* [Interfaces (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/) Microsoft Docs


### 3 - Creating Interfaces to Add Extensibility
* [Patterns of Enterprise Application Architecture](https://www.martinfowler.com/books/eaa.html) by Martin Fowler, et al.


### 4 - Dynamic Loading and Unit Testing
* [Dynamically Loading Types in .NET Core with a Custom Assembly Load Context](https://jeremybytes.blogspot.com/2020/01/dynamically-loading-types-in-net-core.html) by Jeremy Clark
* [Getting Started with Dependency Injection in .NET](https://app.pluralsight.com/library/courses/using-dependency-injection-on-ramp) Pluralsight course by Jeremy Clark
* [Cross-Platform Build Events in .NET Core using MSBuild](https://jeremybytes.blogspot.com/2020/05/cross-platform-build-events-in-net-core.html) by Jeremy Clark


### 5 - Explicit Interface Implementation
* [Explicit Interface Implementation (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/explicit-interface-implementation)


### 6 - Default Implementation and Advanced Topics
* [A Closer Look at C# 8 Interfaces](https://jeremybytes.blogspot.com/2019/09/a-closer-look-at-c-8-interfaces.html) by Jeremy Clark  
* [C# 8 Interfaces: Properties and Default Implementation](https://jeremybytes.blogspot.com/2019/09/c-8-interfaces-properties-and-default.html) by Jeremy Clark
* [C# 8 Interfaces: Public, Private, and Protected Members](https://jeremybytes.blogspot.com/2019/11/c-8-interfaces-public-private-and.html) by Jeremy Clark  
* [C# 8 Interfaces: Static Members](https://jeremybytes.blogspot.com/2019/12/c-8-interfaces-static-members.html) by Jeremy Clark
* [Tutorial: Update interfaces with default interface methods in C# 8.0](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/default-interface-methods-versions) Microsoft Docs
* [Tutorial: Mix functionality in when creating classes using interfaces with default interface methods](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/mixins-with-default-interface-methods) Microsoft Docs
