using System;

namespace MyFirstMathTests
{
    class Program
    {
        static void Main(string[] args)
        {
        int a = 18;
	int b = 6;
	int c = a + b;
	Console.WriteLine($"Calculation: {a} plus {b} equals {c}");
	int d = a - b;
	Console.WriteLine($"Calculation: {a} minus {b} equals {d}");
	int e = a * b;
	Console.WriteLine($"Calculation: {a} multiple times {b} equals {e}");
	int f = a / b;
	Console.WriteLine($"Calculation: {a} divided by {b} equals {f}");
	
	Console.WriteLine($"Floating Points:");
	double ab = 17;
	double bc = 3;
	double cd = ab / bc;
	Console.WriteLine($"Calculation: {ab} divided by {bc} equals {cd}");

	Console.WriteLine($"Calculate the radius of a circle:");
	double radius = 2.50;
	double area = Math.PI * radius * radius;
	Console.WriteLine($"A circle with the radius of {radius} has the area of {area}");	

        }
    }
}
