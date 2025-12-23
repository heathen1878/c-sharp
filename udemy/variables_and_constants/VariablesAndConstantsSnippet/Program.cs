
namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            // Integral numbers
            byte byteVar = 0; // maps to Byte in .Net
            short shortVar = 0; // maps to Int16 in .Net
            int intVar = 0; // maps to Int32 in .Net
            long longVar = 0; // maps to Int64 in .Net

            // Real Numbers
            float floatVar = 3.14f; // maps to Single in .Net
            double doubleVar = 10.99; // maps to Double in .Net - this is the default if you do not specify a suffix
            decimal decimalVar = 10.99m; // maps to Decimal in .Net

            // Characters
            char charVar = 'a'; // maps to Char in .Net

            // Boolean
            bool boolVar = false; // maps to Boolean in .Net

            //Constants
            const byte ByteVar = 0;

            // Non-primative types
            string stringVar = "A String";
            //array 
            //enum
            //class

            // Overflowing
            byte number = 255;
            number++;
            Console.WriteLine(number); // This will output 0

            // Scope
            var globalVar = 0;
            {
                var firstLevelVar = 1;
                Console.WriteLine("Level One");
                Console.WriteLine(globalVar);
                Console.WriteLine(firstLevelVar);
                {
                    var secondLevelVar = 2;
                    Console.WriteLine("Level Two");
                    Console.WriteLine(globalVar);
                    Console.WriteLine(firstLevelVar);
                    Console.WriteLine(secondLevelVar);
                    {
                        var thirdLevelVar = 3;
                        Console.WriteLine("Level Three");
                        Console.WriteLine(globalVar);
                        Console.WriteLine(firstLevelVar);
                        Console.WriteLine(secondLevelVar);
                        Console.WriteLine(thirdLevelVar);
                    }
                }
                //Console.WriteLine(secondLevelVar); // This will throw a compile error
            }
        }
    }
}

