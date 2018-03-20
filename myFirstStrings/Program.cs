using System;

namespace myFirstStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare without initializing.
            string message1;
            message1 = "Hello, this is a message";
            // Initialize to null
            string message2 = null;

            // Initialize as an empty string.
            // Use the empty constant instead of the literal "".
            string message3 = System.String.Empty;

            // Initialize with a regular string literal.
            string oldPath = "c:\\Program Files\\Microsoft VS Code";

            // Use System.String if you prefer.
            System.String greeting = "Hello IKT Spesialisten!";

            // In local variable (i.e. within a method body)
            // You can use implicit typing.
            var temp = "I'm still a strongly-typed System.String!";

            // Use a const string to prevent 'message4' from
            // being used to store another string value.
            // const string message4 = "You can't get rid of me!";

            // Use the String constructor only when creating
            // a string from a char*, char[] or sbyte* see
            // System.String documentation for details.
            char [] letters = { 'A', 'B', 'C'};
            string alphabet = new string(letters);

            // Writing out the strings to the sceen just
            // to see that they work.
            Console.WriteLine(message1);
            Console.WriteLine(greeting);
            Console.WriteLine(temp);
            // Console.WriteLine(message4);
               
        }
    }
}
