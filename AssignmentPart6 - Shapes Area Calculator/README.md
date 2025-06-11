# Shapes Area Calculator

This is a C# console application that calculates the area of different geometric shapes: rectangle, circle, and triangle.

The project was developed as part of the "Complete C# Programming Master Class" course on Udemy, and demonstrates method overloading, user interaction, and input validation in a console-based environment.

## Features

- Calculates area for:
  - Rectangle: `length × breadth`
  - Circle: `π × radius²`
  - Triangle: `0.5 × base × height`
- Input validation to ensure only positive numbers are accepted
- Allows repeated calculations in a loop
- Uses method overloading to implement multiple versions of `calculateArea`

## Technologies

- Language: C#
- Runtime: .NET 6.0 or later (compatible with earlier versions with minor adjustments)
- Type: Console Application

## How to Run

1. Clone or download this repository.
2. Open the solution in Visual Studio or another C#-compatible IDE.
3. Build and run the project.

## Example Output

Choose a shape to calculate the area:

1. Rectangle

2. Circle

3. Triangle

1
Enter the length of the rectangle: 5
Enter the breadth of the rectangle: 3
Area of the Rectangle: 15

Do you want to calculate the area of another shape? (Yes/No): yes
Choose a shape to calculate the area:

1. Rectangle

2. Circle

3. Triangle

2
Enter the radius of the circle: 4
Area of the Circle: 50.26548245743669

Do you want to calculate the area of another shape? (Yes/No): no
Goodbye!

## Notes

- The `calculateArea()` method is overloaded with three signatures:
  - `calculateArea(double length, double breadth)` – for rectangles
  - `calculateArea(double radius)` – for circles
  - `calculateArea(double baseLength, double height, bool isTriangle)` – for triangles

- The `isTriangle` parameter is not used in the logic but is required to differentiate the method signature for overloading.

## License

This code is for educational purposes only, based on course material from Udemy.
