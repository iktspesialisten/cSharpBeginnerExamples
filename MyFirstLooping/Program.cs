using System;

namespace MyFirstLooping
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int a = 5;
	    int b = 6;
	    if (a + b > 10)
		Console.WriteLine("The answer is greater than 10.");
	    else
		Console.WriteLine("The answer is less than 10.");
	    	
	    int counter = 0;
	    while (counter < 10)
		{
			Console.WriteLine($"The while Counter is {counter}");
			counter++;
		}


        }
    }
}
