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
        public int getHeight()
        {
            return height;
        }

        // Method 2: GetWidth
        public int getWidth()
        {
            return width;
        }

        // Method 3: Calculate the Area
        public int calculateArea()
        {
            return height * width;
        }

        // Method 4: isSquare 
        public bool isSquare()
        {
            return height == width;
        }

        // Method 5: displayAll 
        public void displayAll()
        {
        string shapeType = isSquare() ? "This is a Square" : "This is a Rectangle";
            // Return if the rectangle is a square or not (height = width) with the calculated area
            Console.WriteLine($"{shapeType} - Height: {height}, Width: {width}, Calculated Area is: {calculateArea()}");
        }
    }

    // Circle Class
    class Circle
    {
        // Field|variable to hold inputted dimensions as double
        public double Radius;

        // Constructor that accepts an input as a double (a floating-point number of 15-digit precision)
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        // Math.PI is a double-precision constant provided by the .NET framework.
        

        // Method 1: CalcArea
        public double calculateArea()
        {
            // To calculate the area of a circle (π), PI x radius x radius.
            return Math.PI * Radius * Radius;
        }

        // Method 2: CalcCircum
        public double calculateCircumference()
        {
            // To calculate the circumference of a circle, 2 * PI * radius
            return 2 * Math.PI * Radius;
        }

        // Method 5: DisplayAll
        public void displayAll()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {calculateArea():F2}");
            Console.WriteLine($"Circumference: {calculateCircumference():F2}");
        }

    }

}
