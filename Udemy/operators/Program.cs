namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Artimetic Operators
            // +
            // -
            // *
            // /
            // % modulus - remainder of division...
            var numberOne = 10;
            var numberTwo = 3;
            int iResult;

            iResult = numberOne / numberTwo;

            System.Console.WriteLine("The result of the division is: {0}", iResult);

            // cast the integer as float and return a floating point number result
            float fResult;
            fResult = (float)numberOne / (float)numberTwo;

            System.Console.WriteLine("The result of the division is: {0}", fResult);
            Console.WriteLine("");

            // Increment
            var postfixIncrement = 1;
            Console.WriteLine("The initial value of {0} is {1}", nameof(postfixIncrement), postfixIncrement);
            var postfixIncrement2 = postfixIncrement++;
            Console.WriteLine("After running postfixIncrement++, the value of {0} is {1}", nameof(postfixIncrement), postfixIncrement);
            Console.WriteLine("The assignment...var postfixIncrement2 = postfixIncrement++...retains the original value {0}", postfixIncrement2);
            Console.WriteLine("");
            var prefixIncrement = 1;
            Console.WriteLine("The initial value of {0} is {1}", nameof(prefixIncrement), prefixIncrement);
            var prefixIncrement2 = ++prefixIncrement;
            Console.WriteLine("After running ++prefixIncrement, the value of {0} is {1} as is {2}", nameof(prefixIncrement2), prefixIncrement2, nameof(prefixIncrement));
            Console.WriteLine("");

            System.Console.WriteLine(postfixIncrement);
            System.Console.WriteLine("After postfix {0}", postfixIncrement2);

            // Both prefix variables will be the same as the var is incremented then assigned
            System.Console.WriteLine(prefixIncrement);
            System.Console.WriteLine("After prefix {0}", prefixIncrement2);

            // Comparison operators
            // ==
            Console.WriteLine("");
            Console.WriteLine("Comparison operator example ==");
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
            Console.WriteLine("");
            Console.WriteLine("Assignment Operator examples");
            var initialValue = 12;
            Console.WriteLine("The value {0} using the assignment operator += 12 is {1}",initialValue, initialValue += 12);
            Console.WriteLine("The value {0} using the assigment operator -= 12 is {1}", initialValue, initialValue -= 12);
            Console.WriteLine("The value {0} using the assignment operator *= 3 is {1}", initialValue, initialValue *= 3);
            Console.WriteLine("The value {0} using the assignment operator /= 3 is {1}", initialValue, initialValue /= 3);
            Console.WriteLine("");

            // Logical Operators
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