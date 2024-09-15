using System;
using System.Globalization;

// McGrath, M. (2022). C# Programming - modern coding with C# 10 and .NET 6. 3rd Edition.

namespace ShapeApp
{
    class Rectangle // Rectangle Class
    {
        // Fields|variables to hold inputted dimensions as integers
        public int height;
        public int width;

        // Constructor that accepts an inputas an integer whole number only (no decimal)
        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        // Method 1: GetHeight
        public int GetHeight()
        {
            return height;
        }

        // Method 2: GetWidth
        public int GetWidth()
        {
            return width;
        }

        // Method 3: Calculate the Area
        public int CalcArea()
        {
            return height * width;
        }

        // Method 4: IsItSquare
        public bool IsItSquare()
        {
            return height == width;
        }

        // Method 5: DisplayAll
        public void DisplayAll()
        {
        string shapeType = IsItSquare() ? "This is a Square" : "This is a Rectangle";
            // Return if the rectangle is a square or not (height = width) with the calculated area
            Console.WriteLine($"{shapeType} - Height: {height}, Width: {width}, Calculated Area is: {CalcArea()}");
        }
    }

    // Circle Class
    class Circle
    {
        // Field|variable to hold inputted dimensions as double
        public double radius;

        // Constructor that accepts an input as a double (a floating-point number of 15-digit precision)
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Math.PI is a double-precision constant provided by the .NET framework.
        

        // Method 1: CalcArea
        public double CalcArea()
        {
            // To calculate the area of a circle (π), PI x radius x radius.
            return Math.PI * radius * radius;
        }

        // Method 2: CalcCircum
        public double CalcCircum()
        {
            // To calculate the circumference of a circle, 2 * PI * radius
            return 2 * Math.PI * radius;
        }

        // Method 5: DisplayAll
        public void DisplayAll()
        {
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {CalcArea():F2}");
            Console.WriteLine($"Circumference: {CalcCircum():F2}");
        }

    }

}
