namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Increment
            var postfixIncrement = 1;
            var postfixIncrement2 = postfixIncrement++;

            var prefixIncrement = 1;
            var prefixIncrement2 = ++prefixIncrement;

            System.Console.WriteLine(postfixIncrement);
            System.Console.WriteLine("After postfix {0}", postfixIncrement2);

            // Both prefix variables will be the same as the var is incremented then assigned
            System.Console.WriteLine(prefixIncrement);
            System.Console.WriteLine("After prefix {0}", prefixIncrement2);

            // Artimetic
            var numberOne = 10;
            var numberTwo = 3;
            int iResult;

            iResult = numberOne / numberTwo;

            System.Console.WriteLine("The result of the division is: {0}", iResult);

            // cast the integer as float and return a floating point number result
            float fResult;
            fResult = (float)numberOne / (float)numberTwo;

            System.Console.WriteLine("The result of the division is: {0}", fResult);

            // Comparisons
            // result is always boolean
            bool isResult;
            var iValue1 = 10;
            var iValue2 = 5;

            isResult = iValue1 > iValue2;

            System.Console.WriteLine("Is iValue greater than iValue2? - {0}", isResult);

            // Logical
            bool isResult2;
            var iValue3 = 6;

            isResult2 = iValue1 > iValue2 && iValue1 > iValue3;
            System.Console.WriteLine("Is iValue1 greater than iValue2 and iValue3? - {0}", isResult2);
            
            isResult2 = iValue2 == iValue3 || iValue2 > iValue3;
            
            System.Console.WriteLine("Is iValue2 equal to iValue3 or greater than iValue3? - {0}", isResult2);
            }
    }
}