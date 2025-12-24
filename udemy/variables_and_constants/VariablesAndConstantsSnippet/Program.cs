
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
            // var allows the c# compiler to detect the data type
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

            System.Console.WriteLine("The minimum {0} and maximum {1} values for the byte type", byte.MinValue, byte.MaxValue);

            // Type conversion
            // Implicit
            byte ib = 1;
            int ii = ib;
            System.Console.WriteLine(ib);
            System.Console.WriteLine(ii);

            // Explicit
            // setting this to a value greater than 255 will cause data loss
            int ei = 1;
            //int ei = 256; // eb will equal 0
            byte eb = (byte)ei;
            System.Console.WriteLine(ei);
            System.Console.WriteLine(eb);

            // Non compatible
            string ncs = "1";
            System.Console.WriteLine("As a string {0}", ncs);

            int nci = Convert.ToInt32(ncs);
            System.Console.WriteLine("As an integer {0}", nci);

            int ncj = int.Parse(ncs);
            System.Console.WriteLine("As an parsed integer {0}", ncj);
        }
    }
}

