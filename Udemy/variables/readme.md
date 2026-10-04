# Variables

[Home](../readme.md)

See [program](variables_and_constants/Program.cs) for examples

## Defintions

`Variable`: a name given to a storage location in memory
`Constant`:an immutable value - known at compile time and cannot change during the lifetime of the app running.

A good example for a `Constant` is `pi` = `3.14` - this is always the case and must not change. The same premise should be used in for application values.

```c#
// type identifier (default)
int number;

int number =1;

constant type identifier value
const float Pi = 3.14f;
```

Variable identifers are case sensistive, and cannot start with a number, cannot have any whitespace, and cannot use a keyword. Names should be meaningful.

Variables must be initialised before use...for example...

```c#

```

### Naming Conventions

Camel Case: `firstName` - local variables

Pascal Case: `FirstName` - constants

Hungarian Notification: `strFirstName` - not used in c#

### Primative Types

#### Integral Numbers

The larger the number(s) to the larger the data type

c# byte -> Byte in .NET - no. of Bytes 1
c# short -> Int16 in .NET - no. of Bytes 2
c# int -> Int32 in .NET - no. of Bytes 4
c# long -> Int64 in .NET - no. of Bytes 8

##### Overflowing

```c#
byte number = 255;

number = number + 1; // Will overflow to 0

// Checked
checked
{
    byte number = 255;

    number + number + 1;
}
// Will it be used, probably not...move the data type to short...
```

#### Real Numbers

The more precision the larger the data type

c# float -> Single in .NET - no. of Bytes 4
c# double -> Double in .NET - no. of Bytes 8 - Default data type
c# decimal -> Decimal in .NET - no. of Bytes 16

```c#
float number = 1.2f; // use float
decimal number = 1.2m; // use decimal
```

#### Character

c# char -> Char in .NET - no. of Bytes 2

#### Boolean

c# bool -> Boolean in .NET - no. of Bytes 1

##### Scope





### Non-Primative Types

#### String

#### Array

#### Enum

#### Class

