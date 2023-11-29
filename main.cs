using System;

class Program {
  public static void Main (string[] args) {
    // Get user input for wind speed
            Console.Write("Enter the wind speed (in mph): ");
            if (double.TryParse(Console.ReadLine(), out double windSpeed))
            {
                // Determine hurricane category
                string category = ClassifyHurricane(windSpeed);

                // Output the result
                Console.WriteLine($"Hurricane Category: {category}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for wind speed.");
            }
        }

        static string ClassifyHurricane(double windSpeed)
        {
            if (windSpeed >= 157)
            {
                return "Category Five Hurricane";
            }
            else if (windSpeed >= 130)
            {
                return "Category Four Hurricane";
            }
            else if (windSpeed >= 111)
            {
                return "Category Three Hurricane";
            }
            else if (windSpeed >= 96)
            {
                return "Category Two Hurricane";
            }
            else if (windSpeed >= 74)
            {
                return "Category One Hurricane";
            }
            else
            {
                return "Not a Hurricane";
            }
        }
    }