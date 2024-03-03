using System;

namespace BMI_Rechner
{
    internal class Program
    {
        public static void Header()
        {
            
            Console.WriteLine("========================================");
            Console.WriteLine("            BMI-Rechner v1.0");
            Console.WriteLine("========================================");   
        }

        public static double Bmi(double weight, double height)
        {
            double bmi = weight / Math.Pow(height / 100.0, 2);

            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Underweight");
                Console.ResetColor();
            }
            else if (bmi < 24.9)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Normalweight");
                Console.ResetColor();
            }
            else if (bmi < 29.9)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Overweight");
                Console.ResetColor();
            }
            else if (bmi < 34.9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Obese");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Extremely Obese");
                Console.ResetColor();
            }

            return bmi;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Header();
                Console.WriteLine();
                Console.Write("Type in your bodyweight (Kg): ");
                double weight;
                while (!double.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    Console.WriteLine();
                    Console.Write("Type in your bodyweight (Kg): ");
                }
                Console.WriteLine();
                Console.Write("Type in your bodyheight (Cm): ");
                double height;
                while (!double.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    Console.WriteLine();
                    Console.Write("Type in your bodyheight (Cm): ");
                }

                Console.Clear();
                Header();
                Console.WriteLine();
                double bmi = Bmi(weight, height);
                Console.WriteLine($"Your BMI is: {bmi:0.0}");

                Console.WriteLine("\nPress any key to calculate again or 'Q' to quit.");
                var key = Console.ReadKey();
                if (key.KeyChar == 'Q' || key.KeyChar == 'q')
                    break;
                Console.Clear();
            }
        }
    }
}
