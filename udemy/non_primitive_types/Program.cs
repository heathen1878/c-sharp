using non_primitive_types.math;
using non_primitive_types.people;

namespace non_primitive_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            string Name;
            Name = "Dom";
            var person = new Person() { Name = Name };
            person.Introduce();

            int iResult;
            iResult = Calculator.Add(1, 2);
            System.Console.WriteLine(iResult);

            // Struct
            var colours = new RgbColour()
            {
                Red = 0,
                Green = 0,
                Blue = 0
            };

            Console.ForegroundColor = colours.ToConsoleColor();
            Console.WriteLine("This text is...");
            Console.ResetColor();

            // Arrays
            // Variables of the same type
            var numbers = new int[10];
            // The size cannot be changed

            numbers[0] = 1;
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            // Strings
            // strings are immutable
            string firstName;
            string surname;
            string fullName;

            firstName = "Dom";
            surname = "Clayton";
            fullName = string.Format("{0} {1}", firstName, surname);
            System.Console.WriteLine(fullName);

            // Escape characters
            // \n - new line
            // \t - tab
            // \\ - backslash
            // \' - single quote
            // \" - double quote

            // verbatim strings
            string path = @"c:\projects\some folder\";
            System.Console.WriteLine(path);

            string multiLine = @"
This is a multi line string
and it is represented as such...
            ";
            System.Console.WriteLine(multiLine);
            var namesOfFolk = new string[3] { "Dom", "Bob", "Bill" };

            System.Console.WriteLine(string.Join(";", namesOfFolk));

            // Enums
            // Use where you have related constants
            var delivery = ShippingMethods.FirstClass;
            System.Console.WriteLine("Delivery using {0}", delivery);
            System.Console.WriteLine("The value of delivery is {0}", (byte)delivery);

            var deliveryId = 3;
            System.Console.WriteLine("The delivery method is {0}", (ShippingMethods)deliveryId);

            System.Console.WriteLine(delivery);

            var deliveryName = "ExpressDelivery";

            // Parse a string to a Enum
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), deliveryName);
        }
    }

    public enum ShippingMethods : byte
    {
        FirstClass = 1,
        SecondClass = 2,
        ExpressDelivery = 3
    }

    public struct RgbColour
    {
        public int Red;
        public int Green;
        public int Blue;

        public ConsoleColor ToConsoleColor()
        {
            if (Red >= Green && Red >= Blue) return ConsoleColor.Red;
            if (Green >= Red && Green >= Blue) return ConsoleColor.Green;
            if (Blue >= Red && Blue >= Green) return ConsoleColor.Blue;

            return ConsoleColor.White;
        }
    }
}