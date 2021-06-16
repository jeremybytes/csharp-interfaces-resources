# "C# Interfaces" Relevant Files
This document contains the relevant files for each sample application. The files listed are thosed used directly or updated in the course demos.  

The order is based on when they are used in the code demo.

***

## 1 - Course Overview
No sample files.

***

## 2 - Introducing Interfaces

### Polygons

**Polygons.Library**
- ConcreteRegularPolygon.cs
- Square.cs
- AbstractRegularPolygon.cs
- Triangle.cs
- IRegularPolygon.cs
- Octagon.cs

**Polygons**
- Program.cs

### FutureProofing

**People.Library**
- PersonReader.cs

**PeopleViewer**
- Controllers/PeopleController.cs
- Views/People/Index.cshtml

***

## 3 - Creating Interfaces to Add Extensibility

### Extensibility

**PeopleViewer**
- Controllers/PeopleController.cs

**Readers/PersonReader.Interface**
- IPersonReader.cs

**Readers/PersonReader.Service**
- ServiceReader.cs

**Readers/PersonReader.CSV**
- CSVReader.cs

**Readers/PersonReader.SQL**
- SQLReader.cs

**PersonReader.Factory**
- ReaderFactory.cs

***

## 4 - Dynamic Loading and Unit Testing

### Extensibility

**Readers/PersonReader.Factory**
- ReaderFactory.cs

**PeopleViewer**
- appsettings.json
- Controllers/PeopleController.cs
- Views/Home/Index.cshtml

### DynamicLoading

**PeopleViewer**
- appsettings.json
- Controllers/PeopleController.cs

**Readers/ReaderFactory**
- ReaderFactory.cs

### UnitTesting

**PeopleViewer**
- Controllers/PeopleController.cs
- Startup.cs

**PeopleViewer.Test**
- FakeReader.cs
- PeopleControllerTests.cs

***

## 5 - Explicit Interface Implementation

### ExplicitImplementation

**CatalogSaver**
- Library.cs
- Program.cs

**OddNumbers**
- OddGenerator.cs
- Program.cs

***

## 6 - Default Implementation and Advanced Topics

### DefaultImplementation

**PeopleViewer**
- Controllers/PeopleController.cs

**People.Library**
- IPeopleLogger.cs
- ConsoleLogger.cs
- FileLogger.cs

***
