using System;

namespace myApp
{
   class Program
    {
        static void Main(string[] args)


        {

	int[] array = new int[5];
	string[] stringArray = new string[6];
	string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
	int[] array2 = { 1, 3, 5, 7, 9 };

	Console.Write("Weekdays: ");
	foreach (string i in weekDays) {
		Console.Write(i + " ");
					}

        }
    }
}
