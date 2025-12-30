using System;

namespace conditionals
{
    class Program
    {
        static void Main()
        {
            var random = new Random();
            int hour;
            hour = random.Next(0, 24);
            System.Console.WriteLine(hour);

            // if else
            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("Good Morning!");
            }
            else if (hour > 12 && hour < 18)
            {
                System.Console.WriteLine("Good Afternoon!");
            }
            else
            {
                System.Console.WriteLine("Good Evening!");
            }

            // Conditional
            System.Console.WriteLine((hour) < 12 ? "AM" : "PM");

            hour = random.Next(0, 3);
            System.Console.WriteLine(hour);

            switch (hour)
            {
                case 0:
                case 1:
                case 2:
                    {
                        Console.WriteLine("Good Morning!");
                        break;
                    }
            }


            // Determine whether the input value is between 1 and 10...
            Console.WriteLine("Enter a number between 1 and 10");
            var inputFromConsole = Convert.ToInt32(Console.ReadLine());

            switch (inputFromConsole)
            {
                case >= 1 and <= 10:
                    {
                        Console.WriteLine("You typed {0}", inputFromConsole);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You typed an invalid value");
                        break;
                    }
            }

            // Evaluate two numbers and display the maximum...
            Console.WriteLine("Enter the first number...");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number...");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            var max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("Max is {0}", max);

            // Evaluate whether the image dimensions are portrait or landscape
            Console.WriteLine("Enter the image width in pixels...");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the image height in pixels...");
            var height = Convert.ToInt32(Console.ReadLine());

            var imageType = (width > height) ? ImageType.Landscape : ImageType.Portrait;
            Console.WriteLine("The image is {0}", imageType);

            // Evaluate the cars speeds and determine whether how many points to apply
            const int KMPHDemeritPoints = 5;
            int demeritPoints;

            Console.WriteLine("What is the speed limit?");
            var limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How fast was the car travelling?");
            
            var carsSpeed = Convert.ToInt32(Console.ReadLine());

            if (carsSpeed < limit)
            {
                Console.WriteLine("Car speed ok!");
            }
            else
            {
                demeritPoints = (carsSpeed - limit)/KMPHDemeritPoints;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("Licence suspended");
                }
                else
                {
                    Console.WriteLine("Number of points {0}", demeritPoints);
                }
            }
        }

        public enum ImageType
        {
            Landscape,
            Portrait
        }
    }
}