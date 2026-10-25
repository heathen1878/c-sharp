namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comments should be whys, hows and constraints...
            //
            // Artimetic Operators
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Artimetic Operators");
            Console.ResetColor();
            // +
            var numberOne = 10;
            var numberTwo = 3;
            var result = numberOne + numberTwo;
            System.Console.WriteLine("{1} added to {0} = {2}", numberOne, numberTwo, result);
            // -
            result =  numberOne - numberTwo;
            System.Console.WriteLine("{1} subtracted from {0} = {2}", numberOne, numberTwo, result);
            // *
            result =  numberOne * numberTwo;
            System.Console.WriteLine("{0} multiplied by {1} = {2}", numberOne, numberTwo, result);
            // /
            result =  numberOne / numberTwo;
            System.Console.WriteLine("{0} divided by {1} = {2}", numberOne, numberTwo, result);
            // for greater precision we can use a floating point number...
            // cast the integer as float and return a floating point number result
            float precisionResult;
            precisionResult = (float)numberOne / (float)numberTwo;
            System.Console.WriteLine("With greater precision....{0} divided by {1} = {2}", numberOne, numberTwo, precisionResult);
            // % modulus - remainder of division...
            result =  numberOne % numberTwo;
            System.Console.WriteLine("{0} divided by {1} leaves remainder {2}", numberOne, numberTwo, result);
            Console.WriteLine("");

            // Increment
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Incrementing Operators");
            Console.ResetColor();
            var postfixIncrement = 1;
            Console.WriteLine("The initial value of {0} is {1}", nameof(postfixIncrement), postfixIncrement);
            // Assign it then increment it...
            var postfixIncrement2 = postfixIncrement++;
            Console.WriteLine("After running postfixIncrement++, the value of {0} is {1}", nameof(postfixIncrement), postfixIncrement);
            Console.WriteLine("The assignment...var postfixIncrement2 = postfixIncrement++...retains the original value {0}", postfixIncrement2);
            Console.WriteLine("");
            var prefixIncrement = 1;
            Console.WriteLine("The initial value of {0} is {1}", nameof(prefixIncrement), prefixIncrement);
            // Increment it , then assign it...
            var prefixIncrement2 = ++prefixIncrement;
            Console.WriteLine("After running ++prefixIncrement, the value of {0} is {1} as is the value of {2}: {3}", nameof(prefixIncrement2), prefixIncrement2, nameof(prefixIncrement), prefixIncrement);
            Console.WriteLine("");

            System.Console.WriteLine(postfixIncrement);
            System.Console.WriteLine("After postfix {0}", postfixIncrement2);

            // Both prefix variables will be the same as the var is incremented then assigned
            System.Console.WriteLine(prefixIncrement);
            System.Console.WriteLine("After prefix {0}", prefixIncrement2);
            Console.WriteLine("");

            // Comparison operators
            // Always returns a boolean
            // ==
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Comparison operator example ==");
            Console.ResetColor();
            Console.WriteLine("");

            if (1 == 1) {
                Console.WriteLine("1 == 1");
            }
            Console.WriteLine("");
            // !=
            Console.WriteLine("Comparison operator example !=");
            if (1 != 2) {
                Console.WriteLine("1 is not equal to 2....1 != 2");
            }
            // > greater than
            // >= greater than or equal
            // < less than
            // <= less than or equal
            Console.WriteLine("");
            bool isResult;
            var numberTen = 10;
            var numberFive = 5;

            isResult = numberTen > numberFive;

            Console.WriteLine("Is {0} greater than {1}? - {2}", numberTen, numberFive, isResult);
            Console.WriteLine("");

            // Assignment Operators
            // =
            // += add 3 to the var
            // -= subtract 3 from the var
            // *= multiply the var by 3
            // /= divide the var by 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Assignment Operator examples");
            Console.ResetColor();
            var initialValue = 12;
            Console.WriteLine("The value {0} using the assignment operator += 12 is {1}",initialValue, initialValue += 12);
            Console.WriteLine("The value {0} using the assigment operator -= 12 is {1}", initialValue, initialValue -= 12);
            Console.WriteLine("The value {0} using the assignment operator *= 3 is {1}", initialValue, initialValue *= 3);
            Console.WriteLine("The value {0} using the assignment operator /= 3 is {1}", initialValue, initialValue /= 3);
            Console.WriteLine("");

            // Logical Operators
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Logical Operator examples");
            Console.ResetColor();
            // && And
            // || Or
            // ! Not
            var isResult1 = true;
            var isResult2 = true;
            var logicalAnd = isResult1 && isResult2;
            Console.WriteLine("{0} and {1} are both {2}", isResult1, isResult2, logicalAnd);

            var isResult3 = true;
            var isResult4 = false;
            var logicalOr = isResult3 || isResult4;
            Console.WriteLine("{0} or {1} is {2}", isResult3, isResult4, logicalOr);


            //isResult2 = iValue1 > iValue2 && iValue1 > iValue3;
            //System.Console.WriteLine("Is iValue1 greater than iValue2 and iValue3? - {0}", isResult2);

            //isResult2 = iValue2 == iValue3 || iValue2 > iValue3;

            //System.Console.WriteLine("Is iValue2 equal to iValue3 or greater than iValue3? - {0}", isResult2);

            // Bitwise Operators
            // &
            // |
            }
    }
}