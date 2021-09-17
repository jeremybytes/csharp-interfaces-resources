# "C# Interfaces" Troubleshooting Guide

## Issue #1  
Error message when running the sample application.
```
'No connection could be made because the target machine actively refused it. [::ffff:127.0.0.1]:9874 (localhost:9874)'
```

### Cause
The web service is not running.

### Solution
In Visual Studio, set the solution to have multiple startup projects.
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

*If you are using Visual Studio Code and/or command line tools, then please follow the instructions under "Running the Application" in the main [README.md](/README.md) file.*
