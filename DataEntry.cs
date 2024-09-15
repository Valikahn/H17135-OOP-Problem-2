using ShapeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program // Program class 
    {
        static void Main(string[] args)
        {
            // Looping boolean choice of options 1,2, or 0 (alpha characters will not work with this. 
            bool loopApplicaitonwhile = true;

            while (loopApplicaitonwhile)
            {
                Console.WriteLine("Select shape type");
                Console.WriteLine("Press (1) for Rectangle");
                Console.WriteLine("Press (2) for Circle");
                Console.WriteLine("Press (0) to Exit");
                Console.WriteLine();

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Rectangle creation | calculation
                    Console.WriteLine("Enter the height of the rectangle please: ");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Enter the width of the rectangle please: ");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Rectangle rectangle = new Rectangle(height, width);
                    rectangle.displayAll();
                }
                else if (choice == "2")
                {
                    // Circle creation | calculation
                    Console.WriteLine("Enter the radius of the circle please: ");
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine();

                    Circle circle = new Circle(radius);
                    circle.displayAll();
                }
                else if (choice == "0")
                {
                    // Exit the loop of application while
                    loopApplicaitonwhile = false;
                    Console.WriteLine("Exiting the program.");
                }
                else
                {
                    // Invalid choice - thy again
                    Console.WriteLine("Invalid choice, please make a valid choice.");
                }

                // Loopin to to make another choice - asking the user for an entry.
                if (loopApplicaitonwhile)
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to have another go? (y/n):");
                    string continueResponse = Console.ReadLine().ToLower();
                    Console.Clear(); // Clear the screen

                    if (continueResponse != "y")
                    {
                        loopApplicaitonwhile = false;
                        Console.WriteLine("Exiting program.");
                    }
                }
            }
        }
    }
}
