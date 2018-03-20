using System;
using System.Collections.Generic;

namespace list_quickstart
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Sigurd", "Sigfrid", "Nutella" };
	    names.Add("Verden");
            foreach (var name in names)
            {
                Console.WriteLine($"Hallo {name.ToUpper()}!");
	
            }
	Console.WriteLine($"My name is {names[0]}");
	Console.WriteLine($"Listen har {names.Count} elementer i seg");
	       
 	}
    }
}