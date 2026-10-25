using non_primitive_types.math;
using non_primitive_types.people;

namespace non_primitive_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate the class
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Class concepts");
            Console.ResetColor();
            string Name;
            Name = "Dom";
            var person = new Person() { Name = Name };
            person.Introduce();

            Name = "";
            var anotherPerson = new Person() { Name = Name };
            anotherPerson.Introduce();
            Console.WriteLine("");
            var result = Calculator.Add(1, 2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("The result of Calculator.Add(1,2) is {0}", result);
            Console.ResetColor();

            // Struct
            var colours = new RgbColour() {Red = 0, Green = 0, Blue = 0};
            Console.WriteLine("");
            Console.ForegroundColor = colours.ToConsoleColor();
            Console.WriteLine("This text is...{0}", colours.ToConsoleColor());
            Console.ResetColor();

            colours = new RgbColour() {Red = 0, Green = 0, Blue = 1};

            Console.ForegroundColor = colours.ToConsoleColor();
            Console.WriteLine("This text is now...{0}", colours.ToConsoleColor());
            Console.ResetColor();

            // Arrays
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Array concepts");
            Console.ResetColor();
            // Variables of the same type
            var numbers = new int[10];
            // The size cannot be changed

            for (int iterator = 0; iterator < numbers.Length; iterator++)
            {
                numbers[iterator] = iterator + 1;
                if (iterator % 2 == 0 && numbers[iterator] % 2 == 0)
                {
                    // both even
                    colours = new RgbColour() {Red = 0, Green = 1, Blue = 0};

                    Console.ForegroundColor = colours.ToConsoleColor();
                    Console.WriteLine("The array index {0} and has a value of {1}", iterator, numbers[iterator]);
                    Console.ResetColor();
                } else
                {
                    // or one more odd
                    colours = new RgbColour() {Red = 0, Green = 0, Blue = 1};
                    Console.ForegroundColor = colours.ToConsoleColor();
                    Console.WriteLine("The array index {0} and has a value of {1}", iterator, numbers[iterator]);
                    Console.ResetColor();
                }
            }

            // Strings
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("String Concepts");
            Console.ResetColor();
            // strings are immutable
            string firstName;
            string surname;
            string fullName;

            firstName = "Dom";
            surname = "Clayton";
            fullName = string.Format("{0} {1}", firstName, surname);
            Console.WriteLine(fullName);

            // Escape characters
            // \n - new line
            // \t - tab
            // \\ - backslash
            // \' - single quote
            // \" - double quote

            // verbatim strings
            string path = @"c:\projects\some folder\";
            Console.WriteLine(path);

            string multiLine = @"
This is a multi line string
and it is represented as such...
            ";
            System.Console.WriteLine(multiLine);
            var namesOfFolk = new string[3] { "Dom", "Bob", "Bill" };

            Console.WriteLine(string.Join(";", namesOfFolk));

            // Enums
            // Use where you have related constants
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enum Concepts");
            Console.ResetColor();
            var delivery = ShippingMethods.FirstClass;
            System.Console.WriteLine("Delivery using {0}", delivery);
            System.Console.WriteLine("The value of delivery is {0}", (byte)delivery);

            var deliveryId = 3;
            System.Console.WriteLine("The delivery method is {0}", (ShippingMethods)deliveryId);

            System.Console.WriteLine(delivery);

            var deliveryName = "ExpressDelivery";

            // Parse a string to a Enum
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), deliveryName);
            Console.WriteLine("The shipping method is {0}", shippingMethod);

            // Reference TYpes and Value Types
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reference Types and Value Types");
            Console.ResetColor();
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

        public readonly ConsoleColor ToConsoleColor()
        {
            if (Red >= Green && Red >= Blue) return ConsoleColor.Red;
            if (Green >= Red && Green >= Blue) return ConsoleColor.Green;
            if (Blue >= Red && Blue >= Green) return ConsoleColor.Blue;

            return ConsoleColor.White;
        }
    }
}