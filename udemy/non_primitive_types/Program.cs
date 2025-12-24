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


        }
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