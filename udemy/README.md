# Udemy courses

Creating a console app

```shell
dotnet new console -n AppName
```

[Variables and constants](variables_and_constants/README.md)

[Type Conversion](type_conversion/README.md)

[Operators](Operators/README.md)

```c#
// Comments should explain
// why
// how
// and constraints...
```

[Non primiative types](non_primitive_types/README.MD)

Two main types

structures and classes...

primitive types are structures and strings, arrays, and custom classes are classes...

Memory management - 
Value types: structures
Reference types: classes

value types are allocated memory and cleaned up when out of scope.

```c#
var number = 10;
var number2 = number
number2++;
Console.WriteLine("number: {0}, and number2: {1}", number, number2);
```

reference types require the developer to allocate memory e.g.

```c#
var varName = new type();
```

Garbage collection cleans up these types

```c#
// Reference type
var array1 = new int[3] {1,2,3};
var array2 = array1;
// Array2 is just a pointer to the memory address that was created for array1; so they both point to the same memory location.
array2[0] = 0;
Console.WriteLine("Array1: {0}, and Array2: {1}",array1, array2);
```

