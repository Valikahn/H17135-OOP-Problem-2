# Problem 2 - Shapes

You have been asked to begin writing a OOPS application which will create two types of objects: Circle and Rectangle. 

## Rectangle
| Object                  | Rectangle
|-------------------------|-------------------------|
| Class Name              | Rectangle
| Fields	              | Height (int)
|                         | Width (int)
| Method                  | getHeight
|                         | getWidth
|                         | calculateArea
|                         | isSquare
|                         | displayAll

isSquare – will return if the rectangle is a square or not (height = width)<br />
displayAll – will display the dimensions of the shape and its area<br />

## Circle
| Object                  | Circle
|-------------------------|-------------------------|
| Class Name              | Circle
| Field                   | Radius (double)
| Method                  | getRadius
|                         | calculateArea
|                         | displayAll

calculateArea (2πr) or (2 * 3.14 *radius) <br />
displayAll – will display the radius of the shape and its area. <br />

## Sample
A sample run has also been produced to show you what is required. <br />

Sample program running:<br />

```
Shapes Problem
Press 1 for rectangle, 2 for Circle, 3 to exit: 2
Please enter radius: 3
Radius: 3.0 Area: 18.84
Shapes Problem
Press 1 for rectangle, 2 for Circle, 3 to exit: 1
Please enter height: 4
Please enter width: 4
Height: 4 Width: 4 Area: 16 Shape: This is a square
Shapes Problem
Press 1 for rectangle, 2 for Circle, 3 to exit: 1
Please enter height: 4
Please enter width: 3
Height: 4 Width: 3 Area: 12 Shape: This is a rectangle
Shapes Problem
Press 1 for rectangle, 2 for Circle, 3 to exit: 3
```

HINTS – Use a loop and if statement in the main program. To format the area of a circle to two decimal places use the predefined function.

For example:  DecimalFormat df = new DecimalFormat("#.##"); 
