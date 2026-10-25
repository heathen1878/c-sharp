# Non primitive types

```shell
dotnet run --project .
```

## Classes

Classes are types / blueprint from which we create objects; an object is an instance of a class.

Class example

Class name: Person
Fields: Name, Age, Height, Weight a.ka. variables...with an access modifier.
Methods: Walk(), Talk(), Eat() and Sleep()

```c#
string Name;
Name = "Dom";

// instantiate the class i.e. create an object called person and allocate memory using the `new` keyword.
var person = new Person() { Name = Name };
person.Introduce();
```

Access modifier...public or private  - who can access this class within the app
all variables (fields) within the class must have an access modifier...
methods also need an access modifier too.

```c#
public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}
```

A static modifier is used when the concept should only exist once in memory...when the static modifier is used the method is only accessible from the class itself not an object.

```c#
public static int Add(int numberOne, int numberTwo)
{
    return numberOne + numberTwo;
}
```

## Structs

Similar to classes combine related fields and methods together. Use a struct when you want to define a small lightweight object.

## Arrays

Arrays are a collection of variables of the same type

Declare and assign

```c#
var[] numbers = new int[3]; // this cannot be changed and memory must be allocated as an array is an object.
numbers[0] = 10;
...

// or
var[] numbers = new int[3] {1, 2, 3};
```

Access

```c#
Console.Writeline("{0}", numbers[0])
```

## Strings

Declare and assign

```c#
// Once declared the value cannot change for the lifetime of the app.
string name = "Dom";
```

There are methods within the string class to modify the value but these create a new string and do not modify the original.

Strings map to the `String` class in the .Net Framework.

## Enums

Enums are good for group related constants; rather than declaring multiple constants.

## Reference Types and Values Types

Structures and Classes...

All primitive types are structures...and custom `structs` and they're value types...memory allocation done automatically...allocated on stack memory...automatically deallocated once out of scope.

All non primitive types are classes...and they're reference types...memory allocation done via the `new` operator...allocated on heap memory...cleared by the CLR garbage collector...

```c#
// value types
var a = 10;
var b = a;
Console.Writeline(b++;) // b will be 11 a is still 10

// using a method with the same variable name....
public static void Increment(int number)
{
    number += 10;
}

static void Main(String[] args)
{
    var number = 1;
    Increment(number); // this is 10 but a different memory location than number above
    Console.Writeline(number); // this will equal 1
}

// reference types
var c = new int[3] {1, 2, 3};
var d = c;
d[0] = 0; // c[0] and d[0] will equal 0
Console.Writeline("c: {0}, d: {1}", c[0], d[0]);

...
namespace ReferenceTypes
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(String[] args)
        {
            var person = new Person() {Age = 38};
            MakeOlder(person);
            Console.Writeline(person.Age);
        }

        public static void MakeOlder(Person person)
        {
            person.Age += 10;
        }
    }
}
```

