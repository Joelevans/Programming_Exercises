# Chapter 1

## Introduction to Programming

C# runs on CLR Environment.

### Microsoft .NET Framework

C# is not distributed as a stand alone product.
C# is part of .NET  
.NET consists of an environment for the development
and execution of programs written in C# or other
compatible languages.
It consists of :

- .NET programming languages
- env for execution of managed code ( CLR )
  Common Language Runtime
- dev tools i.e csc compiler, turns C# programs
  into intermediate code(MSIL) that CLR can understand
- standard libraries such as ADO. NET for access to DB
  WCF conects apps to communication
  protocols i.e http

---

### Formatting Rules

- All class names start with a capital Letter
- Variable names start with a lower-case
- Method names start with a capital letter

### File Naming

- Each class is defined in a seperate file, with a name
  corresponding to the class name and .cs extension.

.cs files are compiled by csc to executable code and
as a result assemblies are created.
i.e same file, different extension (.exe or .dll)

.exe files cannot run on a computer that does not have
the .NET Framework, you will receive an error.

Decompiling is the process which generates source code
from an existing executable binary file. We might to
decompile in the following cases:

- check how an algorithm is implemented.
- how to use certain API
- how a given library works
- code recovery
