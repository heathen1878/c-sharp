
using System.Linq.Expressions;
using System.Threading.Tasks.Dataflow;

namespace VariablesAndConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            // Primative Types
            // Integral numbers
            byte numberAsByte = 0; // maps to Byte in .Net
            System.Console.WriteLine("The minimum {0} and maximum {1} values for the byte type", byte.MinValue, byte.MaxValue);
            short numberAsShort = 0; // maps to Int16 in .Net
            int numberAsInt = 0; // maps to Int32 in .Net
            long numberAsLong = 0; // maps to Int64 in .Net

            // Real Numbers
            float pi = 3.14f; // maps to Single in .Net
            double totalPriceAsDouble = 10.99; // maps to Double in .Net - this is the default if you do not specify a suffix
            decimal totalPriceAsDecimal = 10.99m; // maps to Decimal in .Net

            // Characters
            char character = 'A'; // maps to Char in .Net

            // Boolean
            bool isWorking = false; // maps to Boolean in .Net

            //Constants
            const byte valueAsByte = 0;

            // You cannot do this...
            //valueAsByte = 1;

            // Non-Primative Types
            string text = "A String";
            //array
            //enum
            //class

            // Overflowing
            byte number = 255;
            number++;
            Console.WriteLine("Overflowing a byte...");
            Console.WriteLine(number); // This will output 0
            Console.WriteLine();

            // Scope
            // var allows the c# compiler to detect the data type
            Console.WriteLine("Scoping of a variable...");
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
            Console.WriteLine();

            // Type conversion
            // Implicit
            byte initialValue = 1;
            int implicitConversion = initialValue;
            Console.WriteLine("Implicit conversion...");
            Console.WriteLine("Byte to Integer...no data loss...");
            Console.WriteLine(initialValue);
            Console.WriteLine(implicitConversion);
            Console.WriteLine();

            // Explicit
            // setting this to a value greater than 255 will cause data loss
            int numberNoDataLoss = 1;
            int numberWithDataLoss = 256;

            // You cannot do this...byte numberConvertedWithoutDataLoss = numberNoDataLoss;
            // You must cast...(type)...
            byte numberConvertedWithoutDataLoss = (byte)numberNoDataLoss;
            byte numberConvertedWithDataLoss = (byte)numberWithDataLoss;

            Console.WriteLine("Explicit conversion...");
            Console.WriteLine("Integer to Byte...potential data loss...in this scenario {0} is {1} and when converted to {2} is still {3}", nameof(numberNoDataLoss), numberNoDataLoss, numberConvertedWithoutDataLoss.GetType().Name, numberConvertedWithoutDataLoss);
            Console.WriteLine("Whereas...");
            Console.WriteLine("This Integer to Byte conversion has data loss...in this scenario {0} is {1} and then converted to {2} is becomes {3}", nameof(numberWithDataLoss), numberWithDataLoss, numberConvertedWithDataLoss.GetType().Name, numberConvertedWithDataLoss);
            Console.WriteLine("");

            // Non-Compatible Types
            var numberOne = "1";
            // This will not compile...int numberOneConvertedToInteger = (int)numberOne;
            // you must use the convert class or parse method...
            var numberOneConvertedToInteger = Convert.ToInt32(numberOne); // you would maybe use ToInt16 for short...etc.
            var numberOneConvertedUsingParseToInteger = int.Parse(numberOne);
            Console.WriteLine("");
            Console.WriteLine("To convert a {0} to a {1}. You must use either the Convert Class or Parse Method.", numberOne.GetType().Name, numberOneConvertedToInteger.GetType().Name);
            Console.WriteLine("Covnert...int numberOneConvertedToInteger = Convert.ToInt32(numberOne); - {0} to {1}", numberOne, numberOneConvertedToInteger);
            Console.WriteLine("Parse...int numberOneConvertedUsingParseToInteger = int.Parse(numberOne); - {0} to {1}", numberOne, numberOneConvertedUsingParseToInteger);
            Console.WriteLine("");

            var numberAsString = "1234";
            byte numberAsByteValue;

            try
            {
                numberAsString = "1234";
                numberAsByteValue = Convert.ToByte(numberAsString);
                Console.WriteLine(numberAsByteValue);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The value {0} cannot be converted from {1} to {2} - the exception is {3}", numberAsString, numberAsString.GetType().Name, typeof(byte).Name, ex.Message);
                //throw;
            }

        }
    }
}

