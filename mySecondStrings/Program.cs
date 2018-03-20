﻿using System;

namespace mySecondStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "A string is more ";
            string s2 = "than the sum of its chars.";
            // Concatenate s1 and s2. This actually creates a new
            // string object and stores it in s1, releasing
            // the reference to the original object
            s1 += s2;

            Console.WriteLine(s1);
            // Output: A string is more than the sum of its chars.

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            /* Output:
            Row 1
            Row 2
            Row 3
             */
            string columns = "Column 1\tColumn 2\tColumn 3";

        Console.WriteLine(columns);        
        Console.WriteLine(rows);

        }
    }
}
